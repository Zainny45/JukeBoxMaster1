using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JukeBox
{
    public partial class Genre : Form
    {
        private DialogResult result;

        public Genre()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Genre f5 = new Genre();
            if (String.IsNullOrEmpty(enterGenre.Text))
                this.Close();
            else
            {

                MessageBox.Show("Are you sure you want to Cancel", "Close",
                    MessageBoxButtons.YesNo);
            }
                if (result == System.Windows.Forms.DialogResult.Yes)
            { 
                
                f5.Close();

            { 
                }
            }
            }
        


        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(enterGenre.Text))
                MessageBox.Show("You must give the Genre a Title");
            else
            {
              

            
            }
            
        }
    }
}
