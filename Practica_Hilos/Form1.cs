using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_Hilos
{
    public partial class Form1 : Form
    {

        private Menu menu;
       
        public Form1()
        {
            InitializeComponent();
        }

        
        private void btInicio_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
            fn_probar();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            ProgressBar pBar = new ProgressBar();
        }

        private void btPausar_Click(object sender, EventArgs e)
        {
            this.timer1.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Parent = lblDatos;
            label1.BackColor = Color.Transparent;
        }

        public void fn_probar()
        {
            progressBar1.Increment(1);
            label1.Text = progressBar1.Value.ToString() + "%";
            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Stop();
                this.Hide();
                Menu ff = new Menu();
                ff.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
