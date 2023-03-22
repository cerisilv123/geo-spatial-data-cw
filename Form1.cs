using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using GMap.NET;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;

namespace GeoSpatialData
{
    public partial class Form1 : Form
    {
        // DB Connections Strings
        string connectionString;
        string databaseName;
        string currentCollectionName;

        // Database Objects
        MongoClient client;
        IMongoDatabase db;
        IMongoCollection<Cities> collectionCities;
        IMongoCollection<Shipwrecks> collectionShipwrecks;

        // Data Grid
        BindingSource bindingSource;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Setting up map instance
            Map.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            Map.AutoSize = true;
            Map.ShowCenter = false;

            // MongoDB Database Details(Atlas)
            this.connectionString = "mongodb+srv://30023073cj:5GXnLBHVkjpKEokB@cluster30023073.fxc3oi1.mongodb.net/?retryWrites=true&w=majority";
            this.databaseName = "30023073-db-cw";
            this.currentCollectionName = "Cities";

            // Initialising DB objects
            this.client = new MongoClient(this.connectionString);
            this.db = client.GetDatabase(this.databaseName);
            this.collectionCities = db.GetCollection<Cities>(this.currentCollectionName);

            // Reading data grid values to get updated values
            this.ReadDataGrid();
        }

        // Plots Point on to Map
        private void PlotPoint(string lat, string lng, GMarkerGoogleType pin)
        {
            // Setting map position to coords passed in as arguments
            Map.Position = new PointLatLng(Convert.ToDouble(lat), Convert.ToDouble(lng));
            GMapOverlay markers = new GMapOverlay("markers");
            GMapMarker marker = new GMarkerGoogle(
                     new PointLatLng(Convert.ToDouble(lat), Convert.ToDouble(lng)),
                    pin);
            markers.Markers.Add(marker);
            Map.Overlays.Add(markers);
            Map.ZoomAndCenterMarkers("markers");
        }

        // Read (CRUD)
        private void ReadDataGrid()
        {
            // Data grid
            this.bindingSource = new BindingSource();
            dataGrid.DataSource = this.bindingSource;

            // Getting all results from collection and binding to data grid
            if (this.currentCollectionName == "Cities")
            {
                var results = this.collectionCities.Find<Cities>(Builders<Cities>.Filter.Empty).ToList();
                this.bindingSource.DataSource = results;
            }
            else if (this.currentCollectionName == "Shipwrecks")
            {
                var results = this.collectionShipwrecks.Find<Shipwrecks>(Builders<Shipwrecks>.Filter.Empty).ToList();
                this.bindingSource.DataSource = results;
            }

        }

        // Update (CRUD)
        private void dataGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Getting index of data grid row that has been updated
            var updatedRow = dataGrid.Rows[e.RowIndex];
            var id = updatedRow.Cells["Id"].Value;
            var filter = Builders<Cities>.Filter.Eq(city => city.Id, id);
            var update = Builders<Cities>.Update.Set(city => city.City, updatedRow.Cells["City"].Value)
                                                .Set(city => city.Lat, updatedRow.Cells["Lat"].Value)
                                                .Set(city => city.Lng, updatedRow.Cells["Lng"].Value)
                                                .Set(city => city.Country, updatedRow.Cells["Country"].Value)
                                                .Set(city => city.Iso2, updatedRow.Cells["Iso2"].Value)
                                                .Set(city => city.AdminName, updatedRow.Cells["AdminName"].Value)
                                                .Set(city => city.Capital, updatedRow.Cells["Capital"].Value)
                                                .Set(city => city.Population, updatedRow.Cells["Population"].Value)
                                                .Set(city => city.PopulationProper, updatedRow.Cells["PopulationProper"].Value);
            this.collectionCities.UpdateOne(filter, update);
            
            // Reading data grid values to get updated values
            this.ReadDataGrid();
        }

        // Delete (CRUD)
        private void dataGrid_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            // Getting index of data grid row that is being deleted
            var updatedRow = e.Row;
            var id = updatedRow.Cells["Id"].Value;
            this.collectionCities.DeleteOne(city => city.Id == id.ToString());

            // Reading data grid values to get updated values
            this.ReadDataGrid();
        }

        // Add Pin to Map by clicking on DataGrid row
        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var clickedRow = dataGrid.Rows[e.RowIndex];
            var lat = clickedRow.Cells["Lat"].Value;
            var lng = clickedRow.Cells["Lng"].Value;
            GMarkerGoogleType pin = GMarkerGoogleType.green_pushpin;
            this.PlotPoint(lat.ToString(), lng.ToString(), pin);
        }

        // Read One record when user enters city name(CRUD) and plot to map
        private void buttonSearchCity_Click(object sender, EventArgs e)
        {
            string input = textBoxSearchCity.Text.ToString();
            var cityResult = this.collectionCities.Find(city => city.City == input.ToString()).FirstOrDefault();
            if (cityResult != null)
            {
                // Getting lng and lat to update Map Markers
                string lat = cityResult.Lat;
                string lng = cityResult.Lng;
                GMarkerGoogleType pin = GMarkerGoogleType.orange_dot;
                this.PlotPoint(lat, lng, pin);

                // Updating datagrid to have the correct city selected for what user searched
                int index = -1;
                foreach(DataGridViewRow row in dataGrid.Rows)
                {
                    if (row.Cells[2].Value.ToString() == lat && row.Cells[3].Value.ToString() == lng)
                    {
                        index = row.Index;
                        break;
                    }
                }

                // If city was not found keep the same selection on grid
                if (index != -1)
                {
                    dataGrid.CurrentCell = dataGrid.Rows[index].Cells[1];
                }
            }
        }

        // Remove Pin from Map by Clicking on Pin (on map)
        private void Map_OnMarkerDoubleClick(GMapMarker item, MouseEventArgs e)
        {
            // Finding overlay that contains the marker clicked so that it can be removed
            GMapOverlay overlay = Map.Overlays.FirstOrDefault(overl => overl.Markers.Contains(item));

            // Checking to make sure an overlay exists
            if (overlay != null)
            {
                overlay.Markers.Remove(item);
            }
        }

        // View Data of Location by clicking on Pin from Map by Clicking on Pin
        private void Map_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            // Getting coords of pin
            string lat = item.Position.Lat.ToString();
            string lng = item.Position.Lng.ToString();

            // Creating query to search mongo db collection for city with same lat and lng
            var filter = Builders<Cities>.Filter.Eq(city => city.Lat, lat) & Builders<Cities>.Filter.Eq(city => city.Lng, lng);
            var cityResult = this.collectionCities.Find(filter).FirstOrDefault();
            if (cityResult != null)
            {
                // Creating text box near pin displaying details
                item.ToolTipText = cityResult.City.ToString();
            }
        }

        private void buttonCities_Click(object sender, EventArgs e)
        {
            this.currentCollectionName = "Cities";
            this.collectionCities = db.GetCollection<Cities>(this.currentCollectionName);

            // Reading data grid values to get updated values
            this.ReadDataGrid();

            buttonCities.BackColor = Color.Green;
            buttonShipwrecks.BackColor = Color.White;
        }

        private void buttonShipwrecks_Click(object sender, EventArgs e)
        {
            this.currentCollectionName = "Shipwrecks";
            this.collectionShipwrecks = db.GetCollection<Shipwrecks>(this.currentCollectionName);

            // Reading data grid values to get updated values
            this.ReadDataGrid();

            buttonCities.BackColor = Color.White;
            buttonShipwrecks.BackColor = Color.Green;

        }
    }
}
