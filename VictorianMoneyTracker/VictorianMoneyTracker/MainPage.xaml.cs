using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VictorianMoneyTracker
{
    [XamlCompilation(XamlCompilationOptions.Compile)] 
    public partial class MainPage : ContentPage
    {
        DataModel model = new DataModel();

        public MainPage()
        {
            InitializeComponent();
        }
        

        //---------- Increase Count on Text---------
        private void AddCrownsClicked(object sender, EventArgs e)
        {
            model.AddCrown();
            UpdateUI();
        }


        private void UpdateUI()
        {
            PoundLabel.Text = model.Pound.ToString();
            totalPound.Text = model.Pound.ToString();
            
            crownLabel.Text = model.Crown.ToString();
            totalCrown.Text = model.Crown.ToString();
            
            shillingLabel.Text = model.Shillings.ToString();
            totalShillings.Text = string.Format(model.Shillings.ToString(), "S");
            
            penceLabel.Text = model.Pence.ToString();
            totalPence.Text = string.Format(model.Pence.ToString(), "d");

        }

        private void AddPoundClicked(object sender, EventArgs e)
        {
            model.AddPound();
            UpdateUI();
        }


        private void AddshillingsClicked(object sender, EventArgs e)
        {
            model.AddShillings();
            UpdateUI();
        }


        private void AddpenceClicked(object sender, EventArgs e)
        {
            
        }



        private void AddfarthingsClicked(object sender, EventArgs e)
        {
            

        }


        // ----------Decrease Count For Text-----------
        private void minusPound(object sender, EventArgs e)
        {
            model.MinusPound();
            UpdateUI();
        }

        private void minusCrowns(object sender, EventArgs e)
        {
            model.MinusCrown();
            UpdateUI();
        }

        private void minusShillings(object sender, EventArgs e)
        {
            model.MinusShillings();
            UpdateUI();
        }

        private void minusPence(object sender, EventArgs e)
        {
            
        }

        private void minusFarthing(object sender, EventArgs e)
        {
            
        }



        // -----------Conversions Buttons----------
        private void crownExchanged(object sender, EventArgs e)
        {
            model.ConvertCrownIncrease();
            UpdateUI();
        }

        
        
        private void poundExchanged(object sender, EventArgs e)
        {
            model.ConvertPoundIncrease();
            UpdateUI();
        }

        
        
        private void shillingsExchanged(object sender, EventArgs e)
        {
            model.ConvertShillingsIncrease();
            UpdateUI();
        }

        
        
        private void poundExchangedDec(object sender, EventArgs e)
        {

            model.ConvertPoundDecrease();
            UpdateUI();
        }

        
        
        private void crownExchangedDec(object sender, EventArgs e)
        {
            model.ConvertCrownDecrease();
            UpdateUI();
        }

        
        
        private void shillingsExchangedDec(object sender, EventArgs e)
        {
            model.ConvertShllingsDecrease();
            UpdateUI();
        }
    }
}
