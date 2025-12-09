namespace AbstractPerson;

public abstract class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName => $"{FirstName} {LastName}";
    public string NationalCode { get; set; }

    public Person(string firstName, string lastName, string nationalCode)
    {
        FirstName = firstName;
        LastName = lastName;
        NationalCode = nationalCode;
    }

    public override string ToString()
    {
        return $"Name: {FullName} | National Code : {NationalCode}";
    }
}
