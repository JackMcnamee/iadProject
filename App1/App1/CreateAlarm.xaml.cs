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
        // alarm object
        Alarms alarm = new Alarms();

        // sets triggerTime to real time
        DateTime triggerTime;

        public CreateAlarm()
        {
            InitializeComponent();

            Device.StartTimer(TimeSpan.FromSeconds(1), OnTimerTick); // timer runs until time picked by user
        }

        // called when leaving CreateAlarm Page
        /*protected override void OnDisappearing()
        {
            base.OnDisappearing();
            // properties of Alarm
            alarm.Name = nameAlarm.Text;
            alarm.Time = timePicker.Time;

            // get the HomePage that invoked this page 
            NavigationPage navPage = (NavigationPage)Application.Current.MainPage;
            IReadOnlyList<Page> navStack = navPage.Navigation.NavigationStack;
            int lastIndex = navStack.Count - 1;
            MainPage homePage = navStack[lastIndex] as MainPage;
            if (homePage == null)
            {
                homePage = navStack[lastIndex - 1] as MainPage;
            }

            // transfers Alarm object to HomePage 
            homePage.InformationReady(alarm);
        }*/

        // sets up alarm created
        /*public void InitializeAlarm(Alarms alarm)
        { 
            // Replace the instance
            this.alarm = alarm;
            // Initialize the views
            nameAlarm.Text = alarm.Name ?? "";
            timePicker.Time = alarm.Time;
        }*/

        // if timer exceeds set time by user, display alert + sound and/or vibrate
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

        // finds time picked by user
        void OnTimePickerPropertyChanged(object obj, PropertyChangedEventArgs args)
        {
            if (args.PropertyName == "Time")
            {
                SetTriggerTime();
            }
        }
        
        // if save switch is turned on, call SetTriggerTime()
        void OnSwitchToggled(object obj, ToggledEventArgs args)
        {
            SetTriggerTime();
        }

        // starts timer / when timer goes off
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
        } // SetTriggerTime()
    }
}