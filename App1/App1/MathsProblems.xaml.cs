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

        Random random = new Random();
        int answer;

        public MathsProblems()
		{
            InitializeComponent();

            Quiz();
        }

        void Quiz()
        {
            int num1 = random.Next(25);
            int num2 = random.Next(25);

            firstNum.Text = num1.ToString();
            secondNum.Text = num2.ToString();

            answer = num1 + num2;
        }
        
        void CheckTheAnswer()
        {
            int sum;

            if (int.TryParse(entryAnswer.Text, out sum))
            {
                if (sum == answer)
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

        void BtnCheckAnswer_Click(object sender, EventArgs e)
        {
            CheckTheAnswer();
        }
    }
}