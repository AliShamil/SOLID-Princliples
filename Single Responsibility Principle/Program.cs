using System.Data;
using System.Numerics;
using System.Security.Principal;

#region Before

//public class BankAccount
//{
//    public BankAccount() { }

//    public string AccountNumber { get; set; }
//    public decimal AccountBalance { get; set; }

//    public decimal CalculateInterest()
//    {
//        // Code to calculate Interest
//        return Math.Round(AccountBalance);
//    }
//}

#endregion

//Here, BankAccount class comprises the properties of the account and computes the interest of the account.
//Now, look at the change Request we received from the business:

//Please implement a new Property AccountHolderName.
//Some new rule has been incorporated to calculate interest.

//These are very different kinds of change requests. One is changing features while the other one is affecting the functionality.
//We have 2 separate kinds of reasons to change one class, which violates SRP.


#region After

//public interface IBankAccount
//{
//    string AccountNumber { get; set; }
//    decimal AccountBalance { get; set; }
//}

//public interface IInterstCalculator
//{
//    decimal CalculateInterest();
//}

//public class BankAccount : IBankAccount
//{
//    public string AccountNumber { get; set; }
//    public decimal AccountBalance { get; set; }
//}

//public class InterstCalculator : IInterstCalculator
//{
//    public decimal CalculateInterest(IBankAccount account)
//    {
//        // Write your logic here
//        return 1000;
//    }

//    public decimal CalculateInterest()
//    {
//        throw new NotImplementedException();
//    }
//}

#endregion

//Our BankAccount class is just responsible for the properties of the bank account.If we wish to incorporate any additional business rule for the Calculation of Interest,
//we don’t require to change BankAccount class. Also InterestCalculator class needs no changes, in case we have to add a new Property AccountHolderName. 