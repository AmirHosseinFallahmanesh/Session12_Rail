using Demo.Core.ApplicationService;
using Demo.Core.Cantracts;
using Demo.Infrastructure.Data;
using System;

namespace EndpointCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            FakeContext context = new FakeContext();
            IStudentRepoistory studentRepository = new StudentRepository(context);
            StudentFacade facade = new StudentFacade(studentRepository);

            facade.AddStudent(new Demo.Core.Domain.Student()
            {
                Age = 12,
                Name = "amir",
                Surname = "rezaii",
                StudentId=1
            });

            foreach (var item in facade.GetStudents())
            {
                Console.WriteLine(item.Surname+" "+item.Name);
            }

            Console.ReadKey();
        }
    }
}
