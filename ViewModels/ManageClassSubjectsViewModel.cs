using DziennikSzkolnyMVC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DziennikSzkolnyMVC.ViewModels;

public class ManageClassSubjectsViewModel
{
    public int ClassId { get; set; }
    public string ClassName { get; set; } = string.Empty;
    public string SchoolYear { get; set; } = string.Empty;

    public List<Subject> AssignedSubjects { get; set; } = new();

    public List<SelectListItem> AvailableSubjects { get; set; } = new();
}