using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeyYou
{
    public partial class Form1 : Form
    {
        private MessageText mt;
        public Form1()
        {
            InitializeComponent();
            mt = new MessageText();
        }

        private void DoIt_Click(object sender, EventArgs e)
        {
            string word = mt.getNextWord();
            output.Text = word;
        }
    }
}
