using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Logic
    {
        public int[,] field = {
            {-5,-5,-5},
            {-5,-5,-5},
            {-5,-5,-5},
            };

        public bool win(bool side)
        {
            if (field[0, 0] + field[0, 1] + field[0, 2] == Convert.ToInt32(side) * 3 ||
                field[1, 0] + field[1, 1] + field[1, 2] == Convert.ToInt32(side) * 3 ||
                field[2, 0] + field[2, 1] + field[2, 2] == Convert.ToInt32(side) * 3 ||
                field[0, 0] + field[1, 0] + field[2, 0] == Convert.ToInt32(side) * 3 ||
                field[0, 1] + field[1, 1] + field[2, 1] == Convert.ToInt32(side) * 3 ||
                field[0, 2] + field[1, 2] + field[2, 2] == Convert.ToInt32(side) * 3 ||
                field[0, 0] + field[1, 1] + field[2, 2] == Convert.ToInt32(side) * 3 ||
                field[0, 2] + field[1, 1] + field[2, 0] == Convert.ToInt32(side) * 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
