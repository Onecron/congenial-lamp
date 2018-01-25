using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TheRectangleClass
{
    private float length;
    private float width;

    public TheRectangleClass()
    {
        length = 3.0f;
        width = 2.0f;
    }
    public TheRectangleClass(float length,float width)
    {
        this.length = length;
        this.width = width;
    }
     public float getLength()
    {
        return this.length;
    }
    public void SetLength(float newlength)
    {
        this.length = newlength;
    }
    public float getWidth()
    {
        return this.width;
    }
    public void SetWidth(float newwidth)
    {
        width = newwidth;
    }
    public double getArea()
    {
        return this.length * this.width;
    }
    public override String ToString()
    {
        return "Rectangle[width=" + width + " length=" + length + "]";
    }

















}