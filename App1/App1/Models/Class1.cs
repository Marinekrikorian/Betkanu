using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Models
{
    public class Cartondetails
    {
        public Carton Carton { get; set; }
    }
    public class Carton
    {
        public string name { get; set; }
        public string description { set; get; }
        public string imageurl { set; get; }

    }

    public class Songdetail
    {
        public Song Song { get; set; }
    }

    public class Song
    {
        public string name { get; set; }
        public string description { set; get; }
        public string imageurl { set; get; }
        public string url { set; get; }

    }
    public enum oopp
    {
        settings,
        contuctus,
        aboutus,
    }
    public class homemenueitem
    {
        public oopp id { get; set; }
        public string title { get; set; }
        public Type targettype { get; set; }
    }

}
