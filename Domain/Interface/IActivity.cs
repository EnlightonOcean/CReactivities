namespace Domain.Interface;
public interface IActivity
{
    Guid Id { get; set; }
    string Title { get; set; }
    DateTime Date { get; set; }
    string Description { get; set; }
    string Category { get; set; }
    string City { get; set; }
    string Venue { get; set; }
}
