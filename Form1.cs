using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sample_proj
{
    public partial class Form1 : Form
    {
        List<Color> _colors = new List<Color> { Color.Black, Color.White, Color.Red,Color.PowderBlue, Color.Aqua, Color.Brown };
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random color = new Random();
            int r = color.Next(_colors.Count);
            BackColor = _colors[r];
        }
    }
}
