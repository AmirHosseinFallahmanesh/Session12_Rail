using Demo.Core.Domain;
using System.Collections.Generic;

namespace Demo.Infrastructure.Data
{
    public class FakeContext
    {
        private List<Student> db = new List<Student>();

        public void Add(Student student)
        {
            db.Add(student);
        }

        public List<Student> GetAll()
        {
            return db;
        }

    }
}
