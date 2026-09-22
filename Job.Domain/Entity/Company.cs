namespace Job.Domain.Entity
{
    public class Company
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Details { get; set; }
        public required string Location { get; set; }

        public int VacancyOpen { get; set; } //Number of vacancies open in the company
    }
}