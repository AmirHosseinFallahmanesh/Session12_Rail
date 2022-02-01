using Demo.Core.Domain;
using System.Collections.Generic;

namespace Demo.Core.Cantracts
{
    public interface IStudentFacade
    {
        void AddStudent(Student stundent);

        IEnumerable<Student> GetStudents();
    } 

}
