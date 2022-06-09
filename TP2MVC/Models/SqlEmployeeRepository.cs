using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Runtime.InteropServices;
namespace TP2MVC.Models.Repositories
{
    public class SQLEmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext context;
        public SQLEmployeeRepository(AppDbContext context)
        {
            this.context = context;
        }
        public Employe Add(Employe employe)
        {
            context.Employees.Add(employe);
            context.SaveChanges();
            return employe;
        }
        public Employe Delete(int Id)
        {
            Employe employe = context.Employees.Find(Id);
            if (employe != null)
            {
                context.Employees.Remove(employe);
                context.SaveChanges();
            }
            return employe;
        }
        public IEnumerable<Employe> GetAllEmploye()
        {
            return context.Employees;
        }
        public Employe GetEmploye(int Id)
        {
            return context.Employees.Find(Id);
        }
        public Employe Update(Employe employeChanges)
        {
            var employe =
            context.Employees.Attach(employeChanges);
            employe.State = EntityState.Modified;
            context.SaveChanges();
            return employeChanges;
        }

        
    }
}
