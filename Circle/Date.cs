using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Date
{

    private int[] day = { 1, 31 };
    private int[] month = { 1, 12 };
    private int[] year = { 1900, 9999 };

    public Date(int[] day, int[] month, int[] year)
    {
        this.day = day;
        this.month = month;
        this.year = year;
    }
    public Date()
    {

    }
    public int[] getDay()
    {
        return day;
    }
    public int[] getMonth()
    {
        return month;
    }
    public int[] getYear()
    {
        return year;
    }
    public void setDay(int[] day)
    {
        this.day = day;
    }
    public void setMonth(int[] month)
    {
        this.month = month;
    }
    public void setYear(int[] year)
    {
        this.year = year;
    }
    public void setDate(int[] day, int[] month, int[] year)
    {
        /// ?
    }
    public new String ToString()
    {
        return "Date[dd" + day +"/mm" + month + "/yyyy" + year + "]"; // ei toimi kunnolla
    }
}
