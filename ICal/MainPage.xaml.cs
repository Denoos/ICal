using System.Diagnostics.Tracing;

namespace ICal
{
    public partial class MainPage : ContentPage
    {
        int currentNum = 0;
        string result = "0";
        string currentDoing = "";

        public MainPage()
        {
            InitializeComponent();
            Style();
        }

        public void Style()
        {
            Resultat.Text = result;
            SemanticScreenReader.Announce(Resultat.Text);
        }

        private void PercentBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void CeBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void CBtn_Clicked(object sender, EventArgs e)
        {
            result = "0";
            currentDoing = "";
            currentNum = 0;

            Style();
        }

        private void BackBtn_Clicked(object sender, EventArgs e)
        {
            if (result.Length != 1)
                result.Remove(result.Length - 1);
            else result = "0";

            Style();
        }

        private void ReverseBtn_Clicked(object sender, EventArgs e)
        {
            currentNum = currentNum * (-1);
            if (result.StartsWith("-"))
                result.Remove(0, 1);
            else result = "-" + result;

            Style();
        }

        private void PowerBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void AntiPowerBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void DelitBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void SevenBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void EightBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void NineBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void YmnogitBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void FourBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void FiveBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void SixBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void MinusBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void OneBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void TwoBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void ThreeBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void PlusBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void AntiXBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void ZeroBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void DesyatieBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void ResultBtn_Clicked(object sender, EventArgs e)
        {

        }
    }


}
