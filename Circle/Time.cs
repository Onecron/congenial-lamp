using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Time
{
    private int[] hour = { 0, 23 };
    private int[] minute = { 0, 59 };
    private int[] second = { 0, 59 };

    public int[] gethour()
    {
        return hour;
    }
    public int[] getMinute()
    {
        return minute;
    }

    public int[] getSecond()
    {
        return second;
    }
    public void setHour(int[] hour)
    {
        this.hour = hour;
    }
    public void setMinute(int[] minute)
    {
        this.minute = minute;
    }
    public void setSecond(int[] second)
    {
        this.second = second;
    }
    public void setTime(int[] hour, int[] minute, int[] second)
    {
        this.hour = hour;
        this.minute = minute;
        this.second = second;
    }
    public new String ToString()
    {
        return "time[hour " + hour + "minute" + minute + "second" + second + "]"; // ei toimi kunnolla
    }
}
