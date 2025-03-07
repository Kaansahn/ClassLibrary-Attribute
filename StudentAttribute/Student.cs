using System;
using DefinexAttribute;

namespace StudentAttribute;

public class Student
{
    [RequiredFieldAttribute]
    public string Name;
    [RequiredFieldAttribute]
    public string Surname;
    public string Department;
}
