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
        int xArrayDimension = 45;
        int yArrayDimension = 45;
        int wallChance = 45;

        int amountOfIterations = 5;

        int minIteration = 3;
        int numWallsWhenWall = 4;
        int numWallsWhenEmpty = 5;

        int minimalRoomSize = 20;

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
            numericUpDownAmountOfIterations.Value = amountOfIterations;

            buttonIterateMap.Text = "Iterate map " + amountOfIterations + " times";

            map = new MapGenerator(xArrayDimension, yArrayDimension, wallChance, minIteration, numWallsWhenWall, numWallsWhenEmpty, minimalRoomSize);

            writeMap();
        }


        
        #region Buttons
        private void buttonGenerateNewMap_Click(object sender, EventArgs e)
        {
            //generate map
            map = new MapGenerator(xArrayDimension, yArrayDimension, wallChance, minIteration, numWallsWhenWall, numWallsWhenEmpty, minimalRoomSize);
            labelIterationCount.Text = "Current iteration: " + map.Iteration;
            writeMap();
            //profit
        }

        private void buttonIterateMap_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < amountOfIterations; i++)
            {
                map.MakeCaverns();
                map.Iteration = map.Iteration + 1;
                labelIterationCount.Text = "Current iteration: " + map.Iteration;
            }

            writeMap();
        }

        private void buttonFrameWalls_Click(object sender, EventArgs e)
        {
            int[,] placeHolderMap = map.Map;
            List<Room> AllRooms = map.GetRooms(0);

            map.removeSmallRooms(AllRooms);
            AllRooms = map.GetRooms(0);
            map.ConnectClosestRooms(AllRooms);

            writeMap();
        }
        #endregion

        #region NumericUpDowns
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

        private void numericUpDownAmountOfIterations_ValueChanged(object sender, EventArgs e)
        {
            amountOfIterations = Decimal.ToInt32(numericUpDownAmountOfIterations.Value);
            buttonIterateMap.Text = "Iterate map " + amountOfIterations + " times";
        }
        #endregion
        
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
                    if(placeHolderMap[i, j] == 0)
                    {
                        mapLine += "  ";
                    }
                    if(!(placeHolderMap[i, j] == 0) && !(placeHolderMap[i, j] == 1))
                    {
                        mapLine += placeHolderMap[i, j] + " ";
                    }
                    
                }

                richTextBoxMap.Text += mapLine + Environment.NewLine;
            }
        }
        
    }
}
