using EFCoreDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreDemo
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            #region Session 03
            APPDbContext dbContext = new APPDbContext();
            #region CRUD Operations
            #region Intro
            Department department01 = new Department()
            {
                DeptName = "IT"
            };
            //dbContext.ChangeTracker.QueryTrackingBehavior = Microsoft.EntityFrameworkCore.QueryTrackingBehavior.NoTracking;
            //Console.WriteLine(dbContext.Entry(department01).State);
            //Console.WriteLine(department01.Id); 
            #endregion
            #region Create(C)
            ////dbContext.Departments.Add(department01);
            ////dbContext.Set<Department>().Add(department01);
            //// dbContext.Add(department01);
            //dbContext.Entry(department01).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            //// The Object Was Added Local
            //Console.WriteLine(dbContext.Entry(department01).State);
            //Console.WriteLine(department01.Id);
            //await dbContext.SaveChangesAsync();
            //Console.WriteLine("After Save Changes");
            //Console.WriteLine(dbContext.Entry(department01).State);
            //Console.WriteLine(department01.Id);


            #endregion
            #region Read |Retrive (R)
            //var department = await dbContext.Departments.AsNoTracking().FirstOrDefaultAsync(E => E.DeptName == "IT");
            //if(department is not null)
            //{
            //    Console.WriteLine(dbContext.Entry(department).State);
            //    Console.WriteLine($"{department.Id}::{department.DeptName}");

            //}
            //------------
            //var department = await dbContext.Departments.FirstOrDefaultAsync(E => E.DeptName == "IT");
            //if (department is not null)
            //{
            //    Console.WriteLine(dbContext.Entry(department).State);
            //    Console.WriteLine($"{department.Id}::{department.DeptName}");
            //}










            #endregion
            #region Update (U)
            #region Connected Scenario
            //var department = await dbContext.Departments.FirstOrDefaultAsync(E => E.DeptName == "IT");
            //if(department is not null)
            //{
            //    Console.WriteLine(dbContext.Entry(department).State);
            //    Console.WriteLine($"{department.Id}::{department.DeptName}");
            //    department.DeptName = "Sales";
            //    Console.WriteLine("After Change Name");
            //    Console.WriteLine(dbContext.Entry(department).State);
            //    Console.WriteLine($"{department.Id}::{department.DeptName}");
            //    await dbContext.SaveChangesAsync();
            //    Console.WriteLine("After Save Changes");
            //    Console.WriteLine(dbContext.Entry(department).State);
            //    Console.WriteLine($"{department.Id}::{department.DeptName}");
            //}
            #endregion
            #region Disconnected Scenario
            //var department = new Department() { Id = 1, DeptName = "DotNet" };
            //Console.WriteLine(dbContext.Entry(department).State);
            //Console.WriteLine($"{department.Id}::{department.DeptName}");
            //dbContext.Update(department);
            //Console.WriteLine("After Change");
            //Console.WriteLine(dbContext.Entry(department).State);
            //Console.WriteLine($"{department.Id}::{department.DeptName}");
            //await dbContext.SaveChangesAsync();
            //Console.WriteLine("After Save Changes");
            //Console.WriteLine(dbContext.Entry(department).State);
            //Console.WriteLine($"{department.Id}::{department.DeptName}");

            #endregion
            #region AsNoTracking 
            //var department = dbContext.Departments.AsNoTracking().FirstOrDefault(E => E.DeptId == 10);
            //if (department is not null)
            //{
            //    Console.WriteLine($"Department State = {dbContext.Entry(department).State}"); // Detached
            //    Console.WriteLine($"{department.DeptId} - {department.DeptName}"); // 10 - Sales
            //    department.DeptName = "IT";

            //    Console.WriteLine("After Changing Name ");
            //    Console.WriteLine($"Department State = {dbContext.Entry(department).State}"); // Detached
            //    Console.WriteLine($"{department.DeptId} - {department.DeptName}"); // 10 - IT
            //    await dbContext.SaveChangesAsync();
            //    Console.WriteLine("After SaveChanges()");
            //    Console.WriteLine($"Department State = {dbContext.Entry(department).State}"); // Detached
            //    Console.WriteLine($"{department.DeptId} - {department.DeptName}"); // 10 - IT
            //    // Object -> DeptName Changed , InDatabase Nothing happened
            //}
            #endregion
            #endregion
            #region Delete| Remove (D)

            #region Connected scenario

            //var department = await dbContext.Departments.FirstOrDefaultAsync(E => E.Id==1);
            //if (department is not null)
            //{
            //    Console.WriteLine(dbContext.Entry(department).State);
            //    Console.WriteLine($"{department.Id}::{department.DeptName}");
            //}
            //// dbContext.Departments.Remove(department);
            ////dbContext.Set<Department>().Remove(department);
            ////dbContext.Entry(department).State = EntityState.Deleted;
            //dbContext.Remove(department);
            //Console.WriteLine(dbContext.Entry(department).State);
            //Console.WriteLine($"{department.Id}::{department.DeptName}");
            //Console.WriteLine("After Delete");
            //await dbContext.SaveChangesAsync();
            //Console.WriteLine(dbContext.Entry(department).State);
            //Console.WriteLine($"{department.Id}::{department.DeptName}");

            #endregion

            #region Disconnected scenario
            //var department = new Department() { Id = 2 };
            //Console.WriteLine($"department State={dbContext.Entry(department).State}");
            //dbContext.Remove(department);
            //Console.WriteLine($"department State={dbContext.Entry(department).State}");
            //Console.WriteLine("After Delete");
            //await dbContext.SaveChangesAsync();
            //Console.WriteLine($"department State={dbContext.Entry(department).State}");

            #endregion

            #endregion

            #endregion
            #region Bulk Operations
            #region Old
            //var employees = dbContext.Employees.Where(E => E.Salary >= 5000).Tolist();//Load
            //foreach (var employee in employees) //Loop
            //{
            //    employee.Salary *= 1.2m;
            //}
            //dbContext.SaveChanges(); 
            #endregion
            #region New
            //await dbContext.Employees.Where(E => E.Salary >= 5000)
            //  .ExecuteUpdateAsync(E => E.SetProperty(emp => emp.Salary, emp => emp.Salary * 1.2m));
            #endregion

            #endregion
            #region Data Seeding
            //if (!await dbContext.Employees.AnyAsync())

            //{
            //    dbContext.Employees.AddRange(
            //        new Employee { Name = "Sara" },
            //        new Employee { Name = "Noha" });
            //    await dbContext.SaveChangesAsync();
            //    Console.WriteLine("Employees Data Seed");

            //}
            #endregion
            #endregion
        }
    }
}
