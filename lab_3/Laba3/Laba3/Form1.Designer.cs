namespace Laba3
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
            this.btnOpen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnGlass = new System.Windows.Forms.Button();
            this.tbGlass = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pbSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGlass)).BeginInit();
            this.SuspendLayout();
            // 
            // pbSource
            // 
            this.pbSource.Location = new System.Drawing.Point(12, 12);
            this.pbSource.Name = "pbSource";
            this.pbSource.Size = new System.Drawing.Size(604, 355);
            this.pbSource.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSource.TabIndex = 0;
            this.pbSource.TabStop = false;
            // 
            // pbResult
            // 
            this.pbResult.Location = new System.Drawing.Point(622, 12);
            this.pbResult.Name = "pbResult";
            this.pbResult.Size = new System.Drawing.Size(604, 355);
            this.pbResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbResult.TabIndex = 1;
            this.pbResult.TabStop = false;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(12, 374);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnGlass
            // 
            this.btnGlass.Location = new System.Drawing.Point(13, 404);
            this.btnGlass.Name = "btnGlass";
            this.btnGlass.Size = new System.Drawing.Size(75, 23);
            this.btnGlass.TabIndex = 3;
            this.btnGlass.Text = "Glass";
            this.btnGlass.UseVisualStyleBackColor = true;
            this.btnGlass.Click += new System.EventHandler(this.btnGlass_Click);
            // 
            // tbGlass
            // 
            this.tbGlass.Location = new System.Drawing.Point(103, 404);
            this.tbGlass.Maximum = 200;
            this.tbGlass.Name = "tbGlass";
            this.tbGlass.Size = new System.Drawing.Size(139, 50);
            this.tbGlass.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 547);
            this.Controls.Add(this.tbGlass);
            this.Controls.Add(this.btnGlass);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.pbResult);
            this.Controls.Add(this.pbSource);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGlass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSource;
        private System.Windows.Forms.PictureBox pbResult;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnGlass;
        private System.Windows.Forms.TrackBar tbGlass;
    }
}

