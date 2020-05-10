using GameTop.Interface;

namespace GameTop.Lib
{
    public class Player_1 : iPlayer
    {
        public readonly string _Name;

        public Player_1(string name = "Roberto")
        {
            _Name = name;
        }

        //kick
        public string Kick()
        {
            return $"{_Name} it is kick \n";
        }
        //run
        public string Run()
        {
            return $"{_Name} it is run \n";
        }
        //pass
        public string Pass()
        {
            return $"{_Name} it is pass \n";
        }
    }
}