using System;

public class EmailValidator : IValidator
{
    private string email;

    public EmailValidator(string email)
    {
        this.email = email;
    }

    public bool Validate()
    {
        return email.Contains("@") && email.Contains(".");
    }
}
