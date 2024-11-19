using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Classes___Objects;

public class Student
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Age { get; set; }
    public string Gender { get; set; }
    public string Status { get; set; }
    public string Citizen { get; set; }
    public string StudyWork { get; set; }
    public string Achievements { get; set; }
    public string BirthCity { get; set; }
    public string LivingAddress { get; set; }

    public void DisplayInfoStudent()
    {
        string result = $"Name: {Name}\n Surname: {Surname}\n Age: {Age}\n Male/Female: {Gender}\n " +
            $"Status: {Status}\n Citizen: {Citizen} StudyWork: {StudyWork}";
        Console.WriteLine(result);
    }




}
