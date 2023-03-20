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
        string connectionString;
        string databaseName;
        string collectionNameCities;

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
            this.databaseName = "Cluster30023073";
            this.collectionNameCities = "Cities";

        }
    }
}
