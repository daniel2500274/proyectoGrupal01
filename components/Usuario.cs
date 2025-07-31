using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoGrupal01.components
{
    public class Usuario
    {
        private string nombre;
        private string dpi;
        private string contrasenia;

        public Usuario(string nombre, string dpi, string contrasenia)
        {
            this.nombre = nombre;
            this.dpi = dpi;
            this.contrasenia = contrasenia;
        }

        public string Autenticar(string pass)
        {

            if (string.IsNullOrEmpty(nombre))
            {
                return "El nombre no puede estar vacío.";  
            }
            if (string.IsNullOrEmpty(dpi))
            {
                return "El DPI no puede estar vacío.";
            }
            if (dpi.Length != 13)
            {
                return "El DPI debe tener exactamente 13 caracteres.";
            }
            if (string.IsNullOrEmpty(pass))
            {
                return "La contraseña no puede estar vacía.";
            }
            if (pass.Length < 6)
            {
                return "La contraseña debe tener minimo 6 caracteres";
            }
            if (pass == contrasenia)
            {
                return $"Autenticación exitosa.";
            }
            else
            {
                return "Contraseña incorrecta.";
            }

        }
    }
}
