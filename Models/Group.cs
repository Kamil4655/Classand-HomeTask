using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Clasasasasa.Models
{
    internal class Group : Student
    {
        public string GroupName { get; set; }
        public int GroupId { get; set; }
        public static int count = 1;
        public Group(string name, string surname, string groupname) : base(name, surname)
        {
            GroupName = Captalize(groupname);
            Name = Captalize(name);
            GroupId = count++;
        }

        static Group[] _groups = new Group[] { };
        static Student[] _students = new Student[] { };

        public static string GroupCount { get; set; }


        public void AddStudent(Student newStudent)
        {
            Array.Resize(ref _students, _students.Length + 1);
            _students[_students.Length - 1] = newStudent;
        }
        public void RemoveStudent(int studentid)
        {
            for (int i = 0; i < _students.Length; i++)
            {
                if (_students[i].Id == studentid)
                {
                    for (int j = i; j < _students.Length - 1; j++)
                    {
                        _students[j] = _students[j + 1];
                    }
                    Array.Resize(ref _students, _students.Length - 1);
                    Console.WriteLine("Students removd");
                    return;
                }
            }
            Console.WriteLine("student not found");
        }

        public void GetStudent(string id)
        {
            bool found = false;
            foreach (var student in _students)
            {
                if (student.Id == GroupId)
                {
                    found = true;
                    break;

                }
            }
        }

        public override string ToString()
        {
            return $"{GroupId}, {GroupName}, {_students.Length}";
        }
    }
}