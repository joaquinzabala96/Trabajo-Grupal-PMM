using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoGrupoPMM.Classes;
using Xamarin.Forms;

namespace TrabajoGrupoPMM
{
    public partial class MainPage : ContentPage
    {
        public List<ListViewTemplate> wismichu = new List<ListViewTemplate>{
            new ListViewTemplate
                {
                Name = "Paco",
                Locations= "Locations: 4",
                OrderNumber = 1,
                Password = "Paco"
               } };

        public MainPage()
        {
            InitializeComponent();

            MainListView.ItemsSource = null;

            MainListView.ItemsSource = wismichu;
        }

        async private void MainListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var Selected = e.Item as ListViewTemplate;

            switch (Selected.OrderNumber)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
            }

          
            ((ListView)sender).SelectedItem = null;

        }
        async private void OnButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1(wismichu));
        }
    }
}
