using System;
using System.Collections.Generic;
using System.Text;

class Item
{
    public string Name;
    public int Price;

    public override string ToString()
    {
        return $"[아이템] {Name} - {Price}골드";
    }
}