using System.ComponentModel.DataAnnotations;

namespace DziennikSzkolnyMVC.Models;

public class Subject
{
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Nazwa przedmiotu jest wymagana")]
    [Display(Name = "Nazwa przedmiotu")]
    public string Name { get; set; } = string.Empty;
    
    public ICollection<SchoolClass> SchoolClasses { get; set; } = new List<SchoolClass>();
}