using Acerodon.Model;
using System;
using System.Data.Entity;
using System.Linq;

namespace Acerodon.Repository {

    public class ProjectContext : DbContext {
        private static readonly DatabaseInitializerMode _databaseInitializerMode = DatabaseInitializerMode.DoNotChange;
        public DbSet<Company> Companies { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CompanyCustomer> CompanyCustomers { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Milestone> Milestones { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Acerodon.Model.TaskStatus> TaskStatus { get; set; }
        public DbSet<MilestoneTask> MilestoneTasks { get; set; }
        public DbSet<CompanyPosition> CompanyPositions { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeRole> EmployeeRoles { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<EmploymentStatus> EmploymentStatus { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public ProjectContext()
            : base("name=ProjectContext") {

                switch (_databaseInitializerMode) {
                    case DatabaseInitializerMode.Reseed:
                        Database.SetInitializer(new ProjectContextInitializer());
                        Database.Initialize(true);
                        break;
                }

        }
        public enum DatabaseInitializerMode {
            DropThenCreate = 0 ,
            Reseed = 1 ,
            DoNotChange = 2
        }

    }


}