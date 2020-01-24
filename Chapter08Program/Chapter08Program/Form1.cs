using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter08Program
{
    


    public partial class Form1 : Form
    {
        const int MAXLETTERS = 26; //Symbolic Constants
        const int MAXCHARS = MAXLETTERS -1;
        const int LETTERA = 65;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            Char oneLetter;
            int index;
            int i;
            int length;
            int[] count = new int[MAXLETTERS];
            string input;
            string buff;

            length = txtInput.Text.Length;
            if (length == 0) //Anything to count??
            {
                MessageBox.Show("You need to enter some text.", "Missing Input");
                txtInput.Focus();
                return;
            }
            input = txtInput.Text;
            input = input.ToUpper();

            for (i = 0; i < input.Length; i++) // Examine all letters.
            {
                oneLetter = input[i];          //Get a Character
                index = oneLetter - LETTERA;   //Make into an index
                if (index < 0 || index > MAXCHARS)  //A Letter??
                    continue;                       //Nope.  
                count[index]++;                     //yep.
            }

            ListViewItem which;
            for (i = 0; i < MAXLETTERS; i++)
            {
                oneLetter = (char)(i + LETTERA);
                which = new ListViewItem(oneLetter.ToString());
                which.SubItems.Add(count[i].ToString());
                lsvOutput.Items.Add(which);

            }


            //for (i = 0; i < MAXLETTERS; i++)
            //{
                //buff = string.Format("{0, 4} {1,20}[{2}]", (char)(i + LETTERA), "", count[i]);
                //lstOutput.Items.Add(buff);
            //}
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
