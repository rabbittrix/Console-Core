using GameTop.Interface;

namespace GameTop.Lib
{
  public class Player_2 : iPlayer
  {
    public string Kick()
    {
      return "\nRonaldinho it is kick \n";
    }

    public string Pass()
    {
      return "Ronaldinho it is pass \n";
    }

    public string Run()
    {
      return "Ronaldinho it is run \n";
    }
  }
}