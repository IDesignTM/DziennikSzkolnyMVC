using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DziennikSzkolnyMVC.Models;

public class Grade
{
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Wartość oceny jest wymagana")]
    [Range(1, 6, ErrorMessage = "Ocena musi być w przedziale od 1 do 6")]
    [Display(Name = "Ocena")]
    public int Value { get; set; }
    
    [Required(ErrorMessage = "Waga oceny jest wymagana")]
    [Range(1, 10, ErrorMessage = "Waga musi być w przedziale od 1 do 10")]
    [Display(Name = "Waga")]
    public int Weight { get; set; }
    
    [MaxLength(100)]
    [Display(Name = "Opis")]
    public string Description { get; set; }
    
    [Display(Name = "Data wystawienia")]
    public DateTime CreatedAt { get; set; }

    [Required] public string StudentId { get; set; } = string.Empty;
    [ForeignKey("StudentId")]
    public ApplicationUser? Student { get; set; }
    
    [Required] public int SubjectId { get; set; }
    [ForeignKey("SubjectId")]
    public Subject? Subject { get; set; }
    
    [Required] public string TeacherId { get; set; } = string.Empty;
    [ForeignKey("TeacherId")]
    public ApplicationUser? Teacher { get; set; }
}