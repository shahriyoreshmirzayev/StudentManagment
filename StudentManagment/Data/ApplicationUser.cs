﻿using Microsoft.AspNetCore.Identity;
using StudentManagment.Shared.Models;
namespace StudentManagment.Data;

public class ApplicationUser : IdentityUser
{
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }
    public string? Photo { get; set; }
    public int GenderId { get; set; }
    public SystemCodeDetail Gender { get; set; }
    public string FullName => $"{FirstName} {MiddleName} {LastName}";
    public bool IsActive { get; set; }
    public DateTime LastActivatyDate { get; set; }
    public DateTime? DeactivatedOn { get; set; }
}
