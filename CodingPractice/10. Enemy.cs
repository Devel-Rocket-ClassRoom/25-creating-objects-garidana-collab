using System;
using System.Collections.Generic;
using System.Text;

class Enemy
{
    public string Name;
    public int Health;
    
    public void ShowInfo()
    {
        Console.WriteLine($"{Name}: HP: {Health}");
    }
}