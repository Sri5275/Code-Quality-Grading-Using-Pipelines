using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Models;
namespace WebAppService.Service
{
    public interface IStudentservices
    {
        public Task<List<Student>> GetStudents();
        public  Task<bool> addNewStd(Student student);

        public Task<bool> updateStd(int id, Student student);
        /*public string GetStudentById(int id);
public List<string> GetStudentWithAlphabet(char x);
public List<string> GetStudentRandomAlphabet(char x);
public List<string> GetStudentsNotWithAlphabet(char x);
public bool isContains(string name);*/
    }
}
