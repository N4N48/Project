﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinephile.Net
{
    internal class Show
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public int Rating
        {
            get { return Rating; }
            set { Rating = (value >= 0 && value <= 10) ? value : Rating; }
        }

        public string Review { get; set; }

        public Show(string name, string genre, int rating, string review)
        {
            this.Name = name;
            this.Genre = genre;
            this.Rating = rating;
            this.Review = review;
        }
    }
}
