using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Movies_Store1.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string MovieName { get; set; }
        public string Genre { get; set; }

        [DisplayFormat(DataFormatString =  "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }
    }
}