﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Overview { get; set; }
        public decimal? Budget { get; set; }
        public decimal? Revenue { get; set; }
        public string PosterURL { get; set; }
        public string BackdropURL { get; set; }
    }
}
