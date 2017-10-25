using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //accés a string a recusos
            labelTest.Text = Properties.Resources.strTest + " " + Properties.Resources.strGlob;

            //mostrem la data que es formatarà automàticament segons la localització
            labelData.Text = DateTime.Today.ToLongDateString();
        }
    }
}
