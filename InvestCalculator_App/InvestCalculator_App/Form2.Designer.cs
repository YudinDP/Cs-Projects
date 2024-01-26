namespace InvestCalculator_App
{
    partial class Form2
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
            this.ProfitSumLabel = new System.Windows.Forms.Label();
            this.ReinvestFinalSumLabel = new System.Windows.Forms.Label();
            this.FinalSumLabel = new System.Windows.Forms.Label();
            this.profitMonthLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // ProfitSumLabel
            // 
            this.ProfitSumLabel.AutoSize = true;
            this.ProfitSumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProfitSumLabel.Location = new System.Drawing.Point(6, 132);
            this.ProfitSumLabel.Name = "ProfitSumLabel";
            this.ProfitSumLabel.Size = new System.Drawing.Size(95, 24);
            this.ProfitSumLabel.TabIndex = 22;
            this.ProfitSumLabel.Text = "Прибыль:";
            // 
            // ReinvestFinalSumLabel
            // 
            this.ReinvestFinalSumLabel.AutoSize = true;
            this.ReinvestFinalSumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReinvestFinalSumLabel.Location = new System.Drawing.Point(6, 71);
            this.ReinvestFinalSumLabel.Name = "ReinvestFinalSumLabel";
            this.ReinvestFinalSumLabel.Size = new System.Drawing.Size(229, 24);
            this.ReinvestFinalSumLabel.TabIndex = 21;
            this.ReinvestFinalSumLabel.Text = "Было реинвестировано:";
            // 
            // FinalSumLabel
            // 
            this.FinalSumLabel.AutoSize = true;
            this.FinalSumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FinalSumLabel.Location = new System.Drawing.Point(6, 21);
            this.FinalSumLabel.Name = "FinalSumLabel";
            this.FinalSumLabel.Size = new System.Drawing.Size(163, 24);
            this.FinalSumLabel.TabIndex = 20;
            this.FinalSumLabel.Text = "Итоговая Сумма:";
            // 
            // profitMonthLabel
            // 
            this.profitMonthLabel.AutoSize = true;
            this.profitMonthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.profitMonthLabel.Location = new System.Drawing.Point(6, 187);
            this.profitMonthLabel.Name = "profitMonthLabel";
            this.profitMonthLabel.Size = new System.Drawing.Size(171, 24);
            this.profitMonthLabel.TabIndex = 23;
            this.profitMonthLabel.Text = "Прибыль в месяц:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.profitMonthLabel);
            this.groupBox1.Controls.Add(this.ProfitSumLabel);
            this.groupBox1.Controls.Add(this.ReinvestFinalSumLabel);
            this.groupBox1.Controls.Add(this.FinalSumLabel);
            this.groupBox1.Location = new System.Drawing.Point(6, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 232);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(101, 259);
            this.chart.Name = "chart";
            this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(565, 426);
            this.chart.TabIndex = 25;
            this.chart.Text = "график";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 697);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Результаты инвестиций";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label ProfitSumLabel;
        public System.Windows.Forms.Label ReinvestFinalSumLabel;
        public System.Windows.Forms.Label FinalSumLabel;
        public System.Windows.Forms.Label profitMonthLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart;
    }
}