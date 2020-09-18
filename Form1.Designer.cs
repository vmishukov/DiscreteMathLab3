namespace WindowsFormsApp1
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
            this.SetEnter = new System.Windows.Forms.TextBox();
            this.WideLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.FillLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SetEnter
            // 
            this.SetEnter.Location = new System.Drawing.Point(36, 44);
            this.SetEnter.Name = "SetEnter";
            this.SetEnter.Size = new System.Drawing.Size(117, 20);
            this.SetEnter.TabIndex = 0;
            this.SetEnter.TextChanged += new System.EventHandler(this.SetEnter_TextChanged);
            // 
            // WideLabel
            // 
            this.WideLabel.AutoSize = true;
            this.WideLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WideLabel.ForeColor = System.Drawing.Color.Blue;
            this.WideLabel.Location = new System.Drawing.Point(25, 11);
            this.WideLabel.Name = "WideLabel";
            this.WideLabel.Size = new System.Drawing.Size(29, 13);
            this.WideLabel.TabIndex = 1;
            this.WideLabel.Text = "wide";
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeightLabel.ForeColor = System.Drawing.Color.Blue;
            this.HeightLabel.Location = new System.Drawing.Point(6, 25);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(13, 78);
            this.HeightLabel.TabIndex = 2;
            this.HeightLabel.Text = "h\r\ne\r\ni\r\ng\r\nh\r\nt\r\n";
            // 
            // FillLabel
            // 
            this.FillLabel.AutoSize = true;
            this.FillLabel.Location = new System.Drawing.Point(25, 38);
            this.FillLabel.Name = "FillLabel";
            this.FillLabel.Size = new System.Drawing.Size(16, 13);
            this.FillLabel.TabIndex = 3;
            this.FillLabel.Text = "fill";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.WideLabel);
            this.panel1.Controls.Add(this.FillLabel);
            this.panel1.Controls.Add(this.HeightLabel);
            this.panel1.Location = new System.Drawing.Point(36, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 217);
            this.panel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 405);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SetEnter);
            this.Name = "Form1";
            this.Text = "Лабораторная работа № 1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SetEnter;
        private System.Windows.Forms.Label WideLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label FillLabel;
        private System.Windows.Forms.Panel panel1;
    }
}

