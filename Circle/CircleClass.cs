using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * The Circle class models a circle with a radius and color.
 */
public class Circle {  // Save as "Circle.java"
   // private instance variable, not accessible from outside this class
   private double radius;
   private String color;
   
   // The default constructor with no argument.
   // It sets the radius and color to their default value.
   public Circle() {
      radius = 1.0;
      color = "red";
   }
   
   // 2nd constructor with given radius, but color default
   public Circle(double radius) {
      this.radius = radius;
      this.color = "red";
   }
    public Circle(double radius, string color)
    {
        this.radius = radius;
        this.color = "red";
    }
   
   // A public method for retrieving the radius
   public double getRadius() {
     return this.radius; 
   }
   
   // A public method for computing the area of circle
   public double getArea() {
      return this.radius*this.radius*Math.PI;
   }

    public String getColor()
    {
        return color;
    }
    // Setter for instance variable radius
    public void setRadius(double newRadius)
    {
        this.radius = newRadius;
    }

    // Setter for instance variable color
    public void setColor(String newColor)
    {
        this.color = newColor;
    }
    // Return a description of this instance in the form of
    // Circle[radius=r,color=c]
    public override String ToString()
    {
        return "Circle[radius=" + radius + " color=" + color + "]";
    }
}
