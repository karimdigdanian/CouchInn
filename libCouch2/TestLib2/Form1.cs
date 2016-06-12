using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using libCouch2.Clases;
using libCouch2.Modelo;

namespace TestLib2
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            USUARIO Us = new USUARIO();
            Us.ID_USUARIO = 2;
            Us.ID_PERSONA = 2;
            string conec = @"data source=PATOTECKPC\SQLEXPRESS;initial catalog=BD_SHAREIT_PROYECTO_COUCHINN;persist security info=True;user id=Usuario;password=123;MultipleActiveResultSets=True;App=EntityFramework";
            ClaseDeConfiguracion.SQLConnectionString = conec;
            this.usContribucion1.Usuario = Us;
            this.usContribucion1.Inicializar();
        }
    }
}
