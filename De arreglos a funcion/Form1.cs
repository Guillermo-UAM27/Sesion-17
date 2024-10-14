using De_arreglos_a_funcion.Models;
using De_arreglos_a_funcion.Servicio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De_arreglos_a_funcion
{
    public partial class Form1 : Form
    {
            ProductoServicio productos;    
        public Form1()
        {
            InitializeComponent();
            ProductoServicio productos = new ProductoServicio();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Productos prod = new Productos();
            prod.ID= int.Parse(tbId.Text);
            prod.Nombre= tbNombre.Text  ;
            prod.Descrincion=tbPrrcio.Text ;
            prod.precio = double.Parse(tbPrrcio.Text);
        }
        private void RegistroPro() 
        {
        
        }
    }
}
