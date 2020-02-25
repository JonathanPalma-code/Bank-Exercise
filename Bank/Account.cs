using System;

namespace Bank {
  class Account {
		
		private string _header = "Account Details";
		private int _taxWithdraw = 5;
		public int AccountId { get; private set; }
		public string Name { get; set; }
		public double Amount { get; private set; }

		public Account (int accountId, string name) {
			AccountId = accountId;
			Name = name;
		}

		public string Deposit {
			set {
				if (value.Equals("y")) {
					Console.Write("     Enter a deposit: ");
					Amount = double.Parse(Console.ReadLine());
				}
			}
		}

		public void DepositAmount(double amount) {
			_header = "Account details updated";
			Amount += amount;
		}

		public void WithdrawAmount(double amount) {
			_header = "Account details updated";
			Amount -= amount + _taxWithdraw;
		}

		public override string ToString() {
      string h = _header +
      $"\nAccount Number: {AccountId},";
      string h1 = h +
			$" Titular Account: {Name},";
      string h2 = h1 +
      $" Montant: £{Amount.ToString("F2")}\n";
      var result = h2;
      return result;
		}
  }
}
