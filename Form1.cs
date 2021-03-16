using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCafe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            personalizarMenu();
        }

        private void personalizarMenu()
        {
            panelSubMenuClientes.Visible = false;
            panelSubMenuCompras.Visible = false;
            panelSubMenuProductos.Visible = false;
            panelSubMenuReportes.Visible = false;
            //... Se pueden escribir otras formas de personalizar el diseño.
            //...
        }

        private void ocultarSubmenu()
        {
            if (panelSubMenuClientes.Visible == true)
                panelSubMenuClientes.Visible = false;
            if (panelSubMenuCompras.Visible == true)
                panelSubMenuCompras.Visible = false;
            if (panelSubMenuProductos.Visible == true)
                panelSubMenuProductos.Visible = false;
            if (panelSubMenuReportes.Visible == true)
                panelSubMenuReportes.Visible = false;
        }

        private void mostrarSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                ocultarSubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(panelSubMenuProductos);
        }
        #region subMenuProductos
        private void btnCafeOrga_Click(object sender, EventArgs e)
        {
            //...
            //Códigos para formularios
            //...
            ocultarSubmenu();
        }

        private void btnMaquinaria_Click(object sender, EventArgs e)
        {
            //...
            //Códigos para formularios
            //...
            ocultarSubmenu();
        }

        private void bnProdCafe_Click(object sender, EventArgs e)
        {
            //...
            //Códigos para formularios
            //...
            ocultarSubmenu();
        }
#endregion
        private void btnVentas_Click(object sender, EventArgs e)
        {
            //...
            //Códigos para formularios
            //...
            ocultarSubmenu();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(panelSubMenuClientes);
        }
        #region subMenuClientes
        private void btnHistorial_Click(object sender, EventArgs e)
        {
            //...
            //Códigos para formularios
            //...
            ocultarSubmenu();
        }

        private void btnPrestaciones_Click(object sender, EventArgs e)
        {
            //...
            //Códigos para formularios
            //...
            ocultarSubmenu();
        }
#endregion
        private void btnCompras_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(panelSubMenuCompras);
        }
        #region subMenuCompras
        private void btnAlmacen_Click(object sender, EventArgs e)
        {
            //...
            //Códigos para formularios
            //...
            ocultarSubmenu();
        }

        private void btnActivos_Click(object sender, EventArgs e)
        {
            //...
            //Códigos para formularios
            //...
            ocultarSubmenu();
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            //...
            //Códigos para formularios
            //...
            ocultarSubmenu();
        }
#endregion
        private void btnReportes_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(panelSubMenuReportes);
        }
        #region subMenuReportes
        private void btnReporteCompras_Click(object sender, EventArgs e)
        {
            //...
            //Códigos para formularios
            //...
            ocultarSubmenu();
        }

        private void btnRepVentas_Click(object sender, EventArgs e)
        {
            //...
            //Códigos para formularios
            //...
            ocultarSubmenu();
        }

        private void btnGenNomina_Click(object sender, EventArgs e)
        {
            //...
            //Códigos para formularios
            //...
            ocultarSubmenu();
        }
#endregion
    }
}
