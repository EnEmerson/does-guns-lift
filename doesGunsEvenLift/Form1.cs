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
        List<Double> liftRepsList = new List<Double>();
        int liftThreshold = 4550;

        public Form1()
        {
            InitializeComponent();
            filePathBox.Text = directory;
            threshLabel.Text = "Lift Threshold: " + liftThreshold.ToString();
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
            StreamReader sr = new StreamReader(directory);
            filePathBox.Text = directory.ToString();

            try
            {
                double current;
                string foo;
                while ((foo = sr.ReadLine()) != null)
                {
                    current = Convert.ToDouble(foo);
                    liftRepsList.Add(current);
                    Console.WriteLine(current);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            if (directory != "No file selected.")
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

                if (avgLifts < liftThreshold) //result of lift or not to lift
                {
                    resultBox.Text = "'The Guns' doesn't lift.";
                }
                else
                {
                    resultBox.Text = "'The Guns' lifts.";
                }
            }
            else
            {
                MessageBox.Show("Please select a directory.");
                filePathBox.Text = "Please select a directory";
                numOfLiftsBox.Clear();
                avgOfLiftsBox.Clear();
                resultBox.Clear();
            }
        }
    }
}
