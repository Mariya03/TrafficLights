namespace TrafficLights
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
            this.RedLight = new System.Windows.Forms.PictureBox();
            this.YellowLight = new System.Windows.Forms.PictureBox();
            this.GreenLight = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.RedLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YellowLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenLight)).BeginInit();
            this.SuspendLayout();
            // 
            // RedLight
            // 
            this.RedLight.Location = new System.Drawing.Point(159, 12);
            this.RedLight.Name = "RedLight";
            this.RedLight.Size = new System.Drawing.Size(150, 150);
            this.RedLight.TabIndex = 0;
            this.RedLight.TabStop = false;
            // 
            // YellowLight
            // 
            this.YellowLight.Location = new System.Drawing.Point(159, 181);
            this.YellowLight.Name = "YellowLight";
            this.YellowLight.Size = new System.Drawing.Size(150, 150);
            this.YellowLight.TabIndex = 1;
            this.YellowLight.TabStop = false;
            // 
            // GreenLight
            // 
            this.GreenLight.Location = new System.Drawing.Point(159, 354);
            this.GreenLight.Name = "GreenLight";
            this.GreenLight.Size = new System.Drawing.Size(150, 150);
            this.GreenLight.TabIndex = 2;
            this.GreenLight.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 525);
            this.Controls.Add(this.GreenLight);
            this.Controls.Add(this.YellowLight);
            this.Controls.Add(this.RedLight);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.RedLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YellowLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenLight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox RedLight;
        private System.Windows.Forms.PictureBox YellowLight;
        private System.Windows.Forms.PictureBox GreenLight;
    }
}

