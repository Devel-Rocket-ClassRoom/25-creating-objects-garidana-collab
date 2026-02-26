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

class Item1
{
    public string Name1;
    public int Price1;

    public override string ToString()
    {
        return $"{Name1}: {Price1}골드";
    }
}