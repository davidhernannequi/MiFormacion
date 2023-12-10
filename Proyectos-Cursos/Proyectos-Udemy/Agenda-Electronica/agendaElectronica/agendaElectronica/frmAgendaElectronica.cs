using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace agendaElectronica
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        string[] _dnis = new string[10];
        string[] _nombres = new string[10];
        string[] _apellidos = new string[10];
        string[] _direcciones = new string[10];
        string[] _FechasNacimiento = new string[10];
        string[] _telefonos = new string[10];

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            string indiceText = txtIndice.Text;
            int indiceNum = int.Parse(indiceText);

            if (indiceNum < 9)
            {
                indiceNum++;
                txtIndice.Text = indiceNum.ToString();
                
                txtDni.Text = _dnis[indiceNum];
                txtNombre.Text = _nombres[indiceNum];
                txtApellido.Text = _apellidos[indiceNum];
                txtDireccion.Text = _direcciones[indiceNum];
                txtNacimiento.Text = _FechasNacimiento[indiceNum];
                txtTelefono.Text = _telefonos[indiceNum];

            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            string indiceText = txtIndice.Text;
            int indiceNum = int.Parse(indiceText);

            if (indiceNum > 0)
            {
                indiceNum--;
                txtIndice.Text = indiceNum.ToString();

                txtDni.Text = _dnis[indiceNum];
                txtNombre.Text = _nombres[indiceNum];
                txtApellido.Text = _apellidos[indiceNum];
                txtDireccion.Text = _direcciones[indiceNum];
                txtNacimiento.Text = _FechasNacimiento[indiceNum];
                txtTelefono.Text = _telefonos[indiceNum];
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string indiceText = txtIndice.Text;
            int indiceNum = int.Parse(indiceText);

            _dnis[indiceNum] = txtDni.Text;
            _nombres[indiceNum] = txtNombre.Text;
            _apellidos[indiceNum] = txtApellido.Text;
            _direcciones[indiceNum] = txtDireccion.Text;
            _FechasNacimiento[indiceNum] = txtNacimiento.Text;
            _telefonos[indiceNum] = txtTelefono.Text;
        }

    }
}
