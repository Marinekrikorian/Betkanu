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
    public partial class cartondetail : ContentPage
    {
        public Carton Carton { get; set; }
        public cartondetail(Carton carton)
        {
            InitializeComponent();
            Carton = carton;    
            this.BindingContext = Carton;
        }
    }
}