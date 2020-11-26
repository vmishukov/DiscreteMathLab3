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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PairsSet = new MetroFramework.Controls.MetroTextBox();
            this.SetOutPut = new MetroFramework.Controls.MetroLabel();
            this.SetEnter = new MetroFramework.Controls.MetroTextBox();
            this.PairsOutPut = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.Matrix = new MetroFramework.Controls.MetroGrid();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.OutPutLabel = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.Matrix)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.SuspendLayout();
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
            this.PairsSet.Location = new System.Drawing.Point(23, 107);
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
            this.SetOutPut.Location = new System.Drawing.Point(3, 4);
            this.SetOutPut.Name = "SetOutPut";
            this.SetOutPut.Size = new System.Drawing.Size(111, 19);
            this.SetOutPut.TabIndex = 6;
            this.SetOutPut.Text = "Вершины графа:";
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
            this.SetEnter.Location = new System.Drawing.Point(23, 59);
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
            this.PairsOutPut.Location = new System.Drawing.Point(3, 6);
            this.PairsOutPut.Name = "PairsOutPut";
            this.PairsOutPut.Size = new System.Drawing.Size(91, 19);
            this.PairsOutPut.TabIndex = 10;
            this.PairsOutPut.Text = "Ребра Графа:";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(23, 145);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(132, 38);
            this.metroButton1.TabIndex = 11;
            this.metroButton1.Text = "Матрица смежности и \r\nподмножества";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // Matrix
            // 
            this.Matrix.AllowUserToResizeRows = false;
            this.Matrix.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Matrix.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Matrix.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Matrix.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Matrix.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Matrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Matrix.DefaultCellStyle = dataGridViewCellStyle2;
            this.Matrix.EnableHeadersVisualStyles = false;
            this.Matrix.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Matrix.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Matrix.Location = new System.Drawing.Point(23, 189);
            this.Matrix.Name = "Matrix";
            this.Matrix.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Matrix.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Matrix.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Matrix.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Matrix.Size = new System.Drawing.Size(240, 150);
            this.Matrix.TabIndex = 12;
            // 
            // metroPanel1
            // 
            this.metroPanel1.AutoScroll = true;
            this.metroPanel1.Controls.Add(this.SetOutPut);
            this.metroPanel1.HorizontalScrollbar = true;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(189, 59);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(246, 36);
            this.metroPanel1.TabIndex = 19;
            this.metroPanel1.VerticalScrollbar = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroPanel2
            // 
            this.metroPanel2.AutoScroll = true;
            this.metroPanel2.Controls.Add(this.PairsOutPut);
            this.metroPanel2.HorizontalScrollbar = true;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(189, 101);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(246, 37);
            this.metroPanel2.TabIndex = 20;
            this.metroPanel2.VerticalScrollbar = true;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroPanel3
            // 
            this.metroPanel3.AutoScroll = true;
            this.metroPanel3.Controls.Add(this.OutPutLabel);
            this.metroPanel3.HorizontalScrollbar = true;
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(269, 175);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(166, 164);
            this.metroPanel3.TabIndex = 21;
            this.metroPanel3.VerticalScrollbar = true;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // OutPutLabel
            // 
            this.OutPutLabel.AutoSize = true;
            this.OutPutLabel.Location = new System.Drawing.Point(4, 4);
            this.OutPutLabel.Name = "OutPutLabel";
            this.OutPutLabel.Size = new System.Drawing.Size(102, 19);
            this.OutPutLabel.TabIndex = 2;
            this.OutPutLabel.Text = "Подмножества:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 358);
            this.Controls.Add(this.metroPanel3);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.Matrix);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.SetEnter);
            this.Controls.Add(this.PairsSet);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.Text = "Лабораторная работа № 3";
            ((System.ComponentModel.ISupportInitialize)(this.Matrix)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroLabel SetOutPut;
        private MetroFramework.Controls.MetroTextBox SetEnter;
        private MetroFramework.Controls.MetroTextBox PairsSet;
        private MetroFramework.Controls.MetroLabel PairsOutPut;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroGrid Matrix;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroLabel OutPutLabel;
    }
}

