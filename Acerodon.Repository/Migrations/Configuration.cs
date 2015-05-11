using Acerodon.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace Acerodon.Repository.Migrations
{


    internal sealed class Configuration : DbMigrationsConfiguration<Acerodon.Repository.ProjectContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "Acerodon.Repository.ProjectContext";

        }

        protected override void Seed(Acerodon.Repository.ProjectContext context)
        {

            var seedDate = DateTime.UtcNow;
            var userid = Guid.Parse("C1AB355C-2244-4A6E-88B1-BF55F0A0401A");

            #region User
            var admin = new User()
            {
                Id = userid,
                Name = "admin",
                CreatedDate = seedDate,
                ModifiedDate = seedDate,
                IsActive = true
            };
            #endregion
            #region Genders
            var male = new Gender()
            {
                Id = Guid.Parse("E6E34425-5380-42D8-B784-AAFD63783034"),
                Name = "Male",
                CreatedBy = admin,
                ModifiedBy = admin,
                CreatedDate = seedDate,
                ModifiedDate = seedDate,
                IsActive = true
            };

            var female = new Gender()
            {
                Id = Guid.Parse("B50ED1B3-444B-417C-944F-FD52CF7B07A6"),
                Name = "Female",
                CreatedBy = admin,
                ModifiedBy = admin,
                CreatedDate = seedDate,
                ModifiedDate = seedDate,
                IsActive = true
            };
            #endregion
            #region EmploymentStatus
            var regular = new EmploymentStatus
            {
                Id = Guid.Parse("13FE6ED0-2CE6-43DA-A819-63EE253F4F93"),
                Name = "Regular",
                CreatedBy = admin,
                ModifiedBy = admin,
                CreatedDate = seedDate,
                ModifiedDate = seedDate,
                IsActive = true
            };
            var contactual = new EmploymentStatus
            {
                Id = Guid.Parse("6EB5A682-91D8-4468-A23B-8921F8A68243"),
                Name = "Contractual",
                CreatedBy = admin,
                ModifiedBy = admin,
                CreatedDate = seedDate,
                ModifiedDate = seedDate,
                IsActive = true
            };
            var projectBase = new EmploymentStatus
            {
                Id = Guid.Parse("4B43473C-ECC4-4049-9A09-ABA27A40E434"),
                Name = "Project Base",
                CreatedBy = admin,
                ModifiedBy = admin,
                CreatedDate = seedDate,
                ModifiedDate = seedDate,
                IsActive = true
            };
            #endregion
            #region Employees
            var employeeA = new Employee()
            {
                Id = Guid.Parse("44EAFC4D-D7E9-4E3A-A542-39D4F325035C"),
                FirstName = "Garen",
                LastName = "Zin",
                MiddleName = "S.",
                Gender = male,
                Name = string.Format("{0}, {1} {2}", "Zin", "Garen", "S."),
                EmploymentStatus = regular,
                CreatedBy = admin,
                ModifiedBy = admin,
                CreatedDate = seedDate,
                ModifiedDate = seedDate,
                IsActive = true
            };

            var employeeB = new Employee()
            {
                Id = Guid.Parse("A476830A-3747-48D4-A57E-81752BD9446A"),
                FirstName = "Xin",
                LastName = "Lao",
                MiddleName = "L.",
                Gender = female,
                Name = string.Format("{0}, {1} {2}", "Lao", "Xin", "L."),
                EmploymentStatus = contactual,
                CreatedBy = admin,
                ModifiedBy = admin,
                CreatedDate = seedDate,
                ModifiedDate = seedDate,
                IsActive = true
            };
            var employeeC = new Employee()
            {
                Id = Guid.Parse("339B6DB4-0B1F-4979-9EC0-D170619B9230"),
                FirstName = "Lee",
                LastName = "Ming",
                MiddleName = "T.",
                Gender = female,
                Name = string.Format("{0}, {1} {2}", "Ming", "Lee", "T."),
                EmploymentStatus = projectBase,
                CreatedBy = admin,
                ModifiedBy = admin,
                CreatedDate = seedDate,
                ModifiedDate = seedDate,
                IsActive = true
            };
            #endregion
            #region TaskStatus
            var done = new TaskStatus
            {
                Id = Guid.Parse("CD710D64-4651-4C2C-AAE1-86658480DFE5"),
                Name = "Done",
                CreatedBy = admin,
                ModifiedBy = admin,
                CreatedDate = seedDate,
                ModifiedDate = seedDate,
                IsActive = true
            };

            var ongoing = new Model.TaskStatus
            {
                Id = Guid.Parse("F5E3592E-C40B-47CF-BB3D-95D238770514"),
                Name = "Ongoing",
                CreatedBy = admin,
                ModifiedBy = admin,
                CreatedDate = seedDate,
                ModifiedDate = seedDate,
                IsActive = true
            };
            var onhold = new Model.TaskStatus
            {
                Id = Guid.Parse("9B7B5A61-BF67-4C3A-A589-D0C7D6888802"),
                Name = "OnHold",
                CreatedBy = admin,
                ModifiedBy = admin,
                CreatedDate = seedDate,
                ModifiedDate = seedDate,
                IsActive = true
            };
            #endregion
            #region Tasks
            var taskA = new Task()
            {
                Id = Guid.Parse("ADD999E2-6097-441A-B4FF-17CA84089597"),
                Name = "Task A",
                Description = "Task A Description",
                StartDate = seedDate,
                EndDate = seedDate.AddMonths(3),
                Employee = employeeA,
                TaskStatus = done,
                CreatedBy = admin,
                ModifiedBy = admin,
                CreatedDate = seedDate,
                ModifiedDate = seedDate,
                IsActive = true
            };
            var taskB = new Task()
            {
                Id = Guid.Parse("F10CD3D6-79D2-46DC-9A5F-76BD6F4C328B"),
                Name = "Task B",
                Description = " Task B Description",
                StartDate = seedDate,
                EndDate = seedDate.AddMonths(3),
                Employee = employeeB,
                TaskStatus = ongoing,
                CreatedBy = admin,
                ModifiedBy = admin,
                CreatedDate = seedDate,
                ModifiedDate = seedDate,
                IsActive = true
            };
            var taskC = new Task()
            {
                Id = Guid.Parse("0C7659FB-15D8-4C14-95D1-D215C4DE2C66"),
                Name = "Task C",
                Description = "Task C Description",
                StartDate = seedDate,
                EndDate = seedDate.AddMonths(3),
                Employee = employeeC,
                TaskStatus = onhold,
                CreatedBy = admin,
                ModifiedBy = admin,
                CreatedDate = seedDate,
                ModifiedDate = seedDate,
                IsActive = true
            };
            #endregion
            #region Milestones
            var milestoneA = new Milestone()
            {
                Id = Guid.Parse("D0560606-2E41-4A8F-90FA-067658B832E2"),
                Name = "Milestone A",
                Description = "Milestone A Description",
                StartDate = seedDate,
                EndDate = seedDate.AddMonths(3),
                Tasks = new Task[]
                {
                    taskA,
                    taskB
                },
                CreatedBy = admin,
                ModifiedBy = admin,
                CreatedDate = seedDate,
                ModifiedDate = seedDate,
                IsActive = true,
            };
            var milestoneB = new Milestone()
            {
                Id = Guid.Parse("582280C8-3A1A-4D7E-9F19-E529F92616AB"),
                Name = "Milestone B",
                Description = "Milestone B Description",
                StartDate = seedDate,
                EndDate = seedDate.AddMonths(3),
                Tasks = new Task[]
                {
                    taskC
                },
                Milestones = new Milestone[]
                {
                    milestoneA
                },
                CreatedBy = admin,
                ModifiedBy = admin,
                CreatedDate = seedDate,
                ModifiedDate = seedDate,
                IsActive = true
            };
            #endregion
            #region Projects
            var project = new Project()
            {
                Id = Guid.Parse("D1972195-51A5-422D-A531-20F54C948423"),
                Name = "Payroll",
                Description = "Payroll",
                StartDate = seedDate,
                EndDate = seedDate.AddMonths(3),
                Milestones = new Milestone[]
                {
                    milestoneA,
                    milestoneB
                },
                CreatedBy = admin,
                ModifiedBy = admin,
                CreatedDate = seedDate,
                ModifiedDate = seedDate,
                IsActive = true
            };
            #endregion
            #region Customer
            var customer = new Customer()
            {
                Id = Guid.Parse("FD9AB732-F73B-41E9-A3F2-330B5997CD31"),
                Name = "Customer A",
                CreatedBy = admin,
                ModifiedBy = admin,
                CreatedDate = seedDate,
                ModifiedDate = seedDate,
                IsActive = true
            };
            #endregion
            #region CompanyCustomers
            var companyCustomer = new CompanyCustomer()
            {
                Id = Guid.Parse("188B8797-AA0D-48C4-A3C5-DA5B9A0A5FDD"),
                Name = "Client A",
                Customer = customer,

                Projects = new Project[]
                {
                    project
                },
                CreatedBy = admin,
                ModifiedBy = admin,
                CreatedDate = seedDate,
                ModifiedDate = seedDate,
                IsActive = true
            };
            #endregion
            #region Company
            var company = new Company
            {
                Id = Guid.Parse("1D4DD7DD-7854-4D03-8E7D-8D19B9D24057"),
                Name = "ABC Company",

                CompanyCustomers = new CompanyCustomer[]
                {
                    companyCustomer
                },

                CreatedBy = admin,
                ModifiedBy = admin,
                CreatedDate = seedDate,
                ModifiedDate = seedDate,
                IsActive = true
            };
            #endregion

            context.Companies.AddOrUpdate(company);

        }

    }
}
