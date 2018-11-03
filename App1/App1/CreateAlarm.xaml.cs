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
	public partial class CreateAlarm : ContentPage
	{
		public CreateAlarm ()
		{
			InitializeComponent ();
		}

        // Save alarm and redirect to MainPage
        private void btnSaveAlarm_Clicked(object sender, EventArgs e)
        {
            // back to MainPage
            Navigation.PushModalAsync(new MainPage());

        }
    }
}