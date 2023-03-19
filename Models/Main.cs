using System.ComponentModel.DataAnnotations;

namespace NetProject.Models
{
    public class Project
    {
        public int? ProjectId { get; set; }
        [Display(Name = "Namn på projekt")]
        public string? Name { get; set; }
        [Display(Name = "Beskrivning")]
        public string? Desc { get; set; }
        [Display(Name = "Länk")]
        public string? Url { get; set; }

    }
}