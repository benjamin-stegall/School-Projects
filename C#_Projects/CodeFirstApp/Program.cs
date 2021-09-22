using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentContext())
            {
                // This name is what gets added to the db
                // An input field could be used but isn't necessary for this exercise
                var name = "John Smith";
                // Adding name and saving it
                var student = new Student { Name = name };
                db.Students.Add(student);
                db.SaveChanges();
                // Interates through the db and gets the Students
                var query = from b in db.Students
                            orderby b.Name
                            select b;
                // Displays students
                Console.WriteLine("List of Students: ");
                foreach (var item in query)
                {
                    Console.WriteLine(item.Name);
                }
                // Prevents console from quitting instantly
                Console.ReadLine();
            }
        }
    }
}
public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
}
public class StudentContext : DbContext
{
    public DbSet<Student> Students { get; set; }
}
