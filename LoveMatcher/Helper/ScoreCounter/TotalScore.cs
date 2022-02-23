using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveMatcher.Helper.ScoreCounter
{
    public class TotalScore
    {
        public int Total { get; set; } = 50;

        //lagrar totala poäng        
        /// <summary>
        /// Adds to the total score.
        /// </summary>
        /// <param name="score">The score.</param>
        /// <returns></returns>
        public int AddToTotal(int score)
        {
            return Total += score;
        }

        /// <summary>
        /// Substracts from total score and controls that the score is not negative
        /// </summary>
        /// <param name="score">The score.</param>
        /// <returns></returns>
        public int SubstractFromTotal(int score)
        {
            Total -= score;
            return Total < 0 ? Total = 0 : Total;
        }
    }
}
