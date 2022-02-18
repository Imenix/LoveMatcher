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

        /// <summary>
        /// Controls that the score doesn't go below zero.
        /// </summary>
        /// <param name="score">The score.</param>
        public TotalScore(int score)
        {
            this.Total = score < 0 ? 0 : score;
        }

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
        /// Substracts from total score.
        /// </summary>
        /// <param name="score">The score.</param>
        /// <returns></returns>
        public int SubstractFromTotal(int score)
        {
            return Total -= score;
        }
    }
}
