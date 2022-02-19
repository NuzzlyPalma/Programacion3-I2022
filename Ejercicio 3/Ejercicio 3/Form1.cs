using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] nombre = new string[] { TxtNombre.Text };
            string[] edad = new string[] { TxtEdad.Text };
            foreach (var item in nombre)
            {
                foreach (var itemedad in edad)
                {
                    combo1.Items.Add(item + " - " + itemedad + " Años");
                }
            }
            TxtEdad.Text = " ";
            TxtNombre.Text = " ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
