using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Country : IComparable
    {
        String name;
        double gdpInflation;
        double inflation;
        double tradeBal;
        double hdiRanking;


        LinkedList<String> mainTradePartners = new LinkedList<String>();
        public int CompareTo(object other)
        {
            Country temp = (Country)other;
            return name.CompareTo(temp.name);
        }
         

        public Country(String name, double gdpinflation, double inflation, double tradebal, double hdiranking, String[] Maintradepartenrs)
        {

            this.name = name;
            this.gdpInflation = gdpinflation;
            this.inflation = inflation;
            this.tradeBal = tradebal;
            this.hdiRanking = hdiranking;

            for (int i = 0; i < Maintradepartenrs.Length; i++  )
            {
                mainTradePartners.AddLast(Maintradepartenrs[i]);
            }



        }
        public String Name
        {
            set { this.name = value; }
            get { return name; }
        }

        public override string ToString()
        {
           return name.ToString();
        }


        public double GDPiflation
        {
            set { gdpInflation = value; }
            get { return gdpInflation; }

        }

        public double Inflation
        {
            set { inflation = value; }
            get { return inflation; }
        }

        public double TradeBal
        {
            set { tradeBal = value; }
            get { return tradeBal; }
        }

        public double HDIRanking
        {
            set { hdiRanking = value; }
            get { return hdiRanking; }
        }

        public LinkedList<String> MainTradePartners
        {
            set { mainTradePartners = value; }
            get { return mainTradePartners; }
        }

    }
}
