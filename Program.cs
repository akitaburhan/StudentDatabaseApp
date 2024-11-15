using System;

class Program
{
    static void Main(string[] args)
    {
        using (var context = new SchoolContext())
        {
            Console.WriteLine("Adding a new student to the database...");

            var student = new Student
            {
                FirstName = "John",
                LastName = "Doe",
                EnrollmentDate = DateTime.Now
            };

            context.Students.Add(student);
            context.SaveChanges();

            Console.WriteLine("Student added successfully!");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
