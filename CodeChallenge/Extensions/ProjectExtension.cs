using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge.Extensions
{
    internal static class ProjectExtension
    {
        public static Models.Project ToControllerProject(this Application.Model.Project project)
        {
            return new Models.Project()
            {
                Employee = project.Employee.ToControllerEmployee(),
                EndDate = project.EndDate,
                StartDate = project.StartDate,
                ProjectId = project.ProjectId
            };
        }

        public static IEnumerable<Models.Project> ToControllerProject(this IEnumerable<Application.Model.Project> projects)
        {
            return projects.Select(ToControllerProject);
        }
    }
}
