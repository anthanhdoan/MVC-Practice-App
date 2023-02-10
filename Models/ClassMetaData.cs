using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using SchoolManagementApp.MVC.Data;

namespace SchoolManagementApp.MVC.Data;

public class ClassMetaData
{
    [Display(Name="Lecturer")]
    public int? LecturerId { get; set; }

    [Display(Name="Course")]
    public int? CourseId { get; set; }
}

[ModelMetadataType(typeof(ClassMetaData))]
public partial class Class{}