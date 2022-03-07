using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Tyler Lee 3/7/2022
namespace CRPG
{
    class Program
    {
        private static Player _player = new Player();

        static void Main(string[] args)
        {
            GameEngine.Initialize();
            _player.Name = "Fred the Fearless";

            Console.ReadLine();
        }
    }
}
