using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> Set;
        private void SetEnter_TextChanged(object sender, EventArgs e)
        {
            Set = new List<int>();
            for (int i = 0; i < SetEnter.Text.Length; i++)
            {

            }
            WideLabel.Text = "";
            HeightLabel.Text = "";
            FillLabel.Text = "";
            string SetString = "";
            foreach (var symbol in SetEnter.Text)
            {
             
                if (Char.IsDigit(symbol))
                {
                    SetString += symbol;
                }
                else
                {
                    if (SetString != "")
                    {
                        Set.Add(int.Parse(SetString));
                        SetString = "";
                    }
                }
            }
            if (SetString != "")
            {
                Set.Add(int.Parse(SetString));
                SetString = "";
            }
            foreach (var element in Set)
            {
                WideLabel.Text += "  " + element.ToString();
                HeightLabel.Text += "\n " + element.ToString();
                foreach (var elementx2 in Set)
                {
                   FillLabel.Text += "  " + elementx2.ToString();
                }
                FillLabel.Text += "\n " ;
            }
        }
    }
}
