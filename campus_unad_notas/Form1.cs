using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace campus_unad_notas
{
    public partial class Form1 : Form
    {
        List<Clases.Registro> Estudiantes = new List<Clases.Registro>();
        public Form1()
        {
           
            InitializeComponent();
        }

        private void Btnconsultar_Click(object sender, EventArgs e)
        {
            if (TxtIdentificacion.Text == "")
            {
                erropErrores.SetError(TxtIdentificacion, "debe ingresar datos");
            }
            else
            {
                erropErrores.Clear();
            }
            
            if (txtNombre.Text == "")
            {
                erropErrores.SetError(txtNombre, "error debe ingresar nombre");
            }
            else
            {
                erropErrores.Clear();
            }

            if (TxtApellido.Text == "")
            {
                erropErrores.SetError(TxtApellido, " error debe ingresar apellido");
            }
            else
            {
                erropErrores.Clear();
            }

            if (txtCurso.Text == "")
            {
                erropErrores.SetError(txtCurso, "error debe ingresar nombre del curso");
            }
            else
            {
                erropErrores.Clear();
            }

            Clases.Registro estudiante = new Clases.Registro();          
            estudiante.nombre = txtNombre.Text;
            estudiante.apellido = TxtApellido.Text;
            estudiante.indentificacion = TxtIdentificacion.Text;
            estudiante.curso = txtCurso.Text;
            Estudiantes.Add(estudiante);


            setnombres.Text = txtNombre.Text.ToString();
            setapellidos.Text = TxtApellido.Text;
            setcurso.Text = txtCurso.Text;
            label13.Text = txtpuntosone.Text;
            label14.Text = txtpuntostwo.Text;
            resultado.Text = estudiante.sumatotalpuntos(int.Parse(txtpuntosone.Text), int.Parse(txtpuntostwo.Text)).ToString();
            label16.Text = estudiante.calculanota(resultado.Text);
            label15.Text = estudiante.estado(label16.Text);
            DateTime fecha = DateTime.Now;
            label17.Text = fecha.ToString();
            limpiar();
            
        }

        public void limpiar()
        {
            txtNombre.Clear();
            TxtApellido.Clear();
            TxtIdentificacion.Clear();
            txtCurso.Clear();
        }        
   
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (validarIndetifacion() == false)
            {
                return;
            }
        }

        private bool validarIndetifacion()
        {
            if (TxtIdentificacion.Text == "")
            {
                erropErrores.SetError(TxtIdentificacion, "debe ingresar numero para buscar");
                return false;

            }
            else
            {
                erropErrores.Clear();
                return true;

            }
        }
      
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
