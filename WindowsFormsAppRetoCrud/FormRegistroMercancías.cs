using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppRetoCrud.Clases;

namespace WindowsFormsAppRetoCrud
{
    public partial class FormRegistroMercancías : FormPadreSinBorde
    {

        //variable global de UID
        public int UID;
        public FormRegistroMercancías()
        {
            InitializeComponent();
        }

        //función limpieza
        public void limpiar()
        {
            textBoxDescripción.Text = "";
            numericUpDownExistencia.Value = 0;
            textBoxComentario.Text = "";
            comboBoxStatus.Text = "Seleccione 1";
            radioButtonNo.Checked = false;
            radioButtonYes.Checked = false;
            buttonInsertar.Text = "Insertar";
            UID = 0;
        }

        private void FormRegistroMercancías_Load(object sender, EventArgs e)
        {
            dataGridViewMercancías.DataSource = ClassMercancías.leerDatos();
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate ()
           {
               this.Close();
           });
        }

        private void buttonInsertar_Click(object sender, EventArgs e)
        {
            string desc = textBoxDescripción.Text;
            int exist = (int) numericUpDownExistencia.Value;
            string comment = textBoxComentario.Text;
            string status = comboBoxStatus.Text;
            bool nEE = (radioButtonNo.Checked != true) ? false : true;

            if (UID != 0)
            {
                bool d = ClassMercancías.actualizarDatos(desc, exist, comment, status, nEE, UID);
                MessageBox.Show($"Datos Actualizados {d}", "RegistroMercancías");
                limpiar();
                dataGridViewMercancías.DataSource = ClassMercancías.leerDatos();
            } 
            else
            {
                if (desc != "" && desc != null)
                {
                    if (exist == 0 || exist > 0)
                    {
                        if (comment != "" && comment != null)
                        {
                            if (status != "" && status != "Seleccione 1")
                            {
                                if (nEE == true || nEE == false)
                                {
                                    ClassMercancías.insertarDatos(desc, exist, comment, status, nEE);
                                    limpiar();
                                    MessageBox.Show($"Datos Insertados Correctamente", "RegistroMercancías");
                                    dataGridViewMercancías.DataSource = ClassMercancías.leerDatos();
                                }
                                else
                                {
                                    MessageBox.Show("Faltan Campos Por llenar", "RegistroMercancías");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Faltan Campos Por llenar", "RegistroMercancías");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Faltan Campos Por llenar", "RegistroMercancías");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Faltan Campos Por llenar", "RegistroMercancías");
                    }
                }
                else
                {
                    MessageBox.Show("Faltan Campos Por llenar", "RegistroMercancías");
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {

            limpiar();

            UID = int.Parse(dataGridViewMercancías.CurrentRow.Cells["IdMercancía"].Value.ToString());
            string desc = dataGridViewMercancías.CurrentRow.Cells["Descripción"].Value.ToString();
            int exist = int.Parse(dataGridViewMercancías.CurrentRow.Cells["Existencia"].Value.ToString());
            string comment = dataGridViewMercancías.CurrentRow.Cells["Comentario"].Value.ToString();
            string status = dataGridViewMercancías.CurrentRow.Cells["Status"].Value.ToString();
            bool er = bool.Parse(dataGridViewMercancías.CurrentRow.Cells["NoEliminable"].Value.ToString());

            textBoxDescripción.Text = desc;
            numericUpDownExistencia.Value = exist;
            textBoxComentario.Text = comment;
            comboBoxStatus.Text = status;
           
            //condicional para saber cual de los 2 checks está activado
            if (er)
            {
                radioButtonNo.Checked = true;
            } else
            {
                radioButtonYes.Checked = false;
            }

            //cambia el valor del boton insertar!
            buttonInsertar.Text = "Actualizar";
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (UID != 0)
            {
                ClassMercancías.eliminarDatos(UID);
                MessageBox.Show("Registro Eliminado Correctamente", "RegistroMercancías");
            } else
            {
                MessageBox.Show("Oops!, No ha seleccionado un registro para eliminar", "RegistroMercancías");
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" v1.0.0 - Es un Crud Sencillo de Usar con sus respectivas funcionalidades: \n\n1- Para Insertar solo debe llenar los campos y darle click al botón Insertar \n\n2 - Para Actualizar debes primero seleccionar con un click el registro que deseas actualizar, darle click al botón seleccionar y luego darle al botón actualizar después de cambiar el dato. \n\n3- Lo mismo para eliminar, seguir el paso 2 hasta la parte de seleccionar, después de ahí es solo darle eliminar. \n\nrecuerde para deseleccionar algún registro debe darle a limpiar", "");
        }
    }
}
