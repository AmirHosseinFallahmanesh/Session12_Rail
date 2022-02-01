using Demo.Core.Domain;
using System;
using System.Collections.Generic;

namespace Demo.Core.Cantracts
{
    public interface IStudentRepoistory
    {
         void Add(Student stundent);

        List<Student> GetAll();
    }

}
