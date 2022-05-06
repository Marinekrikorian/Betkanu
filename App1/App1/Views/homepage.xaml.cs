using App1.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class homepage : ContentPage
    {
   //     ObservableCollection<Model> PICTURES;
        public homepage()
        {
            InitializeComponent();
        /*   PICTURES = new ObservableCollection<Model>
            {
                
                 new Model{   image= "betkanu_logo.png" , },
               
                new Model{   image= "images1.jpg" ,  },
                new Model{   image= "images.jpg" , },
               new Model{ Name = "BET KANU is a team of creatives with a mission to build a foundation to advance the
        endangered dialects of the Syriac language."
                },
         //       new Model{ Name = "dog3" , image= "antsong_1920_350.jpg" , gategorey=Model.group.land },
          //      new Model{ Name = "dog3" , image= "antsong_1920_350.jpg" , gategorey=Model.group.land },
         //       new Model{ Name = "dog3" , image= "antsong_1920_350.jpg" , gategorey=Model.group.land },
            };
          
              my2.ItemsSource = PICTURES; */
        }


      /*  private void searchbar_TextChanged(object sender, TextChangedEventArgs e)
        {
            var filteredlist = PICTURES.Where(a => a.Name.StartsWith(e.NewTextValue));
            my2.ItemsSource = filteredlist;
        }*/
    }
}