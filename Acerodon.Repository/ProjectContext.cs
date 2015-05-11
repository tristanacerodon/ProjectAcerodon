using Acerodon.Model;
using Acerodon.Repository.Mapping;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace Acerodon.Repository {

    public class ProjectContext : DbContext {
        public DbSet<User> Users { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CompanyCustomer> CompanyCustomers { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Milestone> Milestones { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Acerodon.Model.TaskStatus> TaskStatus { get; set; }
        public DbSet<CompanyPosition> CompanyPositions { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeRole> EmployeeRoles { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<EmploymentStatus> EmploymentStatus { get; set; }
        public DbSet<Category> Categories { get; set; }
       
        public ProjectContext()
            : base("name=ProjectContext") {
                Configuration.ProxyCreationEnabled = false;
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserMap());
        }



    }


}