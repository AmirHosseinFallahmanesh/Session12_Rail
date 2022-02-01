using Demo.Core.Cantracts;
using Demo.Core.Domain;
using System;
using System.Collections.Generic;

namespace Demo.Core.ApplicationService
{
    public class StudentFacade : IStudentFacade
    {
        private readonly IStudentRepoistory studentRepoistory;

        public StudentFacade(IStudentRepoistory studentRepoistory)
        {
            this.studentRepoistory = studentRepoistory;
        }
        public void AddStudent(Student stundent)
        {
            studentRepoistory.Add(stundent);
        }

        public IEnumerable<Student> GetStudents()
        {
            return studentRepoistory.GetAll();
        }
    }
}
