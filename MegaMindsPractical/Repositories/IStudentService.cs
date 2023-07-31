using MegaMindsPractical.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaMindsPractical.Repositories
{
    public interface IStudentService
    {
        public Task<List<StudentList>> GetStudentListAsync();
        public Task<IEnumerable<Student>> GetStudentByIdAsync(int Id);
        public Task<int> AddStudentAsync(Student Student);
        public Task<int> UpdateStudentAsync(Student Student);
        public Task<int> DeleteStudentAsync(int Id);
        public List<State> BindState();
        public List<City> BindCity(int stateId);
        bool CheckDublication(string Name, int Id);

    }
}
