namespace SnowshoesPen
{
    partial class Playground_ChartGenerationMS
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.msChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.msChart)).BeginInit();
            this.SuspendLayout();
            // 
            // msChart
            // 
            this.msChart.BackColor = System.Drawing.Color.Black;
            this.msChart.BackSecondaryColor = System.Drawing.Color.CornflowerBlue;
            this.msChart.BorderlineColor = System.Drawing.SystemColors.Window;
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Area3DStyle.Inclination = 0;
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.BackSecondaryColor = System.Drawing.Color.Black;
            chartArea1.BorderColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.msChart.ChartAreas.Add(chartArea1);
            this.msChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.BackColor = System.Drawing.Color.Black;
            legend1.Font = new System.Drawing.Font("Open Sans", 8F);
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.msChart.Legends.Add(legend1);
            this.msChart.Location = new System.Drawing.Point(0, 0);
            this.msChart.Name = "msChart";
            this.msChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.DarkViolet;
            series1.Legend = "Legend1";
            series1.Name = "Indigo Sales";
            series1.ShadowColor = System.Drawing.Color.Maroon;
            series1.YValuesPerPoint = 3;
            this.msChart.Series.Add(series1);
            this.msChart.Size = new System.Drawing.Size(743, 380);
            this.msChart.TabIndex = 0;
            this.msChart.Text = "chart1";
            // 
            // Playground_ChartGenerationMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(743, 380);
            this.Controls.Add(this.msChart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Playground_ChartGenerationMS";
            this.Text = "Playground_ChartGenerationMS";
            ((System.ComponentModel.ISupportInitialize)(this.msChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart msChart;
    }
}