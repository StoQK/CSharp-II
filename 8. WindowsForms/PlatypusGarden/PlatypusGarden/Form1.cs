using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlatypusGarden
{
    public partial class Form1 : Form
    {
        GardenClass[,] TurfsCollection; // 2-dimensional array that will fill the TableLayoutPanel
        Random rand = new Random();
        Label ScoreLabel; // A label to show the current score
        public static int m;
        public static int n;
        public static int k;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGarden_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Clear(); // Clears the panel to start a new game

            int rows = tableLayoutPanel1.RowCount; // new variable that takes the number of rows in the tableLayourPanel in the design
            int cols = tableLayoutPanel1.ColumnCount;

            TurfsCollection = new GardenClass[rows, cols]; // 2-dimensional array with size same as the table size

            //Fill in the 2-dimensional array with pictures of the Platypuses
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    int value = rand.Next(3);
                    if (value == 0)
                    {
                        TurfsCollection[i, j] = new GardenClass(i, j, ref tableLayoutPanel1, Image.FromFile("images/Platypus.png"));
                        //platypusType = new PlatypusClass(1);
                        //platypusType.GetK();
                        m = 1;
                    }
                    else if (value == 1)
                    {
                        TurfsCollection[i, j] = new GardenClass(i, j, ref tableLayoutPanel1, Image.FromFile("images/RabidPlatypus.png"));
                        //platypusType = new PlatypusClass(3);
                        n = 3;
                    }
                    else 
                    {
                        TurfsCollection[i, j] = new GardenClass(i, j, ref tableLayoutPanel1, Image.FromFile("images/StonePlatypus.png"));
                        k = 5;
                    }
                }
            }
        }

        private void buttonRules_Click(object sender, EventArgs e) // Loads the second form
        {
            Form2 rules = new Form2();
            rules.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
