﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Controls;
using libCounchinn.Clases;
using libCounchinn.Controles;


namespace ProyectoIngSoft
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
<<<<<<< HEAD
            //string conect = @"data source=PATOTECK\SQLEXPRESS;initial catalog=BD_SHAREIT_PROYECTO_COUCHINN;integrated security=True;";
            string conect = @"data source=192.168.0.12;initial catalog=BD_SHAREIT_PROYECTO_COUCHINN;persist security info=True;user id=Grupo35;password=1111;MultipleActiveResultSets=True;App=EntityFramework";
            libCounchinn.Clases.ClaseDeConfiguracion.SQLConnectionString = conect;
            this.ucCuerpo1.Inicializar();
            //this.ucReservar1.Inicializar(5);
=======
            string conect = @"data source=PATOTECK\SQLEXPRESS;initial catalog=BD_SHAREIT_PROYECTO_COUCHINN;integrated security=True;";
            //string conect = @"data source=192.168.0.12;initial catalog=BD_SHAREIT_PROYECTO_COUCHINN;persist security info=True;user id=Grupo35;password=1111;MultipleActiveResultSets=True;App=EntityFramework";
            libCounchinn.Clases.ClaseDeConfiguracion.SQLConnectionString = conect;
            this.ucCuerpo1.Inicializar();
>>>>>>> d62441738278bd8b51b78c7df77bdb6611298dd2
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ucLogin22_EventoLoginSactifactorio()
        {

        }
    }
}
