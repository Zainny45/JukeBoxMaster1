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


namespace JukeBox
{
    public partial class Setup : Form
    {
        int currentGenre = 0;


        public bool bool_Requires_Saving { get; private set; }
        public object Tracks { get; private set; }

        public Setup()
        {
            InitializeComponent();



        }





        private List<List<string>> readFile()
        {

            StreamReader sr = new StreamReader("../../Media.txt");


            int genreNumber = Convert.ToInt32(sr.ReadLine());

            List<List<string>> genre = new List<List<string>>();

            for (int i = 0; i < genreNumber; i++)
            {
                List<string> newgenre = new List<string>();
                int trackNumber = Convert.ToInt32(sr.ReadLine());
                newgenre.Add((trackNumber.ToString()));
                newgenre.Add(sr.ReadLine());
                for (int f = 0; f < trackNumber; f++)
                {
                    newgenre.Add(sr.ReadLine());
                }
                genre.Add(newgenre);
            }
            return (genre);
        }

        private void update()
        {
            List<List<string>> genre = readFile();
            genreBox.Text = genre[currentGenre][1].ToString();
            TrackList.Items.Clear();
            UpdateGenrelist(genre);
        }
        private void UpdateGenrelist(List<List<string>> genre)
        {
            int max = Convert.ToInt32(genre[currentGenre][0]);
            for (int i = 0; i < max; i++)
            {
                TrackList.Items.Add(genre[currentGenre][i + 2]);
            }
        }

        private void Setup_Load(object sender, EventArgs e)
        {
            Update();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            {
                bool_Requires_Saving = true;
                OpenFileDialog newDialogue = new OpenFileDialog();
                newDialogue.Title = "Import Track";
                newDialogue.Filter = "Music files (*.mp3, *.wma) | *.mp3; *.wma";
                if (newDialogue.ShowDialog() == DialogResult.OK)
                {
                    Imported_tracks.Items.Add(newDialogue.SafeFileName.ToString());
                }
            }
        }







        private void button11_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to cancel?";
            string error = "Close";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, error, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            Imported_tracks.Items.Clear();
        }


        private void Imported_tracks_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> imported_tracks = new List<string>();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Imported_tracks.Text != "")
            {
                string MovedItem;
                MovedItem = (Imported_tracks.Text);

                TrackList.Items.Add(Imported_tracks.Text);
                Imported_tracks.Items.Remove(MovedItem);
            }
            else
                MessageBox.Show("You Must Select an Item To Move");

        }

        private void button9_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(TrackList);
            selectedItems = TrackList.SelectedItems;

            if (TrackList.SelectedIndex != -1)
            {
                for (int i = selectedItems.Count - 1; i >= 0; i--)
                    TrackList.Items.Remove(selectedItems[i]);
            }
            else
                MessageBox.Show("You Must Select an Item to Delete");

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Imported_tracks.Text != "")
            {
                TrackList.Items.Add(Imported_tracks.Text);
            }
            else
                MessageBox.Show("You Must Select an Item to Copy");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string applicationPath = Directory.GetCurrentDirectory() + "//";

            StreamWriter myOutputStream = File.CreateText(applicationPath + (genreBox.Text) + ".txt");

            myOutputStream.Close();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("../../Media.txt");
            int genreNumber = Convert.ToInt32(sr.ReadLine());

            if (currentGenre < genreNumber - 1)
            {
                currentGenre = currentGenre + 1;
                update();
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void genreBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("../../Media.txt");
            int genreNumber = Convert.ToInt32(sr.ReadLine());

            if (currentGenre > 0)
            {
                currentGenre = currentGenre - 1;
                update();
            }
        }

        private void TrackList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}

        
        

     

