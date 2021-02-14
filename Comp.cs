using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApp9
{
    public class Comp   // комп. управление в игре 
    {
        // компьютер
        public int[,] myMap = new int[Form1.mapSize, Form1.mapSize];
        // игрок
        public int[,] enemyMap = new int[Form1.mapSize, Form1.mapSize];

        public Button[,] myButtons = new Button[Form1.mapSize, Form1.mapSize];
        public Button[,] enemyButtons = new Button[Form1.mapSize, Form1.mapSize];

        public Comp(int[,] myMap, int[,] enemyMap, Button[,] myButtons, Button[,] enemyButtons)
        {
            this.myMap = myMap;
            this.enemyMap = enemyMap;
            this.enemyButtons = enemyButtons;
            this.myButtons = myButtons;
        }



        public bool IsInsideMap(int i, int j)
        {
            if (i < 0 || j < 0 || i >= Form1.mapSize || j >= Form1.mapSize)
            {
                return false;
            }
            return true;
        }

        public bool IsEmpty(int i, int j, int length)
        {
            bool isEmpty = true;

            for (int k = j; k < j + length; k++)
            {
                if (myMap[i, k] != 0)
                {
                    isEmpty = false;

                    break;
                }
            }

            return isEmpty;

        }

        public int[,] ConfigureShips()
        {
            int lengthShip = 4;
            int cycleValue = 4;
            int shipsCount = 10;
            Random r = new Random();

            int posX = 0;
            int posY = 0;

            while (shipsCount > 0)
            {
                for (int i = 0; i < cycleValue / 4; i++)
                {
                    posX = r.Next(1, Form1.mapSize);
                    posY = r.Next(1, Form1.mapSize);

                    while (!IsInsideMap(posX, posY + lengthShip - 1) || !IsEmpty(posX, posY, lengthShip))
                    {
                        posX = r.Next(1, Form1.mapSize);
                        posY = r.Next(1, Form1.mapSize);
                    }
                    for (int k = posY; k < posY + lengthShip; k++)
                    {
                        myMap[posX, k] = 1;
                    }
                    shipsCount--;
                    if (shipsCount <= 0)
                        break;
                }
                cycleValue += 4;
                lengthShip--;
            }

            return myMap;

        }


    }
}
