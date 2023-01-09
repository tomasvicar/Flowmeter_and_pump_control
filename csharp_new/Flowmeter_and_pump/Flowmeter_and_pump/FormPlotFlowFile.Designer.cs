
namespace Flowmeter_and_pump
{
    partial class FormPlotFlowFile
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
            this.listBox_header = new System.Windows.Forms.ListBox();
            this.chart_flow = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart_flow)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_header
            // 
            this.listBox_header.FormattingEnabled = true;
            this.listBox_header.Location = new System.Drawing.Point(2, 544);
            this.listBox_header.Name = "listBox_header";
            this.listBox_header.Size = new System.Drawing.Size(315, 160);
            this.listBox_header.TabIndex = 0;
            this.listBox_header.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // chart_flow
            // 
            this.chart_flow.BackColor = System.Drawing.Color.DimGray;
            chartArea1.BackColor = System.Drawing.Color.Gray;
            chartArea1.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.chart_flow.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_flow.Legends.Add(legend1);
            this.chart_flow.Location = new System.Drawing.Point(2, -1);
            this.chart_flow.Name = "chart_flow";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_flow.Series.Add(series1);
            this.chart_flow.Size = new System.Drawing.Size(1345, 539);
            this.chart_flow.TabIndex = 1;
            this.chart_flow.Text = "chart1";
            // 
            // FormPlotFlowFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 713);
            this.Controls.Add(this.chart_flow);
            this.Controls.Add(this.listBox_header);
            this.Name = "FormPlotFlowFile";
            this.Text = "FormPlotFlowFile";
            this.Load += new System.EventHandler(this.FormPlotFlowFile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_flow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_header;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_flow;
    }
}