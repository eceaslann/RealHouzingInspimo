﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHouzing.DtoLayer.BuyLeaseDtos
{
    public class UpdateBuyLeaseDto
    {
        public int BuyLeaseID { get; set; }
        public string Title1 { get; set; }
        public string Title2 { get; set; }
        public string ImageURL { get; set; }
        public string Button { get; set; }
    }
}