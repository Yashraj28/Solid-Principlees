// Each class has ONE responsibility

// Responsibility 1: Hold user data
public class User
{
    public string Name { get; set; }
    public string Email { get; set; }
}

// Responsibility 2: Validate user data
public class UserValidator
{
    public bool ValidateEmail(string email)
    {
        return email.Contains("@");
    }
}

// Responsibility 3: Handle database operations
public class UserRepository
{
    public void Save(User user)
    {
        Console.WriteLine($"Saving {user.Name} to database...");
    }
}

// Responsibility 4: Send emails
public class EmailService
{
    public void SendWelcomeEmail(User user)
    {
        Console.WriteLine($"Sending welcome email to {user.Email}");
    }
}

// Responsibility 5: Generate reports
public class UserReportGenerator
{
    public string GenerateReport(User user)
    {
        return $"User Report: {user.Name} - {user.Email}";
    }
}

// Usage
public class Program
{
    public static void Main()
    {
        var user = new User { Name = "John", Email = "john@example.com" };
        
        var validator = new UserValidator();
        var repository = new UserRepository();
        var emailService = new EmailService();
        var reportGenerator = new UserReportGenerator();
        
        if (validator.ValidateEmail(user.Email))
        {
            repository.Save(user);
            emailService.SendWelcomeEmail(user);
            string report = reportGenerator.GenerateReport(user);
            Console.WriteLine(report);
        }
    }
}