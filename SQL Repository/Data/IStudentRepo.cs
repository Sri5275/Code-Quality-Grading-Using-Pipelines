using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Models;

namespace SQLRepository.Data
{
    public interface IStudentRepo
    {
        public Task<List<Student>> GetStudents();
        public Task<bool> addNewStd(Student student);
        public Task<bool> updateStd(int id, Student student);
      /*  public Task<bool> addNewStd();
        public Task<bool> updateStd();*/
    }
}
