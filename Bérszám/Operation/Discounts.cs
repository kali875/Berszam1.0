using Bérszám.Model;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bérszám.Operation
{
    //1. a négy vagy több gyermeket nevelő anyák kedvezménye,
    //2. személyi kedvezmény,
    //3. első házasok kedvezménye,
    //4. családi kedvezmény.
    struct FamilyDiscount_values
    {
        public string name;
        public int Children_Count;
        public int defaultvalue;
        public int allowance;
    }
    abstract class Discounts
    {
        private customers_table customers;
        protected FamilyDiscount_values FamilyDiscount_values;
        public int FirstMarried= 0;
        public bool FourorMoreChidlren = false;
        protected customers_table Customers { get => customers; set => customers = value; }

        public Discounts(customers_table customers) 
        {
            this.Customers = customers;
        }

        public abstract void Contract();
    }
     class FoureorMoreChildren : Discounts
     {
         public FoureorMoreChildren(customers_table customers) : base(customers)
         {
         }
        public override void Contract() 
        {
            //ha 4 v több gyermeke van
            if (FamilyDiscount_values.Children_Count >=  4) 
            {
                this.FourorMoreChidlren = true;
            }
        }
     }
    /*
     class PersonalDiscounts : Discounts
     {
         public PersonalDiscounts(customers_table customers) : base(customers)
         {
         }
     }*/
    class FirstMarried : Discounts
    {
        
        public FirstMarried(customers_table customers) : base(customers)
        {
            Contract();
        }
        public override void Contract() 
        {           
            //volt már házas 2 v több
            if (Customers.Maried_Table.Count() == 1)
            {
                FirstMarried = 5000;
            }
        }
    }
    class FamilyDiscount : Discounts
    {

        //családi pótlék,
        //családi adókedvezmény.
        private int Children_Allowance = 0;
        public FamilyDiscount(customers_table customers) : base(customers)
        {
            
        }
        public override void Contract() 
        {
            if (Family_taxlegal_check()) 
            {
                MessageBox.Show("Jár a kedvezmény");
            }
        }
        private bool Family_taxlegal_check() 
        {
            //van-e gyereke
            if (Customers.Children_Table.Count == 0)
            {
                return false;
            }
            else
            {
                foreach (var item in Customers.Children_Table)
                {
                    var Children_Old = DateTime.Now - item.Date_of_Birth;
                    
                    //ha 6 és 16 év között van vagy ha még tanul akkor 20 éves korig
                    if (Children_Old.Days >= 2190 && 5840 >= Children_Old.Days || item.School == "true" && 7300 >= Children_Old.Days)
                    {
                        Children_Allowance++;
                    }
                }
                //gyerek jogosultság vizsgálata
                if (Children_Allowance > 0) 
                {
                    if (Children_Allowance == 1)
                    {
                        FamilyDiscount_values = new FamilyDiscount_values() { Children_Count = Children_Allowance, defaultvalue = 66670, allowance = 20000 };
                    }
                    else if (Children_Allowance == 2)
                    {
                        FamilyDiscount_values= new FamilyDiscount_values() { Children_Count = Children_Allowance, defaultvalue = 133330, allowance = 20000 };
                    }
                    else if (Children_Allowance >= 3)
                    {
                        FamilyDiscount_values= new FamilyDiscount_values() { Children_Count = Children_Allowance, defaultvalue = 220000, allowance = 33000 };                     
                    }
                    return true;
                }
                return false;
            }           
        }
    }
}
