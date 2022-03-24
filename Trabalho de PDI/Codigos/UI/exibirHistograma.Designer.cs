namespace Trabalho_de_PDI
{
    partial class exibirHistograma
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
            this.histogramaChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.histogramaChart)).BeginInit();
            this.SuspendLayout();
            // 
            // histogramaChart
            // 
            this.histogramaChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.histogramaChart.BorderSkin.BackColor = System.Drawing.Color.Black;
            this.histogramaChart.BorderSkin.BorderColor = System.Drawing.Color.Gainsboro;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            chartArea1.BorderColor = System.Drawing.Color.IndianRed;
            chartArea1.CursorX.LineColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.histogramaChart.ChartAreas.Add(chartArea1);
            this.histogramaChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.Name = "Legend1";
            this.histogramaChart.Legends.Add(legend1);
            this.histogramaChart.Location = new System.Drawing.Point(0, 0);
            this.histogramaChart.Name = "histogramaChart";
            this.histogramaChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "Quantidade";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series1.YValuesPerPoint = 2;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.histogramaChart.Series.Add(series1);
            this.histogramaChart.Size = new System.Drawing.Size(534, 361);
            this.histogramaChart.TabIndex = 0;
            this.histogramaChart.Text = "histograma";
            title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.White;
            title1.Name = "maintitle";
            title1.Text = "Distribuição de Intensidades";
            this.histogramaChart.Titles.Add(title1);
            // 
            // exibirHistograma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(534, 361);
            this.Controls.Add(this.histogramaChart);
            this.Name = "exibirHistograma";
            this.ShowIcon = false;
            this.Text = "exibirHistograma";
            this.Load += new System.EventHandler(this.exibirHistograma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.histogramaChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart histogramaChart;
    }
}