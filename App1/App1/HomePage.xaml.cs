using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Navigation;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        // ObservableCollection<Alarms> list = new ObservableCollection<Alarms>();

        public MainPage()
        {
            InitializeComponent();
            // listView.ItemsSource = list;
        }

        void btnCreateAlarm_Clicked(object sender, EventArgs args)
        {
            // opens CreateAlarm page
            Navigation.PushModalAsync(new CreateAlarm());
        }

        // called from CreateAlarm 
        /*public void InformationReady(Alarms alarm)
        { 
            // If the object has already been added, replace it. 
            int index = list.IndexOf(alarm);
            if (index != -1)
            {
                list[index] = alarm;
            }
            // Otherwise, add it. 
            else
            {
                list.Add(alarm);
            }
        }*/

        // allows user to select created alarm and edit 
        /*async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            if (args.SelectedItem != null)
            { 
                // Deselect the item. 
                listView.SelectedItem = null;
                CreateAlarm createAlarm = new CreateAlarm();
                await Navigation.PushAsync(createAlarm);
                createAlarm.InitializeAlarm((Alarms)args.SelectedItem);
            }
        }*/
    }
}

