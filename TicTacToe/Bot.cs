using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Bot
    {
        public int[,] field = {
            {-5,-5,-5},
            {-5,-5,-5},
            {-5,-5,-5},
            };
        public int[] currentMove = new int[2];
        public int[] prevMove = new int[2];
        public bool isDone;

        public void getMove(bool side) //запись хода бота в таблицу
        {
            var rand = new Random();
            isDone = false;
            int index1, index2;
            currentMove[0] = 111;
            currentMove[1] = 111;
            checkBotWin(side);
            if (currentMove[0] != 111 && currentMove[1] != 111)
            {
                isDone = true;
                return;
            }
            checkUserWin(side);

            if (currentMove[0] != 111 && currentMove[1] != 111 && field[currentMove[0],currentMove[1]] == -5)
            {
                isDone = true;
                return;
            }
            else
            {
                if (field[1, 1] == Convert.ToInt32(side))  //если игрок походил в центр
                {
                    isDone = true;
                    if (field[0, 0] == -5) //ход в край, что бы заблокировать выигрышную комбинацию игрока
                    {
                        currentMove[0] = 0;
                        currentMove[1] = 0;
                        return;
                    }
                    do //вариант хода если центр занят игроком
                    {
                        index1 = rand.Next(0, 3);
                        index2 = rand.Next(0, 3);
                    } while (index1 == 1 && index2 == 1 || field[index1, index2] != -5);
                    currentMove[0] = index1;
                    currentMove[1] = index2;
                }
                else if (field[1, 1] != Convert.ToInt32(side) && field[1, 1] == -5) //если игрок походил не в центр
                {
                    isDone = true;
                    currentMove[0] = 1;
                    currentMove[1] = 1;
                }
                if (field[1, 1] != Convert.ToInt32(side) && field[1, 1] == Convert.ToInt32(!side)) //вариант хода,если центр занят ботом
                {
                    isDone = true;
                    do
                    {
                        index1 = rand.Next(0, 3);
                        index2 = rand.Next(0, 3);
                    } while (index1 == 1 && index2 == 1 || field[index1, index2] == Convert.ToInt32(side));
                    currentMove[0] = index1;
                    currentMove[1] = index2;
                }
            }
        }

        public void checkUserWin(bool side) //проверка победы пользователя при следующем ходе
        {
            for (int i = 0, j = 0, k = 2; i < 3; i++)
            {
                if (field[i, j] + field[i, j + 1] + field[i, j + 2] == -5 + Convert.ToInt32(side) * 2)
                {
                    if (field[i, j] == -5)
                    {
                        currentMove[0] = i;
                        currentMove[1] = 0;
                    }
                    else if (field[i, j + 1] == -5)
                    {
                        currentMove[0] = i;
                        currentMove[1] = 1;
                    }
                    else if (field[i, j + 2] == -5)
                    {
                        currentMove[0] = i;
                        currentMove[1] = 2;
                    }
                    isDone = true;

                }
                else if (field[j, i] + field[j + 1, i] + field[j + 2, i] == -5 + Convert.ToInt32(side) * 2)
                {
                    if (field[j, i] == -5)
                    {
                        currentMove[0] = 0;
                        currentMove[1] = i;
                    }
                    else if (field[j + 1, i] == -5)
                    {
                        currentMove[0] = 1;
                        currentMove[1] = i;
                    }
                    else if (field[j + 2, i] == -5)
                    {
                        currentMove[0] = 2;
                        currentMove[1] = i;
                    }
                    isDone = true;
                }
                else if (field[j, j] + field[j + 1, j + 1] + field[j + 2, j + 2] == -5 + Convert.ToInt32(side) * 2)
                {
                    if (field[i, i] == -5)
                    {
                        currentMove[0] = i;
                        currentMove[1] = i;
                    }
                    isDone = true;
                }
                else if (field[j, k] + field[k - 1, k - 1] + field[k, j] == -5 + Convert.ToInt32(side) * 2)
                {
                    if (field[j, k] == -5)
                    {
                        currentMove[0] = j;
                        currentMove[1] = k;
                    }
                    else if (field[k - 1, k - 1] == -5)
                    {
                        currentMove[0] = k - 1;
                        currentMove[1] = k - 1;
                    }
                    else if (field[k, j] == -5)
                    {
                        currentMove[0] = k;
                        currentMove[1] = j;
                    }
                    isDone = true;
                }
            }
        }

        public void checkBotWin(bool side) //проверка победы бота при следующем ходе
        {
            for (int i = 0, j = 0, k = 2; i < 3; i++)
            {
                if (field[i, j] + field[i, j + 1] + field[i, j + 2] == -5 + Convert.ToInt32(!side) * 2)
                {
                    if (field[i, j] == -5)
                    {
                        currentMove[0] = i;
                        currentMove[1] = 0;
                    }
                    else if (field[i, j + 1] == -5)
                    {
                        currentMove[0] = i;
                        currentMove[1] = 1;
                    }
                    else if (field[i, j + 2] == -5)
                    {
                        currentMove[0] = i;
                        currentMove[1] = 2;
                    }
                    isDone = true;

                }
                else if (field[j, i] + field[j + 1, i] + field[j + 2, i] == -5 + Convert.ToInt32(!side) * 2)
                {
                    if (field[j, i] == -5)
                    {
                        currentMove[0] = 0;
                        currentMove[1] = i;
                    }
                    else if (field[j + 1, i] == -5)
                    {
                        currentMove[0] = 1;
                        currentMove[1] = i;
                    }
                    else if (field[j + 2, i] == -5)
                    {
                        currentMove[0] = 2;
                        currentMove[1] = i;
                    }
                    isDone = true;
                }
                else if (field[j, j] + field[j + 1, j + 1] + field[j + 2, j + 2] == -5 + Convert.ToInt32(!side) * 2)
                {
                    if (field[i, i] == -5)
                    {
                        currentMove[0] = i;
                        currentMove[1] = i;
                    }
                    isDone = true;
                }
                else if (field[j, k] + field[k - 1, k - 1] + field[k, j] == -5 + Convert.ToInt32(!side) * 2)
                {
                    if (field[j, k] == -5)
                    {
                        currentMove[0] = j;
                        currentMove[1] = k;
                    }
                    else if (field[k - 1, k - 1] == -5)
                    {
                        currentMove[0] = k - 1;
                        currentMove[1] = k - 1;
                    }
                    else if (field[k, j] == -5)
                    {
                        currentMove[0] = k;
                        currentMove[1] = j;
                    }
                    isDone = true;
                }
            }
        }
    }
}
