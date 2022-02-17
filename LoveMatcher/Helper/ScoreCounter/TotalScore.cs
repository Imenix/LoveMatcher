using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveMatcher.Helper.ScoreCounter
{
    public class TotalScore
    {
        //lagrar totala poäng
        public int Score(int score)
        {
            int total;
            total+= score;
            return total;
        }

        public int AddScore(int score)
        {
            Score(score);
        }
    }
}
