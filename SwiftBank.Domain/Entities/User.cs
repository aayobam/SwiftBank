using SwiftBank.Domain.Entities.Common;

namespace SwiftBank.Domain.Entities;

public class User: BaseEntity
{
   public string FirstName { get; set; } = string.Empty;
   public string LastName { get; set; } = string.Empty;
   public DateOnly DateOfBirth { get; set; }
   
   public Account? Account { get; set; }
   public string? AccountId { get; set; }
   
   public Transaction? Transaction { get; set; }
   public string? TransactionId { get; set; }

   public Loan? Loan { get; set; }
   public string? LoanId { get; set; }
}
