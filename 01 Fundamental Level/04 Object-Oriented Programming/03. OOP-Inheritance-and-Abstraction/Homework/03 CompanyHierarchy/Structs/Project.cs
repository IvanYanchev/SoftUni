using System;

namespace CompanyHierarchy.Structs
{
    public class Project
    {
        private string projectName;
        private DateTime projectStartDate;
        private string projectDetails;
        private State projectState;

        public Project(string name, DateTime startDate, string details)
        {
            this.ProjectName = name;
            this.ProjectStartDate = startDate;
            this.ProjectDetails = details;
            this.ProjectState = State.Open;
        }

        public string ProjectName { get; set; }
        public DateTime ProjectStartDate { get; set; }
        public string ProjectDetails { get; set; }
        public State ProjectState
        {
            get
            {
                return this.projectState;
            }
            private set
            {
                this.projectState = value;
            }
        }

        public void CloseProject()
        {
            this.ProjectState = State.Closed;
        }

        public override string ToString()
        {
            return string.Format("Project name: {0}, Start date: {1}, Project state: {2}, Details: {3}\r\n", this.ProjectName, this.ProjectStartDate.ToShortDateString(), this.ProjectState, this.ProjectDetails);
        }
    }
}
