﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHouzing.EntityLayer.Concrete
{
    public class Team
    {
        public int TeamID { get; set; }
        public string NameSurname { get; set; }
        public string ImageURL { get; set; }
        public string Title { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Linkedln { get; set; }
    }
}
