namespace LabaRGR
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pbSource = new System.Windows.Forms.PictureBox();
            this.pbResult = new System.Windows.Forms.PictureBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.chartRed = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartBlue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartGreen = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tbRmin = new System.Windows.Forms.TextBox();
            this.tbRmax = new System.Windows.Forms.TextBox();
            this.tbGmin = new System.Windows.Forms.TextBox();
            this.tbGmax = new System.Windows.Forms.TextBox();
            this.tbBmin = new System.Windows.Forms.TextBox();
            this.tbBmax = new System.Windows.Forms.TextBox();
            this.btnHist = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGreen)).BeginInit();
            this.SuspendLayout();
            // 
            // pbSource
            // 
            this.pbSource.Location = new System.Drawing.Point(12, 12);
            this.pbSource.Name = "pbSource";
            this.pbSource.Size = new System.Drawing.Size(614, 342);
            this.pbSource.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSource.TabIndex = 0;
            this.pbSource.TabStop = false;
            // 
            // pbResult
            // 
            this.pbResult.Location = new System.Drawing.Point(649, 12);
            this.pbResult.Name = "pbResult";
            this.pbResult.Size = new System.Drawing.Size(614, 342);
            this.pbResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbResult.TabIndex = 1;
            this.pbResult.TabStop = false;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(12, 361);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // chartRed
            // 
            chartArea1.Name = "ChartArea1";
            this.chartRed.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chartRed.Legends.Add(legend1);
            this.chartRed.Location = new System.Drawing.Point(133, 361);
            this.chartRed.Name = "chartRed";
            this.chartRed.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartRed.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Red};
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Red";
            this.chartRed.Series.Add(series1);
            this.chartRed.Size = new System.Drawing.Size(370, 220);
            this.chartRed.TabIndex = 3;
            this.chartRed.Click += new System.EventHandler(this.chartRed_Click);
            // 
            // chartBlue
            // 
            chartArea2.Name = "ChartArea1";
            this.chartBlue.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chartBlue.Legends.Add(legend2);
            this.chartBlue.Location = new System.Drawing.Point(885, 360);
            this.chartBlue.Name = "chartBlue";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Blue";
            this.chartBlue.Series.Add(series2);
            this.chartBlue.Size = new System.Drawing.Size(370, 220);
            this.chartBlue.TabIndex = 4;
            this.chartBlue.Text = "Blue";
            // 
            // chartGreen
            // 
            chartArea3.Name = "ChartArea1";
            this.chartGreen.ChartAreas.Add(chartArea3);
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            this.chartGreen.Legends.Add(legend3);
            this.chartGreen.Location = new System.Drawing.Point(509, 361);
            this.chartGreen.Name = "chartGreen";
            this.chartGreen.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartGreen.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Lime};
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Green";
            this.chartGreen.Series.Add(series3);
            this.chartGreen.Size = new System.Drawing.Size(370, 220);
            this.chartGreen.TabIndex = 5;
            this.chartGreen.Text = "Green";
            // 
            // tbRmin
            // 
            this.tbRmin.Location = new System.Drawing.Point(133, 598);
            this.tbRmin.Name = "tbRmin";
            this.tbRmin.Size = new System.Drawing.Size(100, 20);
            this.tbRmin.TabIndex = 6;
            // 
            // tbRmax
            // 
            this.tbRmax.Location = new System.Drawing.Point(240, 598);
            this.tbRmax.Name = "tbRmax";
            this.tbRmax.Size = new System.Drawing.Size(100, 20);
            this.tbRmax.TabIndex = 7;
            // 
            // tbGmin
            // 
            this.tbGmin.Location = new System.Drawing.Point(509, 598);
            this.tbGmin.Name = "tbGmin";
            this.tbGmin.Size = new System.Drawing.Size(100, 20);
            this.tbGmin.TabIndex = 8;
            // 
            // tbGmax
            // 
            this.tbGmax.Location = new System.Drawing.Point(616, 598);
            this.tbGmax.Name = "tbGmax";
            this.tbGmax.Size = new System.Drawing.Size(100, 20);
            this.tbGmax.TabIndex = 9;
            // 
            // tbBmin
            // 
            this.tbBmin.Location = new System.Drawing.Point(885, 598);
            this.tbBmin.Name = "tbBmin";
            this.tbBmin.Size = new System.Drawing.Size(100, 20);
            this.tbBmin.TabIndex = 10;
            // 
            // tbBmax
            // 
            this.tbBmax.Location = new System.Drawing.Point(992, 597);
            this.tbBmax.Name = "tbBmax";
            this.tbBmax.Size = new System.Drawing.Size(100, 20);
            this.tbBmax.TabIndex = 11;
            // 
            // btnHist
            // 
            this.btnHist.Location = new System.Drawing.Point(13, 597);
            this.btnHist.Name = "btnHist";
            this.btnHist.Size = new System.Drawing.Size(75, 23);
            this.btnHist.TabIndex = 13;
            this.btnHist.Text = "HistChange";
            this.btnHist.UseVisualStyleBackColor = true;
            this.btnHist.Click += new System.EventHandler(this.btnHist_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 633);
            this.Controls.Add(this.btnHist);
            this.Controls.Add(this.tbBmax);
            this.Controls.Add(this.tbBmin);
            this.Controls.Add(this.tbGmax);
            this.Controls.Add(this.tbGmin);
            this.Controls.Add(this.tbRmax);
            this.Controls.Add(this.tbRmin);
            this.Controls.Add(this.chartGreen);
            this.Controls.Add(this.chartBlue);
            this.Controls.Add(this.chartRed);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.pbResult);
            this.Controls.Add(this.pbSource);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSource;
        private System.Windows.Forms.PictureBox pbResult;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRed;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBlue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGreen;
        private System.Windows.Forms.TextBox tbRmin;
        private System.Windows.Forms.TextBox tbRmax;
        private System.Windows.Forms.TextBox tbGmin;
        private System.Windows.Forms.TextBox tbGmax;
        private System.Windows.Forms.TextBox tbBmin;
        private System.Windows.Forms.TextBox tbBmax;
        private System.Windows.Forms.Button btnHist;
    }
}

