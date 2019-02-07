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
        List<ListViewTemplate> wismi;

        public Page1 (List<ListViewTemplate> wismichu)
		{
			InitializeComponent ();
            wismi = wismichu;

        }

       async private void OnButtonClickedDone(object sender, EventArgs e)
        {
            ListViewTemplate x = new ListViewTemplate();
            x.Name = user.Text;
            x.Password = password.Text;
            x.OrderNumber = 1;
            x.Locations = "1";
            wismi.Add(x);

            await Navigation.PopAsync();
        }

    }
}