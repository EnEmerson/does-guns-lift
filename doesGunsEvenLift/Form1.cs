using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace doesGunsEvenLift
{
    public partial class Form1 : Form
    {
        Stream myStream = null;
        string directory = "No file selected.";
        List<int> liftRepsList = new List<int>();
        const int LIFT_THRESHOLD = 4550;
        const int REPS = 5000;

        public Form1()
        {
            InitializeComponent();
            filePathBox.Text = directory;
            threshLabel.Text = "Lift Threshold: " + LIFT_THRESHOLD.ToString();
            randSetButton.Text = "Create a random set of " + REPS.ToString() + " reps and test";
        }

        private void generateRandomSet()
        {
            List<int> repsList = new List<int>();
            Random repGenerator = new Random();
            int upperBound = 9101;

            for (int i = 0; i < REPS; i++)
            {
                int randRep = repGenerator.Next(1,upperBound);
                repsList.Add(randRep);
            }
            directory = "Trying a random set...";
            getLifts(repsList);
        }

        private void selectFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            directory = openFileDialog1.FileName.ToString();
                            getLifts();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }

        public void getLifts() 
        {
            clearList();

            StreamReader sr = new StreamReader(directory);
            filePathBox.Text = directory.ToString();

            try
            {
                int current;
                string foo;
                while ((foo = sr.ReadLine()) != null)
                {
                    current = Int32.Parse(foo);
                    liftRepsList.Add(current);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

        public void getLifts(List<int> tempLifts)
        {
            clearList();

            filePathBox.Text = directory.ToString();
            foreach (int i in tempLifts)
            {
                liftRepsList.Add(i);
            }
        }

        public void clearList()
        {
            liftRepsList.Clear();
        }

        private void calculateTheLifts()
        {
            numOfLiftsBox.Text = liftRepsList.Count().ToString(); // number of lifts in the set

            double divisor = 0;
            double dividend = liftRepsList.Count();
            int avgLifts = 0;
            int count = liftRepsList.Count();

            for (int i = 0; i < count; i++)
            {
                divisor += liftRepsList.ElementAt(i);
            }

            avgLifts = (int)(divisor / dividend);

            avgOfLiftsBox.Text = avgLifts.ToString(); // average number of lifts

            if (avgLifts < LIFT_THRESHOLD) // whether 'The Guns' lifts or not
            {
                resultBox.Text = "'The Guns' doesn't lift.";
            }
            else
            {
                resultBox.Text = "'The Guns' lifts.";
            }
            
        }
        private void calcButton_Click(object sender, EventArgs e)
        {
            if (directory != "No file selected.")
            {
                calculateTheLifts();
            }
            else
            {
                MessageBox.Show("Please select a directory.");
                filePathBox.Text = "Please select a directory...";
                numOfLiftsBox.Clear();
                avgOfLiftsBox.Clear();
                resultBox.Clear();
            }
        }

        private void randSetButton_Click(object sender, EventArgs e)
        {
            generateRandomSet();
            calculateTheLifts();
        }
    }
}