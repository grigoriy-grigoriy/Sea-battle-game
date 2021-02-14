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
        




    }
}
