using System;
using System.Collections.Generic;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace ArtemHuyaritKod
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly List<string> SignList = new() { "/", "*", "-", "+" };

        public MainWindow()
        {
            InitializeComponent();

            foreach (object btn in MyGrid.Children)
            {
                if (btn is Button)
                {
                    ((Button)btn).Click += MyClick;
                }
            }
        }

        

        private void MyClick(object sender, RoutedEventArgs e)
        {
            string Str1 = (string)((Button)e.OriginalSource).Content;
            int Num;

            switch (Str1)
            {
                case "+/-":
                    
                    break;

                case "+" or "-" or "/" or "*":

                    break;

                case ".":

                    break;

                case "C":

                    break;

                case "=":

                    break;

                default:
                    bool Check = Int32.TryParse(Str1, out Num);


                    break;
            }

        }


       /*private bool check = true;
        private bool ChAnsw = false;
        private string CurrentSign;
        private string CurrentCont;
        private string Answer;
        private string ot;
        private string Temp;

        private readonly List<string> SignList = new() {"/", "*", "-", "+"};*/

       /* public MainWindow()
        {
            InitializeComponent();

            foreach (object btn in MyGrid.Children)
            {
                if (btn is Button)
                {
                    ((Button)btn).Click += MyClick;
                }
            }
        }*/



        /*private void Mutch(string MyStr)
        {


            foreach (string Sg in SignList)
            {
                if ((Temp.Length > (Temp.IndexOf(CurrentSign) + 1)) && Temp.Contains(Sg))
                {
                    Temp += MyStr;
                    TB3.Text = "";
                    TB3.Text = Temp + " index :" + (Temp.IndexOf(CurrentSign) + 1) + "lenght :" + Temp.Length;
                    return;
                }
            }

            TB3.Text = Temp + " index :" + (Temp.IndexOf(CurrentSign) + 1) + "lenght :" + Temp.Length;

            if (!TB1.Text.Contains("=") || TB1.Text != "")
            {
                foreach (string Sg in SignList)
                {
                    if (TB1.Text.Contains(Sg) && !TB1.Text.Contains("="))
                    {
                        CurrentSign = MyStr;
                        TB1.Text = TB1.Text.Replace(Sg, MyStr);
                        Temp = Temp.Replace(Sg, MyStr);
                        return;
                    }
                }
            }

            if (ChAnsw == true)
            {
                CurrentSign = MyStr;
                TB1.Text = TB2.Text + MyStr;
                check = false;
                ChAnsw = false;
            }
            else
            {
                CurrentSign = MyStr;
                TB1.Text += TB2.Text + MyStr;
                check = false;
            }
            Temp += MyStr;
        }*/


        /*private void MResult(string TempStr)
        {
            if (TB1.Text.Contains('='))
            {
                TB1.Text = TB2.Text + CurrentSign + CurrentCont;
                Answer = new DataTable().Compute(TB1.Text, null).ToString().Replace(',', '.');
                TB1.Text += TempStr;
                TB2.Text = Answer;
                TB3.Text = TB1.Text + TB2.Text;
            }
            else
            {
                TB1.Text += TB2.Text;
                ot = new DataTable().Compute(TB1.Text, null).ToString().Replace(',', '.');
                TB1.Text += TempStr;
                TB2.Text = ot;
                TB3.Text = TB1.Text + TB2.Text;
            }
            ChAnsw = true;
            Temp = "";
        }*/

        /*private void Clear()
        {
            TB1.Text = "";
            TB2.Text = "0";
            Answer = "";
            ot = "";
            CurrentCont = "";
            CurrentSign = "";
            Temp = "";
        }*/

        /*private void MyClick(object sender, RoutedEventArgs e)
        {

            string Str1 = (string)((Button)e.OriginalSource).Content;

            switch (Str1)
            {
                case "+/-":
                    if (TB2.Text != "0")
                    {
                        if (TB2.Text[0] == '-')
                        {
                            TB2.Text = TB2.Text.Remove(0, 1);
                        }
                        else
                        {
                            TB2.Text = TB2.Text.Insert(0, "-");
                        }
                    }

                    break;

                case "=":
                    MResult(Str1);
                    break;

                case "+" or "-" or "/" or "*":
                    Mutch(Str1);
                    break;

                case "C":
                    Clear();
                    break;

                case ".":
                    if (ChAnsw == true) { Clear(); ChAnsw = false; }
                    if (TB2.Text.Contains(".") && check == true)
                    {
                    }
                    else if (TB2.Text == "0" || check == false)
                    {
                        TB2.Text = "0" + Str1;
                        check = true;
                    }
                    else
                    {
                        TB2.Text += Str1;
                    }
                    break;

                default:
                    if (ChAnsw == true) { Clear(); ChAnsw = false; }
                    if ((TB1.Text.EndsWith('+') || TB1.Text.EndsWith('-') || TB1.Text.EndsWith('*') || TB1.Text.EndsWith('/')) && check == false)
                    {
                        TB2.Text = "0";
                        check = true;
                    }

                    if (TB2.Text == "0")
                    {
                        TB2.Text = Str1;
                    }
                    else
                    {
                        TB2.Text += Str1;
                    }
                    Temp += Str1;
                    CurrentCont = TB2.Text;
                    TB3.Text = Temp + " index :" + (Temp.IndexOf(Str1) + 1) + " lenght :" + Temp.Length;
                    break;
            }
        }*/
    }
}
