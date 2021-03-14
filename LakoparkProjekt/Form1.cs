using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LakoparkProjekt
{
    public partial class Form1 : Form
    {
        private int active = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HappyLiving happy = new HappyLiving("lakoparkok.txt");
            betoltes();
        }

        private void betoltes()
        {
            UtcaImgBox.Image()
        }
    }
}
