using System;
using System.Collections.Generic;
using System.Text;

class GameManager
{
    static int TotalPlayers;
    string PlayerName;

    public static void ShowStatus(int totalplayers)
    {
        TotalPlayers = totalplayers;
        Console.WriteLine($"[정적] 총 플레이어 수: {TotalPlayers}");
    }

    public void Greet(string playername)
    {
        PlayerName = playername;
        Console.WriteLine($"[인스턴스] 안녕하세요, {PlayerName}님!");
    }
}
