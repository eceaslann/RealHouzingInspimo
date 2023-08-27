using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHouzing.DtoLayer.VideoandAboutDtos
{
    public class UpdateVideoDto
    {
        public int VideoandAboutID { get; set; }
        public string VideoURL { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}