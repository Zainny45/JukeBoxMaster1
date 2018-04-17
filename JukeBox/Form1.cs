﻿using System;
using System.Collections;
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
    public partial class Jukebox : Form

    {
        int currentGenre = 0;


        public Jukebox()
        {
            InitializeComponent();



        }







        private void button1_Click(object sender, EventArgs e)
        {
            Setup f2 = new Setup();
            f2.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AboutForm f3 = new AboutForm();
            f3.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {

            update();
        }

        private void update()
        {
            List<List<string>> genre = readFile();
            GenreName.Text = genre[currentGenre][1].ToString();

            UpdateGenrelist();


        }

        private void UpdateGenrelist()
        {
            List<List<string>> genre = readFile();
            int max = Convert.ToInt32(genre[currentGenre][0]);
            for (int i = 0; i < max; i++)
            {
                Genrelist.Items.Add(genre[currentGenre][i + 2]);
            }
        }

        private List<List<string>> readFile()
        {

            StreamReader sr = new StreamReader("../../Media.txt");

            // read in the number of genres from the file
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

        private void Genrelist_DoubleClick(object sender, EventArgs e)
        {
            if (Genrelist.SelectedItem != null)
            {
                if (Playlist.Items.Count == 0 && playingNow.Text == "")
                {
                    playingNow.Text = Genrelist.SelectedItem.ToString();
                    playTrack();

                }
                else if (Playlist.Items.Count > 0 || (Playlist.Items.Count == 0 && playingNow.Text != ""))
                {
                    // add to the playlist
                    Playlist.Items.Add(Genrelist.SelectedItem.ToString());
                }
            }
            readFile();
        }

        private void playTrack()
        {
            // select the track, play the track
            MediaPlayer.Ctlcontrols.stop();
            MediaPlayer.URL = filename();
            MediaPlayer.Ctlcontrols.play();
        }



        private string filename()
        {

            string filename = playingNow.Text;
            string path = Environment.CurrentDirectory;
            string newPath = Path.GetFullPath(Path.Combine(path, @"..\..\..\"));
            string finalPath = newPath + "Tracks\\" + filename;
            return finalPath;
        }

        private void MediaPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            //Timer is enabled  here
            if (e.newState == 8)
            {
                timer1.Enabled = true;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (Playlist.Items.Count != 0)
            {
                playingNow.Text = Playlist.Items[0].ToString();
                Playlist.Items.RemoveAt(0);
                playTrack();
                timer1.Enabled = false;
            }
        }

        private void ChooseGenre_Scroll(object sender, ScrollEventArgs e)
        {
            if (ChooseGenre.Value == 0)
            {
                Genrelist.Items.Clear();
                GenreName.Text = "OST";
                Genrelist.Items.Add("Boku No Hero Hero A.mp3");
            }
            else if (ChooseGenre.Value == 1)
            {
                Genrelist.Items.Clear();
                GenreName.Text = "KPOP";
                Genrelist.Items.Add("BTS DNA.mp3");
                Genrelist.Items.Add("BTS Mic Drop Remix");
            }
        }
    }
}







