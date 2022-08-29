using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba2
{
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void GBClientes_Enter(object sender, EventArgs e)
        {

        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            /* Metodo que solo permite ingresar texto en caracteres y sin espacios en blanco
            primero se debe activar el evento keypress con ayuda del IDE */
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
            // con este flujo de datos se toma el enter cuando es presionado y cambia el focus
            // al text box inmediato
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txt_apellido.Focus();
            }
        }

        private void txt_apellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            /* Metodo que solo permite ingresar texto en caracteres y sin espacios en blanco
            primero se debe activar el evento keypress con ayuda del IDE */
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
            // con este flujo de datos se toma el enter cuando es presionado y cambia el focus
            // al text box inmediato
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txt_DNI.Focus();
            }
        }

        private void txt_DNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            /* Metodo que solo permite ingresar texto en caracteres y sin espacios en blanco
            primero se debe activar el evento keypress con ayuda del IDE */
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            // con este flujo de datos se toma el enter cuando es presionado y cambia el focus
            // al text box inmediato
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                TXT_tel.Focus();
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            lbl_cambiante.Text = "Guardado";


            if (txt_nombre.Text == "" || txt_apellido.Text == "" || txt_DNI.Text == "" || TXT_tel.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos!",
                                "ERROR!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                );

            }
            else
            {
                if (MessageBox.Show("Seguro que desea insertar nuevo cliente?",
                               "Guardar Datos!",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question,
                               MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    string nombre = txt_nombre.Text;
                    string apellido = txt_apellido.Text;
                    string nomyape = nombre + " " + apellido;

                    MessageBox.Show("se insertaron los datos de " + nomyape,
                                    "Cleinte Guardado",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information
                    );
                }
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            string nombre = txt_nombre.Text;
            string apellido = txt_apellido.Text;
            string nomyape = nombre + " " + apellido;
            if (MessageBox.Show("Esta a punto de eliminar a " + nomyape,
                               "Confirmar Eliminación",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question,
                               MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                lbl_cambiante.Text = nomyape;
                txt_nombre.Clear();
                txt_apellido.Clear();
                txt_DNI.Clear();
                TXT_tel.Clear();

                MessageBox.Show("El cliente: " + nomyape + " se eliminó correctamente",
                                    "Eliminar!",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information
                );
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb_mujer_CheckedChanged(object sender, EventArgs e)
        {
            pic_sexo.Image = prueba2.Properties.Resources.female;
            //= Practico2.Properties.Resources.female;
        }

        private void rb_varon_CheckedChanged(object sender, EventArgs e)
        {
            pic_sexo.Image = prueba2.Properties.Resources.male;
        }

        private void TXT_tel_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_DNI_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXT_tel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
