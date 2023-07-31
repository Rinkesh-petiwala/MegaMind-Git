using MegaMindsPractical.Data;
using MegaMindsPractical.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaMindsPractical.Repositories
{
    public class StudentService : IStudentService
    {
        private readonly DataContext _dbContext;

        public StudentService(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<StudentList>> GetStudentListAsync()
        {
            return await _dbContext.StudentLists.FromSqlRaw<StudentList>("GetStudentList")
                .ToListAsync();
        }

        public async Task<IEnumerable<Student>> GetStudentByIdAsync(int StudentId)
        {
            var param = new SqlParameter("@StudentId", StudentId);

            var productDetails = await Task.Run(() => _dbContext.Students
                            .FromSqlRaw(@"exec GetStudentByID @StudentId", param).ToListAsync());

            return productDetails;
        }

        public async Task<int> AddStudentAsync(Student student)
        {
            var parameter = new List<SqlParameter>();
            parameter.Add(new SqlParameter("@Name", student.Name));
            parameter.Add(new SqlParameter("@Email", student.Email));
            parameter.Add(new SqlParameter("@Photo", student.Phone));
            parameter.Add(new SqlParameter("@Address", student.Address));
            parameter.Add(new SqlParameter("@StateId", student.StateId));
            parameter.Add(new SqlParameter("@CityId", student.CityId));

            var result = await Task.Run(() => _dbContext.Database
           .ExecuteSqlRawAsync(@"exec AddNewStudent @Name, @Email, @Photo, @Address, @StateId, CityId", parameter.ToArray()));

            return result;
        }

        public async Task<int> UpdateStudentAsync(Student student)
        {
            var parameter = new List<SqlParameter>();
            parameter.Add(new SqlParameter("@StudentId", student.Id));
            parameter.Add(new SqlParameter("@Name", student.Name));
            parameter.Add(new SqlParameter("@Email", student.Email));
            parameter.Add(new SqlParameter("@Photo", student.Phone));
            parameter.Add(new SqlParameter("@Address", student.Address));
            parameter.Add(new SqlParameter("@StateId", student.StateId));
            parameter.Add(new SqlParameter("@CityId", student.CityId));

            var result = await Task.Run(() => _dbContext.Database
            .ExecuteSqlRawAsync(@"exec UpdateStudent @Id, @Name, @Email, @Photo, @Address,@StateId, CityId", parameter.ToArray()));
            return result;
        }
        public async Task<int> DeleteStudentAsync(int StudentId)
        {
            return await Task.Run(() => _dbContext.Database.ExecuteSqlInterpolatedAsync($"DeleteStudentByID {StudentId}"));
        }

        public List<State> BindState()
        {
            List<State> lstState = new List<State>();
            try
            {
                lstState = _dbContext.States.ToList();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return lstState;
        }

        public List<City> BindCity(int stateId)
        {
            List<City> lstCity = new List<City>();
            try
            {
              lstCity = _dbContext.Cities.Where(a => a.StateId == stateId).ToList();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return lstCity;
        }

        public bool CheckDublication(string Name, int Id)
        {
            // && d.Id != Id
            List<Student> duplicateTRN = _dbContext.Students.Where(d => d.Name == Name && d.Id != Id).ToList();
            if (duplicateTRN != null)
            {
                return duplicateTRN.Count > 0;
            }
            else
            {
                return duplicateTRN.Count > 0;
            }
        }
    }
}
