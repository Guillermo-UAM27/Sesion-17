using De_arreglos_a_funcion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De_arreglos_a_funcion.Servicio
{
    internal class ProductoServicio
    {
        List<Productos> producto = new List<Productos>();
        public List<Productos> productos()
        {
            return producto;
        }

        public void agregarProductos (Productos productos)
        {
            producto.Add(productos);
        }
        public Productos BuscarProducto (Productos productos)
        {
            return producto.Find(prod => prod.ID == productos.ID);
        }
        public void EliminarProducto (Productos productos)
        {
   
                producto.Remove(productos);
        }
        public void ActualizarProducto (Productos productos, int id)
        {
            int index = producto.FindIndex(prod => prod.ID == id);

            if (index == -1)
            {
                producto[index] = productos;
            }
            else
            {
                MessageBox.Show("No existe el producto");
            }
        }
    }
}
