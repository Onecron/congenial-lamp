using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class InvoiceItem
{
    private String id;
    private String desc;
    private int qty;
    private double unitPrice;
    
    public InvoiceItem(String id, String desc, int qty, double unitPrice)
    {
        this.id = id;
        this.desc = desc;
        this.qty = qty;
        this.unitPrice = unitPrice;
    }
    public InvoiceItem()
    {
        id = "A";
        desc = "Book";
    }
    public String getID()
    {
        return this.id;
    }
    public String getDesc()
    {
        return this.desc;
    }

    public int getQty()
    {
        return this.qty;
    }
    public void setQty(int newqty)
    {
        this.qty = newqty;
    }
    public double getUnitPrice()
    {
        return this.unitPrice;
    }
    public void setUnitPrice(double newunitPrice)
    {
        this.unitPrice = newunitPrice;
    }
    public double getTotal()
    {
        return this.unitPrice * qty;
    }
    public override String ToString()
    {
        return "InvoiceItem[id= " + id + " desc= " + desc + " qty= " + qty + " unitprice= " + unitPrice + "]";
    }
}
