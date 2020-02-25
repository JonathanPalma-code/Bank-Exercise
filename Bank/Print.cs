using System;

namespace Bank {
	class Print {
		static void Main(string[] args) {
			Console.WriteLine("To create an account we will need you to fill those details:");
			Console.Write("- Account number: ");
			int accountId = int.Parse(Console.ReadLine());
			Console.Write("- Full name: ");
			string name = Console.ReadLine();
			Console.Write("- Deposit? (y/n): ");
			string deposit = Console.ReadLine();

			DepositAnswer(deposit);

			Account account = new Account(accountId, name) {
					Deposit = deposit
			};
			Console.WriteLine("\n" + account);
			Console.Write("Enter an amount to deposit: ");
			account.DepositAmount(double.Parse(Console.ReadLine()));
			Console.WriteLine("\n" + account);
			Console.Write("Enter an amount to withdraw: ");
			account.WithdrawAmount(double.Parse(Console.ReadLine()));
			Console.WriteLine("\n" + account);
		}
		static void DepositAnswer(string deposit) {
			while (deposit != "y" && deposit != "n") {
				Console.WriteLine("Invalid Operation, " +
					"please insert 'y' for yes and 'n' for no.");
				deposit = Console.ReadLine();
			}
		}
	}
}
