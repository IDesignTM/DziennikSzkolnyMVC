using DziennikSzkolnyMVC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DziennikSzkolnyMVC.ViewModels;

public class ManageClassStudentsViewModel
{
    public int ClassId { get; set; }
    public string ClassName { get; set; } = string.Empty;
    public string SchoolYear { get; set; } = string.Empty;

    public List<ApplicationUser> AssignedStudents { get; set; } = new();
    
    public string? SelectedStudentId { get; set; }
    public List<SelectListItem> AvailableStudents { get; set; } = new();
}