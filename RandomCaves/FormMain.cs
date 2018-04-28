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

        MapGenerator map;


        public FormMain()
        {
            InitializeComponent();
            numericUpDownXLength.Value = xArrayDimension;
            numericUpDownYLength.Value = yArrayDimension;
            numericUpDownWallChance.Value = wallChance;

            map = new MapGenerator(xArrayDimension, yArrayDimension, wallChance);

            writeMap();
        }

        private void buttonGenerateNewMap_Click(object sender, EventArgs e)
        {
            //generate map
            map = new MapGenerator(xArrayDimension, yArrayDimension, wallChance);
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
            }
            
            writeMap();
        }
    }
}
