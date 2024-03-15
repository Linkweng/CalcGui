using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
            
        }

        private void ClearAll_Click(object sender, EventArgs e)
        {

            textBox1.Text = " ";
        }



        private void Equal_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "0"){
                textBox1.Text = "";
            }
            Button button = (Button)sender;

            String DisplayResult = textBox1.Text;

            
        }

        private void Comma_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

           String OperatorPerformed = button.Text;
           double ResulVal = double.Parse(textBox1.Text);

               bool KungPerformed = true;

           switch (OperatorPerformed)
           {
               case "+":{

               }
               case "-":
                   {

                   }
               case "*":
                   {

                   }
               case "%":
                   {

                   }
            }
        }

        private void Numbers_clicked(object sender, EventArgs e)
        {

        }

       

        
    }
}
