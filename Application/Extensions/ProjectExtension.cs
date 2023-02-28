namespace Application.Extensions
{
    internal static class ProjectExtension
    {
        public static Application.Model.Project ToApplicationProject(this Domain.Model.DomainProject project)
        {
            return new Application.Model.Project()
            {
                Employee = project.Employee.ToApplicationEmployee(),
                EndDate = project.EndDate,
                StartDate = project.StartDate,
                ProjectId = project.ProjectId
            };
        }

        public static IEnumerable<Application.Model.Project> ToApplicationProject(this IEnumerable<Domain.Model.DomainProject> projects)
        {
            return projects.Select(ToApplicationProject);
        }
    }
}
