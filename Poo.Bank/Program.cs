using System.Threading.Channels;
using Poo.Bank;

var account1 = new BankAccount("Leandro", 1000);
var account2 = new BankAccount("Michele", 2000);

account1.MakeDeposit(500, DateTime.Now, "Aluguel");
account1.MakeWithdrawal(100, DateTime.Now, "Cana");


Console.WriteLine($"Account {account1.Number} was created for {account1.Owner} with {account1.Balance} initial balance.");
Console.WriteLine($"Account {account2.Number} was created for {account2.Owner} with {account2.Balance} initial balance.");
Console.WriteLine(account1.Balance);