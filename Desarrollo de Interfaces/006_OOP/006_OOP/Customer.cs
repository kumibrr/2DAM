using System;

namespace _006_OOP
{
    public class Customer
    {
        public string name;
        public double money;

        public Customer(string name, double money)
        {
            this.name = name;
            this.money = money;
        }

        public void Deposit(double cashToAdd)
        {
            money += cashToAdd;
        }

        public void Withdraw(double cashToWithdraw)
        {
            money -= cashToWithdraw;
        }

        public String getCash()
        {
            return $"{money}";
        }
    }
}