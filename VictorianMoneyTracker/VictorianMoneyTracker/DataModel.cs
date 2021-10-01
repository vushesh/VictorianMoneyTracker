using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Linq;
using Xamarin.Forms.Xaml;
using VictorianMoneyTracker;
using System.Windows.Input;
using Xamarin.Forms.Internals;

namespace VictorianMoneyTracker
{
    public partial class DataModel
    {

        //--------Conversions Rate ---------
        int PoundToCrown = 4;
        int CrownToShillings = 5;
        int ShillingsToPence = 12;

        //--------------------------------


        public int Pound { get; set; }
        public int Crown { get; set; }
        public int Shillings { get; set; }
        public int Pence { get; set; }
        public int Farthings { get; set; }
        
        //-----------Pound Conversions------------

        public void AddPound()
        {
            Pound++;
        }
        public void MinusPound()
        {
            Pound--;
        }
        public void ConvertPoundIncrease()
        {
            //doesnt exist
        }
        public void ConvertPoundDecrease()
        {
            if(Pound >= 1)
            {
                Pound--;
                Crown += PoundToCrown;
            }
            
        }


        //-----------Crowns Conversions------------

        public void AddCrown()
        {
            Crown++;
        }
        public void MinusCrown()
        {
            Crown--;
        }
        public void ConvertCrownIncrease()
        {
            if (Crown >= PoundToCrown)
            {
                Crown -= PoundToCrown;
                Pound++;
            }
        }
        public void ConvertCrownDecrease()
        {
            if (Crown >= 1)
            {
                Crown--;
                Shillings += CrownToShillings;
            }
        }

        //--------Shillings Conversions---------
        
        public void AddShillings()
        {
            Shillings++;
        }
        public void MinusShillings()
        {
            Shillings--;
        }
        public void ConvertShillingsIncrease()
        {
            if (Shillings >= CrownToShillings)
            {
                Shillings -= CrownToShillings;
                Crown++;
            }
        }
        public void ConvertShllingsDecrease()
        {
            if (Shillings >= 1)
            {
                Shillings--;
                Pence += ShillingsToPence;
            }
        }


        //---------------------------




        public void AddPence()
        {
            Pence++;
        }
        public void MinusPence()
        {
            Pence--;
        }



        public void AddFarthings()
        {
            Farthings++;
        }
        public void MinusFarthings()
        {
            Farthings--;
        }
    }
}
