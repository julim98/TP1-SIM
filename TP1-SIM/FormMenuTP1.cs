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
        private bool bandOk = false;
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
        private void controlarVariables()
        {

            if (validarVariables(txtRaiz.Text) == -1)
            {
                MessageBox.Show("Error la Raiz \"X0\" debe ser entero y mayor a cero");
                return;
            }
            else if (validarVariables(txtC.Text) == -1)
            {
                MessageBox.Show("Error la constante \"c\" debe ser entero y mayor a cero");
                return;

            }
            else if (validarVariables(txtA.Text) == -1)
            {
                MessageBox.Show("Error la constante \"a\" debe ser entero y mayor a cero");
                return;
            }
            else if (validarVariables(txtM.Text) == -1)
            {
                MessageBox.Show("Error el modulo \"m\" debe ser entero y mayor a cero");
                return;
            }
            else if (validarVariables(txtK.Text) == -1)
            {
                MessageBox.Show("Error el numero \"k\" debe ser entero y mayor a cero");
                return;
            }
            else if (validarVariables(txtG.Text) == -1)
            {
                MessageBox.Show("Error el numero \"g\" debe ser entero y mayor a cero");
                return;
            }

            //Cuando Todos los valores de las variables de entrada sean correctos pongo la bandera en True
            else
            {
                bandOk = true;
            }
        }

        private List<int> generarList()
        {

           
            //creo una lista con los valores de las variables
            List<int> elementos = new List<int>();
            elementos.Add(int.Parse(txtRaiz.Text));
            elementos.Add(int.Parse(txtA.Text));
            elementos.Add(int.Parse(txtC.Text));
            elementos.Add(int.Parse(txtM.Text));
            elementos.Add(int.Parse(txtK.Text));
            elementos.Add(int.Parse(txtG.Text));

            return elementos;
        }

        private void validarMetodo()
        {
            if (bandOk == true)
            {
                //Verifico que el metodo seleccionado se solo el Mixto
                if (cbMixto.Checked && !cbMultiplicativo.Checked)
                {
                    var elementos = generarList();
                    metodoMixto(elementos);
                    return;
                }
                //Verifico que el metodo seleccionado se solo el Multiplicativo
                else if (!cbMixto.Checked && cbMultiplicativo.Checked)
                {
                    var elementos = generarList();
                    return;
                }
                else
                {
                    MessageBox.Show("ERROR SE DEBE SELECCIONAR UN SOLO METODO !!! ");
                    return;
                    
                }
                
            }
        }
        //Este metodo genera los 20 numeros 
        private void btnGenerar_Click(object sender, EventArgs e)
        {

            controlarVariables();
            validarMetodo();
                    
          
            
            
        }

        //Metodo Mixto o Lineal
        private void metodoMixto(List<int> elements )
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
                    rnd = resto / (m - 1);
                    
                }
                else
                {
                    axc = a * resto + c;
                    resto = axc % m;
                    rnd = resto / (m - 1);
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
