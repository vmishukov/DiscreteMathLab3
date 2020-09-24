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
            this.WideLabel = new MetroFramework.Controls.MetroLabel();
            this.HeightLabel = new MetroFramework.Controls.MetroLabel();
            this.FillLabel = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new MetroFramework.Controls.MetroPanel();
            this.PairsSet = new MetroFramework.Controls.MetroTextBox();
            this.SetOutPut = new MetroFramework.Controls.MetroLabel();
            this.SetEnter = new MetroFramework.Controls.MetroTextBox();
            this.PairsOutPut = new MetroFramework.Controls.MetroLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // WideLabel
            // 
            this.WideLabel.AutoSize = true;
            this.WideLabel.ForeColor = System.Drawing.Color.Blue;
            this.WideLabel.Location = new System.Drawing.Point(25, 11);
            this.WideLabel.Name = "WideLabel";
            this.WideLabel.Size = new System.Drawing.Size(36, 19);
            this.WideLabel.TabIndex = 1;
            this.WideLabel.Text = "wide";
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.ForeColor = System.Drawing.Color.Blue;
            this.HeightLabel.Location = new System.Drawing.Point(6, 25);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(17, 133);
            this.HeightLabel.TabIndex = 2;
            this.HeightLabel.Text = "h\r\ne\r\ni\r\ng\r\nh\r\nt\r\n";
            // 
            // FillLabel
            // 
            this.FillLabel.AutoSize = true;
            this.FillLabel.Location = new System.Drawing.Point(25, 38);
            this.FillLabel.Name = "FillLabel";
            this.FillLabel.Size = new System.Drawing.Size(22, 19);
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
            this.panel1.HorizontalScrollbar = true;
            this.panel1.HorizontalScrollbarBarColor = true;
            this.panel1.HorizontalScrollbarHighlightOnWheel = false;
            this.panel1.HorizontalScrollbarSize = 10;
            this.panel1.Location = new System.Drawing.Point(25, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 217);
            this.panel1.TabIndex = 4;
            this.panel1.VerticalScrollbar = true;
            this.panel1.VerticalScrollbarBarColor = true;
            this.panel1.VerticalScrollbarHighlightOnWheel = false;
            this.panel1.VerticalScrollbarSize = 10;
            // 
            // PairsSet
            // 
            // 
            // 
            // 
            this.PairsSet.CustomButton.Image = null;
            this.PairsSet.CustomButton.Location = new System.Drawing.Point(128, 2);
            this.PairsSet.CustomButton.Name = "";
            this.PairsSet.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.PairsSet.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PairsSet.CustomButton.TabIndex = 1;
            this.PairsSet.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PairsSet.CustomButton.UseSelectable = true;
            this.PairsSet.CustomButton.Visible = false;
            this.PairsSet.Lines = new string[] {
        "("};
            this.PairsSet.Location = new System.Drawing.Point(23, 101);
            this.PairsSet.MaxLength = 32767;
            this.PairsSet.Name = "PairsSet";
            this.PairsSet.PasswordChar = '\0';
            this.PairsSet.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PairsSet.SelectedText = "";
            this.PairsSet.SelectionLength = 0;
            this.PairsSet.SelectionStart = 0;
            this.PairsSet.ShortcutsEnabled = true;
            this.PairsSet.Size = new System.Drawing.Size(146, 20);
            this.PairsSet.TabIndex = 5;
            this.PairsSet.Text = "(";
            this.PairsSet.UseSelectable = true;
            this.PairsSet.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PairsSet.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.PairsSet.TextChanged += new System.EventHandler(this.PairsSet_TextChanged);
            this.PairsSet.Click += new System.EventHandler(this.PairsSet_Click);
            this.PairsSet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PairsSet_KeyPress);
            // 
            // SetOutPut
            // 
            this.SetOutPut.AutoSize = true;
            this.SetOutPut.Location = new System.Drawing.Point(189, 63);
            this.SetOutPut.Name = "SetOutPut";
            this.SetOutPut.Size = new System.Drawing.Size(95, 19);
            this.SetOutPut.TabIndex = 6;
            this.SetOutPut.Text = "Множество А:";
            // 
            // SetEnter
            // 
            // 
            // 
            // 
            this.SetEnter.CustomButton.Image = null;
            this.SetEnter.CustomButton.Location = new System.Drawing.Point(124, 1);
            this.SetEnter.CustomButton.Name = "";
            this.SetEnter.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.SetEnter.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SetEnter.CustomButton.TabIndex = 1;
            this.SetEnter.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SetEnter.CustomButton.UseSelectable = true;
            this.SetEnter.CustomButton.Visible = false;
            this.SetEnter.Lines = new string[0];
            this.SetEnter.Location = new System.Drawing.Point(23, 63);
            this.SetEnter.MaxLength = 32767;
            this.SetEnter.Name = "SetEnter";
            this.SetEnter.PasswordChar = '\0';
            this.SetEnter.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SetEnter.SelectedText = "";
            this.SetEnter.SelectionLength = 0;
            this.SetEnter.SelectionStart = 0;
            this.SetEnter.ShortcutsEnabled = true;
            this.SetEnter.Size = new System.Drawing.Size(146, 23);
            this.SetEnter.TabIndex = 9;
            this.SetEnter.UseSelectable = true;
            this.SetEnter.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SetEnter.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.SetEnter.TextChanged += new System.EventHandler(this.SetEnter_TextChanged);
            this.SetEnter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SetEnter_KeyPress);
            // 
            // PairsOutPut
            // 
            this.PairsOutPut.AutoSize = true;
            this.PairsOutPut.Location = new System.Drawing.Point(189, 101);
            this.PairsOutPut.Name = "PairsOutPut";
            this.PairsOutPut.Size = new System.Drawing.Size(108, 19);
            this.PairsOutPut.TabIndex = 10;
            this.PairsOutPut.Text = "Пары вида (a,b):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 452);
            this.Controls.Add(this.PairsOutPut);
            this.Controls.Add(this.SetEnter);
            this.Controls.Add(this.SetOutPut);
            this.Controls.Add(this.PairsSet);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Лабораторная работа № 1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel HeightLabel;
        private MetroFramework.Controls.MetroLabel FillLabel;
        private MetroFramework.Controls.MetroPanel panel1;
        private MetroFramework.Controls.MetroLabel SetOutPut;
        private MetroFramework.Controls.MetroTextBox SetEnter;
        private MetroFramework.Controls.MetroTextBox PairsSet;
        private MetroFramework.Controls.MetroLabel WideLabel;
        private MetroFramework.Controls.MetroLabel PairsOutPut;
    }
}

