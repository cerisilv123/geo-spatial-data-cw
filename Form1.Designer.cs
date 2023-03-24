
namespace GeoSpatialData
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.Map = new GMap.NET.WindowsForms.GMapControl();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.buttonSearchCity = new System.Windows.Forms.Button();
            this.textBoxSearchCity = new System.Windows.Forms.TextBox();
            this.labelSearchInfo = new System.Windows.Forms.Label();
            this.buttonCities = new System.Windows.Forms.Button();
            this.buttonShipwrecks = new System.Windows.Forms.Button();
            this.textBoxLat1 = new System.Windows.Forms.TextBox();
            this.textBoxLat2 = new System.Windows.Forms.TextBox();
            this.labelLat1 = new System.Windows.Forms.Label();
            this.labelLat2 = new System.Windows.Forms.Label();
            this.buttonCalculateDistance = new System.Windows.Forms.Button();
            this.buttonResetCoords = new System.Windows.Forms.Button();
            this.textBoxLng1 = new System.Windows.Forms.TextBox();
            this.textBoxLng2 = new System.Windows.Forms.TextBox();
            this.labelLng1 = new System.Windows.Forms.Label();
            this.labelLng2 = new System.Windows.Forms.Label();
            this.textBoxDistance = new System.Windows.Forms.TextBox();
            this.buttonAddCity = new System.Windows.Forms.Button();
            this.buttonAddShipwreck = new System.Windows.Forms.Button();
            this.chartCityPopulation = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartShipwreckDepth = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonUserGuide = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCityPopulation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartShipwreckDepth)).BeginInit();
            this.SuspendLayout();
            // 
            // Map
            // 
            this.Map.Bearing = 0F;
            this.Map.CanDragMap = true;
            this.Map.EmptyTileColor = System.Drawing.Color.Navy;
            this.Map.GrayScaleMode = false;
            this.Map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.Map.LevelsKeepInMemory = 5;
            this.Map.Location = new System.Drawing.Point(2, 1);
            this.Map.MarkersEnabled = true;
            this.Map.MaxZoom = 10;
            this.Map.MinZoom = 2;
            this.Map.MouseWheelZoomEnabled = true;
            this.Map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.Map.Name = "Map";
            this.Map.NegativeMode = false;
            this.Map.PolygonsEnabled = true;
            this.Map.RetryLoadTile = 0;
            this.Map.RoutesEnabled = true;
            this.Map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.Map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.Map.ShowTileGridLines = false;
            this.Map.Size = new System.Drawing.Size(472, 585);
            this.Map.TabIndex = 0;
            this.Map.Zoom = 0D;
            this.Map.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.Map_OnMarkerClick);
            this.Map.OnMarkerDoubleClick += new GMap.NET.WindowsForms.MarkerDoubleClick(this.Map_OnMarkerDoubleClick);
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(480, 36);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(379, 218);
            this.dataGrid.TabIndex = 1;
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentClick);
            this.dataGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellValueChanged);
            this.dataGrid.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGrid_UserDeletingRow);
            // 
            // buttonSearchCity
            // 
            this.buttonSearchCity.Location = new System.Drawing.Point(712, 309);
            this.buttonSearchCity.Name = "buttonSearchCity";
            this.buttonSearchCity.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchCity.TabIndex = 2;
            this.buttonSearchCity.Text = "Search";
            this.buttonSearchCity.UseVisualStyleBackColor = true;
            this.buttonSearchCity.Click += new System.EventHandler(this.buttonSearchCity_Click);
            // 
            // textBoxSearchCity
            // 
            this.textBoxSearchCity.Location = new System.Drawing.Point(521, 311);
            this.textBoxSearchCity.Name = "textBoxSearchCity";
            this.textBoxSearchCity.Size = new System.Drawing.Size(185, 20);
            this.textBoxSearchCity.TabIndex = 3;
            // 
            // labelSearchInfo
            // 
            this.labelSearchInfo.AutoSize = true;
            this.labelSearchInfo.Location = new System.Drawing.Point(518, 314);
            this.labelSearchInfo.Name = "labelSearchInfo";
            this.labelSearchInfo.Size = new System.Drawing.Size(0, 13);
            this.labelSearchInfo.TabIndex = 4;
            // 
            // buttonCities
            // 
            this.buttonCities.Location = new System.Drawing.Point(480, 7);
            this.buttonCities.Name = "buttonCities";
            this.buttonCities.Size = new System.Drawing.Size(75, 23);
            this.buttonCities.TabIndex = 5;
            this.buttonCities.Text = "Cities";
            this.buttonCities.UseVisualStyleBackColor = true;
            this.buttonCities.Click += new System.EventHandler(this.buttonCities_Click);
            // 
            // buttonShipwrecks
            // 
            this.buttonShipwrecks.Location = new System.Drawing.Point(561, 7);
            this.buttonShipwrecks.Name = "buttonShipwrecks";
            this.buttonShipwrecks.Size = new System.Drawing.Size(75, 23);
            this.buttonShipwrecks.TabIndex = 6;
            this.buttonShipwrecks.Text = "Shipwrecks";
            this.buttonShipwrecks.UseVisualStyleBackColor = true;
            this.buttonShipwrecks.Click += new System.EventHandler(this.buttonShipwrecks_Click);
            // 
            // textBoxLat1
            // 
            this.textBoxLat1.Location = new System.Drawing.Point(521, 358);
            this.textBoxLat1.Name = "textBoxLat1";
            this.textBoxLat1.Size = new System.Drawing.Size(90, 20);
            this.textBoxLat1.TabIndex = 7;
            // 
            // textBoxLat2
            // 
            this.textBoxLat2.Location = new System.Drawing.Point(521, 395);
            this.textBoxLat2.Name = "textBoxLat2";
            this.textBoxLat2.Size = new System.Drawing.Size(90, 20);
            this.textBoxLat2.TabIndex = 8;
            // 
            // labelLat1
            // 
            this.labelLat1.AutoSize = true;
            this.labelLat1.Location = new System.Drawing.Point(518, 342);
            this.labelLat1.Name = "labelLat1";
            this.labelLat1.Size = new System.Drawing.Size(54, 13);
            this.labelLat1.TabIndex = 9;
            this.labelLat1.Text = "Latitude 1";
            // 
            // labelLat2
            // 
            this.labelLat2.AutoSize = true;
            this.labelLat2.Location = new System.Drawing.Point(518, 381);
            this.labelLat2.Name = "labelLat2";
            this.labelLat2.Size = new System.Drawing.Size(54, 13);
            this.labelLat2.TabIndex = 10;
            this.labelLat2.Text = "Latitude 2";
            // 
            // buttonCalculateDistance
            // 
            this.buttonCalculateDistance.Location = new System.Drawing.Point(712, 395);
            this.buttonCalculateDistance.Name = "buttonCalculateDistance";
            this.buttonCalculateDistance.Size = new System.Drawing.Size(105, 23);
            this.buttonCalculateDistance.TabIndex = 11;
            this.buttonCalculateDistance.Text = "Calculate Distance";
            this.buttonCalculateDistance.UseVisualStyleBackColor = true;
            this.buttonCalculateDistance.Click += new System.EventHandler(this.buttonCalculateDistance_Click);
            // 
            // buttonResetCoords
            // 
            this.buttonResetCoords.Location = new System.Drawing.Point(712, 358);
            this.buttonResetCoords.Name = "buttonResetCoords";
            this.buttonResetCoords.Size = new System.Drawing.Size(105, 23);
            this.buttonResetCoords.TabIndex = 12;
            this.buttonResetCoords.Text = "Reset Coordinates";
            this.buttonResetCoords.UseVisualStyleBackColor = true;
            this.buttonResetCoords.Click += new System.EventHandler(this.buttonResetCoords_Click);
            // 
            // textBoxLng1
            // 
            this.textBoxLng1.Location = new System.Drawing.Point(616, 358);
            this.textBoxLng1.Name = "textBoxLng1";
            this.textBoxLng1.Size = new System.Drawing.Size(90, 20);
            this.textBoxLng1.TabIndex = 13;
            // 
            // textBoxLng2
            // 
            this.textBoxLng2.Location = new System.Drawing.Point(616, 395);
            this.textBoxLng2.Name = "textBoxLng2";
            this.textBoxLng2.Size = new System.Drawing.Size(90, 20);
            this.textBoxLng2.TabIndex = 14;
            // 
            // labelLng1
            // 
            this.labelLng1.AutoSize = true;
            this.labelLng1.Location = new System.Drawing.Point(613, 342);
            this.labelLng1.Name = "labelLng1";
            this.labelLng1.Size = new System.Drawing.Size(63, 13);
            this.labelLng1.TabIndex = 15;
            this.labelLng1.Text = "Longitude 1";
            // 
            // labelLng2
            // 
            this.labelLng2.AutoSize = true;
            this.labelLng2.Location = new System.Drawing.Point(613, 381);
            this.labelLng2.Name = "labelLng2";
            this.labelLng2.Size = new System.Drawing.Size(63, 13);
            this.labelLng2.TabIndex = 16;
            this.labelLng2.Text = "Longitude 2";
            // 
            // textBoxDistance
            // 
            this.textBoxDistance.Location = new System.Drawing.Point(521, 421);
            this.textBoxDistance.Name = "textBoxDistance";
            this.textBoxDistance.Size = new System.Drawing.Size(296, 20);
            this.textBoxDistance.TabIndex = 17;
            // 
            // buttonAddCity
            // 
            this.buttonAddCity.Location = new System.Drawing.Point(683, 7);
            this.buttonAddCity.Name = "buttonAddCity";
            this.buttonAddCity.Size = new System.Drawing.Size(75, 23);
            this.buttonAddCity.TabIndex = 18;
            this.buttonAddCity.Text = "Add City";
            this.buttonAddCity.UseVisualStyleBackColor = true;
            this.buttonAddCity.Click += new System.EventHandler(this.buttonAddCity_Click);
            // 
            // buttonAddShipwreck
            // 
            this.buttonAddShipwreck.Location = new System.Drawing.Point(764, 7);
            this.buttonAddShipwreck.Name = "buttonAddShipwreck";
            this.buttonAddShipwreck.Size = new System.Drawing.Size(95, 23);
            this.buttonAddShipwreck.TabIndex = 19;
            this.buttonAddShipwreck.Text = "Add Shipwreck";
            this.buttonAddShipwreck.UseVisualStyleBackColor = true;
            this.buttonAddShipwreck.Click += new System.EventHandler(this.buttonAddShipwreck_Click);
            // 
            // chartCityPopulation
            // 
            chartArea1.Name = "ChartArea1";
            this.chartCityPopulation.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartCityPopulation.Legends.Add(legend1);
            this.chartCityPopulation.Location = new System.Drawing.Point(875, 36);
            this.chartCityPopulation.Name = "chartCityPopulation";
            this.chartCityPopulation.Size = new System.Drawing.Size(548, 212);
            this.chartCityPopulation.TabIndex = 20;
            // 
            // chartShipwreckDepth
            // 
            chartArea2.Name = "ChartArea1";
            this.chartShipwreckDepth.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartShipwreckDepth.Legends.Add(legend2);
            this.chartShipwreckDepth.Location = new System.Drawing.Point(875, 273);
            this.chartShipwreckDepth.Name = "chartShipwreckDepth";
            this.chartShipwreckDepth.Size = new System.Drawing.Size(548, 212);
            this.chartShipwreckDepth.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(518, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Search by City Name:";
            // 
            // buttonUserGuide
            // 
            this.buttonUserGuide.Location = new System.Drawing.Point(521, 462);
            this.buttonUserGuide.Name = "buttonUserGuide";
            this.buttonUserGuide.Size = new System.Drawing.Size(75, 23);
            this.buttonUserGuide.TabIndex = 23;
            this.buttonUserGuide.Text = "User Guide";
            this.buttonUserGuide.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1435, 677);
            this.Controls.Add(this.buttonUserGuide);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartShipwreckDepth);
            this.Controls.Add(this.chartCityPopulation);
            this.Controls.Add(this.buttonAddShipwreck);
            this.Controls.Add(this.buttonAddCity);
            this.Controls.Add(this.textBoxDistance);
            this.Controls.Add(this.labelLng2);
            this.Controls.Add(this.labelLng1);
            this.Controls.Add(this.textBoxLng2);
            this.Controls.Add(this.textBoxLng1);
            this.Controls.Add(this.buttonResetCoords);
            this.Controls.Add(this.buttonCalculateDistance);
            this.Controls.Add(this.labelLat2);
            this.Controls.Add(this.labelLat1);
            this.Controls.Add(this.textBoxLat2);
            this.Controls.Add(this.textBoxLat1);
            this.Controls.Add(this.buttonShipwrecks);
            this.Controls.Add(this.buttonCities);
            this.Controls.Add(this.labelSearchInfo);
            this.Controls.Add(this.textBoxSearchCity);
            this.Controls.Add(this.buttonSearchCity);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.Map);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCityPopulation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartShipwreckDepth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl Map;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button buttonSearchCity;
        private System.Windows.Forms.TextBox textBoxSearchCity;
        private System.Windows.Forms.Label labelSearchInfo;
        private System.Windows.Forms.Button buttonCities;
        private System.Windows.Forms.Button buttonShipwrecks;
        private System.Windows.Forms.TextBox textBoxLat1;
        private System.Windows.Forms.TextBox textBoxLat2;
        private System.Windows.Forms.Label labelLat1;
        private System.Windows.Forms.Label labelLat2;
        private System.Windows.Forms.Button buttonCalculateDistance;
        private System.Windows.Forms.Button buttonResetCoords;
        private System.Windows.Forms.TextBox textBoxLng1;
        private System.Windows.Forms.TextBox textBoxLng2;
        private System.Windows.Forms.Label labelLng1;
        private System.Windows.Forms.Label labelLng2;
        private System.Windows.Forms.TextBox textBoxDistance;
        private System.Windows.Forms.Button buttonAddCity;
        private System.Windows.Forms.Button buttonAddShipwreck;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCityPopulation;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartShipwreckDepth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonUserGuide;
    }
}

