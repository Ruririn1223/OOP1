using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
	internal class SavingAccount: BankAccount
	{
		public SavingAccount(): base( string ownerName, double initialBalance = 0, double interestRate = 0) {
		}
	}
}
