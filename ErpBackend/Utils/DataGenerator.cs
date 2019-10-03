using Bogus;
using ErpBackend.Models;
using ErpBackend.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpBackend.Utils
{
    public class DataGenerator
    {
        private readonly IDepartmentRepo _context;
        public DataGenerator(IDepartmentRepo context)
        {
            _context = context;
        }
        public enum Gender{
            Male,Female

        }

        public async Task FakeDpt()
        {
            for (int i = 8; i < 39; i++)
            {
                var testDpt = new Faker<Department>()
                    .RuleFor(dpt => dpt.DepartmentName, f => f.Commerce.Department());

                await _context.Create(testDpt);
            }
        }
        public async Task FakeDes()
        {
            //for (int i = 8; i <= 39; i++)
            //{
            //    var testDes = new Faker<Designation>()
            //        .RuleFor(dpt => dpt.JobTitle, f => f.Name.JobTitle())
            //        .RuleFor(dpt => dpt.Division, f => f.Name.JobArea())
            //        .RuleFor(dpt => dpt.ReportTo, f => f.Random.Number());
                    
            //    await _context.Create(testDes);
            //}
        }
        public async Task Fakedata()
        {

            for (int i = 0; i < 30; i++)
            {
                var testEmployee = new Faker<Employee>()
               .RuleFor(emp => emp.FirstName, f => f.Name.FirstName())
               .RuleFor(emp => emp.LastName, f => f.Name.LastName())
               .RuleFor(emp => emp.HomeAddress, f => f.Address.FullAddress())
               .RuleFor(emp => emp.Town, f => f.Address.StreetName())
               .RuleFor(emp => emp.PostCode, f => f.Address.ZipCode())
               .RuleFor(emp => emp.PhoneNumber, f => f.Random.Number(20, 60))
               .RuleFor(emp => emp.MaritalStatus, f => "Married")
               .RuleFor(emp => emp.Status, f => "Active")
               .RuleFor(emp => emp.DateofBirth, f => f.Date.Past())
               .RuleFor(emp => emp.City, f => f.Address.City())
               .RuleFor(emp => emp.Email, f => f.Internet.Email())
               .RuleFor(emp => emp.NiNumber, f => Guid.NewGuid().ToString())
               .RuleFor(emp => emp.Gender, f => f.PickRandom<Gender>().ToString())
               .RuleFor(emp => emp.EmployeeType, f => "Permanent")
               .RuleFor(emp => emp.DateofJoin, f => f.Date.Past())
               .RuleFor(emp => emp.ModeofRecruitment, f => "Interview")
               .RuleFor(emp => emp.Education, f => "MCA")
               .RuleFor(emp => emp.Experience, f => "5 years");

                //await _context.Create(testEmployee);

            }
            //var testDepartment = new Faker<Department>()
            //.RuleFor(emp => emp.DepartmentName, f => f.Commerce.Department())
            //.RuleFor(emp => emp.Description, f => f.Lorem.Word())
            //.RuleFor(emp => emp.EmployeeId, f =>f.);





        }
    }
}
