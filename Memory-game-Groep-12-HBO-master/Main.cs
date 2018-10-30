using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory_game_Groep_12_HBO
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
           
        }

        public static string SetValueForText1 = "";
        public static string SetValueForText2 = "";

        private void playersubmitBtn_Click(object sender, EventArgs e)
        {
            SetValueForText1 = player1Txt.Text;
            SetValueForText2 = player2Txt.Text;

           
            Form1 frm = new Form1();
            frm.Show();
           
            
        }

    }
    }

