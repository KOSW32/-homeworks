public class PasswordValidator : IValidator
{
    private string password;

    public PasswordValidator(string password)
    {
        this.password = password;
    }

    public bool Validate()
    {
        return password.Length >= 6;
    }
}
