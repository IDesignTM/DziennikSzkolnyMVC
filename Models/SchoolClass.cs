using System.ComponentModel.DataAnnotations;

namespace DziennikSzkolnyMVC.Models;

public class SchoolClass
{
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Nazwa klasy jest wymagana")]
    [Display(Name = "Nazwa klasy")]
    public string Name { get; set; } = string.Empty;
    
    [Display(Name = "Rok szkolny")]
    public string SchoolYear { get; set; } = string.Empty;

    public ICollection<Subject> Subjects { get; set; } = new List<Subject>();
}