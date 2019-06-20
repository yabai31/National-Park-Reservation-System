﻿using System;
using System.Collections.Generic;


namespace Capstone.Models
{
    public class Site
    {
        public int SiteId { get; set; }
        public int CampgroundId { get; set; }
        public int SiteNumber { get; set; }
        public int MaxOccupancy { get; set; }
        public int Accessible { get; set; }
        public int MaxRvLength { get; set; }
        public int Utilities { get; set; }
        
    }
}