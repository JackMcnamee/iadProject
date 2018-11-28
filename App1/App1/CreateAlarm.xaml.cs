using Android.App;
using Android.OS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;

namespace App1
{
	public partial class CreateAlarm : ContentPage
	{
        DateTime triggerTime;

        public CreateAlarm()
		{
			InitializeComponent ();

            Device.StartTimer(TimeSpan.FromSeconds(1), OnTimerTick);
        }

        bool OnTimerTick()
        {
            if (@switchSaveAlarm.IsToggled && DateTime.Now >= triggerTime)
            {
                @switchSaveAlarm.IsToggled = false;
                DisplayAlert("Alarm name", nameAlarm.Text, "Ok");
                Navigation.PushModalAsync(new MathsProblems());

                // vibration is turned on
                /*if (@switchVibration.IsToggled)
                {
                    @switchSaveAlarm.IsToggled = false;
                    DisplayAlert("Alarm name", nameAlarm.Text, "Ok");
                    object Vibration = null;
                    try
                    {
                        // Vibration.Vibrate();

                    }
                    catch (Exception)
                    {
                        // other error has occurred
                    }

                }

                // alarm sound turned on
                else if(switchAlarmSound.IsToggled)
                {
                    @switchSaveAlarm.IsToggled = false;
                    DisplayAlert("Alarm name", nameAlarm.Text, "Ok");
                    
                }*/

            }
            return true;
        }

        void OnTimePickerPropertyChanged(object obj, PropertyChangedEventArgs args)
        {
            if (args.PropertyName == "Time")
            {
                SetTriggerTime();
            }
        }

        void OnSwitchToggled(object obj, ToggledEventArgs args)
        {
            SetTriggerTime();
        }

        void SetTriggerTime()
        {
            if (@switchSaveAlarm.IsToggled)
            {
                triggerTime = DateTime.Today + timePicker.Time;
                Navigation.PushModalAsync(new MainPage());

                if (triggerTime < DateTime.Now)
                {
                    triggerTime += TimeSpan.FromDays(1);
                }
            }
        }
    }
}