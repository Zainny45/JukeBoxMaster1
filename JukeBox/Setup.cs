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
            List<List<string>> genre = readFile(); //readfile
            genreBox.Text = genre[currentGenre][1].ToString(); //turns it into string 
            TrackList.Items.Clear(); //clears track list
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
                newDialogue.Filter = "Music files (*.mp3, *.wma) | *.mp3; *.wma";//Only will import mp3 and wma files
                if (newDialogue.ShowDialog() == DialogResult.OK)
                {
                    Imported_tracks.Items.Add(newDialogue.SafeFileName.ToString());
                }
            }
        }






        //code if you click cancel. 
        private void button11_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to cancel?"; //message
            string error = "Close";//name
            MessageBoxButtons buttons = MessageBoxButtons.YesNo; //buttons saying yes and no
            DialogResult result;
            result = MessageBox.Show(message, error, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes) //if yes clicked then closes setup form and if no is pressed then only closes the popup
            {
                this.Close();
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            Imported_tracks.Items.Clear();//clears the imported tracks
        }


        private void Imported_tracks_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> imported_tracks = new List<string>(); //list to hold the imported tracks

        }

        private void button8_Click(object sender, EventArgs e)//if a imported track is clicked on and then the move button pressed it will move it to the tracklist from imported tracks and deletes it from imported tracks
        {
            if (Imported_tracks.Text != "")
            {
                string MovedItem;
                MovedItem = (Imported_tracks.Text);

                TrackList.Items.Add(Imported_tracks.Text);
                Imported_tracks.Items.Remove(MovedItem);
            }
            else
                MessageBox.Show("You Must Select an Item To Move"); //message if nothing is selected

        }

        private void button9_Click(object sender, EventArgs e)//deletes the tracks from the tracklist
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

        private void button7_Click(object sender, EventArgs e)//copies the imported tracks to tracklist but does not delete from imported tracks
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
            


        }

        private void button4_Click(object sender, EventArgs e) //next genre and tracklist
        {
            StreamReader sr = new StreamReader("../../Media.txt"); //file location to streamreader
            int genreNumber = Convert.ToInt32(sr.ReadLine());

            if (currentGenre < genreNumber - 1)
            {
                currentGenre = currentGenre + 1;
                update();
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void genreBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e) //previous genre and tracklist
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

        
        

     


