namespace Library.Domain.Entities;

public class Borrower
{
    public long Id { get; set; }

    public string Name { get; set; }

    public string Email { get; set; }

    public Borrower(long id, string name, string email)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentNullException("Name cannot be empty.");

        if (string.IsNullOrWhiteSpace(email))
            throw new ArgumentNullException("Email cannot be empty.");

        Id = id;
        Name = name;
        Email = email;
    }
}
