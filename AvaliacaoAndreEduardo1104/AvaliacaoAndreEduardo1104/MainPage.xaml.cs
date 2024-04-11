using System.Security.Cryptography;

namespace AvaliacaoAndreEduardo1104
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage() => InitializeComponent();

        
        private void RollerButton_Clicked(object sender, EventArgs e)
        {
            Random rnd = new Random();
            double numeroEscolhido = Convert.ToDouble(picker.SelectedItem);
            if (numeroEscolhido == 4)
            {
                int maxValue = 4;
                int RandomNumber = rnd.Next(maxValue);
                NumberResult.Text = RandomNumber.ToString();
            }
            else if (numeroEscolhido == 6)
            {
                int maxValue = 6;
                int RandomNumber = rnd.Next(maxValue);
                NumberResult.Text = RandomNumber.ToString();
            }
            else if (numeroEscolhido == 10)
            {
                int maxValue = 10;
                int RandomNumber = rnd.Next(maxValue);
                NumberResult.Text = RandomNumber.ToString();
            }
            else if (numeroEscolhido == 20)
            {
                int maxValue = 20;
                int RandomNumber = rnd.Next(maxValue);
                NumberResult.Text = RandomNumber.ToString();
            }
            else
            {
                int maxValue = 100;
                int RandomNumber = rnd.Next(maxValue);
                NumberResult.Text = RandomNumber.ToString();
            }
        }
    }

}
