namespace ClassesPract.Class;

public class Passport
{
    public string FullName { get; set; }
    public string PassportNumber { get; set; }
    public string? DateOfIssue { get; set; }

    public Passport(string fullName, string passportNumber, string dateOfIssue)
    {
        if (string.IsNullOrWhiteSpace(passportNumber))
        {
            throw new ArgumentException("Passport number cannot be null or empty.");
        }

        if (string.IsNullOrWhiteSpace(fullName))
        {
            throw new ArgumentException("Full name cannot be null or empty.");
        }

        if (!DateTime.TryParse(dateOfIssue, out var parsedDate))
        {
            throw new ArgumentException("Invalid date format.");
        }
        if (parsedDate > DateTime.Now)
        {
            throw new ArgumentException("Date of issue cannot be in the future.");
        }
        FullName = fullName;
        PassportNumber = passportNumber;
        DateOfIssue = dateOfIssue;
    }
}