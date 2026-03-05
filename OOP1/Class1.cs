using System;

public class BankAccount
{
    public string _accountNumber { get; set; }
    private string _ownerName { get; set; }
    private double _balance { get; set; }
	private double _interestRate { get; set; }
    public string _discription { get; set; }

	public BankAccount(string accountNumber, string ownerName, double initialBalance = 0, double interestRate = 0)
    {
        _accountNumber = accountNumber;
        _ownerName = ownerName;
        _balance = initialBalance >= 0 ? initialBalance : throw new ArgumentException("Начальный баланс не может быть отрицательным.");
        _interestRate = interestRate >= 0 ? interestRate : throw new ArgumentException("Процентная ставка не может быть отрицательной.");
    }
    public BankAccount() {
		_accountNumber = "RU00000000000";
		_ownerName = "Неизвестно";
        _balance = 1200;
		_interestRate = 0.05;
	}


	public void Deposit( double amount)
    {

        if (amount <= 0)
            throw new ArgumentException("Сумма пополнения должна быть положительной.");
        _balance += amount;
    }

	public void Deposit1(int c, params double[] amount)
	{
        for (int i = 0; i < c; i++) {
			if (amount[i] <= 0)
				throw new ArgumentException("Сумма пополнения должна быть положительной.");
			_balance += amount[i];
		}
	}

	public void Withdraw(double amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Сумма снятия должна быть положительной.");
        if (amount > _balance)
            throw new InvalidOperationException("Недостаточно средств на счёте.");
        _balance -= amount;
    }

    public void ApplyInterest()
    {
        _balance += _balance * _interestRate;
    }

    public void PrintBalance()
    {
        Console.WriteLine($"Счёт: {_accountNumber}");
        Console.WriteLine($"Владелец: {_ownerName}");
        Console.WriteLine($"Текущий баланс: {_balance}");
    }
}