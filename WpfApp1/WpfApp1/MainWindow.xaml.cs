﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.Clase; //pRIMERO EL NOMBRE DEL PROYECTO (LITERALMENTE)
using SQLite;//Agregar

namespace WpfApp1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            Contactos contacto = new Contactos()
            {
                Nombre = txtNombre.Text,
                Correo =txtCorreo.Text,
                Telefono = txtTelefono.Text
            };
            using (SQLiteConnection conexion=new SQLiteConnection(App.databasePath))
                {
                conexion.CreateTable<Contactos>();
                conexion.Insert(contacto);
                 }
            Close();
        }

        private void TxtNombre_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
