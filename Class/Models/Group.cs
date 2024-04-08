using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.Models
{
    internal class Group:Student
    {
        

        public static Group[] Groups = new Group[0];
        public int GroupCount { get; set; }
        public int GroupId { get; set; }
        public string GroupName { get; set; }

        Student[] Students=new Student[0];

        public Group(string name,string surname,string groupName, int groupId) : base(name,surname)
        {
           
            GroupId = groupId;
            GroupName = groupName;
           
        }

        public void GetGroupInfo()
        {
            Console.WriteLine($"GroupId:{GroupId}  GroupName:{GroupName}"); 
        }

        public void  GetStudent(int id)
        {
            foreach (Student students in Students)
            {
                if (students.Id == id) Console.WriteLine(students);
            }
            return;
        }
        public void AddStudent(Student newStudents)
        {

            Array.Resize(ref Students, Students.Length + 1);
            Students[Students.Length - 1] = newStudents;

        }
        public void Search(string a)
        {
            foreach(Student student in Students)
            {
                if(a == student.Name || a == student.Surname)
                {
                    Console.WriteLine(student.GetInfo);    
                }
            }
        }

        public void ShowStudent()
        {

        }

        public string Tostring()
        {
            return $"GroupId:{GroupId}  GroupName:{GroupName}";
            
            foreach(Student student in Students)
            {
                Console.WriteLine($"{Student.name}  {student.surname}  {student.id}");
            }
        }
    }
}
