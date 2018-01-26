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
    public int transferTo()
    
}
