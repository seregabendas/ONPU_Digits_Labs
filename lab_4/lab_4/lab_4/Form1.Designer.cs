namespace lab_4
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
            this.pbSource = new System.Windows.Forms.PictureBox();
            this.pbResult = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnWave = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.tbV2 = new System.Windows.Forms.TrackBar();
            this.tbV1 = new System.Windows.Forms.TrackBar();
            this.tbV3 = new System.Windows.Forms.TrackBar();
            this.tbV4 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pbSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbV2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbV3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbV4)).BeginInit();
            this.SuspendLayout();
            // 
            // pbSource
            // 
            this.pbSource.Location = new System.Drawing.Point(12, 12);
            this.pbSource.Name = "pbSource";
            this.pbSource.Size = new System.Drawing.Size(720, 448);
            this.pbSource.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSource.TabIndex = 0;
            this.pbSource.TabStop = false;
            // 
            // pbResult
            // 
            this.pbResult.Location = new System.Drawing.Point(730, 12);
            this.pbResult.Name = "pbResult";
            this.pbResult.Size = new System.Drawing.Size(720, 448);
            this.pbResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbResult.TabIndex = 1;
            this.pbResult.TabStop = false;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(12, 467);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnWave
            // 
            this.btnWave.Location = new System.Drawing.Point(12, 497);
            this.btnWave.Name = "btnWave";
            this.btnWave.Size = new System.Drawing.Size(75, 23);
            this.btnWave.TabIndex = 3;
            this.btnWave.Text = "Wave";
            this.btnWave.UseVisualStyleBackColor = true;
            this.btnWave.Click += new System.EventHandler(this.btnWave_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(146, 467);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 50);
            this.trackBar1.TabIndex = 4;
            // 
            // tbV2
            // 
            this.tbV2.Location = new System.Drawing.Point(257, 467);
            this.tbV2.Maximum = 50;
            this.tbV2.Minimum = 1;
            this.tbV2.Name = "tbV2";
            this.tbV2.Size = new System.Drawing.Size(104, 50);
            this.tbV2.TabIndex = 5;
            this.tbV2.Value = 1;
            // 
            // tbV1
            // 
            this.tbV1.Location = new System.Drawing.Point(146, 466);
            this.tbV1.Maximum = 50;
            this.tbV1.Name = "tbV1";
            this.tbV1.Size = new System.Drawing.Size(104, 50);
            this.tbV1.TabIndex = 6;
            this.tbV1.Value = 1;
            // 
            // tbV3
            // 
            this.tbV3.Location = new System.Drawing.Point(146, 523);
            this.tbV3.Maximum = 50;
            this.tbV3.Name = "tbV3";
            this.tbV3.Size = new System.Drawing.Size(104, 50);
            this.tbV3.TabIndex = 7;
            this.tbV3.Value = 1;
            // 
            // tbV4
            // 
            this.tbV4.Location = new System.Drawing.Point(257, 523);
            this.tbV4.Maximum = 50;
            this.tbV4.Minimum = 1;
            this.tbV4.Name = "tbV4";
            this.tbV4.Size = new System.Drawing.Size(104, 50);
            this.tbV4.TabIndex = 8;
            this.tbV4.Value = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1462, 636);
            this.Controls.Add(this.tbV4);
            this.Controls.Add(this.tbV3);
            this.Controls.Add(this.tbV1);
            this.Controls.Add(this.tbV2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.btnWave);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.pbResult);
            this.Controls.Add(this.pbSource);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbV2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbV3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbV4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSource;
        private System.Windows.Forms.PictureBox pbResult;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnWave;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar tbV2;
        private System.Windows.Forms.TrackBar tbV1;
        private System.Windows.Forms.TrackBar tbV3;
        private System.Windows.Forms.TrackBar tbV4;
    }
}

