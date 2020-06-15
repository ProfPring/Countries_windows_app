using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Security.Permissions;
using System.Security;
using System.Collections;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        AVLCountrys AVLtree = new AVLCountrys();


        public Form1()
        {
            //run everything at the start. 
            InitializeComponent();
            this.ListOfAll.SelectionMode = SelectionMode.One;
            ReadingFile();
            AVLtree.InOrder(ref ListOfAll);
            //AVLtree.CountNodes(ref countrysNumber);
            getHiehgt();
            countryNumber();
            heightesttrade();
        }



        private void ReadingFile()
        {
            using (StreamReader sr = new StreamReader("countries.csv")) 
            {
                string[] headers = new string[6];

                const int MAX_LINES_FILE = 50000;

                string[] AllLines = new string[MAX_LINES_FILE];

                AllLines = File.ReadAllLines("countries.csv"); 

                foreach (String line in AllLines)
                {

                    //split data using commas
                    string[] columns = line.Split(',');
                    Console.Write(columns[0] + ","); //first string in line;
                    Console.Write(columns[1] + ","); //2nd string in line;

                    if (!columns[0].Equals("Country")) //if the array of colunms does not start with country 
                    {
                        //ListOfAll.Items.Add(columns[0]);
                        string[] partners = columns[5].Split(';', '[', ']'); //split on both semi colons and square brackets 

                        foreach (string tradePartner in partners)
                        {
                            if (tradePartner != "")
                            {
                                TradePartnerDropDown.Items.Add(tradePartner); //add all trade partners to the tradeapartners drop down list
                            }
                        }
                        AddingCountrys(columns, partners); //pass colunms and partners to adding countrys method to use in the AVL tree.  

                    }
                }
            }
        }



        public void CountryInfo() //methos to add and update country infomatin in all feilds
        {
            DisplayMainTradeP.Items.Clear(); 

            LinkedList<String> mainTradPartners = new LinkedList<String>();

            Country temp = (Country)ListOfAll.SelectedItem; //make a new country. 

            mainTradPartners = temp.MainTradePartners;

            String[] maintradepartners = mainTradPartners.ToArray();


            //foreach main trade partner in the Stirng array of main trade paerners add them to the lost of main trade partners. 
            for (int i = 0; i < maintradepartners.Length; i++) 
            {
                DisplayMainTradeP.Items.Add(maintradepartners[i]);
                Console.WriteLine(temp.MainTradePartners);
            }
            
            //add relavent infomation to the relavent places from the country object that has been created. 
            getHiehgt(); //get the highet
            countryNumber(); //get the number of countrys. 
            heightesttrade(); //get the heightest trade partner 
            NametextBox.Text = temp.Name;
            GDPBoxInput.Text = temp.GDPiflation.ToString();
            InflationTextBox.Text = temp.Inflation.ToString();
            TradeBalInput.Text = temp.TradeBal.ToString();
            HDIInput.Text = temp.HDIRanking.ToString();


            //format Strings for textbox infomation
            String name = "Name:" + " " + temp.Name;
            String GDP = "GDP:" + " " + temp.GDPiflation.ToString();
            String Inflation = "Inflation:" + " " + temp.Inflation.ToString();
            String TradeBal = "Trade Balance:" + " " + temp.TradeBal.ToString();
            String Hdi = "HDI ranking:" + " " + temp.HDIRanking.ToString();

            String[] Countrys = new String[] { name, GDP, Inflation, TradeBal, Hdi };

            for (int i = 0; i < Countrys.Length; i++)
            {
                countryInfoBox.Text += Countrys[i] + "\r\n";
            }
        }

        public void heightesttrade()
        {
            if (ListOfAll.Items != null)
            {
                HeightestPotential.Clear();
                HeightestPotential.Update();
                AVLtree.InOrderTrade(ref HeightestPotential);
            }
        }

        //update the list by clearing the items and re adding them this allows the programe's list to update by reading in from the avl tree again. 
        public void UpdateList()
        {
            ListOfAll.Items.Clear();
            AVLtree.InOrder(ref ListOfAll);
        }

        //gewt the height of the tree and convert it to a stirng. 
        public void getHiehgt()
        {
            treeHeight.Text = AVLtree.Height().ToString();
        }


        public void AddingCountrys(String[] columns, String[] partners)
        {
            //create a new country object from the items in the colunms and partners string array
            Country country = new Country(columns[0], Convert.ToDouble(columns[1]), Convert.ToDouble(columns[2]), Convert.ToDouble(columns[3]), Convert.ToDouble(columns[4]), partners);
            //add the country to the AVL tree 
            AVLtree.InsertItem(country);
        }

        public void AddEditCuntry()
        {
            FileIOPermission f = new FileIOPermission(PermissionState.Unrestricted); //handle permissons 
            f.AllLocalFiles = FileIOPermissionAccess.Read; //set the permissons.

            string filename = "countries.csv";

            string CountryDetails = NametextBox.Text + ", " + GDPBoxInput.Text + ", " +
                   InflationTextBox.Text + ", " + TradeBalInput.Text + ", " + HDIInput.Text + ", " + TradePartnerDropDown.Text; 

            if (!File.Exists(filename)) //if the file does not exist
            {
                String countryHeader = "Country" + "GDP Growth" + "Inflation" + "Trade Balance" + "HDI Ranking" + "Main Trade Partners"; //header of the CSV file

                try
                {
                    f.Demand();//try to force the file to load 
                    File.WriteAllText(filename, countryHeader); //write to the file name with the country header. 
                }
                catch (SecurityException s)
                {
                    Console.WriteLine(s.Message); //catch any secuirty Exceptions

                }
            }
            String[] tradepartner = new String[1];
            tradepartner[0] = TradePartnerDropDown.Text;
            Country country = new Country(NametextBox.Text, Convert.ToDouble(GDPBoxInput.Text), Convert.ToDouble(InflationTextBox.Text),
            Convert.ToDouble(TradeBalInput.Text), Convert.ToDouble(HDIInput.Text), tradepartner);

            AVLtree.InsertItem(country); //put the country item into the avl tree
            File.AppendAllText(filename, CountryDetails); //Append all text into the end of the CSV file
            Console.WriteLine(NametextBox.Text);
            getHiehgt(); //update tree height
            countryNumber(); //update number of countrys

        }





        private void Form1_Load(object sender, EventArgs e)
        {



        }

        public void ListOfAll_SelectedIndexChanged(object sender, EventArgs e)
        {
            countryInfoBox.Clear();
            CountryInfo(); 
        }



        private void InflationTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TradeBalInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void HDIInput_TextChanged(object sender, EventArgs e)
        {

        }




        private void SerchBox_TextChanged(object sender, EventArgs e)
        {
            if (SerchBox.Text != null)
            {
                ListOfAll.Items.Clear();
                AVLtree.ContainsCountry(SerchBox.Text, ref ListOfAll);
            }
            else
            {
                UpdateList();
                getHiehgt();
                countryNumber();
            }
        }



        protected void TradePartnerDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void GDPBoxInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddEditCuntry();
        }

        public void UpdateCSV(string Pstring)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Country temp = (Country)ListOfAll.SelectedItem;

            AVLtree.Removeitem(temp);
            UpdateList();
            getHiehgt();
            countryNumber();

        }

        private void NametextBox_TextChanged(object sender, EventArgs e)
        {

        }



        private void editButton_Click(object sender, EventArgs e)
        {
            if (ListOfAll.SelectedItem != null)
            {
                //remove the selected item in the list. 
                Country temp = (Country)ListOfAll.SelectedItem;
                AVLtree.Removeitem(temp);

                
                AddEditCuntry();
                UpdateList();
            }
            else
            {
                UpdateList();
                getHiehgt();
                countryNumber();
            }
        }



        private void SaveButton_Click(object sender, EventArgs e)
        {

        }

        private void treeHeight_TextChanged(object sender, EventArgs e)
        {

        }

        public void countryNumber()
        {
            int count = 0;
            //countrysNumber.Text = ListOfAll.Items.Count.ToString();
            AVLtree.CountNodes(ref count);
            countrysNumber.Text = count.ToString();
        }
        private void countrysNumber_TextChanged(object sender, EventArgs e)
        {
            countryNumber();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void countryInfoBox_TextChanged(object sender, EventArgs e)
        {
            //add scroll bars to the info box 
            countryInfoBox.Multiline = true;
            countryInfoBox.ScrollBars = ScrollBars.Vertical;
        }

        private void gotoButton_Click(object sender, EventArgs e)
        {
            if (DisplayMainTradeP != null)
            {
                ListOfAll.SetSelected(ListOfAll.FindString(DisplayMainTradeP.SelectedItem.ToString()), true); //find String in list of all from the selected item in the main trade partners
            }
        }

        private void deletetradePartner_Click(object sender, EventArgs e)
        {
            if (ListOfAll != null)
            {
                DisplayMainTradeP.Items.Remove(DisplayMainTradeP.SelectedItem);
                deletetradePartner.Update();

                getHiehgt();
                countryNumber();
            }
        }

        private void DisplayMainTradeP_SelectedIndexChanged(object sender, EventArgs e)
        {
        }


        private void HeightestPotential_TextChanged(object sender, EventArgs e)
        {
        }


        private void LookUpViaTrade_TextChanged(object sender, EventArgs e)
        {

            if (LookUpViaTrade.Text != "")
            {
                ListOfAll.Items.Clear();
                AVLtree.searchTradePartners(LookUpViaTrade.Text, ref ListOfAll);
            }
            else
            {
                UpdateList();
                getHiehgt();
                countryNumber();
            }

        }

    }
}
