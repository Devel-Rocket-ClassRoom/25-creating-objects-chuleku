using System;

Console.WriteLine("=== 계좌 개설 ===");
BankAccount Ba = new BankAccount("홍길동", "[1001]",100000);
BankAccount Ba1 = new BankAccount("이순신", "[1002]",50000);
BankAccount.ShowTotalAccounts();
Console.WriteLine();
Console.WriteLine("=== 거래 ===");
Ba.Deposit(50000);
Ba1.Deposit(30000);
Ba.Withdraw(200000);
Ba.Withdraw(100000);
Console.WriteLine();
Console.WriteLine("=== 최종 계좌 정보 ===");
Ba.ShowInfo();
Ba1.ShowInfo();

class BankAccount
{
    private static int TotalAccounts;
    private string AccountNumber;
    private string OwnerName;
    private int Balance;

    public BankAccount(string name,string accountnumber,int money)
    {
        TotalAccounts++;
        AccountNumber = accountnumber;
        OwnerName = name;
        Balance = money;
        Console.WriteLine($"{AccountNumber} {OwnerName} 계좌가 개설되었습니다.");
    }
    public void Deposit(int amount)
    {
        Balance += amount;
        Console.WriteLine($"{AccountNumber} {amount}원 입금 완료. 잔액: {Balance}");
    }
    public void Withdraw(int amount)
    {
        if(Balance >=amount)
        {
            Balance -= amount;
            Console.WriteLine($"{AccountNumber} {amount}원 출금 완료. 잔액: {Balance}");
        }
        else
        {
            Console.WriteLine($"{AccountNumber} {amount}원 출금 실패. 잔액이 부족합니다.");
        }
    }
    public static void ShowTotalAccounts()
    {
        Console.WriteLine($"현재 총 계좌 수: {TotalAccounts}개");
    }
    public void ShowInfo()
    {
        Console.WriteLine($"계좌번호: {AccountNumber}, 예금주: {OwnerName}, 잔액: {Balance}원");
    }
}
