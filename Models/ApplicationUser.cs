using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace DziennikSzkolnyMVC.Models;

public class ApplicationUser : IdentityUser
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    
    public int? SchoolClassId { get; set; }
    
    [ForeignKey(("SchoolClassId"))]
    public SchoolClass SchoolClass { get; set; }
}