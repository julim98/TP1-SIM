using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_SIM
{
    public partial class FormMenuTP1 : Form
    {
        private bool proximo = false;
        public FormMenuTP1()
        {
            InitializeComponent();
        }
        // Verificamos que lo ingresado en el txt sea un numero
        private int validarVariables(string variable)
        {
            if(int.TryParse(variable, out int resultado)) {

                //verificamos que el numero es positivo
                if (resultado > 0)
                {
                    return resultado;
                }
            }

            return -1;
        }

        private List<int> generarListLineal()
        {

            int x = 0;
            int c = 0;
            int a = 0;
            int m = 0;
            int k = 0;
            int g = 0;

            if(txtRaiz.Text != "")
            {
                x = int.Parse(txtRaiz.Text);
            }
            else
            {
                MessageBox.Show("DEBE COMPLETAR EL CAMPO DEL VALOR RAIZ (X0) OBLIGATORIAMENTE");
                return null;
            }

            if (txtC.Text != "")
            {
                c = int.Parse(txtC.Text);
            }
            else
            {
                MessageBox.Show("DEBE COMPLETAR EL CAMPO DE C OBLIGATORIAMENTE");
                return null;
            }

            if (txtK.Text != "")
            {
                 k = int.Parse(txtK.Text);
                 a = 1 + 4*k;
            }
            else if (txtA.Text != "")
            {
                a = int.Parse(txtA.Text);
            }
            else
            {
                MessageBox.Show("DEBE COMPLETAR EL CAMPO DE LOS VALORES A O K OBLIGATORIAMENTE");
                return null;
            }

            if (txtG.Text != "")
            {
                 g = int.Parse(txtG.Text);
                 m = (int )Math.Pow(2,g) ;
            }
            else if(txtM.Text != "")
            {
                 m = int.Parse(txtM.Text);
            }
            else
            {
                MessageBox.Show("DEBE COMPLETAR EL CAMPO DE LOS VALORES G O M OBLIGATORIAMENTE");
                return null;
            }
            

            //creo una lista con los valores de las variables
            List<int> elementos = new List<int>();
            elementos.Add(x);
            elementos.Add(a);
            elementos.Add(c);
            elementos.Add(m);
            elementos.Add(k);
            elementos.Add(g);

            return elementos;
        }

        private List<int> generarListMultiplicativo()
        {

            int x = 0;
            int c = 0;
            int a = 0;
            int m = 0;
            int k = 0;
            int g = 0;

            if (txtRaiz.Text != "")
            {
                x = int.Parse(txtRaiz.Text);
            }
            else
            {
                MessageBox.Show("DEBE COMPLETAR EL CAMPO DEL VALOR RAIZ (X0) OBLIGATORIAMENTE");
                return null;
            }

            if (txtC.Text != "")
            {
                MessageBox.Show("C NO PUEDE TENER ALGUN VALOR PARA EL METODO MULTIPLICATIVO");
                return null;
            }

            if (txtK.Text != "")
            {
                k = int.Parse(txtK.Text);
                a = 3 + 8 * k;
            }
            else if (txtA.Text != "")
            {
                a = int.Parse(txtA.Text);
            }
            else
            {
                MessageBox.Show("DEBE COMPLETAR EL CAMPO DE LOS VALORES A O K OBLIGATORIAMENTE");
                return null;
            }

            if (txtG.Text != "")
            {
                g = int.Parse(txtG.Text);
                m = (int)Math.Pow(2, g);
            }
            else if (txtM.Text != "")
            {
                m = int.Parse(txtM.Text);
            }
            else
            {
                MessageBox.Show("DEBE COMPLETAR EL CAMPO DE LOS VALORES G O M OBLIGATORIAMENTE");
                return null;
            }


            //creo una lista con los valores de las variables
            List<int> elementos = new List<int>();
            elementos.Add(x);
            elementos.Add(a);
            elementos.Add(c);
            elementos.Add(m);
            elementos.Add(k);
            elementos.Add(g);

            return elementos;
        }


        private void validarMetodo()
        {

            //Verifico que el metodo seleccionado se solo el Mixto
            if (cbMixto.Checked && !cbMultiplicativo.Checked)
            {
                var elementos = generarListLineal();
                if (elementos != null)
                {
                    completarTabla(elementos);
                }
                return;
            }
            //Verifico que el metodo seleccionado se solo el Multiplicativo
            else if (!cbMixto.Checked && cbMultiplicativo.Checked)
            {
                var elementos = generarListMultiplicativo();
                if (elementos != null)
                {
                    completarTabla(elementos);
                }
                return;
            }
            else
            {
                MessageBox.Show("ERROR SE DEBE SELECCIONAR UN SOLO METODO !!! ");
                return;
                    
            }
        }

        //Este metodo genera los 20 numeros 
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            dgvTabla.Rows.Clear();
            validarMetodo();
        }

        //Metodo Mixto o Lineal
        private void completarTabla(List<int> elements )
        {
            int x = elements[0];
            int a = elements[1];
            int c = elements[2];
            int m = elements[3];
            int k = elements[4];
            int g = elements[5];

            double axc;
            double resto = 0;
            double rnd;
            int vueltas = 20;
           

            if(proximo == true)
            {
                vueltas = dgvTabla.Rows.Count;
                dgvTabla.Rows.Clear();
                proximo = false;
            }

            for (int i = 1; i <= vueltas; i++)
            {
                if(i==1)
                {
                    
                    axc = a * x + c;
                    resto = axc % m;
                    rnd = resto / m;
                    
                }
                else
                {
                    axc = a * resto + c;
                    resto = axc % m;
                    rnd = resto / m;
                }
                

                dgvTabla.Rows.Add(i,rnd);
                
            }
            



        }

        
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
           
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtRaiz.Clear();
            txtA.Clear();
            txtC.Clear();
            txtG.Clear();
            txtK.Clear();
            txtM.Clear();
            dgvTabla.Rows.Clear();
           
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            proximo = true;
            validarMetodo();
            
        }
    }
}
