using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.SqlDAL.Extensions
{
    internal static class ProjectExtension
    {
        public static Domain.Model.DomainProject ToDomainProject(this Infrastructure.SqlDAL.Model.InfrastructureProject project)
        {
            return new Domain.Model.DomainProject()
            {
                Employee = project.Employee.ToDomainEmployee(),
                EndDate = project.EndDate,
                StartDate = project.StartDate,
                ProjectId = project.ProjectId
            };
        }

        public static Infrastructure.SqlDAL.Model.InfrastructureProject ToInfrastructureProject(this Domain.Model.DomainProject project)
        {
            return new Infrastructure.SqlDAL.Model.InfrastructureProject()
            {
                Employee = project.Employee.ToInfrastructureEmployee(),
                EndDate = project.EndDate,
                StartDate = project.StartDate,
                ProjectId = project.ProjectId
            };
        }

        public static IEnumerable<Domain.Model.DomainProject> ToDomainProject(this IEnumerable<Infrastructure.SqlDAL.Model.InfrastructureProject> projects)
        {
            return projects.Select(ToDomainProject);
        }

        public static IEnumerable<Infrastructure.SqlDAL.Model.InfrastructureProject> ToInfrastructureProject(this IEnumerable<Domain.Model.DomainProject> projects)
        {
            return projects.Select(ToInfrastructureProject);
        }
    }
}
