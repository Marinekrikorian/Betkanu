using App1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class carton : ContentPage
    {
        public List<Carton> Cartons { get; set; }
        public carton()
        {
            InitializeComponent();
            Cartons = new List<Carton>
            {


                  new Carton
                  {
                name = "Nino And Mia", imageurl="ninoandmia.jpg",
                description = "Nino & Mia is the very first cartoon series in Syriac. Nino is the main character of the educational series, where he discovers the world by try and error. The fictional character Mia is his friend helping him in his way to a greater knowledge and learning.",
                Details=" Cartoon Series⏸//Educational//🧍‍ Children",

                  },

                   new Carton
                   {
                    name="ALPHABET SRIES", imageurl="download.jpg",
                    description= "A 22 episode cartoon series that teaches children the Syriac alphabet in both Eastern and Western, while using the colloquial Surit/Surayt dialects to share a simple and fun story for each alphabet. In each espisode, the child will learn an alphabet along with three associated words that begin with that alphabet (name, object, and animal).",
                    Details=" Cartoon Series⏸//Educational//🧍‍ Children",
                   },

              };

            cartondetails.ItemsSource = Cartons;
        }
        private async void cartondetails_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            await this.Navigation.PushAsync(new cartondetail(e.Item as Carton));
        }


        private async void refreshing_Refreshing(object sender, EventArgs e)
        {
            await Task.Delay(2000);
            refreshing.IsRefreshing = false;
        }
    } 

}