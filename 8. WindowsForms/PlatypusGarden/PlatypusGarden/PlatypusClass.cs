using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlatypusGarden
{
    public class PlatypusClass
    {
        private int k;
        private int points;

        // Default constructor
        public PlatypusClass()
        {

        }

        // Constructor that takes the value of the static variable k in order to check for platypus type
        public PlatypusClass(int k)
        {
            this.K = k;
        }

        public string GetPlatypusType()
        {
            return "normal";
        }

        public virtual void Swipe(TableLayoutPanel image)
        {
            image.BackgroundImage = null;
        }

        //Property for the private variable k
        public int K
        {
            get { return k; }
            set { k = value; }
        }

        public int GetK()
        {
            return this.K = k;
        }

        public int PointValue()
        {
            return 1;
        }
    }

    public class RabidPlatypus : PlatypusClass
    {

        //public override string GetPlatypusType()
        //{
        //    return "hard";
        //}

        public override void Swipe(TableLayoutPanel image)
        {

        }
        public int PointValue()
        {
            return 3;
        }
    }

    public class StonePlatypus : PlatypusClass
    {


        public string GetPlatypusType()
        {
            return "worst";
        }

        public override void Swipe(TableLayoutPanel image)
        {

        }

        //public override int PointValue()
        //{
        //    return -1;
        //}
    }

    

    public class GardenClass
    {
        Button Turf;
        Random rand = new Random();
        //Image myImage = Image.FromFile("images/Platypus.png");
        int counter = 0;
        Label labelScore;

        private int numberOfPlatypus = 25;

        public void GetPlatypusType()
        {
            
        }
        
        public int NumberOfPlatypus
        {
            get { return numberOfPlatypus; }
            set { numberOfPlatypus = value; }
        }

        // Assignes buttons to the tableLayoutPanel tiles
        public GardenClass(int row, int col, ref TableLayoutPanel table,
                              Image myImage)
        {
            Turf = new Button();
            Turf.BackgroundImage = myImage;
            table.Controls.Add(Turf, row, col);
            Turf.Dock = DockStyle.Fill;
            Turf.Click += Turf_Click;

            GardenClass[] typesOfPlatypus = new GardenClass[25];

            //for (int i = 0; i < typesOfPlatypus.Length; i++)
            //{
            //    typesOfPlatypus[i] = 
            //}
        }

        // Checks the how many clicks are needed for the platypus to be swiped.
        public void Turf_Click(object sender, EventArgs e)
        {
            Turf.Enabled = true;

            counter++;

            if (Form1.m == 1 && counter == 1)
            {
                Turf.Visible = false;
            }
            else if (Form1.n == 3 && counter == 3)
            {
                Turf.Visible = false;
            }
            else if (Form1.k == 5 && counter == 5)
            {
                Turf.Visible = false;
            }

            //labelScore.Text = "Score " + counter.ToString();

            //if (platypusType.GetK() == 1 && counter == 1)
            //{
            //    Turf.Visible = false;
            //}
            //else if (platypusType.GetK() == 3 && counter == 3)
            //{
            //    Turf.Visible = false;
            //}

        }
    }
}
