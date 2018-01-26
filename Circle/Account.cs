using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Account
{
    private String id;
    private String name;
    private int balance = 0;
    
    public Account(String id , String name)
    {
        this.id = id;
        this.name = name;
    }
    public Account(String id, String name, int balance)
    {
    }
    public Account()
    {
        id = "A";
        name = "Ryan";
    }
    public String getID()
    {
        return id;
    }
    public String getName()
    {
        return name;
    }
    public int getBalance()
    {
        return balance;
    }
    public int credit(int amount)
    {
        return balance = balance + amount;
    }
    public int debit(int amount)
    {
        if (amount <= balance)
        {
           balance = balance - amount;
        }
        else
        {
            Console.WriteLine("Amount exceed balance");
        }
        return balance;
    }
    public int transferTo(Account another, int amount)
    {
        if (amount <= balance)
        {
            // Account.another = another + amount; 
        }
        else
        {
            Console.WriteLine("Amount exceeded balance");
        }
        return balance;
    }
    public override String ToString()
    {
        return "Account[id= " + id + " name= " + name + " balance= " + balance + "]";
    }
}
