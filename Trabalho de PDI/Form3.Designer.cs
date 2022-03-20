namespace Trabalho_de_PDI
{
    partial class Form3
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartTest = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.imageTest = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageTest)).BeginInit();
            this.SuspendLayout();
            // 
            // chartTest
            // 
            chartArea2.Name = "ChartArea1";
            this.chartTest.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartTest.Legends.Add(legend2);
            this.chartTest.Location = new System.Drawing.Point(3, 102);
            this.chartTest.Name = "chartTest";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartTest.Series.Add(series2);
            this.chartTest.Size = new System.Drawing.Size(375, 213);
            this.chartTest.TabIndex = 0;
            this.chartTest.Text = "chart1";
            // 
            // imageTest
            // 
            this.imageTest.Location = new System.Drawing.Point(415, 102);
            this.imageTest.Name = "imageTest";
            this.imageTest.Size = new System.Drawing.Size(323, 213);
            this.imageTest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageTest.TabIndex = 1;
            this.imageTest.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imageTest);
            this.Controls.Add(this.chartTest);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageTest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartTest;
        private System.Windows.Forms.PictureBox imageTest;
    }
}