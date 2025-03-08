using System;
using DefinexAttribute;

namespace StudentMVC.Models;

public class Student
{
    [RequiredProperty]
    public string Name { get; set; }
    [RequiredProperty]
    public string Surname { get; set; }
    [RequiredProperty]
    public string Department { get; set; }
}
