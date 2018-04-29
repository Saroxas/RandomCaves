using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomCaves
{
    public partial class FormMain : Form
    {
        int xArrayDimension = 35;
        int yArrayDimension = 35;
        int wallChance = 40;

        int minIteration = 4;
        int numWallsWhenWall = 4;
        int numWallsWhenEmpty = 5;

        MapGenerator map;


        public FormMain()
        {
            InitializeComponent();
            numericUpDownXLength.Value = xArrayDimension;
            numericUpDownYLength.Value = yArrayDimension;
            numericUpDownWallChance.Value = wallChance;
            numericUpDownMinIteration.Value = minIteration;
            numericUpDownNumWallsWhenWall.Value = numWallsWhenWall;
            numericUpDownNumWallsWhenEmpty.Value = numWallsWhenEmpty;

            map = new MapGenerator(xArrayDimension, yArrayDimension, wallChance, minIteration, numWallsWhenWall, numWallsWhenEmpty);

            writeMap();
        }

        private void buttonGenerateNewMap_Click(object sender, EventArgs e)
        {
            //generate map
            map = new MapGenerator(xArrayDimension, yArrayDimension, wallChance, minIteration, numWallsWhenWall, numWallsWhenEmpty);
            writeMap();
            //profit
        }
        
        private void numericUpDownXLength_ValueChanged(object sender, EventArgs e)
        {
            xArrayDimension = Decimal.ToInt32(numericUpDownXLength.Value);
        }

        private void numericUpDownYLength_ValueChanged(object sender, EventArgs e)
        {
            yArrayDimension = Decimal.ToInt32(numericUpDownYLength.Value);
        }
        
        private void numericUpDownWallChance_ValueChanged(object sender, EventArgs e)
        {
            wallChance = Decimal.ToInt32(numericUpDownWallChance.Value);
        }


        private void writeMap()
        {
            richTextBoxMap.Clear();

            int[,] placeHolderMap = map.Map;
            for(int i = 0; i < map.MapWidth; i++)
            {
                string mapLine = "";

                for(int j = 0; j < map.MapHeight; j++)
                {
                    if(placeHolderMap[i, j] == 1)
                    {
                        mapLine += "# ";
                    }
                    else
                    {
                        mapLine += ". ";
                    }
                    
                }

                richTextBoxMap.Text += mapLine + Environment.NewLine;
            }
        }

        private void buttonIterateMap_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 5; i++)
            {
                map.MakeCaverns();
                map.Iteration = map.Iteration + 1;
            }
            
            writeMap();
        }

        private void numericUpDownMinIteration_ValueChanged(object sender, EventArgs e)
        {
            minIteration = Decimal.ToInt32(numericUpDownMinIteration.Value);
        }

        private void numericUpDownNumWallsWhenWall_ValueChanged(object sender, EventArgs e)
        {
            numWallsWhenWall = Decimal.ToInt32(numericUpDownNumWallsWhenWall.Value);
        }

        private void numericUpDownNumWallsWhenEmpty_ValueChanged(object sender, EventArgs e)
        {
            numWallsWhenEmpty = Decimal.ToInt32(numericUpDownNumWallsWhenEmpty.Value);
        }
    }
}
