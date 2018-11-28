using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MathsProblems : ContentPage
	{
        Random randomizer = new Random();

        int num1;
        int num2;
        int sum;

        public MathsProblems ()
		{
            InitializeComponent();
            Quiz();
		}

        public void Quiz()
        {
            num1 = randomizer.Next(25);
            num2 = randomizer.Next(25);

            firstNum.Text = num1.ToString();
            secondNum.Text = num2.ToString();
            sum = Convert.ToInt32(answer.Text);
        }
        
        bool CheckTheAnswer()
        {
            if (num1 + num2 == sum)
                return true;
            else
                return false;
        }

        public void BtnCheckAnswer_Click(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                DisplayAlert("Correct answer", "Well done", "Ok");
                // stopAlarm();
                Navigation.PushModalAsync(new MainPage());
            }
            else
            {
                DisplayAlert("Incorrect answer", "Unlucky", "Try again");
            }
        }
    }
}