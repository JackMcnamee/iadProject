using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        // Called from InfoPage. 
        /*internal void InformationReady(Alarms info)
        { 
            // If the object has already been added, replace it. 
            int index = list.IndexOf(info);
            if (index != -1)
            {
                list[index] = info;
            }
            // Otherwise, add it. 
            else
            { list.Add(info);
            }
        }

        // ListView ItemSelected handler. 
        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            if (args.SelectedItem != null)
            { // Deselect the item. 
                listView.SelectedItem = null;
                CreateAlarm infoPage = new CreateAlarm();
                await Navigation.PushAsync(infoPage);
                infoPage.InitializeInfo((Alarms)args.SelectedItem); }
        }*/
    }
}

