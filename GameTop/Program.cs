using System;
using GameTop.Lib;

namespace GameTop
{
    class Program
    {
        static void Main(string[] args)
        {
            var Game = new GameNICE(new Player_1("Roberto"), new Player_2());
            Game.StartGame();
        }
    } 
    
}
