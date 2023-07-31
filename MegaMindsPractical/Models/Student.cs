using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaMindsPractical.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int StateId { get; set; }
        public int CityId { get; set; }

    }
    public class StudentDataTable
    {
        public List<StudentList> data { get; set; }
    }

    public class StudentList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int StateId { get; set; }
        public int CityId { get; set; }
        public string StateName { get; set; }
        public string CityName { get; set; }

    }

    public class State
    {
        public int Id { get; set; }
        public string StateName { get; set; }
       
    }


    public class City
    {
        public int Id { get; set; }
        public int StateId { get; set; }
        public string CityName { get; set; }
        public State State { get; set; }
    }
}
