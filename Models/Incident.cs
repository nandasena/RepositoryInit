namespace RepositoryInit.Models
{
    public class Incident
    {
        public int IncidentId { get; set; }

        public string IncidentCode { get; set; }

        public string IncidentTitle { get; set; }

        public string IncidentDescription { get; set; }

        public DateTime InvestigationDueDate { get; set; }

        public DateTime ReportedDate { get; set; }
    }
}
