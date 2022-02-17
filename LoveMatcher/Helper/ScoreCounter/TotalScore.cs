using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveMatcher.Helper.ScoreCounter
{
    public class TotalScore
    {
        private int Total;
        //lagrar totala poäng        
        /// <summary>
        /// Calculates the total score.
        /// </summary>
        /// <param name="score">The score.</param>
        /// <returns></returns>
        public int AddToTotal(int score)
        {          
            return Total += score;
        }
    }
}
