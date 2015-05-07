using Acerodon.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Acerodon.Repository {
    public class ProjectContextInitializer : IDatabaseInitializer<ProjectContext> {

        public void InitializeDatabase(ProjectContext context) {
            CreateUser(context);
            CreateGender(context);
            CreateCompany(context);
            CreateCustomer(context);
            CreateEmploymentStatus(context);
            CreateEmployee(context);
            CreateCompanyCustomer(context);
            
            CreateProject(context);
            CreateCompanyPosition(context);
            CreateEmployeeRole(context);
            CreateMilestone(context);
            CreateTask(context);
            CreateTaskStatus(context);
            CreateMilestoneTask(context);

            
        }

        private const string _adminUserId = "F5E336D7-DBCD-42D7-B4B8-41FB346F266A";
        private const string _adminProjectName = "1B642228-7A23-40D5-A8B4-B3757FA0BCDD";

        private void CreateUser(ProjectContext context) {
            var entity = new User {
                Id = Guid.Parse(_adminUserId) ,
                Name = "admin" ,
                CreatedById = Guid.Parse(_adminUserId) ,
                CreatedDate = DateTime.UtcNow ,
                ModifiedById = null ,
                ModifiedDate = DateTime.UtcNow ,
                IsActive = true
            };

            context.Users.Add(entity);
            context.SaveChanges();
            entity = new User {
                Id = Guid.Parse(_adminProjectName) ,
                Name = "admin.ProjectName" ,
                CreatedById = Guid.Parse(_adminUserId) ,
                CreatedDate = DateTime.UtcNow ,
                ModifiedById = null ,
                ModifiedDate = DateTime.UtcNow ,
                IsActive = true
            };
            context.Users.Add(entity);
            context.SaveChanges();
        }

        private void CreateGender(ProjectContext context) {
            var entity = new Gender {
                Id = Guid.Parse("E0DFD76B-C689-4241-824A-0FCFA956348A") ,
                Name = "Male" ,
                CreatedById = Guid.Parse(_adminUserId) ,
                CreatedDate = DateTime.UtcNow ,
                ModifiedById = null ,
                ModifiedDate = DateTime.UtcNow ,
                IsActive = true
            };
            context.Genders.Add(entity);
            context.SaveChanges();

            entity = new Gender {
                Id = Guid.Parse("77FEE6EF-D574-4384-A06F-B9BF14923627") ,
                Name = "Female" ,
                CreatedById = Guid.Parse(_adminUserId) ,
                CreatedDate = DateTime.UtcNow ,
                ModifiedById = null ,
                ModifiedDate = DateTime.UtcNow ,
                IsActive = true
            };
            context.Genders.Add(entity);
            context.SaveChanges();
        }

        private void CreateCompany(ProjectContext context) {
            var entity = new Company {
                Id = Guid.Parse("1B65B807-9E3A-4178-AA46-7CA1C42867E8") ,
                Name = "ABC Company" ,
                CreatedById = Guid.Parse(_adminUserId) ,
                CreatedDate = DateTime.UtcNow ,
                ModifiedById = null ,
                ModifiedDate = DateTime.UtcNow ,
                IsActive = true
            };
            context.Companies.Add(entity);
            context.SaveChanges();

            entity = new Company {
                Id = Guid.Parse("77FEE6EF-D574-4384-A06F-B9BF14923627") ,
                Name = "LTD Company" ,
                CreatedById = Guid.Parse(_adminUserId) ,
                CreatedDate = DateTime.UtcNow ,
                ModifiedById = null ,
                ModifiedDate = DateTime.UtcNow ,
                IsActive = true
            };
            context.Companies.Add(entity);
            context.SaveChanges();
        }

        private void CreateCustomer(ProjectContext context) {
            var entity = new Customer {
                Id = Guid.Parse("FF4D41F0-A054-4EF5-B715-A0ECD17F3CFC") ,
                Name = "Customer A" ,
                CreatedById = Guid.Parse(_adminUserId) ,
                CreatedDate = DateTime.UtcNow ,
                ModifiedById = null ,
                ModifiedDate = DateTime.UtcNow ,
                IsActive = true
            };
            context.Customers.Add(entity);
            context.SaveChanges();

            entity = new Customer {
                Id = Guid.Parse("85C92F4A-82E0-4D9A-B3A7-6F44565D18A0") ,
                Name = "Customer B" ,
                CreatedById = Guid.Parse(_adminUserId) ,
                CreatedDate = DateTime.UtcNow ,
                ModifiedById = null ,
                ModifiedDate = DateTime.UtcNow ,
                IsActive = true
            };
            context.Customers.Add(entity);
            context.SaveChanges();

            entity = new Customer {
                Id = Guid.Parse("49979459-26B3-4390-83F3-1E371BD850D1") ,
                Name = "Customer C" ,
                CreatedById = Guid.Parse(_adminUserId) ,
                CreatedDate = DateTime.UtcNow ,
                ModifiedById = null ,
                ModifiedDate = DateTime.UtcNow ,
                IsActive = true
            };
            context.Customers.Add(entity);
            context.SaveChanges();
        }

        private void CreateEmploymentStatus(ProjectContext context) {
            var entity = new EmploymentStatus {
                Id = Guid.Parse("78BA7391-266F-4C8C-8143-7B4FEB70F37E") ,
                Name = "Regular" ,
                CreatedById = Guid.Parse(_adminUserId) ,
                CreatedDate = DateTime.UtcNow ,
                ModifiedById = null ,
                ModifiedDate = DateTime.UtcNow ,
                IsActive = true
            };
            context.EmploymentStatus.Add(entity);
            context.SaveChanges();

            entity = new EmploymentStatus {
                Id = Guid.Parse("6490171A-5811-4D5D-9D64-0996127C2429") ,
                Name = "Contractual" ,
                CreatedById = Guid.Parse(_adminUserId) ,
                CreatedDate = DateTime.UtcNow ,
                ModifiedById = null ,
                ModifiedDate = DateTime.UtcNow ,
                IsActive = true
            };
            context.EmploymentStatus.Add(entity);
            context.SaveChanges();

            entity = new EmploymentStatus {
                Id = Guid.Parse("E41AEF4D-1CAC-46A7-90CB-34A1814C5461") ,
                Name = "Project Base" ,
                CreatedById = Guid.Parse(_adminUserId) ,
                CreatedDate = DateTime.UtcNow ,
                ModifiedById = null ,
                ModifiedDate = DateTime.UtcNow ,
                IsActive = true
            };
            context.EmploymentStatus.Add(entity);
            context.SaveChanges();

        }

        private void CreateEmployee(ProjectContext context) {
            var entity = new Employee {
                Id = Guid.Parse("2C86F2C4-6695-43B9-9C35-305F8D49849A") ,
                EmploymentStatusId = Guid.Parse("78BA7391-266F-4C8C-8143-7B4FEB70F37E") ,
                FirstName = "Xin" ,
                LastName = "Xiao" ,
                MiddleName = "L." ,
                GenderId = Guid.Parse("E0DFD76B-C689-4241-824A-0FCFA956348A") ,
                Name = string.Format("{0}, {1} {2}" , "Xiao" , "Xin" , "L.") ,
                CreatedById = Guid.Parse(_adminUserId) ,
                CreatedDate = DateTime.UtcNow ,
                ModifiedById = null ,
                ModifiedDate = DateTime.UtcNow ,
                IsActive = true
            };
            context.Employees.Add(entity);
            context.SaveChanges();

            entity = new Employee {
                Id = Guid.Parse("2F6853E4-09C8-47AE-9166-CFEE627E8981") ,
                EmploymentStatusId = Guid.Parse("6490171A-5811-4D5D-9D64-0996127C2429") ,
                FirstName = "Garen" ,
                LastName = "Zin" ,
                MiddleName = "S." ,
                GenderId = Guid.Parse("77FEE6EF-D574-4384-A06F-B9BF14923627") ,
                Name = string.Format("{0}, {1} {2}" , "Zin" , "Garen" , "S.") ,
                CreatedById = Guid.Parse(_adminUserId) ,
                CreatedDate = DateTime.UtcNow ,
                ModifiedById = null ,
                ModifiedDate = DateTime.UtcNow ,
                IsActive = true
            };
            context.Employees.Add(entity);
            context.SaveChanges();

            entity = new Employee {
                Id = Guid.Parse("10B45FD4-1472-45D8-99D8-27BA64614D2C") ,
                EmploymentStatusId = Guid.Parse("6490171A-5811-4D5D-9D64-0996127C2429") ,
                FirstName = "Zhen" ,
                LastName = "Whee" ,
                MiddleName = "C." ,
                GenderId = Guid.Parse("77FEE6EF-D574-4384-A06F-B9BF14923627") ,
                Name = string.Format("{0}, {1} {2}" , "Whee" , "Zhen" , "C.") ,
                CreatedById = Guid.Parse(_adminUserId) ,
                CreatedDate = DateTime.UtcNow ,
                ModifiedById = null ,
                ModifiedDate = DateTime.UtcNow ,
                IsActive = true
            };
            context.Employees.Add(entity);
            context.SaveChanges();

        }
        private void CreateCompanyCustomer(ProjectContext context) {
            var entity = new CompanyCustomer {
                Id = Guid.Parse("DB4DB9F0-6CC2-41CB-B10C-D27E42056810") ,
                CompanyId = Guid.Parse("1B65B807-9E3A-4178-AA46-7CA1C42867E8") ,
                CustomerId = Guid.Parse("FF4D41F0-A054-4EF5-B715-A0ECD17F3CFC") ,
                Name = "Client A" ,
                CreatedById = Guid.Parse(_adminUserId) ,
                CreatedDate = DateTime.UtcNow ,
                ModifiedById = null ,
                ModifiedDate = DateTime.UtcNow ,
                IsActive = true
            };
            context.CompanyCustomers.Add(entity);
            context.SaveChanges();

            entity = new CompanyCustomer {
                Id = Guid.Parse("C5767D53-5FF6-474D-8080-79358E43D1F4") ,
                CompanyId = Guid.Parse("77FEE6EF-D574-4384-A06F-B9BF14923627") ,
                CustomerId = Guid.Parse("85C92F4A-82E0-4D9A-B3A7-6F44565D18A0") ,
                Name = "Client B" ,
                CreatedById = Guid.Parse(_adminUserId) ,
                CreatedDate = DateTime.UtcNow ,
                ModifiedById = null ,
                ModifiedDate = DateTime.UtcNow ,
                IsActive = true
            };
            context.CompanyCustomers.Add(entity);
            context.SaveChanges();
        }

        private void CreateProject(ProjectContext context) {
            var entity = new Project {
                Id = Guid.Parse("401E9CBE-3E6C-4D58-A0FF-C060A25C5DA4") ,
                CompanyCustomerId = Guid.Parse("DB4DB9F0-6CC2-41CB-B10C-D27E42056810") ,
                Description = "Payroll" ,
                StartDate = DateTime.UtcNow ,
                EndDate = DateTime.UtcNow.AddMonths(3) ,
                Name = "Payroll" ,
                CreatedById = Guid.Parse(_adminUserId) ,
                CreatedDate = DateTime.UtcNow ,
                ModifiedById = null ,
                ModifiedDate = DateTime.UtcNow ,
                IsActive = true
            };
            context.Projects.Add(entity);
            context.SaveChanges();

            entity = new Project {
                Id = Guid.Parse("E29EA720-5B78-4CF4-8C72-4DF289888179") ,
                CompanyCustomerId = Guid.Parse("C5767D53-5FF6-474D-8080-79358E43D1F4") ,
                Description = "Sales and Inventory" ,
                StartDate = DateTime.UtcNow ,
                EndDate = DateTime.UtcNow.AddMonths(3) ,
                Name = "Sales and Inventory" ,
                CreatedById = Guid.Parse(_adminUserId) ,
                CreatedDate = DateTime.UtcNow ,
                ModifiedById = null ,
                ModifiedDate = DateTime.UtcNow ,
                IsActive = true
            };
            context.Projects.Add(entity);
            context.SaveChanges();
        }

        private void CreateCompanyPosition(ProjectContext context) {
            var entity = new CompanyPosition {
                Id = Guid.Parse("D33578DD-27BB-4B9E-9C0C-C2629EAFF5BB") ,
                JobTitle = "Project Manager" ,
                Description = "Project Manager" ,
                Name = "Project Manager" ,
                CreatedById = Guid.Parse(_adminUserId) ,
                CreatedDate = DateTime.UtcNow ,
                ModifiedById = null ,
                ModifiedDate = DateTime.UtcNow ,
                IsActive = true
            };
            context.CompanyPositions.Add(entity);
            context.SaveChanges();

            entity = new CompanyPosition {
                Id = Guid.Parse("EA1DB3C3-32A4-4511-9F61-40C05FD846C7") ,
                JobTitle = "Team Lead" ,
                Description = "Team Lead" ,
                Name = "Team Lead" ,
                CreatedById = Guid.Parse(_adminUserId) ,
                CreatedDate = DateTime.UtcNow ,
                ModifiedById = null ,
                ModifiedDate = DateTime.UtcNow ,
                IsActive = true
            };
            context.CompanyPositions.Add(entity);
            context.SaveChanges();
        }

        private void CreateEmployeeRole(ProjectContext context) {
            var entity = new EmployeeRole {
                Id = Guid.Parse("C320F24E-1BA9-4251-B4ED-341AC7AE77CF") ,
                EmployeeId = Guid.Parse("2C86F2C4-6695-43B9-9C35-305F8D49849A") ,
                CompanyPositionId = Guid.Parse("D33578DD-27BB-4B9E-9C0C-C2629EAFF5BB") ,
                ProjectId = Guid.Parse("401E9CBE-3E6C-4D58-A0FF-C060A25C5DA4") ,
                Name = "Project Manager" ,
                CreatedById = Guid.Parse(_adminUserId) ,
                CreatedDate = DateTime.UtcNow ,
                ModifiedById = null ,
                ModifiedDate = DateTime.UtcNow ,
                IsActive = true
            };
            context.EmployeeRoles.Add(entity);
            context.SaveChanges();

            entity = new EmployeeRole {
                Id = Guid.Parse("66A49E10-85B6-4BAB-8CA5-9D7A6C039F2B") ,
                EmployeeId = Guid.Parse("2F6853E4-09C8-47AE-9166-CFEE627E8981") ,
                CompanyPositionId = Guid.Parse("EA1DB3C3-32A4-4511-9F61-40C05FD846C7") ,
                ProjectId = Guid.Parse("E29EA720-5B78-4CF4-8C72-4DF289888179") ,
                Name = "Team Lead" ,
                CreatedById = Guid.Parse(_adminUserId) ,
                CreatedDate = DateTime.UtcNow ,
                ModifiedById = null ,
                ModifiedDate = DateTime.UtcNow ,
                IsActive = true
            };
            context.EmployeeRoles.Add(entity);
            context.SaveChanges();
        }

        private void CreateMilestone(ProjectContext context) {
            var entity = new Milestone {
                Id = Guid.Parse("8738FEC2-9637-4CAD-AD42-25E475F20EF1") ,
                Name = "Milestone A" ,
                CreatedById = Guid.Parse(_adminUserId) ,
                CreatedDate = DateTime.UtcNow ,
                ModifiedById = null ,
                ModifiedDate = DateTime.UtcNow ,
                IsActive = true
            };
            context.Milestones.Add(entity);
            context.SaveChanges();

            entity = new Milestone {
                Id = Guid.Parse("B6E4EA83-DC4D-451F-A708-C9E5DA45FD70") ,
                Name = "Milestone B" ,
                CreatedById = Guid.Parse(_adminUserId) ,
                CreatedDate = DateTime.UtcNow ,
                ModifiedById = null ,
                ModifiedDate = DateTime.UtcNow ,
                IsActive = true
            };
            context.Milestones.Add(entity);
            context.SaveChanges();
        }

        private void CreateTask(ProjectContext context) {
            var entity = new Task {
                Id = Guid.Parse("1CF1A465-D4E3-46DC-A9ED-D4A19073EAC3") ,
                Name = "Task A" ,
                CreatedById = Guid.Parse(_adminUserId) ,
                CreatedDate = DateTime.UtcNow ,
                ModifiedById = null ,
                ModifiedDate = DateTime.UtcNow ,
                IsActive = true
            };
            context.Tasks.Add(entity);
            context.SaveChanges();

            entity = new Task {
                Id = Guid.Parse("438A6378-B06C-4FAD-AA48-C9FD7780549A") ,
                Name = "Task B" ,
                CreatedById = Guid.Parse(_adminUserId) ,
                CreatedDate = DateTime.UtcNow ,
                ModifiedById = null ,
                ModifiedDate = DateTime.UtcNow ,
                IsActive = true
            };
            context.Tasks.Add(entity);
            context.SaveChanges();
        }
        private void CreateTaskStatus(ProjectContext context) {
            var entity = new TaskStatus {
                Id = Guid.Parse("1C278D2B-5C5A-4286-A8A2-B48A5C30B2AD") ,
                Name = "Done" ,
                CreatedById = Guid.Parse(_adminUserId) ,
                CreatedDate = DateTime.UtcNow ,
                ModifiedById = null ,
                ModifiedDate = DateTime.UtcNow ,
                IsActive = true
            };
            context.TaskStatus.Add(entity);
            context.SaveChanges();

            entity = new Model.TaskStatus {
                Id = Guid.Parse("AEAB5604-BC7E-4A10-B5E3-10E4CF0BDD3B") ,
                Name = "Ongoing" ,
                CreatedById = Guid.Parse(_adminUserId) ,
                CreatedDate = DateTime.UtcNow ,
                ModifiedById = null ,
                ModifiedDate = DateTime.UtcNow ,
                IsActive = true
            };
            context.TaskStatus.Add(entity);
            context.SaveChanges();

            entity = new Model.TaskStatus {
                Id = Guid.Parse("F401DF13-4EAE-44E7-87C9-E947B12E0768") ,
                Name = "OnHold" ,
                CreatedById = Guid.Parse(_adminUserId) ,
                CreatedDate = DateTime.UtcNow ,
                ModifiedById = null ,
                ModifiedDate = DateTime.UtcNow ,
                IsActive = true
            };
            context.TaskStatus.Add(entity);
            context.SaveChanges();
        }

        private void CreateMilestoneTask(ProjectContext context) {
            var entity = new MilestoneTask {
                Id = Guid.Parse("8C247632-720A-4148-BD52-B4D189EE6CBC") ,
                ProjectId = Guid.Parse("401E9CBE-3E6C-4D58-A0FF-C060A25C5DA4") ,
                MilestoneId = Guid.Parse("8738FEC2-9637-4CAD-AD42-25E475F20EF1") ,
                TaskId = Guid.Parse("1CF1A465-D4E3-46DC-A9ED-D4A19073EAC3") ,
                EmployeeId = Guid.Parse("2C86F2C4-6695-43B9-9C35-305F8D49849A") ,
                CompanyPositionId = Guid.Parse("D33578DD-27BB-4B9E-9C0C-C2629EAFF5BB") ,
                TaskStatusId = Guid.Parse("1C278D2B-5C5A-4286-A8A2-B48A5C30B2AD") ,
                StartDate = DateTime.UtcNow ,
                EndDate = DateTime.UtcNow.AddMonths(3) ,
                Name = "Milestone Task" ,
                CreatedById = Guid.Parse(_adminUserId) ,
                CreatedDate = DateTime.UtcNow ,
                ModifiedById = null ,
                ModifiedDate = DateTime.UtcNow ,
                IsActive = true
            };
            context.MilestoneTasks.Add(entity);
            context.SaveChanges();
        }
    }
}
