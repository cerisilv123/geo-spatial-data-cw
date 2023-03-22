
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
            this.Map = new GMap.NET.WindowsForms.GMapControl();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.buttonSearchCity = new System.Windows.Forms.Button();
            this.textBoxSearchCity = new System.Windows.Forms.TextBox();
            this.labelSearchInfo = new System.Windows.Forms.Label();
            this.buttonCities = new System.Windows.Forms.Button();
            this.buttonShipwrecks = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
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
            this.Map.Location = new System.Drawing.Point(1, 1);
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
            this.Map.Size = new System.Drawing.Size(396, 449);
            this.Map.TabIndex = 0;
            this.Map.Zoom = 0D;
            this.Map.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.Map_OnMarkerClick);
            this.Map.OnMarkerDoubleClick += new GMap.NET.WindowsForms.MarkerDoubleClick(this.Map_OnMarkerDoubleClick);
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(413, 36);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(379, 218);
            this.dataGrid.TabIndex = 1;
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentClick);
            this.dataGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellValueChanged);
            this.dataGrid.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGrid_UserDeletingRow);
            // 
            // buttonSearchCity
            // 
            this.buttonSearchCity.Location = new System.Drawing.Point(604, 257);
            this.buttonSearchCity.Name = "buttonSearchCity";
            this.buttonSearchCity.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchCity.TabIndex = 2;
            this.buttonSearchCity.Text = "Search";
            this.buttonSearchCity.UseVisualStyleBackColor = true;
            this.buttonSearchCity.Click += new System.EventHandler(this.buttonSearchCity_Click);
            // 
            // textBoxSearchCity
            // 
            this.textBoxSearchCity.Location = new System.Drawing.Point(413, 260);
            this.textBoxSearchCity.Name = "textBoxSearchCity";
            this.textBoxSearchCity.Size = new System.Drawing.Size(185, 20);
            this.textBoxSearchCity.TabIndex = 3;
            // 
            // labelSearchInfo
            // 
            this.labelSearchInfo.AutoSize = true;
            this.labelSearchInfo.Location = new System.Drawing.Point(410, 274);
            this.labelSearchInfo.Name = "labelSearchInfo";
            this.labelSearchInfo.Size = new System.Drawing.Size(0, 13);
            this.labelSearchInfo.TabIndex = 4;
            // 
            // buttonCities
            // 
            this.buttonCities.Location = new System.Drawing.Point(413, 7);
            this.buttonCities.Name = "buttonCities";
            this.buttonCities.Size = new System.Drawing.Size(75, 23);
            this.buttonCities.TabIndex = 5;
            this.buttonCities.Text = "Cities";
            this.buttonCities.UseVisualStyleBackColor = true;
            this.buttonCities.Click += new System.EventHandler(this.buttonCities_Click);
            // 
            // buttonShipwrecks
            // 
            this.buttonShipwrecks.Location = new System.Drawing.Point(494, 7);
            this.buttonShipwrecks.Name = "buttonShipwrecks";
            this.buttonShipwrecks.Size = new System.Drawing.Size(75, 23);
            this.buttonShipwrecks.TabIndex = 6;
            this.buttonShipwrecks.Text = "Shipwrecks";
            this.buttonShipwrecks.UseVisualStyleBackColor = true;
            this.buttonShipwrecks.Click += new System.EventHandler(this.buttonShipwrecks_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

