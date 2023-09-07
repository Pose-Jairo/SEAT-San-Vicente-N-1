using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Diseño.Formularios
{
    public partial class PrincipalFrm : Form
    {
        public PrincipalFrm()
        {
            InitializeComponent();
            MenuFrm menu = new MenuFrm();
            menu.TopLevel = false;
            menu.FormBorderStyle = FormBorderStyle.None;
            menu.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(menu);
            menu.Show();
        }
    }
}
