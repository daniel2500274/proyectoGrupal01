namespace proyectoGrupal01.components
{
    public class Libro
    {
        //atributos privados
        private static int _correlativosID = 1;
        private int _id;
        private string _titulo;
        private string _autor;
        private bool _disponible;
        private string _usuarioActualPrestado;
        //constructor 
        public Libro(string titulo, string autor)
            // por definicion todo libro nuevo nace disponible y sin usuario 
        {
            _id = _correlativosID++;
            _titulo = titulo ?? throw new ArgumentNullException(nameof(titulo));
            _autor = autor ?? throw new ArgumentNullException(nameof(autor));
            _disponible = true;
            _usuarioActualPrestado = " ";
        }
    
        // propiedades publicas para proteger contra escritura
        // nota mental: "=>" asigna el valor de las propiedades privadas a las publicas pero solo para leer
        public int Id => _id;
        public string Titulo => _titulo;
        public string Autor => _autor;
        public bool Disponible => _disponible;
        public string UsuarioActualPrestado => _usuarioActualPrestado;
    
        //encapsulamiento, se crean metodos para modificar los estados dentro de la misma clase
        internal void Prestar(string usuario)
        {
            if (string.IsNullOrEmpty(usuario))
                throw new ArgumentNullException(nameof(usuario), " El usuario no puede estar vacio");
            _disponible = false;
            _usuarioActualPrestado = usuario;
        }

        internal void Devolver()
        {
            _disponible = true;
            _usuarioActualPrestado = " ";
        }

        public override string ToString()
        {
            string estadoFormateado = _disponible ? "El titulo está disponible" : $"Prestado a {_usuarioActualPrestado}";
            return $"ID: {_id} - {_titulo} - {_autor} - {estadoFormateado}";
        }
    }
}