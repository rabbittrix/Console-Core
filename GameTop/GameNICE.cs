using GameTop.Interface;

namespace GameTop
{
    public class GameNICE{
    private readonly iPlayer _player_1;
    private readonly iPlayer _player_2;

    public GameNICE(iPlayer player_1, iPlayer player_2)
        {
      _player_1 = player_1;
      _player_2 = player_2;
    }
    public void StartGame(){
        System.Console.Write(_player_1.Kick());
        System.Console.Write(_player_1.Run());
        System.Console.Write(_player_1.Pass());

        System.Console.Write(" \n NEXT PLAYER \n");
        
        System.Console.Write(_player_2.Kick());
        System.Console.Write(_player_2.Run());
        System.Console.Write(_player_2.Pass());
      
        }
    }
}