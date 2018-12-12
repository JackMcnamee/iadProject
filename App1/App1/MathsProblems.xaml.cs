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
        // random object
        Random random = new Random();

        int answer;

        public MathsProblems()
		{
            InitializeComponent();
            GenerateRandNumber();
        }

        // creates random numbers
        void GenerateRandNumber()
        {
            int num1 = random.Next(25); // random number from 0 - 25
            int num2 = random.Next(25);

            firstNum.Text = num1.ToString();
            secondNum.Text = num2.ToString();

            answer = num1 + num2;
        }
        
        // checks if answer by user is correct
        void CheckTheAnswer()
        { 
            // parses entryAnswer to int
            if (int.TryParse(entryAnswer.Text, out int sum))
            {
                // if answer is correct
                if (sum == answer)
                {
                    DisplayAlert("Correct answer", "Well done", "Ok");
                    // stopAlarm();
                    Navigation.PushModalAsync(new MainPage());
                }
                // if answer is wrong
                else
                {
                    DisplayAlert("Incorrect answer", "Unlucky", "Try again");
                }
            }
        }

        // when button clicked, CheckTheAnswer() is called
        void BtnCheckAnswer_Click(object sender, EventArgs e)
        {
            CheckTheAnswer();
        }
    }
}