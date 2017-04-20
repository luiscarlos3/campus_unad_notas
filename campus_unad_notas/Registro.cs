using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace campus_unad_notas.Clases
{
    public class Registro
    {
        private string Nombre;

        public string nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }

        private string Apellido;

        public string apellido
        {
            get { return Apellido; }
            set { Apellido = value; }
        }

        private string Identificacion;

        public string indentificacion
        {
            get { return Identificacion; }
            set { Identificacion = value; }
        }

        private string Curso;

        public string curso
        {
            get { return Curso; }
            set { Curso = value; }
        }

        public int sumatotalpuntos(int one, int two)
        {
            int result = one + two;
            return result;
        }

        public string calculanota(string resultado)
        {
            int result = int.Parse(resultado);
            int nota = result * 5 / 500;
            return nota.ToString();
        }

        public string estado(string nota)
        {
            if (int.Parse(nota) >= 3)
            {
                return ("aprobado");
            }
            else
            {
                return ("no aprobado");
            }

        }
    }
}
