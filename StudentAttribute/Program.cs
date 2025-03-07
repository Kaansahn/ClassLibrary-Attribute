// See https://aka.ms/new-console-template for more information
using DefinexAttribute;
using StudentAttribute;

Console.WriteLine("Hello, World!");

Student student = new Student();
student.Name = "Kaan";
student.Surname = "Sahin";
student.Department = "Software Engineering";

if (!RequiredFieldAttribute.IsValid(student))
{
    Console.WriteLine("invalid input");
}
else
{
    Console.WriteLine("valid input");
}