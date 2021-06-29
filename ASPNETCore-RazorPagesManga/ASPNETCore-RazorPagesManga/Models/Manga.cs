using System;
using System.ComponentModel.DataAnnotations;

namespace ASPNETCore_RazorPagesManga.Models
{
    public class Manga
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Synopsis { get; set; }
        [DataType(DataType.Date)]
        public DateTime PublishedDate { get; set; }
        public string Genre { get; set; }
        public string Author { get; set; }
    }
}
