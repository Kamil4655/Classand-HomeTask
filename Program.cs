using Clasasasasa.Models;

namespace Clasasasasa
{
    internal class Program
    {
        static void Main()
        {
            Student student = new Student("Kamil", "Qehremaniv");

            Group group = new Group("math", "bachelor", "ab106");
            group.AddStudent(student);
            group.RemoveStudent(1);
            Console.WriteLine(student.GetInfo());
            Console.WriteLine(group.ToString());
        }
    }
}