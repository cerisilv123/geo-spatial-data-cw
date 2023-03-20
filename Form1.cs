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
        string collectionNameCities;

        // Database Objects
        MongoClient client;
        IMongoDatabase db;
        IMongoCollection<Cities> collectionCities;

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
            Map.ShowCenter = false;

            // MongoDB Database Details(Atlas)
            this.connectionString = "mongodb+srv://30023073cj:5GXnLBHVkjpKEokB@cluster30023073.fxc3oi1.mongodb.net/?retryWrites=true&w=majority";
            this.databaseName = "30023073-db-cw";
            this.collectionNameCities = "Cities";

            // Initialising DB objects
            this.client = new MongoClient(this.connectionString);
            this.db = client.GetDatabase(this.databaseName);
            this.collectionCities = db.GetCollection<Cities>(this.collectionNameCities);

            // Data grid
            this.bindingSource = new BindingSource();
            dataGrid.DataSource = this.bindingSource;

            var results = this.collectionCities.Find<Cities>(Builders<Cities>.Filter.Empty).ToList();
            this.bindingSource.DataSource = results;
        }

        // Update (CRUD)
        private void dataGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var updatedRow = dataGrid.Rows[e.RowIndex];
            var id = updatedRow.Cells["Id"].Value;
            var filter = Builders<Cities>.Filter.Eq(city => city.Id, id);
            var update = Builders<Cities>.Update.Set(city => city.Lat, updatedRow.Cells["Lat"].Value);
            this.collectionCities.UpdateOne(filter, update);
        }
    }
}
