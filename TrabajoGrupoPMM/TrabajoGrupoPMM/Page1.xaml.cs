using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoGrupoPMM.Classes;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrabajoGrupoPMM
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage
	{
        MainPage MainListView2;

        public Page1 (MainPage MainListView)
		{
			InitializeComponent ();
            MainListView2 = MainListView;

        }

       async private void OnButtonClickedDone(object sender, EventArgs e)
        {
           // MainListView2 = new List<ListViewTemplate>{
           // new ListViewTemplate
           //     {
           //     Name = user.Text,
           //     Locations= "Locations: 4",
           //     OrderNumber = 1,
           //     Password = password.Text
           //    }
           //};
            await Navigation.PushAsync(MainPage());
        }

    }
}