﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelCrown.Models
{
    public class Feature
    {
        public int FeatureId { get; set; }
        public string FeatureName { get; set; }
        public virtual ICollection<Room> Rooms { get; set; }
    }
}
