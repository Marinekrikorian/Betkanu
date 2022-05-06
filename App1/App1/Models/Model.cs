using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Models
{
     class Model
    {
        public string Name { get; set; }
        public string image { get; set; }
        public enum group { land, water, air }
        public group gategorey { get; set; }
    }
}
