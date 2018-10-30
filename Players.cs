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
    public partial class Players : Form
    {
        public Players()
        {
            InitializeComponent();
        }

        public void playerOneTxt_TextChanged(object sender, EventArgs e)
        {
            //string playerone = playerOneTxt.Text;


           
        }

        public void playerTwoTxt_TextChanged(object sender, EventArgs e)
        {
          
            //string playertwo = playerTwoTxt.Text;
        }

        public static string SetValueForText1 = "";
        public static string SetValueForText2 = "";

        private void button1_Click(object sender, EventArgs e)
        {
            SetValueForText1 = playerOneTxt.Text;
            SetValueForText2 = playerTwoTxt.Text;

 

            Form1 frm = new Form1();
            frm.Show();

            this.Close();
        }
    }
}
