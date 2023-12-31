﻿namespace RealHouzing.Consume.Models.BlogModels
{
    public class UpdateBlogViewModel
    {
        public int BlogID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string BlogImage { get; set; }
        public string Writer { get; set; }
        public string WriterImage { get; set; }
        public DateTime Date { get; set; }
    }
}