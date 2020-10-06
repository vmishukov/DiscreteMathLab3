using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1.Classes;
using GraphLibrary;

namespace WindowsFormsApp1
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> Set;
        List<Pairs> Pairs;
        private void SetEnter_TextChanged(object sender, EventArgs e)
        {
            Set = new List<int>();

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
                        if (!Set.Contains(int.Parse(SetString)))
                        {
                            Set.Add(int.Parse(SetString));
                        }
                        SetString = "";
                    }
                }
            }
            if (SetString != "")
            {
                if (!Set.Contains(int.Parse(SetString)))
                {
                    Set.Add(int.Parse(SetString));
                }

                SetString = "";
            }

            Set.Sort();
            SetOutPut.Text = "Множество А:";
            foreach (var element in Set)
            {
                if (Set.IndexOf(element) == 0)
                {
                    SetOutPut.Text += element.ToString();
                }
                else
                    SetOutPut.Text += ", " + element.ToString();
            }
            
        }



        private void SetEnter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.Equals(',', e.KeyChar)) && ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar))))
            {

                e.Handled = true;
            }
            else
            {
                if ((SetEnter.Text.Length > 0))
                {

                    if ((char.Equals(',', SetEnter.Text.Last())) && char.Equals(',', e.KeyChar))
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    if (char.Equals(',', e.KeyChar))
                    {
                        e.Handled = true;
                    }

                }

            }

        }
    
        private void PairsSet_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if ((!char.Equals(',', e.KeyChar)) && ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar))) && (!char.Equals('(', e.KeyChar)) && (!char.Equals(')', e.KeyChar)))
            {

                e.Handled = true;

            }
            else
            {
                if ((PairsSet.Text.Length > 0))
                {

                    if ((!char.IsNumber(e.KeyChar)) && (char.Equals(e.KeyChar, PairsSet.Text.Last())))
                    {
                        e.Handled = true;
                    }
                    else
                    {
                        //if (!char.IsNumber(e.KeyChar) && !(char.Equals('(', PairsSet.Text.Last()-1)))
                        //{
                        //   e.Handled = true;
                        //}
                    }
                }
                else
                {

                    if (char.Equals(',', e.KeyChar) || char.Equals(')', e.KeyChar) || (char.IsNumber(e.KeyChar)))
                    {
                        e.Handled = true;
                    }

                }
            }
        }

        private void PairsSet_TextChanged(object sender, EventArgs e)
        {
            Pairs = new List<Pairs>();
            int A = 0;
            int B;
           
            string SetString = "";
            bool isPairMade = false;
            foreach (var symbol in PairsSet.Text)
            {

                if (Char.IsDigit(symbol))
                {
                    SetString += symbol;
                }
                else
                {
                    if (SetString != "")
                    {
                        if (Set!= null) 
                        {
                            if (isPairMade == false)
                            {
                                isPairMade = true;
                                A = int.Parse(SetString);
                                SetString = "";
                            }
                            else
                            {
                                isPairMade = false; 
                                B = int.Parse(SetString);
                                if (!Classes.Pairs.Contains(Pairs, new Pairs(A, B)) &&((Set.Contains(A)&&(Set.Contains(B))) ))
                                {
                                    Pairs.Add(new Pairs(A, B));
                                }

                                SetString = "";
                            }


                        }
                     
                        SetString = "";
                    }
                }

            }
            if ((SetString != "") && (isPairMade == true))
            {
                isPairMade = false;
                B = int.Parse(SetString);
                if (!Classes.Pairs.Contains(Pairs, new Pairs(A, B)) && ((Set.Contains(A) && (Set.Contains(B)))))
                {
                    Pairs.Add(new Pairs(A, B));
                }

                SetString = "";
            }

            Classes.Pairs.Sort(Set,Pairs);
            PairsOutPut.Text = "Пары вида (a,b):";
            foreach (var element in Pairs)
            {
                //if (Pairs.IndexOf(element) == 0)
                //{
                //    PairsOutPut.Text += element.ToString();
                //}
                //else
                    PairsOutPut.Text += "(" + element.a.ToString() + " , " + element.b.ToString() + ") " ;
            


            }
            
        }

        private void PairsSet_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            ReflexiveLabel.Text = "Рефлексивное";
            AntiReflexiveLabel.Text = "Антирефлексивное";
            Symmetric.Text = "Симметричное";
            AntiSymmetric.Text = "Антисимметричное";
            TransitiveLabel.Text = "Транзитивное";
            Matrix.Columns.Clear();
            Matrix.Rows.Clear();
            Matrix.Refresh();
            if (Pairs != null && Set !=null && Set.Any() && Pairs.Any())
            {

                Matrix.ColumnCount = Set.Count;
                Matrix.RowCount = Set.Count;


                for (int i = 0; i < Set.Count; i++)
                {
                    Matrix.Columns[i].Width = 30;
                    Matrix.Columns[i].HeaderText = Set[i].ToString();             
                    Matrix.Rows[i].HeaderCell.Value = Set[i].ToString();

                    for (int j = 0; j < Set.Count; j++)
                    {
                        if (Classes.Pairs.Contains(Pairs, new Classes.Pairs(Set[i], Set[j])))
                        {

                            Matrix.Rows[j].Cells[i].Value = 1;
                        }
                        else
                        {
                            Matrix.Rows[j].Cells[i].Value = 0;
                        }
                    }
                }

                if (Classes.Pairs.ReflexiveCheck(Set,Pairs))
                {
                    ReflexiveLabel.Text += " ✔";
                }
                else
                {
                    ReflexiveLabel.Text += " ✘";
                }
                if (Classes.Pairs.AntiReflexiveCheck(Set, Pairs))
                {
                    AntiReflexiveLabel.Text += " ✔";
                }
                else
                {
                    AntiReflexiveLabel.Text += " ✘";
                }
                if (Classes.Pairs.SymmetricCheck(Pairs))
                {
                    Symmetric.Text += " ✔";
                }
                else
                {
                    Symmetric.Text += " ✘";
                }
                if (Classes.Pairs.AntiSymmetricCheck(Pairs))
                {
                    AntiSymmetric.Text += " ✔";
                }
                else
                {
                    AntiSymmetric.Text += " ✘";
                }
                if (Classes.Pairs.TransitiveCheck(Pairs))
                {
                    TransitiveLabel.Text += " ✔";
                }
                else
                {
                    TransitiveLabel.Text += " ✘";
                }
            }
     
        }

  
    }
}
