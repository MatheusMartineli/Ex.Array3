using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex.Array3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lsbA.Items.Clear();
            lsbB.Items.Clear();

           
            int[] vetorA = new int[15];
            int[] vetorB = new int[15];
            Random random = new Random();

            
            for (int i = 0; i < vetorA.Length; i++)
            
            {
                vetorA[i] = random.Next(1, 101); 

                
                lsbA.Items.Add("Valor " + vetorA[i]);

                
                vetorB[i] = vetorA[i] * vetorA[i];

                
                lsbB.Items.Add("Valor " + vetorB[i]);
            }
        }
    }

}
