using System.Collections.Generic;

namespace catchDuckGame
{

    public class GameDifficulty
    {
        private static Dictionary<int, int> levelRequirements = new Dictionary<int, int>()
    {
        { 1, 5 },
        { 2, 10 },
        { 3, 20 },
        { 4, 40 },
     
    };



        public static bool isLvlUp(int score, int lvlDifficulty)
        {
            if (score >= levelRequirements[lvlDifficulty]) { return true; }
            return false;
        }



    }

}
