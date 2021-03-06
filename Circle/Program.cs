﻿using System;

public class TestCircle
{  // Save as "TestCircle.java"
    public static void Main(String[] args)
    {
        // Declare an instance of Circle class called c1.
        // Construct the instance c1 by invoking the "default" constructor
        // which sets its radius and color to their default value.
        Circle c1 = new Circle();
        // Invoke public methods on instance c1, via dot operator.
        Console.WriteLine("The circle has radius of "
           + c1.getRadius() + " and area of " + c1.getArea());

        // Declare an instance of class circle called c2.
        // Construct the instance c2 by invoking the second constructor
        // with the given radius and default color.
        Circle c2 = new Circle(2.0);
        // Invoke public methods on instance c2, via dot operator.
        Console.WriteLine("The circle has radius of "
           + c2.getRadius() + " and area of " + c2.getArea());

        Circle c3 = new Circle(2.0);

        Console.WriteLine("The circle has radius of "
            + c2.getRadius() + " and area of " + c2.getArea() + " and color of " + c2.getColor());

        Circle c4 = new Circle();   // construct an instance of Circle
        c4.setRadius(5.0);          // change radius
        c4.setColor("blue");        // Change color
        Console.WriteLine("The circle has radius is: " + c4.getRadius() + // Print radius via getter
        " and the circle color is: " + c4.getColor());  // Print color via getter

        // You cannot do the following because setRadius() returns void,
        // which cannot be printed.
        // Console.WriteLine(c4.setRadius(4.0));
        Circle c5 = new Circle(5.0);
        Console.WriteLine(c1.ToString());   // explicit call

        Circle c6 = new Circle(1.2);
        Console.WriteLine(c2.ToString());  // explicit call
        Console.WriteLine(c2);             // println() calls toString() implicitly, same as above
        Console.WriteLine("Operator '+' invokes toString() too: " + c2);  // '+' invokes toString() too
        Console.WriteLine();

        TheRectangleClass r1 = new TheRectangleClass();
        r1.SetWidth(4.0f);
        Console.WriteLine(r1.ToString() + "Area = " + r1.getArea());

        Console.WriteLine();

        EmployeeClass e1 = new EmployeeClass();
        e1.setSalary(5000);
        Console.WriteLine(e1.ToString());
        Console.WriteLine("Annual salary " + e1.getAnnualSalary());

        Console.WriteLine();

        InvoiceItem i1 = new InvoiceItem();
        i1.setQty(33);
        i1.setUnitPrice(440);
        Console.WriteLine("ID is = " + i1.getID() + " Desc is = " + i1.getDesc());
        Console.WriteLine("Total is = " + i1.getTotal());
        Console.WriteLine(i1.ToString());

        Console.WriteLine();

        Account a1 = new Account();
        Console.WriteLine("ID is = " + a1.getID() + " Name is = " + a1.getName());
        Console.WriteLine("Balance is = " + a1.getBalance());
        Console.WriteLine(a1.ToString());

        Console.WriteLine();

        Date d1 = new Date();
        Console.WriteLine("Day is = " + d1.getDay()); // Work in progress
        Console.WriteLine(d1.ToString());

        Console.WriteLine();

        Time t1 = new Time();
        Console.WriteLine("hour is =" + t1.gethour()); // ei toimi
        Console.WriteLine(t1.ToString());


    }
} 
