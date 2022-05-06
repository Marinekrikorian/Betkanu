using App1.Models;
using MvvmHelpers.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace App1.ViewModels
{
    public class CartonsEquipmentModelView
    {
        public ObservableCollection<Carton> Cartons { get; set; }
        public AsyncCommand RefreshComand { get; }
        public CartonsEquipmentModelView()
        {
            Cartons = new ObservableCollection<Carton>
            {
                   new Carton
                  {
                name = "Nino And Mia", imageurl="antsong_1920_350.jpg",
                description = "Nino & Mia is the very first cartoon series in Syriac. Nino is the main character of the educational series, where he discovers the world by try and error. The fictional character Mia is his friend helping him in his way to a greater knowledge and learning.",


                  },

                   new Carton
                   {
                    name="ALPHABET SRIES", imageurl="antsong_1920_350.jpg",
                    description= "A 22 episode cartoon series that teaches children the Syriac alphabet in both Eastern and Western, while using the colloquial Surit/Surayt dialects to share a simple and fun story for each alphabet. In each espisode, the child will learn an alphabet along with three associated words that begin with that alphabet (name, object, and animal).",

                   },
            };
       
        }

 
    }
}
