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
    public partial class songdetail : ContentPage
    {

        public Song Song { get; set; }
        public songdetail(Song song )
        {
            InitializeComponent();
            Song = song;
            this.BindingContext = song;
         
        }
     
    }
}