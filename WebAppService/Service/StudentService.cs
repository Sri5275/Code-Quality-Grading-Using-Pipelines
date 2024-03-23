using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using WebAppService.Data;
using WebAppService.Service;
using SQLRepository.Data;
using Common.Models;

namespace WebAppService.Service
{
    public class StudentService:IStudentservices
    {
        public readonly IStudentRepo studentRepo;
        public StudentService (IStudentRepo _ISRepo)
        {
            studentRepo = _ISRepo;
        }
        
        public async Task<List<Student>> GetStudents()
        {
            List<Student> stds =await studentRepo.GetStudents();
            return stds;
        }
        public async Task<bool> addNewStd(Student student)
        {
            return await studentRepo.addNewStd(student);
        }
        public async Task<bool> updateStd(int id, Student student)
        {
            return await studentRepo.updateStd(id, student);
        }


        /* public async Task<bool> addNewStd(Student student)
         {
             return await studentRepo.addNewStd(student);
         }
         public async Task<bool> updateStd(int id, Student student)
         {
             return await studentRepo.updateStd(id, student);
         }*/


    }
}