using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module07_WinForms_Delegates
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += Button_myOtherClick;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblFirst.Text = "Event was triggered!";
            
        }

        private void Button_myOtherClick(object sender, EventArgs e)
        {
            lblSecond.Text = "This one worked too!!";
        }
    }
}
