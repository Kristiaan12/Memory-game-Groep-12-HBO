using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using Microsoft.VisualBasic;


// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace Memory_game_Groep_12_HBO
{
    public partial class Instellingen : Form
    {
        Form1 newForm = new Form1();

        // and on closing event
        private void Instellingen_FormClosing(object sender, EventArgs e)
        {
            Instellingen f2 = new Instellingen();
            this.Hide();
            f2.ShowDialog();
            this.Show();
        }
    }
}

