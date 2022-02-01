using Demo.Core.Cantracts;
using Demo.Core.Domain;
using System;
using System.Collections.Generic;

namespace Demo.Infrastructure.Data
{
    public class StudentRepository : IStudentRepoistory
    {
        private readonly FakeContext context;

        public StudentRepository(FakeContext context)
        {
            this.context = context;
        }
        public void Add(Student stundent)
        {
            context.Add(stundent);
        }

        public List<Student> GetAll()
        {
           return context.GetAll();
        }
    }
}
