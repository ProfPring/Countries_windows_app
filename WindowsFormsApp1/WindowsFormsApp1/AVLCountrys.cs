using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    //AVL country class for all methods pertaining to the Country Object. 
    class AVLCountrys : AVLTree<Country>, IComparable
    {
        //======================================================================================

        public void InOrder(ref ListBox list)
        {
            list.BeginUpdate();
            inOrder(node, ref list);
            list.EndUpdate();
        }
        public void inOrder(Node<Country> tree, ref ListBox list)
        {
            if (tree != null)
            {
                inOrder(tree.Left, ref list); 
                list.Items.Add(tree.Data); //add the country object to the list of items in alphabetic order
                inOrder(tree.Right, ref list);
            }

        }



        public void CountNodes(ref int count) 
        {
          countNodes(node, ref count);
           
        }
        private void countNodes(Node<Country> tree, ref int count)
        {
            if (tree != null)
            {
                //go through the tree and count each item in the tree by going all the way left and all the way right. 
                countNodes(tree.Left, ref count); 
                countNodes(tree.Right, ref count);
                count++; 
            }

        }
        

        //======================================================================================

        public String countryName = "";
        public double totalGDP = -10;

        public void InOrderTrade(ref TextBox textbox)
        {
            textbox.Update();
            inOrdertrade(node, ref textbox);
        }
        private void inOrdertrade(Node<Country> tree, ref TextBox textbox) 
        {
            if (tree == null)
            {
                return;
            }
            if (tree != null)
            {
                inOrdertrade(tree.Left, ref textbox);
               
                foreach (String i in tree.Data.MainTradePartners) //for each String tradepartner in all of the tradepartners
                { 
                    Country temp = ConvertCountry(i); //make a new country object and pass the String in from the main trade partners from the serach to find the country needed

                    double newtotalGDP = -10; 
                    String newCountryname = i;
                    if (temp != null) 
                    {
                        if (totalGDP > newtotalGDP )
                        {
                            totalGDP = newtotalGDP;
                            countryName = newCountryname;
                        }
                        textbox.Text = newCountryname; 
                    }   
                }
                inOrdertrade(tree.Right, ref textbox);

            }
        }

        private Country ConvertCountry(String name)
        { 
            return convertcountry(name, ref node);
        }

        private Country convertcountry (String temp, ref Node<Country> tree)
        {
            if (tree == null)
            {
                return null;
            }
           
            else if (temp.CompareTo(tree.Data.Name) == 0) //if the Stirng temp is the same as the name of the country you are trying to find
            {
                Country tempCountry = tree.Data; 
                return tempCountry; //return the country
            }
            else if (temp.CompareTo(tree.Data.Name) < 0) //keep looking through the tree
            {
                return convertcountry(temp, ref tree.Left); //go left
                
            }
            else if (temp.CompareTo(tree.Data.Name) > 0)
            { 
                return convertcountry(temp, ref tree.Right); //left
            }

            return null;
        }
        //======================================================================================

        public void ContainsCountry(String country, ref ListBox list)
        { 
          Containscountry(country, ref node, ref list); 
        }

        private void Containscountry(String country, ref Node<Country> tree, ref ListBox list)
        {
            if (tree != null )
            {
                Console.WriteLine(country + " compare" + tree.Data.Name);
                Console.WriteLine(country.StartsWith(tree.Data.Name));
            }
            if (tree == null)
            {
                return;
            }
            else if (tree.Data.Name.StartsWith(country)) //if the name you are looking for starts with the country name
            {
                Containscountry(country, ref tree.Left, ref list);
                list.Items.Add(tree.Data); //add all the names to the country name
                Containscountry(country, ref tree.Right, ref list);
            }
            else
            {
                if (country.CompareTo(tree.Data.Name) < 0)
                {
                    Containscountry(country, ref tree.Left, ref list);
                }
                else if (country.CompareTo(tree.Data.Name) > 0)
                {
                    Containscountry(country, ref tree.Right, ref list);
                }

            }
//gggg
        }



        public void searchTradePartners(String country, ref ListBox list)
        {
            SearchTradePartners(country, ref node, ref list);
        }

        private void SearchTradePartners (String country, ref Node<Country> tree, ref ListBox list)
        {
            if (tree != null)
            {
                Console.WriteLine(country + " compare" + tree.Data.Name);
                Console.WriteLine(country.StartsWith(tree.Data.Name));
            }
            if (tree != null)
            {
                SearchTradePartners(country, ref tree.Left, ref list);

                foreach (String tradepartners in tree.Data.MainTradePartners) //foreach trade partner in the main tradepartners 
                {
                    if(tradepartners.StartsWith(country)) 
                    {
                        list.Items.Add(tree.Data.Name); //add the name of the countrys main trade partners to the list
                        break; //break out of the foreach loop so the countrys do not repeat.
                        
                    }
                }

                SearchTradePartners(country, ref tree.Right, ref list);

            }

            //===========================================================================

        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}

/*

tempCountry = tree.Data;

convertcountry(temp, ref tree.Left, ref textbox);
convertcountry(temp, ref tree.Right, ref textbox);
 
*/