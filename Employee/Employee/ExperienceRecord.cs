using System;

namespace CQRS.Employee.Domain
{
    internal class ExperienceRecord
    {
        public ExperienceRecord(
            string role,
            string projectName,
            string description,
            DateTime startDate,
            DateTime endDate)
        {
            Role = role;
            ProjectName = projectName;
            Description = description;
            StartDate = startDate;
            EndDate = endDate;
        }
        public string Role { get; }

        public string ProjectName { get; set; }

        public string Description { get; }

        public DateTime StartDate { get; }

        public DateTime EndDate { get; }
    }
}