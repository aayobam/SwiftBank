namespace SwiftBank.Domain.Entities;

public class User
{
   public string FirstName { get; set; } = null!;
   public string LastName { get; set; } = null!;
   public DateOnly DateOfBirth { get; set; }
   public DateTime DateCreated { get; set; }
   public DateTime DateModified { get; set; }
   public Account? AccountId { get; set; }
   public Transaction? TransactionId { get; set; }
   public Loan? LoanId { get; set; }
}
