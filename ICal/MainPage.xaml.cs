using System.Diagnostics.Tracing;
using System.Runtime.InteropServices;

namespace ICal
{
    public partial class MainPage : ContentPage
    {
        double ResultNumber = 0;
        string num = "0";
        string currentDoing = "";

        public MainPage()
        {
            InitializeComponent();
            Style();
            num = "";
        }

        public void Style()
        {
            Resultat.Text = num;
            SemanticScreenReader.Announce(num);
        }

        private void PercentBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void CeBtn_Clicked(object sender, EventArgs e)
        {
            num = "0";
            Style();
            num = "";
        }

        private void CBtn_Clicked(object sender, EventArgs e)
        {
            num = "0";
            currentDoing = "";
            ResultNumber = 0;
            Style();
            num = "";
        }

        private void BackBtn_Clicked(object sender, EventArgs e)
        {
            num = num.Remove(num.Length - 1);
            Style();
        }

        private void ReverseBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void PowerBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void AntiPowerBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void DelitBtn_Clicked(object sender, EventArgs e)
        {
            currentDoing = "/";
        }

        private void SevenBtn_Clicked(object sender, EventArgs e)
        {
            num += "7";
            Style();
        }

        private void EightBtn_Clicked(object sender, EventArgs e)
        {
            num += "8";
            Style();
        }

        private void NineBtn_Clicked(object sender, EventArgs e)
        {
            num += "9";
            Style();
        }

        private void YmnogitBtn_Clicked(object sender, EventArgs e)
        {
            currentDoing = "*";
        }

        private void FourBtn_Clicked(object sender, EventArgs e)
        {
            num += "4";
            Style();
        }

        private void FiveBtn_Clicked(object sender, EventArgs e)
        {
            num += "5";
            Style();
        }

        private void SixBtn_Clicked(object sender, EventArgs e)
        {
            num += "6";
            Style();
        }

        private void MinusBtn_Clicked(object sender, EventArgs e)
        {
            currentDoing = "*";
        }

        private void OneBtn_Clicked(object sender, EventArgs e)
        {
            num += "1";
            Style();
        }

        private void TwoBtn_Clicked(object sender, EventArgs e)
        {
            num += "2";
            Style();
        }

        private void ThreeBtn_Clicked(object sender, EventArgs e)
        {
            num += "3";
            Style();
        }

        private void PlusBtn_Clicked(object sender, EventArgs e)
        {
            currentDoing = "+";
        }

        private void AntiXBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void ZeroBtn_Clicked(object sender, EventArgs e)
        {
            num += "0";
            Style();
        }

        private void DesyatieBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void ResultBtn_Clicked(object sender, EventArgs e)
        {

        }
    }


}
