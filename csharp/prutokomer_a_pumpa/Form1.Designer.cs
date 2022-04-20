
namespace prutokomer_a_pumpa
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label_COM_flow = new System.Windows.Forms.Label();
            this.chart_flow = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart_flow)).BeginInit();
            this.SuspendLayout();
            // 
            // label_COM_flow
            // 
            this.label_COM_flow.AutoSize = true;
            this.label_COM_flow.ForeColor = System.Drawing.Color.Red;
            this.label_COM_flow.Location = new System.Drawing.Point(286, 9);
            this.label_COM_flow.Name = "label_COM_flow";
            this.label_COM_flow.Size = new System.Drawing.Size(20, 17);
            this.label_COM_flow.TabIndex = 0;
            this.label_COM_flow.Text = "NA";
            this.label_COM_flow.UseCompatibleTextRendering = true;
            this.label_COM_flow.Click += new System.EventHandler(this.COM_flow_Click);
            // 
            // chart_flow
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_flow.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_flow.Legends.Add(legend1);
            this.chart_flow.Location = new System.Drawing.Point(12, 29);
            this.chart_flow.Name = "chart_flow";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_flow.Series.Add(series1);
            this.chart_flow.Size = new System.Drawing.Size(725, 306);
            this.chart_flow.TabIndex = 1;
            this.chart_flow.Text = "flow";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 631);
            this.Controls.Add(this.chart_flow);
            this.Controls.Add(this.label_COM_flow);
            this.Name = "Form1";
            this.Text = "Flowmeter and pump";
            ((System.ComponentModel.ISupportInitialize)(this.chart_flow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_COM_flow;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_flow;
    }
}

