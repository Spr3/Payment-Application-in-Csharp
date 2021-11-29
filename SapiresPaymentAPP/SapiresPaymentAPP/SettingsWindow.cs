//Needed: Check character items in setters for card
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SapiresPaymentAPP
{
    public partial class SettingsWindow : Form
    {
        public SettingsWindow()
        {
            InitializeComponent();
        }

        private void SendNotifacationsLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(checkBox2.Checked)
            {
                SettingsLabel.ForeColor = Color.White;
                checkBox1.ForeColor = Color.White;
                label5.ForeColor = Color.White;
                label4.ForeColor = Color.White;
                label3.ForeColor = Color.White;
                checkBox2.ForeColor = Color.White;
                label1.ForeColor = Color.White;
                label7.ForeColor = Color.White;
                label6.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                this.BackColor = Color.Black;
            }
            else
            {
                SettingsLabel.ForeColor = Color.Black;
                checkBox1.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                checkBox2.ForeColor = Color.Black;
                label1.ForeColor = Color.Black;
                label7.ForeColor = Color.Black;
                label6.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                this.BackColor = Color.White;
            }
            if (string.IsNullOrWhiteSpace(CVV.Text) || string.IsNullOrWhiteSpace(NameTextBox.Text) || string.IsNullOrWhiteSpace(Experationdate.Text) || string.IsNullOrWhiteSpace(CardNumberTextBox.Text))
            {
                bool trueorfalse = false;
                button1.Visible = trueorfalse;
                checkBox1.Visible = trueorfalse;
                checkBox2.Visible = trueorfalse;
                NameTextBox.Visible = trueorfalse;
                CardNumberTextBox.Visible = trueorfalse;
                Experationdate.Visible = trueorfalse;
                CVV.Visible = trueorfalse;
                SettingsLabel.Visible = trueorfalse;
                label1.Visible = trueorfalse;
                label2.Visible = trueorfalse;
                label3.Visible = trueorfalse;
                label4.Visible = trueorfalse;
                label5.Visible = trueorfalse;
                label6.Visible = true;
                label6.Text = "Payment Info";
                label7.Text = "Is Incorrect";
                label7.Visible = true;
                Errorbutton.Visible = true;
            }
            if (CVV.Text.Length != 3 || Regex.IsMatch(CVV.Text, @"^\d+$") == false)
            {
                bool trueorfalse = false;
                button1.Visible = trueorfalse;
                checkBox1.Visible = trueorfalse;
                checkBox2.Visible = trueorfalse;
                NameTextBox.Visible = trueorfalse;
                CardNumberTextBox.Visible = trueorfalse;
                Experationdate.Visible = trueorfalse;
                CVV.Visible = trueorfalse;
                SettingsLabel.Visible = trueorfalse;
                label1.Visible = trueorfalse;
                label2.Visible = trueorfalse;
                label3.Visible = trueorfalse;
                label4.Visible = trueorfalse;
                label5.Visible = trueorfalse;
                label6.Visible = true;
                label6.Text = "CVV";
                label7.Text = "is incorrect";
                label7.Visible = true;
                Errorbutton.Visible = true;
            }
            int spaces = 0;
            foreach (char character in NameTextBox.Text)
            {
                if (character.ToString() == " ")
                {   
                    spaces -= -1;
                }
            }
            if (spaces != 2)
            {
                bool trueorfalse = false;
                button1.Visible = trueorfalse;
                checkBox1.Visible = trueorfalse;
                checkBox2.Visible = trueorfalse;
                NameTextBox.Visible = trueorfalse;
                CardNumberTextBox.Visible = trueorfalse;
                Experationdate.Visible = trueorfalse;
                CVV.Visible = trueorfalse;
                SettingsLabel.Visible = trueorfalse;
                label1.Visible = trueorfalse;
                label2.Visible = trueorfalse;
                label3.Visible = trueorfalse;
                label4.Visible = trueorfalse;
                label5.Visible = trueorfalse;
                label6.Visible = true;
                label6.Text = "Name";
                label7.Text = "is incorrect";
                label7.Visible = true;
                Errorbutton.Visible = true;
            }
            int dashes = 0;
            foreach (char character in Experationdate.Text)
            {
                if (character.ToString() == " " || character.ToString() == "/")
                {
                    dashes += 1;
                }
            }
            if (dashes != 1)
            {
                bool trueorfalse = false;
                button1.Visible = trueorfalse;
                checkBox1.Visible = trueorfalse;
                checkBox2.Visible = trueorfalse;
                NameTextBox.Visible = trueorfalse;
                CardNumberTextBox.Visible = trueorfalse;
                Experationdate.Visible = trueorfalse;
                CVV.Visible = trueorfalse;
                SettingsLabel.Visible = trueorfalse;
                label1.Visible = trueorfalse;
                label2.Visible = trueorfalse;
                label3.Visible = trueorfalse;
                label4.Visible = trueorfalse;
                label5.Visible = trueorfalse;
                label6.Visible = true;
                label6.Text = "Experation Date";
                label7.Text = "is incorrect";
                label7.Visible = true;
                Errorbutton.Visible = true;
            }
            int Cardnumber = 0;
            foreach (char character in CardNumberTextBox.Text)
            {
                if (character.ToString() == " " || character.ToString() == "/")
                {
                    Cardnumber += 1;
                }
            }
            if (Cardnumber != 3)
            {
                bool trueorfalse = false;
                button1.Visible = trueorfalse;
                checkBox1.Visible = trueorfalse;
                checkBox2.Visible = trueorfalse;
                NameTextBox.Visible = trueorfalse;
                CardNumberTextBox.Visible = trueorfalse;
                Experationdate.Visible = trueorfalse;
                CVV.Visible = trueorfalse;
                SettingsLabel.Visible = trueorfalse;
                label1.Visible = trueorfalse;
                label2.Visible = trueorfalse;
                label3.Visible = trueorfalse;
                label4.Visible = trueorfalse;
                label5.Visible = trueorfalse;
                label6.Visible = true;
                label6.Text = "Card Number";
                label7.Text = "is incorrect";
                label7.Visible = true;
                Errorbutton.Visible = true;
            }
        }

        private void Errorbutton_Click(object sender, EventArgs e)
        {
            bool trueorfalse = true;
            button1.Visible = trueorfalse;
            checkBox1.Visible = trueorfalse;
            checkBox2.Visible = trueorfalse;
            NameTextBox.Visible = trueorfalse;
            CardNumberTextBox.Visible = trueorfalse;
            Experationdate.Visible = trueorfalse;
            CVV.Visible = trueorfalse;
            SettingsLabel.Visible = trueorfalse;
            label1.Visible = false;
            label2.Visible = trueorfalse;
            label3.Visible = trueorfalse;
            label4.Visible = trueorfalse;
            label5.Visible = trueorfalse;
            label6.Visible = false;
            label7.Visible = false;
            Errorbutton.Visible = false;
        }
    }
}
