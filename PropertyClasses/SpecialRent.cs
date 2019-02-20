using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyClasses
{
    public class SpecialRent :Rent
    {
        //attributes/ fields
        private decimal getbed;
        private double getbath;
        public const decimal bed_price = 300;
        public const decimal bath_price = 75;
        public const decimal town_base_price = 500;
        public const decimal semi_detached_base_price = 700;
        public const decimal detached_base_price = 1000;

        private bool bathRoom1, bathRoom2, bathRoom3, bathRoom4, bedRoom1, bedRoom2, bedRoom3, bedRoom4,detached,semiDetached,town;
        private string checkBed;


      


        //properties
        public bool BathRoom1
        {
            get
            {
                return bathRoom1;
            }
            set
            {
                bathRoom1 = value;
            }
        }

        public bool BathRoom2
        {
            get
            {
                return bathRoom2;
            }
            set
            {
                bathRoom2 = value;
            }
        }

        public bool BathRoom3
        {
            get
            {
                return bathRoom3;
            }
            set
            {
                bathRoom3 = value;
            }
        }

        public bool BathRoom4
        {
            get
            {
                return bathRoom4;
            }
            set
            {
                bathRoom4 = value;
            }
        }

        public bool BedRoom1
        {
            get
            {
                return bedRoom1;
            }
            set
            {
                bedRoom1 = value;
            }
        }

        public bool BedRoom2
        {
            get
            {
                return bedRoom2;
            }
            set
            {
                bedRoom2 = value;
            }
        }
        public bool BedRoom3
        {
            get
            {
                return bedRoom3;
            }
            set
            {
                bedRoom3 = value;
            }
        }
        public bool BedRoom4
        {
            get
            {
                return bedRoom4;
            }
            set
            {
                bedRoom4 = value;
            }
        }


        //property rent


        public bool Detached
        {
            get
            {
                return detached;
            }
            set
            {
                detached = value;
            }
        }


        public bool SemiDetached
        {
            get
            {
                return semiDetached;
            }
            set
            {
                semiDetached = value;
            }
        }


        public bool Town
        {
            get
            {
                return town;
            }
            set
            {
                town = value;
            }
        }

        public override decimal Buy()
        {
            decimal sumbed = bed_price * getbed;
            decimal sumbath = bath_price * Convert.ToDecimal(getbath);

            decimal sumtotal = sumbed + sumbath;

            //check property room
            if (Detached)
            {
                sumtotal = sumtotal + detached_base_price;

            }

            if (SemiDetached)
            {
                sumtotal = sumtotal + semi_detached_base_price;

            }

            if (Town)
            {
                sumtotal = sumtotal + town_base_price;

            }
            return sumtotal;
        }
       

       

        public string CondiCheck
        {
            get
            {
                checkBed = string.Empty;//refreshes to empty list


                //check property room
                if (Detached)
                {
                    checkBed += " Detached house \t";

                }

                if (SemiDetached)
                {
                    checkBed += " Semi Detached house";

                }

                if (Town)
                {
                    checkBed += "Town House";

                }

                // bath room
                if (BathRoom1)
                {
                    checkBed += "with 1 BedRoom \n";
                    getbed = 1;
                }
                if (BathRoom2)
                {
                    checkBed += "with 2 BedRooms \n";
                    getbed = 2;
                }
                if (BathRoom3)
                {
                    checkBed += "with 3 BedRooms \n";
                    getbed = 3;
                }
                if (BathRoom4)
                {
                    checkBed += "with 4 BedRooms \n";
                    getbed = 4;
                }


                //bed room

                if (BedRoom1)
                {
                    checkBed += "and 1 BathRoom \t";
                    getbath = 1;
                }

                if (BedRoom2)
                {
                    checkBed += "and 1.5 BathRooms \t";
                    getbath = 1.5;
                }
                if (BedRoom3)
                {
                    checkBed += "and 2 BathRoom \t";
                    getbath = 2;
                }

                if (BedRoom4)
                {
                    checkBed += "and 2.5 BathRooms \t";
                    getbath = 2.5;
                }


                return checkBed;
            }
            set
            {
                checkBed = value;
            }
        }


        public SpecialRent() : base()
        {
            BathRoom1=BathRoom2=bathRoom3=BathRoom4=BedRoom1=BedRoom2=BedRoom3=BedRoom4= Detached=SemiDetached=Town=false;
        }


        public SpecialRent(string fname, string lname,bool bat1, bool bat2, bool bat3, bool bat4,
            bool bed1,bool bed2, bool bed3, bool bed4,bool detach,bool semiDetach,bool town)
            : base(fname,lname)
        {
            BathRoom1 = bat1;
            BathRoom2 = bat2;
            BathRoom3 = bat3;
            BathRoom4 = bat4;
            BedRoom1 = bed1;
            BedRoom2 = bed2;
            BedRoom3 = bed3;
            BedRoom4 = bed4;

            Detached = detach;
            SemiDetached = semiDetach;
            Town = town;



        }

     


        public override string ToString()
        {
            string output = string.Empty;
          
            if (CondiCheck != string.Empty)
            {
                output = "You have rented ";
                return base.ToString() + output + CondiCheck + " for the monthly rent of " + Buy().ToString("C", CultureInfo.CreateSpecificCulture("en-US")) + " !!";
            }
            else
            {
                return null;
            }
        }

    }

  
}
