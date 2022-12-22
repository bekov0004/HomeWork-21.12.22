using Domain.Models;
using Infrastructure.Services;
using System;
var student1 = new Student();
student1.Id = 1; 
student1.FirstName = "Anushervon";
student1.LastName = "Bekov";
student1.Address = "Hamadoni";

var student2 = new Student();
student2.Id = 2;
student2.FirstName = "Muhammad";
student2.LastName = "Yaaqubzoda";
student2.Address = "Farhor";

var student3 = new Student();
student3.Id = 2;
student3.FirstName = "Abdulloh";
student3.LastName = "Sheraalizoda";
student3.Address = "Dushanbe";

var student1Services = new StudentService();
student1Services.AddStudent(student1);
student1Services.AddStudent(student2);
student1Services.AddStudent(student3);


foreach (var element in student1Services.GetStudents())
    {
        Console.WriteLine(element.FirstName + " " + element.LastName + " " + element.Address);
    }
student1Services.Delete(1);

 

foreach (var element in student1Services.GetStudents())
{
    Console.WriteLine(element.FirstName + " " + element.LastName + " " + element.Address);
}
