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
        List<Pairs> Pairs;
        //List<string> Set;
        Dictionary<string,int> Set;
        SimpleUndirectedGraph<string, string> _graph = new SimpleUndirectedGraph<string, string>();
        private void SetEnter_TextChanged(object sender, EventArgs e)
        {
            _graph = new SimpleUndirectedGraph<string, string>();
            Set = new Dictionary<string, int>();       
            string SetString = "";
            foreach (var symbol in SetEnter.Text)
            {
                if (symbol!=',')
                {
                    SetString += symbol;
                }
                else
                {
                    if (SetString != "")
                    {
                        if (!Set.Keys.Contains(SetString))
                        {
                            Set.Add(SetString,0);
                           
                        }
                        SetString = "";
                    }
                }
            }
            if (SetString != "")
            {
                if (!Set.Keys.Contains(SetString))
                {
                    Set.Add(SetString,0);
                }
                SetString = "";
            }
            SetOutPut.Text = "Вершины графа:";
            foreach (var element in Set.Keys)
            {
                if (Set.Keys.ToList().IndexOf(element) == 0)
                {
                    SetOutPut.Text += element;
                }
                else
                    SetOutPut.Text += ", " + element;
                _graph.AddVertex(element);
            }
        }
        private void SetEnter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.Equals(',', e.KeyChar)) && ((!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar))))
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
            if ((!char.Equals(',', e.KeyChar)) && ((!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar))) && (!char.Equals('(', e.KeyChar)) && (!char.Equals(')', e.KeyChar)))
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
            _graph.DeleteEdges();
            string A = "";
            string B= "";
            string SetString = "";
            bool isPairMade = false;
            foreach (var symbol in PairsSet.Text)
            {
                if (Char.IsDigit(symbol) || Char.IsLetter(symbol))
                {
                    SetString += symbol;
                }
                else
                {
                    if (SetString != "")
                    {
                        if (Set != null)
                        {
                            if (isPairMade == false)
                            {
                                isPairMade = true;
                                A = SetString;
                                SetString = "";
                            }
                            else
                            {
                                isPairMade = false;
                                B = SetString;
                                if (!Classes.Pairs.Contains(Pairs, new Pairs(A, B)) && ((Set.Keys.Contains(A) && (Set.Keys.Contains(B)))))
                                {
                                    Pairs.Add(new Pairs(A, B));
                                    if (!Classes.Pairs.Contains(Pairs, new Pairs(B, A)) && ((Set.Keys.Contains(B) && (Set.Keys.Contains(A)))))
                                    {
                                        Pairs.Add(new Pairs(B, A));
                                    }
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
                B = SetString;
                if (!Classes.Pairs.Contains(Pairs, new Pairs(A, B)) && ((Set.Keys.Contains(A) && (Set.Keys.Contains(B)))))
                {
                    Pairs.Add(new Pairs(A, B));
                    if (!Classes.Pairs.Contains(Pairs, new Pairs(B, A)) && ((Set.Keys.Contains(B) && (Set.Keys.Contains(A)))))
                    {
                        Pairs.Add(new Pairs(B, A));
                    }
                }
                SetString = "";
            }
            PairsOutPut.Text = "Ребра графа:";
            foreach (var element in Pairs)
            {     
                PairsOutPut.Text += "(" + element.a + " , " + element.b + ") ";
                _graph.AddEdge(element.a, element.b, "");
            }
        }
        private void PairsSet_Click(object sender, EventArgs e)
        {

        }
        private void metroButton1_Click(object sender, EventArgs e)
        {                         
            Matrix.Columns.Clear();
            Matrix.Rows.Clear();
            Matrix.Refresh();
            OutPutLabel.Text = "Подмножества:";
            if (_graph !=null && _graph.GetVertexSet().ToList().Count >0)
            {            
                Matrix.ColumnCount = _graph.GetVertexSet().ToList().Count;
                Matrix.RowCount = _graph.GetVertexSet().ToList().Count;
                for (int i = 0; i < _graph.GetVertexSet().ToList().Count; i++)
                {
                    Matrix.Columns[i].Width = 30;
                    Matrix.Columns[i].HeaderText = _graph.GetVertexSet().ToList()[i].ToString();
                    Matrix.Rows[i].HeaderCell.Value = _graph.GetVertexSet().ToList()[i].ToString();
                    for (int j = 0; j < Set.Count; j++)
                    {
                        if (Pairs != null && Pairs.Any())
                        {
                            if (Classes.Pairs.Contains(Pairs, new Classes.Pairs(Set.Keys.ToList()[i], Set.Keys.ToList()[j])))
                            {
                                Matrix.Rows[j].Cells[i].Value = 1;                             
                            }
                            else
                            {
                                Matrix.Rows[j].Cells[i].Value = 0;
                            }
                        }
                        else
                        {
                            Matrix.Rows[j].Cells[i].Value = 0;
                        }
                    }
                }
                int k = 1;
                List<string> CopyKeys = new List<string>();
                foreach (var key in Set.Keys)
                {
                    CopyKeys.Add(key);                 
                }
                foreach (var item in CopyKeys)
                {
                    Set[item] = 0;
                }
                foreach (var key in CopyKeys)
                {
                    if (Set[key] ==0)
                    {
                        bool kek = false;
                        foreach (var item in _graph.BFS(_graph.GetVertexSet().ToList().IndexOf(key)))
                        {
                            if (Set[item] == 0 )
                            {
                                Set[item] = k;
                                kek = true;
                            }
                        }      
                 
                            k++;                       
                    }                  
                }           
                for (int i = 1; i < k; i++)
                {

                    bool newline = true;
                    OutPutLabel.Text += "\n" +i.ToString()+ ") ";
                    foreach (var item in Set)
                    {
                        if (item.Value == i)
                        {
                            if (newline)
                            {
                                OutPutLabel.Text += item.Key.ToString();
                                newline=false;
                            }
                            else
                            {
                                OutPutLabel.Text += ", "+item.Key.ToString() ;
                            }
                            
                        }
                    }
                }
            }   
        }
    }
}
