using System;

BankAccount account = new BankAccount("RU123456789", "Иванов Иван Иванович", 1000, 0.05);

account._accountNumber = "RU12367567410";
account.PrintBalance();
account.Deposit(500);
account.Withdraw(200);
account.ApplyInterest();
account.PrintBalance();


account.Deposit1(5, 10, 20, 50, 30, 40);
account.PrintBalance();

BankAccount a = new BankAccount();
a.PrintBalance();
a._discription = "7869876jhfg";