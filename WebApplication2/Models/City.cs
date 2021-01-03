using System.ComponentModel.DataAnnotations;

namespace AntiforgeryTest.Models
{
    public class City
    {
        [Display(Name = "City")]
        public string Name { get; set; }
        [DisplayFormat(DataFormatString = "{0:F4}", ApplyFormatInEditMode = true)]
        public int? Population { get; set; }
        public string Notes { get; set; }
    }
}