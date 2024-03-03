
namespace AstroSimCharts
{
    partial class SystemVisualisation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private global::System.ComponentModel.IContainer components = null;

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
            this.systemPointChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.AddPlanetButton = new System.Windows.Forms.Button();
            this.AddSatelliteButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.systemPointChart)).BeginInit();
            this.SuspendLayout();
            // 
            // systemPointChart
            // 
            chartArea1.Name = "ChartArea1";
            this.systemPointChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.systemPointChart.Legends.Add(legend1);
            this.systemPointChart.Location = new System.Drawing.Point(12, 12);
            this.systemPointChart.Name = "systemPointChart";
            this.systemPointChart.Size = new System.Drawing.Size(977, 434);
            this.systemPointChart.TabIndex = 0;
            this.systemPointChart.Text = "systemPointChart";
            this.systemPointChart.Click += new System.EventHandler(this.systemPointChart_Click);
            // 
            // AddPlanetButton
            // 
            this.AddPlanetButton.Location = new System.Drawing.Point(360, 485);
            this.AddPlanetButton.Name = "AddPlanetButton";
            this.AddPlanetButton.Size = new System.Drawing.Size(133, 44);
            this.AddPlanetButton.TabIndex = 1;
            this.AddPlanetButton.Text = "Add a planet";
            this.AddPlanetButton.UseVisualStyleBackColor = true;
            this.AddPlanetButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddSatelliteButton
            // 
            this.AddSatelliteButton.Location = new System.Drawing.Point(525, 485);
            this.AddSatelliteButton.Name = "AddSatelliteButton";
            this.AddSatelliteButton.Size = new System.Drawing.Size(133, 44);
            this.AddSatelliteButton.TabIndex = 2;
            this.AddSatelliteButton.Text = "Add a satellite";
            this.AddSatelliteButton.UseVisualStyleBackColor = true;
            this.AddSatelliteButton.Click += new System.EventHandler(this.AddSatelliteButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(416, 465);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Add a new object to the system";
            // 
            // SystemVisualisation
            // 
            this.ClientSize = new System.Drawing.Size(1001, 553);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddSatelliteButton);
            this.Controls.Add(this.AddPlanetButton);
            this.Controls.Add(this.systemPointChart);
            this.Name = "SystemVisualisation";
            ((System.ComponentModel.ISupportInitialize)(this.systemPointChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private global::System.Windows.Forms.DataVisualization.Charting.Chart systemChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart systemPointChart;
        private System.Windows.Forms.Button AddPlanetButton;
        private System.Windows.Forms.Button AddSatelliteButton;
        private System.Windows.Forms.Label label1;
    }
}

