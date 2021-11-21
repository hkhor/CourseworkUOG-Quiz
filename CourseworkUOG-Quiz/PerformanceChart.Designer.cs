
namespace CourseworkUOG_Quiz
{
    partial class PerformanceChart
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartPerformance = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartPerformance)).BeginInit();
            this.SuspendLayout();
            // 
            // chartPerformance
            // 
            chartArea1.Name = "ChartArea1";
            this.chartPerformance.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartPerformance.Legends.Add(legend1);
            this.chartPerformance.Location = new System.Drawing.Point(110, 57);
            this.chartPerformance.Name = "chartPerformance";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartPerformance.Series.Add(series1);
            this.chartPerformance.Size = new System.Drawing.Size(565, 363);
            this.chartPerformance.TabIndex = 0;
            this.chartPerformance.Text = "chart1";
            title1.Name = "Last Performace";
            this.chartPerformance.Titles.Add(title1);
            // 
            // PerformanceChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartPerformance);
            this.Name = "PerformanceChart";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chartPerformance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartPerformance;
    }
}