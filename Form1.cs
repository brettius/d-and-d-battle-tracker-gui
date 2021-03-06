﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DD_Battle_Tracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addHealth_Click(object sender, EventArgs e)
        {

            int plusHealth;

            if (int.TryParse(currentHealth.Text, out plusHealth))
                {
                plusHealth += 1;

                currentHealth.Text = plusHealth.ToString();
            }
            else
            {
                MessageBox.Show("Enter a valid number");
            }

        }


        private void decreaseHealth_Click(object sender, EventArgs e)
        {
            int minusHealth;

            if (int.TryParse(currentHealth.Text, out minusHealth))
            {
                minusHealth -= 1;

                currentHealth.Text = minusHealth.ToString();
            }
            else
            {
                MessageBox.Show("Enter a valid number");
            }

        }


        private void ragePlus_Click(object sender, EventArgs e)
        {
            int plusHealth;

            if (int.TryParse(rageBox2.Text, out plusHealth))
            {
                plusHealth += 1;

                rageBox2.Text = plusHealth.ToString();
            }
            else
            {
                MessageBox.Show("Enter a valid number");
            }
        }

        private void rageMinus_Click(object sender, EventArgs e)
        {
            int minusHealth;

            if (int.TryParse(rageBox2.Text, out minusHealth))
            {
                minusHealth -= 1;

                rageBox2.Text = minusHealth.ToString();
            }
            else
            {
                MessageBox.Show("Enter a valid number");
            }
        }

        private void hitDicePlus_Click(object sender, EventArgs e)
        {
            int plusHealth;

            if (int.TryParse(hitDiceBox.Text, out plusHealth))
            {
                plusHealth += 1;

                hitDiceBox.Text = plusHealth.ToString();
            }
            else
            {
                MessageBox.Show("Enter a valid number");
            }
        }

        private void hitDiceMinus_Click(object sender, EventArgs e)
        {
            int minusHealth;

            if (int.TryParse(hitDiceBox.Text, out minusHealth))
            {
                minusHealth -= 1;

                hitDiceBox.Text = minusHealth.ToString();
            }
            else
            {
                MessageBox.Show("Enter a valid number");
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter outputFile;

                outputFile = File.CreateText("tracker.txt");

                outputFile.WriteLine(nameBox.Text);
                outputFile.WriteLine(classBox.Text);
                outputFile.WriteLine(currentHealth.Text);
                outputFile.WriteLine(maxHealth.Text);
                outputFile.WriteLine(expBox.Text);
                outputFile.WriteLine(rageBox2.Text);
                outputFile.WriteLine(hitDiceBox.Text);

                outputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                string name;


                StreamReader inputFile;

                inputFile = File.OpenText("tracker.txt");

                name = inputFile.ReadLine();
                nameBox.Text = name;
                name = inputFile.ReadLine();
                classBox.Text = name;
                name = inputFile.ReadLine();
                currentHealth.Text = name;
                name = inputFile.ReadLine();
                maxHealth.Text = name;
                name = inputFile.ReadLine();
                expBox.Text = name;
                name = inputFile.ReadLine();
                rageBox2.Text = name;
                name = inputFile.ReadLine();
                hitDiceBox.Text = name;

                inputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            nameBox.Clear();
            classBox.Clear();
            currentHealth.Clear();
            maxHealth.Clear();
            expBox.Clear();
            rageBox2.Clear();
            hitDiceBox.Clear();


        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You dont really need a helpfile, do you?");
           
        }
    }
}
