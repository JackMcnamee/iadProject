using Android.App;
using Android.OS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using System.Data;
using System.Drawing;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;
using Application = Xamarin.Forms.Application;

namespace App1
{
    public partial class CreateAlarm : ContentPage
    {
        Alarms info = new Alarms();

        DateTime triggerTime;

        public CreateAlarm()
        {
            InitializeComponent();

            Device.StartTimer(TimeSpan.FromSeconds(1), OnTimerTick);
        }

        /*protected override void OnDisappearing()
        {
            base.OnDisappearing();
            // Set properties of Information object
            info.Name = nameAlarm.Text;
            info.Time = timePicker.Time;

            // Get the MainPage that invoked this page 
            NavigationPage navPage = (NavigationPage)Application.Current.MainPage;
            IReadOnlyList<Page> navStack = navPage.Navigation.NavigationStack;
            int lastIndex = navStack.Count - 1;
            MainPage homePage = navStack[lastIndex] as MainPage;
            if (homePage == null)
            {
                homePage = navStack[lastIndex - 1] as MainPage;
            }

            // Transfer Information object to MainPage 
            homePage.InformationReady(info);
        }*/

        /*internal void InitializeInfo(Alarms info)
        { 
            // Replace the instance
            this.info = info;
            // Initialize the views
            nameAlarm.Text = info.Name ?? "";
            timePicker.Time = info.Time;
        }*/

        bool OnTimerTick()
        {
            if (@switchSaveAlarm.IsToggled && DateTime.Now >= triggerTime)
            {
                @switchSaveAlarm.IsToggled = false;
                DisplayAlert("Alarm name", nameAlarm.Text, "Ok");
                Navigation.PushModalAsync(new MathsProblems());
                // PlaySound("ringing.wav", (IntPtr)0, 0);
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