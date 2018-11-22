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

        int addend1;
        int addend2;

        public MathsProblems ()
		{
            InitializeComponent();
		}

        public void startQuiz()
        {
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);

            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();
            
            answer.SetValue = 0;

        }

        private void IsAnswerRight()
        {
            if (CheckTheAnswer())
            {
                DisplayAlert("Correct answers", "Well done", "Ok");
                // stopAlarm();
            }
            else
            {
                DisplayAlert("Incorrect answers", "Unlucky", "Try again");
            }

        }

        bool CheckTheAnswer()
        {
            if (addend1 + addend2 == answer.GetValue)
            {
                return true;
            }

            else
            {
                return false;
            }
               
        }
    }
}