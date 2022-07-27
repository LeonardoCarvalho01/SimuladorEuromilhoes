using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExEuromilhoes
{
    public partial class frmMilhoes : Form
    {
        public frmMilhoes()
        {
            InitializeComponent();
        }
        
        private void btnJogar_Click(object sender, EventArgs e)
        {
            
            string acumulada="";
            int[] numeros =new int[5];
            bool flag;
            Random alt = new Random();
            int aux=0;
            numeros[0] = alt.Next(1, 51);
            for (int i = 1; i < 5; i++)
            {
                do
                {
                    flag = false;
                    aux = alt.Next(1, 51);
                    for (int j = 0; j < i; j++)
                    {
                        if (aux == numeros[j])
                        {
                            flag = true;
                        }                       
                    }
                } while (flag == true);
                numeros[i] = aux;
            }
            
            string acumuladas = "";
            int[] estrelas= new int[2];
            bool flags;
            Random alt2 = new Random();
            int suplente = 0;
            estrelas[0] = alt2.Next(1, 12);
            for (int q = 1; q < 2; q++)
            {
                do
                {
                    flags=false;
                    suplente = alt2.Next(1,12);
                    for (int w = 0; w < q; w++)
			        {
			            if (suplente == estrelas[w])
	                    {
		                    flags = true;
	                    }
			        }
                } while (flags==true);
                estrelas[q] = suplente;
            }
            Array.Sort(numeros);
            for (int i = 0; i < 5; i++)
            {
                acumulada = acumulada + numeros[i] + " ";
            }
            txtNumeros.Text = " " + acumulada;

            Array.Sort(estrelas);
            for (int q = 0; q < 2; q++)
            {
                acumuladas += estrelas[q] + " ";
            }
            txtEstrelas.Text = " " + acumuladas;
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
