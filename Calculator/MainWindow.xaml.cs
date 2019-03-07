﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Make calculator object for calculation
        Calc calculator = new Calc();

        public MainWindow()
        {
            InitializeComponent();
        }

        class Calc
        {
            private long firstNumber, secondNumber;
            private bool isNumSaved;
            private bool isPlus, isMinus, isMult, isDiv, isExp;

            public Calc()
            {
                firstNumber = 0;
                secondNumber = 0;
                isNumSaved = false;
                isPlus = false;
                isMinus = false;
                isMult = false;
                isDiv = false;
                isExp = false;
            }

            public Calc(long firstNumber, long secondNumber)
            {
                this.firstNumber = firstNumber;
                this.secondNumber = secondNumber;
                isNumSaved = false;
                isPlus = false;
                isMinus = false;
                isMult = false;
                isDiv = false;
                isExp = false;
            }

            public void SetFirstNumber(long num)
            {
                firstNumber = num;
            }

            public void SetSecondNumber(long num)
            {
                secondNumber = num;
            }

            public bool Check(bool arg)
            {
                if (arg)
                {
                    return true;
                }

                return false;
            }

            public void setFirstNumberSaved()
            {
                isNumSaved = true;
            }

            public void setFirstNumberUnsaved()
            {
                isNumSaved = false;
            }
          
            public void setPlus()
            {
                isPlus = true;
            }

            public void unsetPlus()
            {
                isPlus = false;
            }


            public void setMinus()
            {
                isMinus = true;
            }

            public void unsetMinus()
            {
                isMinus = false;
            }

            public void setMult()
            {
                isMult = true;
            }

            public void unsetMult()
            {
                isMult = false;
            }

            public void setDiv()
            {
                isDiv = true;
            }

            public void unsetDiv()
            {
                isDiv = false;
            }

            public void setExp()
            {
                isExp = true;
            }

            public void unsetExp()
            {
                isExp = false;
            }

            public static long Add(long firstNumber, long secondNumber)
            {
                return firstNumber + secondNumber;
            }

            public static long Subtract(long firstNumber, long secondNumber)
            {
                return firstNumber - secondNumber;
            }

            public static long Multiply(long firstNumber, long secondNumber)
            {
                return firstNumber * secondNumber;
            }

            public static long Divide(long firstNumber, long secondNumber)
            {
                return firstNumber / secondNumber;
            }

            public static long Exponentiate(long number, long exponent)
            {
                for (int i = 1; i < exponent; i++)
                {
                    number *= number;
                }

                return number;
            }

            public void Clear()
            {
                firstNumber = 0;
                secondNumber = 0;
            }

        }

        private void num0Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string newNumStr = resultBox.Text + "0";
                long newNum = long.Parse(newNumStr);
                resultBox.Text = newNum.ToString();
            }
            catch (OverflowException)
            {
                resultBox.Text = resultBox.Text;
            }

        }

        private void num1Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string newNumStr = resultBox.Text + "1";
                long newNum = long.Parse(newNumStr);
                resultBox.Text = newNum.ToString();
            }
            catch (OverflowException)
            {
                resultBox.Text = resultBox.Text;
            }
        }

        private void num2Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string newNumStr = resultBox.Text + "2";
                long newNum = long.Parse(newNumStr);
                resultBox.Text = newNum.ToString();
            } catch (OverflowException)
            {
                resultBox.Text = resultBox.Text;
            }
        }

        private void num3Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string newNumStr = resultBox.Text + "3";
                long newNum = long.Parse(newNumStr);
                resultBox.Text = newNum.ToString();
            }
            catch (OverflowException)
            {
                resultBox.Text = resultBox.Text;
            }
        }

        private void num4Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string newNumStr = resultBox.Text + "4";
                long newNum = long.Parse(newNumStr);
                resultBox.Text = newNum.ToString();
            }
            catch (OverflowException)
            {
                resultBox.Text = resultBox.Text;
            }
        }

        private void num5Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string newNumStr = resultBox.Text + "5";
                long newNum = long.Parse(newNumStr);
                resultBox.Text = newNum.ToString();
            }
            catch (OverflowException)
            {
                resultBox.Text = resultBox.Text;
            }
        }

        private void num6Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string newNumStr = resultBox.Text + "6";
                long newNum = long.Parse(newNumStr);
                resultBox.Text = newNum.ToString();
            }
            catch (OverflowException)
            {
                resultBox.Text = resultBox.Text;
            }
        }

        private void num7Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string newNumStr = resultBox.Text + "7";
                long newNum = long.Parse(newNumStr);
                resultBox.Text = newNum.ToString();
            }
            catch (OverflowException)
            {
                resultBox.Text = resultBox.Text;
            }
        }

        private void num8Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string newNumStr = resultBox.Text + "8";
                long newNum = long.Parse(newNumStr);
                resultBox.Text = newNum.ToString();
            }
            catch (OverflowException)
            {
                resultBox.Text = resultBox.Text;
            }
        }

        private void num9Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string newNumStr = resultBox.Text + "9";
                long newNum = long.Parse(newNumStr);
                resultBox.Text = newNum.ToString();
            }
            catch (OverflowException)
            {
                resultBox.Text = resultBox.Text;
            }
        }

        private void clearEntryClick(object sender, RoutedEventArgs e)
        {
            resultBox.Text = "0";
            calculator.setFirstNumberUnsaved();
        }

        private void plusClick(object sender, RoutedEventArgs e)
        {
            calculator.SetFirstNumber(long.Parse(resultBox.Text));
            calculator.setPlus();
            calculator.setFirstNumberSaved();
            
        }
    }
}
