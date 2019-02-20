using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyClasses
{

    public class Rent
    {
        //attributes/ fields
        private string fname;
        private string lname;
        private decimal noofRoom;
        public const decimal roomRent = 500;
        private decimal totalCost;
        private string condimentList;
       

        //properties
        public string Fname
        {
            get
            {
                return fname;
            }
            set
            {
                fname = value;
            }
        }


        public string Lname
        {
            get
            {
                return lname;
            }
            set
            {
                lname = value;
            }
        }


        public decimal NoofRoom
        {
            get
            {
                return noofRoom;
            }
            set
            {
                noofRoom = value;
            }
        }


        //buy method
        public virtual decimal Buy()
        {

            return totalCost = this.noofRoom * roomRent;
        }
       

        //clear button
        public string Clear()
        {
            return null;
        }

        //clear num
        public decimal ClearNum()
        {
            return 0;
        }

        public bool ClearBool()
        {
            return false;
        }


        public string CondimentsList
        {
            get
            {
                condimentList = string.Empty;//refreshes to empty list
                if (Fname != null)
                    condimentList += fname + "  ";
                if (Lname != null)
                    condimentList += lname + " ";

                return condimentList;
            }
            set
            {
                condimentList = value;
            }
        }



        //constructor
        public Rent()
        {
            Fname = Lname = null;
            //NoofRoom = 0;
        }

        //overloaded constructor
        public Rent(string fn, string ln)
        {
            Fname = fn;
            Lname = ln;
            //NoofRoom = nor;

        }

     

        public override string ToString()
        {
            string output = string.Empty;
            output = "Thank You" + "  ";
            if (CondimentsList != string.Empty)
                output += " " + CondimentsList +"\n";

            return output;
        }

    }
}
