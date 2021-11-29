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
    public partial class Form1 : Form
    {
        //This is part of the database
        List<PayCompanys> companypaying = new List<PayCompanys>();

        Dictionary<int, Employee> dictionaryCompanys = new Dictionary<int, Employee>()
        {
            { 1, new Employee {Name="BestBuy", Price=342.00, Date = "03/21/32"}},
            { 2, new Employee {Name="Walmart", Price=4333.00, Date = "03/22/32"}},
            { 3, new Employee {Name="College", Price=1.80, Date = "03/25/32"}},
            { 4, new Employee {Name="Car", Price=2432.00, Date = "03/25/32"}},
            { 5, new Employee {Name="Kids", Price=20.00, Date = "03/31/32"}},
            { 6, new Employee {Name="Garbage", Price=15.00, Date = "04/02/32"}},
            { 7, new Employee {Name="Water", Price=105.00, Date = "04/06/32"}},
            { 8, new Employee {Name=" ", Price=0.00, Date = " "}},
        };
        Dictionary<int, Employee> lastFew = new Dictionary<int, Employee>()
        {
            { 1, new Employee {Name=" ", Price=0.0, Date = " "}},
            { 2, new Employee {Name=" ", Price=0.0, Date = " "}},
            { 3, new Employee {Name=" ", Price=0.0, Date = " "}},
            { 4, new Employee {Name=" ", Price=0.0, Date = " "}},
            { 5, new Employee {Name=" ", Price=0.0, Date = " "}},
            { 6, new Employee {Name=" ", Price=0.0, Date = " "}},
            { 7, new Employee {Name=" ", Price=0.0, Date = " "}},
            { 8, new Employee {Name=" ", Price=0.00, Date = " "}},
        };
        public Form1()
        {
            InitializeComponent();
            CompanyName1.Text = dictionaryCompanys[1].Name;
            CompanyName2.Text = dictionaryCompanys[2].Name;
            CompanyName3.Text = dictionaryCompanys[3].Name;
            Company4.Text = dictionaryCompanys[4].Name;
            Company5.Text = dictionaryCompanys[5].Name;
            PaymentCompany1.Text = "Price:" + dictionaryCompanys[1].Price + "$ Due: " + dictionaryCompanys[1].Date;
            PaymentCompany2.Text = "Price:" + dictionaryCompanys[2].Price + "$ Due: " + dictionaryCompanys[2].Date;
            PaymentDue3.Text = "Price:" + dictionaryCompanys[3].Price + "$ Due: " + dictionaryCompanys[3].Date;
            PaymentCompany4.Text = "Price:" + dictionaryCompanys[4].Price + "$ Due: " + dictionaryCompanys[4].Date;
            PaymentCompany5.Text = "Price:" + dictionaryCompanys[5].Price + "$ Due: " + dictionaryCompanys[5].Date;
            LoadPeopleList();
        }

        private void LoadPeopleList()
        {
            companypaying.Add(new PayCompanys { company = "Best Buy",amountpay=3, StartingDate="01/23/2021", howoftenneddedpayed = 2});
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            HelloLabel.Visible = false;
            SettingsLabel.Visible = true;
            NotifacationsBox.Visible = true;
            DarkMode.Visible = true;
            button2.Visible = false;
            button1.Visible = false;
            AddButton.Visible = false;
            PayCompany1.Visible = false;
            PayingButton2.Visible = false;
            PayCompany3.Visible = false;
            PaymentButton4.Visible = false;
            PayCompany5.Visible = false;
            CompanyName3.Visible = false;
            PaymentDue3.Visible = false;
            PaymentCompany1.Visible = false;
            CompanyName1.Visible = false;
            CompanyName2.Visible = false;
            PaymentCompany2.Visible = false;
            Company4.Visible = false;
            PaymentCompany4.Visible = false;
            Company5.Visible = false;
            PaymentCompany5.Visible = false;
            SaveButton.Visible = true;
            CVVlabel.Visible = true;
            CVV.Visible = true;
            Experationdate.Visible = true;
            label4.Visible = true;
            label3.Visible = true;
            label2.Visible = true;
            NameTextBox.Visible = true;
            CardNumberTextBox.Visible = true;
            label5.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public class Employee
        {
            public string Name { get; set; }
            public double Price { get; set; }
            public string Date { get; set; }
        }

        private void Errorbutton_Click(object sender, EventArgs e)
        {
            bool trueorfalse = true;
            button1.Visible = trueorfalse;
            NotifacationsBox.Visible = trueorfalse;
            DarkMode.Visible = trueorfalse;
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
            SaveButton.Visible = true;
            button1.Visible = false;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            bool notdone = false;
            if (DarkMode.Checked)
            {
                AddCompanysLabel.ForeColor = Color.White;
                AddCompanyLabel.ForeColor = Color.White;
                PaymentLabelAdd.ForeColor = Color.White;
                AddStartingDate.ForeColor = Color.White;
                HowOftenNeededPayedLabel.ForeColor = Color.White;
                CompanyName.ForeColor = Color.White;
                PriceLabel.ForeColor = Color.White;
                DueDate.ForeColor = Color.White;
                SettingsLabel.ForeColor = Color.White;
                DarkMode.ForeColor = Color.White;
                label5.ForeColor = Color.White;
                label4.ForeColor = Color.White;
                label3.ForeColor = Color.White;
                NotifacationsBox.ForeColor = Color.White;
                label1.ForeColor = Color.White;
                label7.ForeColor = Color.White;
                label6.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                CVVlabel.ForeColor = Color.White;
                HelloLabel.ForeColor = Color.White;
                CompanyName1.ForeColor = Color.White;
                PaymentCompany1.ForeColor = Color.White;
                CompanyName2.ForeColor = Color.White;
                PaymentCompany2.ForeColor = Color.White;
                CompanyName3.ForeColor = Color.White;
                PaymentDue3.ForeColor = Color.White;
                Company4.ForeColor = Color.White;
                PaymentCompany4.ForeColor = Color.White;
                Company5.ForeColor = Color.White;
                PaymentCompany5.ForeColor = Color.White;
                this.BackColor = Color.Black;
            }
            else
            {
                AddCompanysLabel.ForeColor = Color.Black;
                AddCompanyLabel.ForeColor = Color.Black;
                PaymentLabelAdd.ForeColor = Color.Black;
                AddStartingDate.ForeColor = Color.Black;
                HowOftenNeededPayedLabel.ForeColor = Color.Black;
                CompanyName.ForeColor = Color.Black;
                PriceLabel.ForeColor = Color.Black;
                DueDate.ForeColor = Color.Black;
                SettingsLabel.ForeColor = Color.Black;
                DarkMode.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                NotifacationsBox.ForeColor = Color.Black;
                label1.ForeColor = Color.Black;
                label7.ForeColor = Color.Black;
                label6.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                CVVlabel.ForeColor = Color.Black;
                HelloLabel.ForeColor = Color.Black;
                CompanyName1.ForeColor = Color.Black;
                PaymentCompany1.ForeColor = Color.Black;
                CompanyName2.ForeColor = Color.Black;
                PaymentCompany2.ForeColor = Color.Black;
                CompanyName3.ForeColor = Color.Black;
                PaymentDue3.ForeColor = Color.Black;
                Company4.ForeColor = Color.Black;
                PaymentCompany4.ForeColor = Color.Black;
                Company5.ForeColor = Color.Black;
                PaymentCompany5.ForeColor = Color.Black;
                this.BackColor = Color.White;
            }
            if (string.IsNullOrWhiteSpace(CVV.Text) || string.IsNullOrWhiteSpace(NameTextBox.Text) || string.IsNullOrWhiteSpace(Experationdate.Text) || string.IsNullOrWhiteSpace(CardNumberTextBox.Text))
            {
                notdone = true;
                bool trueorfalse = false;
                button1.Visible = trueorfalse;
                NotifacationsBox.Visible = trueorfalse;
                DarkMode.Visible = trueorfalse;
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
                CVVlabel.Visible = false;
                SaveButton.Visible = false;
            }
            if (CVV.Text.Length != 3 || Regex.IsMatch(CVV.Text, @"^\d+$") == false)
            {
                notdone = true;
                bool trueorfalse = false;
                button1.Visible = trueorfalse;
                NotifacationsBox.Visible = trueorfalse;
                DarkMode.Visible = trueorfalse;
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
                label7.Text = "Is Incorrect";
                label7.Visible = true;
                Errorbutton.Visible = true;
                CVVlabel.Visible = false;
                SaveButton.Visible = false;
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
                notdone = true;
                bool trueorfalse = false;
                button1.Visible = trueorfalse;
                NotifacationsBox.Visible = trueorfalse;
                DarkMode.Visible = trueorfalse;
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
                label7.Text = "Is Incorrect";
                label7.Visible = true;
                Errorbutton.Visible = true;
                CVVlabel.Visible = false;
                SaveButton.Visible = false;
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
                notdone = true;
                bool trueorfalse = false;
                button1.Visible = trueorfalse;
                NotifacationsBox.Visible = trueorfalse;
                DarkMode.Visible = trueorfalse;
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
                label6.Text = "ExperationDate";
                label7.Text = "Is Incorrect";
                label7.Visible = true;
                Errorbutton.Visible = true;
                CVVlabel.Visible = false;
                SaveButton.Visible = false;
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
                notdone = true;
                bool trueorfalse = false;
                button1.Visible = trueorfalse;
                NotifacationsBox.Visible = trueorfalse;
                DarkMode.Visible = trueorfalse;
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
                label7.Text = "Is Incorrect";
                label7.Visible = true;
                Errorbutton.Visible = true;
                CVVlabel.Visible = false;
                SaveButton.Visible = false;
                notdone = true;
            }
            if (notdone == false)
            {
                label1.Visible = true;
                HelloLabel.Visible = true;
                SettingsLabel.Visible = false;
                NotifacationsBox.Visible = false;
                DarkMode.Visible = false;
                button2.Visible = true;
                button1.Visible = true;
                AddButton.Visible = true;
                PayCompany1.Visible = true;
                PayingButton2.Visible = true;
                PayCompany3.Visible = true;
                PaymentButton4.Visible = true;
                PayCompany5.Visible = true;
                CompanyName3.Visible = true;
                PaymentDue3.Visible = true;
                PaymentCompany1.Visible = true;
                CompanyName1.Visible = true;
                CompanyName2.Visible = true;
                PaymentCompany2.Visible = true;
                Company4.Visible = true;
                PaymentCompany4.Visible = true;
                Company5.Visible = true;
                PaymentCompany5.Visible = true;
                SaveButton.Visible = false;
                CVVlabel.Visible = false;
                CVV.Visible = false;
                Experationdate.Visible = false;
                label4.Visible = false;
                label3.Visible = false;
                label2.Visible = false;
                NameTextBox.Visible = false;
                CardNumberTextBox.Visible = false;
                label5.Visible = false;
            }
        }

        private void PayCompany3_Click(object sender, EventArgs e)
        {
            CompanyName.Text = CompanyName3.Text;
            label1.Visible = false;
            HelloLabel.Visible = false;
            button2.Visible = false;
            button1.Visible = false;
            AddButton.Visible = false;
            PayCompany1.Visible = false;
            PayingButton2.Visible = false;
            PayCompany3.Visible = false;
            PaymentButton4.Visible = false;
            PayCompany5.Visible = false;
            CompanyName3.Visible = false;
            PaymentDue3.Visible = false;
            PaymentCompany1.Visible = false;
            CompanyName1.Visible = false;
            CompanyName2.Visible = false;
            PaymentCompany2.Visible = false;
            Company4.Visible = false;
            PaymentCompany4.Visible = false;
            Company5.Visible = false;
            PaymentCompany5.Visible = false;
            CompanyName.Visible = true;
            PriceLabel.Visible = true;
            PriceLabel.Text = "Price:" + dictionaryCompanys[3].Price;
            DueDate.Visible = true;
            DueDate.Text = "Due:" + dictionaryCompanys[3].Date;
            Pay10.Visible = true;
            Pay25.Visible = true;
            Pay50.Visible = true;
            Pay100.Visible = true;
            GoBackButton.Visible = true;
            AmountPay.Visible = true;
            PayTextBox.Visible = true;
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            HelloLabel.Visible = true;
            button2.Visible = true;
            button1.Visible = true;
            AddButton.Visible = true;
            PayCompany1.Visible = true;
            PayingButton2.Visible = true;
            PayCompany3.Visible = true;
            PaymentButton4.Visible = true;
            PayCompany5.Visible = true;
            CompanyName3.Visible = true;
            PaymentDue3.Visible = true;
            PaymentCompany1.Visible = true;
            CompanyName1.Visible = true;
            CompanyName2.Visible = true;
            PaymentCompany2.Visible = true;
            Company4.Visible = true;
            PaymentCompany4.Visible = true;
            Company5.Visible = true;
            PaymentCompany5.Visible = true;
            CompanyName.Visible = true;
            PriceLabel.Visible = false;
            PriceLabel.Text = "Price:" + dictionaryCompanys[3].Price;
            DueDate.Visible = false;
            DueDate.Text = "Due:" + dictionaryCompanys[3].Date;
            Pay10.Visible = false;
            Pay25.Visible = false;
            Pay50.Visible = false;
            Pay100.Visible = false;
            GoBackButton.Visible = false;
            AmountPay.Visible = false;
            PayTextBox.Visible = false;
            CompanyName.Visible = false;
        }
        private void Pay10_Click(object sender, EventArgs e)
        {
            string Payment = "";
            bool FoundNumber = false;
            foreach (char letter in PriceLabel.Text)
            {
                if (letter.ToString() == ":")
                {
                    FoundNumber = true;
                }
                else if (FoundNumber == true)
                {
                    Payment = Payment + letter;
                }
            }
            for (int count = 1; count < dictionaryCompanys.Count; count++)
            {
                if (dictionaryCompanys[count].Name == CompanyName.Text)
                {
                    dictionaryCompanys[count].Price = Math.Round(dictionaryCompanys[count].Price - (.1 * Convert.ToDouble(Payment)), 2);
                }
            }
            label1.Visible = true;
            HelloLabel.Visible = true;
            button2.Visible = true;
            button1.Visible = true;
            AddButton.Visible = true;
            PayCompany1.Visible = true;
            PayingButton2.Visible = true;
            PayCompany3.Visible = true;
            PaymentButton4.Visible = true;
            PayCompany5.Visible = true;
            CompanyName3.Visible = true;
            PaymentDue3.Visible = true;
            PaymentCompany1.Visible = true;
            CompanyName1.Visible = true;
            CompanyName2.Visible = true;
            PaymentCompany2.Visible = true;
            Company4.Visible = true;
            PaymentCompany4.Visible = true;
            Company5.Visible = true;
            PaymentCompany5.Visible = true;
            CompanyName.Visible = true;
            PriceLabel.Visible = false;
            PriceLabel.Text = "Price:" + dictionaryCompanys[3].Price;
            DueDate.Visible = false;
            DueDate.Text = "Due:" + dictionaryCompanys[3].Date;
            Pay10.Visible = false;
            Pay25.Visible = false;
            Pay50.Visible = false;
            Pay100.Visible = false;
            GoBackButton.Visible = false;
            AmountPay.Visible = false;
            PayTextBox.Visible = false;
            CompanyName.Visible = false;
            PaymentCompany1.Text = "Price:" + dictionaryCompanys[1].Price + "$ Due: " + dictionaryCompanys[1].Date;
            PaymentCompany2.Text = "Price:" + dictionaryCompanys[2].Price + "$ Due: " + dictionaryCompanys[2].Date;
            PaymentDue3.Text = "Price:" + dictionaryCompanys[3].Price + "$ Due: " + dictionaryCompanys[3].Date;
            PaymentCompany4.Text = "Price:" + dictionaryCompanys[4].Price + "$ Due: " + dictionaryCompanys[4].Date;
            PaymentCompany5.Text = "Price:" + dictionaryCompanys[5].Price + "$ Due: " + dictionaryCompanys[5].Date;
        }
        private void Pay25_Click(object sender, EventArgs e)
        {
            string Payment = "";
            bool FoundNumber = false;
            foreach (char letter in PriceLabel.Text)
            {
                if (letter.ToString() == ":")
                {
                    FoundNumber = true;
                }
                else if (FoundNumber == true)
                {
                    Payment = Payment + letter;
                }
            }
            for (int count = 1; count < dictionaryCompanys.Count; count++)
            {
                if (dictionaryCompanys[count].Name == CompanyName.Text)
                {
                    dictionaryCompanys[count].Price = Math.Round(dictionaryCompanys[count].Price - (.25 * Convert.ToDouble(Payment)), 2);
                }
            }
            label1.Visible = true;
            HelloLabel.Visible = true;
            button2.Visible = true;
            button1.Visible = true;
            AddButton.Visible = true;
            PayCompany1.Visible = true;
            PayingButton2.Visible = true;
            PayCompany3.Visible = true;
            PaymentButton4.Visible = true;
            PayCompany5.Visible = true;
            CompanyName3.Visible = true;
            PaymentDue3.Visible = true;
            PaymentCompany1.Visible = true;
            CompanyName1.Visible = true;
            CompanyName2.Visible = true;
            PaymentCompany2.Visible = true;
            Company4.Visible = true;
            PaymentCompany4.Visible = true;
            Company5.Visible = true;
            PaymentCompany5.Visible = true;
            CompanyName.Visible = true;
            PriceLabel.Visible = false;
            PriceLabel.Text = "Price:" + dictionaryCompanys[3].Price;
            DueDate.Visible = false;
            DueDate.Text = "Due:" + dictionaryCompanys[3].Date;
            Pay10.Visible = false;
            Pay25.Visible = false;
            Pay50.Visible = false;
            Pay100.Visible = false;
            GoBackButton.Visible = false;
            AmountPay.Visible = false;
            PayTextBox.Visible = false;
            CompanyName.Visible = false;
            PaymentCompany1.Text = "Price:" + dictionaryCompanys[1].Price + "$ Due: " + dictionaryCompanys[1].Date;
            PaymentCompany2.Text = "Price:" + dictionaryCompanys[2].Price + "$ Due: " + dictionaryCompanys[2].Date;
            PaymentDue3.Text = "Price:" + dictionaryCompanys[3].Price + "$ Due: " + dictionaryCompanys[3].Date;
            PaymentCompany4.Text = "Price:" + dictionaryCompanys[4].Price + "$ Due: " + dictionaryCompanys[4].Date;
            PaymentCompany5.Text = "Price:" + dictionaryCompanys[5].Price + "$ Due: " + dictionaryCompanys[5].Date;
        }
        private void Pay50_Click(object sender, EventArgs e)
        {
            string Payment = "";
            bool FoundNumber = false;
            foreach (char letter in PriceLabel.Text)
            {
                if (letter.ToString() == ":")
                {
                    FoundNumber = true;
                }
                else if (FoundNumber == true)
                {
                    Payment = Payment + letter;
                }
            }
            for (int count = 1; count < dictionaryCompanys.Count; count++)
            {
                if (dictionaryCompanys[count].Name == CompanyName.Text)
                {
                    dictionaryCompanys[count].Price = Math.Round(dictionaryCompanys[count].Price - (.5 * Convert.ToDouble(Payment)), 2);
                }
            }
            label1.Visible = true;
            HelloLabel.Visible = true;
            button2.Visible = true;
            button1.Visible = true;
            AddButton.Visible = true;
            PayCompany1.Visible = true;
            PayingButton2.Visible = true;
            PayCompany3.Visible = true;
            PaymentButton4.Visible = true;
            PayCompany5.Visible = true;
            CompanyName3.Visible = true;
            PaymentDue3.Visible = true;
            PaymentCompany1.Visible = true;
            CompanyName1.Visible = true;
            CompanyName2.Visible = true;
            PaymentCompany2.Visible = true;
            Company4.Visible = true;
            PaymentCompany4.Visible = true;
            Company5.Visible = true;
            PaymentCompany5.Visible = true;
            CompanyName.Visible = true;
            PriceLabel.Visible = false;
            PriceLabel.Text = "Price:" + dictionaryCompanys[3].Price;
            DueDate.Visible = false;
            DueDate.Text = "Due:" + dictionaryCompanys[3].Date;
            Pay10.Visible = false;
            Pay25.Visible = false;
            Pay50.Visible = false;
            Pay100.Visible = false;
            GoBackButton.Visible = false;
            AmountPay.Visible = false;
            PayTextBox.Visible = false;
            CompanyName.Visible = false;
            PaymentCompany1.Text = "Price:" + dictionaryCompanys[1].Price + "$ Due: " + dictionaryCompanys[1].Date;
            PaymentCompany2.Text = "Price:" + dictionaryCompanys[2].Price + "$ Due: " + dictionaryCompanys[2].Date;
            PaymentDue3.Text = "Price:" + dictionaryCompanys[3].Price + "$ Due: " + dictionaryCompanys[3].Date;
            PaymentCompany4.Text = "Price:" + dictionaryCompanys[4].Price + "$ Due: " + dictionaryCompanys[4].Date;
            PaymentCompany5.Text = "Price:" + dictionaryCompanys[5].Price + "$ Due: " + dictionaryCompanys[5].Date;
        }
        private void Pay100_Click(object sender, EventArgs e)
        {
            string Payment = "";
            bool FoundNumber = false;
            foreach (char letter in PriceLabel.Text)
            {
                if (letter.ToString() == ":")
                {
                    FoundNumber = true;
                }
                else if (FoundNumber == true)
                {
                    Payment = Payment + letter;
                }
            }
            //this finds the ID in the disctionary it is in
            for (int count = 1; count < dictionaryCompanys.Count; count++)
            {
                if (dictionaryCompanys[count].Name == CompanyName.Text)
                {
                    //This moves everything forward
                    for (int number = count; number < dictionaryCompanys.Count; number++)
                    {
                        dictionaryCompanys[number].Name = dictionaryCompanys[number + 1].Name;
                        dictionaryCompanys[number].Price = dictionaryCompanys[number + 1].Price;
                        dictionaryCompanys[number].Date = dictionaryCompanys[number + 1].Date;
                        if (number >= 2)
                        {
                            if (dictionaryCompanys[number].Name == dictionaryCompanys[number - 1].Name)
                            {
                                dictionaryCompanys[number].Name = "";
                                dictionaryCompanys[number].Date = "";
                                dictionaryCompanys[number].Price = 0.0;
                            }
                        }
                    }
                }
            }
            CompanyName1.Text = dictionaryCompanys[1].Name;
            CompanyName2.Text = dictionaryCompanys[2].Name;
            CompanyName3.Text = dictionaryCompanys[3].Name;
            Company4.Text = dictionaryCompanys[4].Name;
            Company5.Text = dictionaryCompanys[5].Name;
            PaymentCompany1.Text = "Price:" + dictionaryCompanys[1].Price + "$ Due: " + dictionaryCompanys[1].Date;
            PaymentCompany2.Text = "Price:" + dictionaryCompanys[2].Price + "$ Due: " + dictionaryCompanys[2].Date;
            PaymentDue3.Text = "Price:" + dictionaryCompanys[3].Price + "$ Due: " + dictionaryCompanys[3].Date;
            PaymentCompany4.Text = "Price:" + dictionaryCompanys[4].Price + "$ Due: " + dictionaryCompanys[4].Date;
            PaymentCompany5.Text = "Price:" + dictionaryCompanys[5].Price + "$ Due: " + dictionaryCompanys[5].Date;
            label1.Visible = true;
            HelloLabel.Visible = true;
            button2.Visible = true;
            button1.Visible = true;
            AddButton.Visible = true;
            PayCompany1.Visible = true;
            PayingButton2.Visible = true;
            PayCompany3.Visible = true;
            PaymentButton4.Visible = true;
            PayCompany5.Visible = true;
            CompanyName3.Visible = true;
            PaymentDue3.Visible = true;
            PaymentCompany1.Visible = true;
            CompanyName1.Visible = true;
            CompanyName2.Visible = true;
            PaymentCompany2.Visible = true;
            Company4.Visible = true;
            PaymentCompany4.Visible = true;
            Company5.Visible = true;
            PaymentCompany5.Visible = true;
            CompanyName.Visible = true;
            PriceLabel.Visible = false;
            PriceLabel.Text = "Price:" + dictionaryCompanys[3].Price;
            DueDate.Visible = false;
            DueDate.Text = "Due:" + dictionaryCompanys[3].Date;
            Pay10.Visible = false;
            Pay25.Visible = false;
            Pay50.Visible = false;
            Pay100.Visible = false;
            GoBackButton.Visible = false;
            AmountPay.Visible = false;
            PayTextBox.Visible = false;
            CompanyName.Visible = false;
        }
        private void PayCompany1_Click(object sender, EventArgs e)
        {
            CompanyName.Text = CompanyName1.Text;
            label1.Visible = false;
            HelloLabel.Visible = false;
            button2.Visible = false;
            button1.Visible = false;
            AddButton.Visible = false;
            PayCompany1.Visible = false;
            PayingButton2.Visible = false;
            PayCompany3.Visible = false;
            PaymentButton4.Visible = false;
            PayCompany5.Visible = false;
            CompanyName3.Visible = false;
            PaymentDue3.Visible = false;
            PaymentCompany1.Visible = false;
            CompanyName1.Visible = false;
            CompanyName2.Visible = false;
            PaymentCompany2.Visible = false;
            Company4.Visible = false;
            PaymentCompany4.Visible = false;
            Company5.Visible = false;
            PaymentCompany5.Visible = false;
            CompanyName.Visible = true;
            PriceLabel.Visible = true;
            PriceLabel.Text = "Price:" + dictionaryCompanys[1].Price;
            DueDate.Visible = true;
            DueDate.Text = "Due:" + dictionaryCompanys[1].Date;
            Pay10.Visible = true;
            Pay25.Visible = true;
            Pay50.Visible = true;
            Pay100.Visible = true;
            GoBackButton.Visible = true;
            AmountPay.Visible = true;
            PayTextBox.Visible = true;
        }
        private void PayingButton2_Click(object sender, EventArgs e)
        {
            CompanyName.Text = CompanyName2.Text;
            label1.Visible = false;
            HelloLabel.Visible = false;
            button2.Visible = false;
            button1.Visible = false;
            AddButton.Visible = false;
            PayCompany1.Visible = false;
            PayingButton2.Visible = false;
            PayCompany3.Visible = false;
            PaymentButton4.Visible = false;
            PayCompany5.Visible = false;
            CompanyName3.Visible = false;
            PaymentDue3.Visible = false;
            PaymentCompany1.Visible = false;
            CompanyName1.Visible = false;
            CompanyName2.Visible = false;
            PaymentCompany2.Visible = false;
            Company4.Visible = false;
            PaymentCompany4.Visible = false;
            Company5.Visible = false;
            PaymentCompany5.Visible = false;
            CompanyName.Visible = true;
            PriceLabel.Visible = true;
            PriceLabel.Text = "Price:" + dictionaryCompanys[2].Price;
            DueDate.Visible = true;
            DueDate.Text = "Due:" + dictionaryCompanys[2].Date;
            Pay10.Visible = true;
            Pay25.Visible = true;
            Pay50.Visible = true;
            Pay100.Visible = true;
            GoBackButton.Visible = true;
            AmountPay.Visible = true;
            PayTextBox.Visible = true;
        }
        private void PaymentButton4_Click(object sender, EventArgs e)
        {
            CompanyName.Text = Company4.Text;
            label1.Visible = false;
            HelloLabel.Visible = false;
            button2.Visible = false;
            button1.Visible = false;
            AddButton.Visible = false;
            PayCompany1.Visible = false;
            PayingButton2.Visible = false;
            PayCompany3.Visible = false;
            PaymentButton4.Visible = false;
            PayCompany5.Visible = false;
            CompanyName3.Visible = false;
            PaymentDue3.Visible = false;
            PaymentCompany1.Visible = false;
            CompanyName1.Visible = false;
            CompanyName2.Visible = false;
            PaymentCompany2.Visible = false;
            Company4.Visible = false;
            PaymentCompany4.Visible = false;
            Company5.Visible = false;
            PaymentCompany5.Visible = false;
            CompanyName.Visible = true;
            PriceLabel.Visible = true;
            PriceLabel.Text = "Price:" + dictionaryCompanys[4].Price;
            DueDate.Visible = true;
            DueDate.Text = "Due:" + dictionaryCompanys[4].Date;
            Pay10.Visible = true;
            Pay25.Visible = true;
            Pay50.Visible = true;
            Pay100.Visible = true;
            GoBackButton.Visible = true;
            AmountPay.Visible = true;
            PayTextBox.Visible = true;
        }
        private void PayCompany5_Click(object sender, EventArgs e)
        {
            CompanyName.Text = Company5.Text;
            label1.Visible = false;
            HelloLabel.Visible = false;
            button2.Visible = false;
            button1.Visible = false;
            AddButton.Visible = false;
            PayCompany1.Visible = false;
            PayingButton2.Visible = false;
            PayCompany3.Visible = false;
            PaymentButton4.Visible = false;
            PayCompany5.Visible = false;
            CompanyName3.Visible = false;
            PaymentDue3.Visible = false;
            PaymentCompany1.Visible = false;
            CompanyName1.Visible = false;
            CompanyName2.Visible = false;
            PaymentCompany2.Visible = false;
            Company4.Visible = false;
            PaymentCompany4.Visible = false;
            Company5.Visible = false;
            PaymentCompany5.Visible = false;
            CompanyName.Visible = true;
            PriceLabel.Visible = true;
            PriceLabel.Text = "Price:" + dictionaryCompanys[5].Price;
            DueDate.Visible = true;
            DueDate.Text = "Due:" + dictionaryCompanys[5].Date;
            Pay10.Visible = true;
            Pay25.Visible = true;
            Pay50.Visible = true;
            Pay100.Visible = true;
            GoBackButton.Visible = true;
            AmountPay.Visible = true;
            PayTextBox.Visible = true;
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            HelloLabel.Visible = false;
            button2.Visible = false;
            button1.Visible = false;
            AddButton.Visible = false;
            PayCompany1.Visible = false;
            PayingButton2.Visible = false;
            PayCompany3.Visible = false;
            PaymentButton4.Visible = false;
            PayCompany5.Visible = false;
            CompanyName3.Visible = false;
            PaymentDue3.Visible = false;
            PaymentCompany1.Visible = false;
            CompanyName1.Visible = false;
            CompanyName2.Visible = false;
            PaymentCompany2.Visible = false;
            Company4.Visible = false;
            PaymentCompany4.Visible = false;
            Company5.Visible = false;
            PaymentCompany5.Visible = false;
            AddCompanysLabel.Visible = true;
            AddCompanyLabel.Visible = true;
            PaymentLabelAdd.Visible = true;
            AddStartingDate.Visible = true;
            HowOftenNeededPayedLabel.Visible = true;
            FinishButtonAdd.Visible = true;
            AddPaymentTextBox.Visible = true;
            Date.Visible = true;
            DasPayed.Visible = true;
            AddCompanyName.Visible = true;
        }
        private void FinishButtonAdd_Click(object sender, EventArgs e)
        {
            for (int count = 1; count < dictionaryCompanys.Count; count++)
            {
                if(dictionaryCompanys[count].Name == "")
                {
                    dictionaryCompanys[count].Name = AddCompanyName.Text;
                    dictionaryCompanys[count].Price = Convert.ToDouble(AddPaymentTextBox.Text);
                    dictionaryCompanys[count].Date = Date.Text;
                }
            }
            label1.Visible = true;
            HelloLabel.Visible = true;
            button2.Visible = true;
            button1.Visible = true;
            AddButton.Visible = true;
            PayCompany1.Visible = true;
            PayingButton2.Visible = true;
            PayCompany3.Visible = true;
            PaymentButton4.Visible = true;
            PayCompany5.Visible = true;
            CompanyName3.Visible = true;
            PaymentDue3.Visible = true;
            PaymentCompany1.Visible = true;
            CompanyName1.Visible = true;
            CompanyName2.Visible = true;
            PaymentCompany2.Visible = true;
            Company4.Visible = true;
            PaymentCompany4.Visible = true;
            Company5.Visible = true;
            PaymentCompany5.Visible = true;
            AddCompanysLabel.Visible = false;
            AddCompanyLabel.Visible = false;
            PaymentLabelAdd.Visible = false;
            AddStartingDate.Visible = false;
            HowOftenNeededPayedLabel.Visible = false;
            FinishButtonAdd.Visible = false;
            AddPaymentTextBox.Visible = false;
            Date.Visible = false;
            DasPayed.Visible = false;
            AddCompanyName.Visible = false;
        }

        private void PayTextBox_Click(object sender, EventArgs e)
        {
            string Payment = "";
            bool FoundNumber = false;
            foreach (char letter in PriceLabel.Text)
            {
                if (letter.ToString() == ":")
                {
                    FoundNumber = true;
                }
                else if (FoundNumber == true)
                {
                    Payment = Payment + letter;
                }
            }
            //this finds the ID in the disctionary it is in
            for (int count = 1; count < dictionaryCompanys.Count; count++)
            {
                if (dictionaryCompanys[count].Name == CompanyName.Text)
                {
                    dictionaryCompanys[count].Price = Math.Round(dictionaryCompanys[count].Price - Convert.ToDouble(AmountPay.Text));
                    if (dictionaryCompanys[count].Price <= 0)
                    {
                        //This moves everything forward
                        for (int number = count; number < dictionaryCompanys.Count; number++)
                        {
                            dictionaryCompanys[number].Name = dictionaryCompanys[number + 1].Name;
                            dictionaryCompanys[number].Price = dictionaryCompanys[number + 1].Price;
                            dictionaryCompanys[number].Date = dictionaryCompanys[number + 1].Date;
                            if (number >= 2)
                            {
                                if (dictionaryCompanys[number].Name == dictionaryCompanys[number - 1].Name)
                                {
                                    dictionaryCompanys[number].Name = "";
                                    dictionaryCompanys[number].Date = "";
                                    dictionaryCompanys[number].Price = 0.0;
                                }
                            }
                        }
                    }
                }
            }
            CompanyName1.Text = dictionaryCompanys[1].Name;
            CompanyName2.Text = dictionaryCompanys[2].Name;
            CompanyName3.Text = dictionaryCompanys[3].Name;
            Company4.Text = dictionaryCompanys[4].Name;
            Company5.Text = dictionaryCompanys[5].Name;
            PaymentCompany1.Text = "Price:" + dictionaryCompanys[1].Price + "$ Due: " + dictionaryCompanys[1].Date;
            PaymentCompany2.Text = "Price:" + dictionaryCompanys[2].Price + "$ Due: " + dictionaryCompanys[2].Date;
            PaymentDue3.Text = "Price:" + dictionaryCompanys[3].Price + "$ Due: " + dictionaryCompanys[3].Date;
            PaymentCompany4.Text = "Price:" + dictionaryCompanys[4].Price + "$ Due: " + dictionaryCompanys[4].Date;
            PaymentCompany5.Text = "Price:" + dictionaryCompanys[5].Price + "$ Due: " + dictionaryCompanys[5].Date;
            label1.Visible = true;
            HelloLabel.Visible = true;
            button2.Visible = true;
            button1.Visible = true;
            AddButton.Visible = true;
            PayCompany1.Visible = true;
            PayingButton2.Visible = true;
            PayCompany3.Visible = true;
            PaymentButton4.Visible = true;
            PayCompany5.Visible = true;
            CompanyName3.Visible = true;
            PaymentDue3.Visible = true;
            PaymentCompany1.Visible = true;
            CompanyName1.Visible = true;
            CompanyName2.Visible = true;
            PaymentCompany2.Visible = true;
            Company4.Visible = true;
            PaymentCompany4.Visible = true;
            Company5.Visible = true;
            PaymentCompany5.Visible = true;
            CompanyName.Visible = true;
            PriceLabel.Visible = false;
            PriceLabel.Text = "Price:" + dictionaryCompanys[3].Price;
            DueDate.Visible = false;
            DueDate.Text = "Due:" + dictionaryCompanys[3].Date;
            Pay10.Visible = false;
            Pay25.Visible = false;
            Pay50.Visible = false;
            Pay100.Visible = false;
            GoBackButton.Visible = false;
            AmountPay.Visible = false;
            PayTextBox.Visible = false;
            CompanyName.Visible = false;
        }
    }
}