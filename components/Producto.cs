namespace proyectoGrupal01.components.components;

public class Producto
{  
    // Atributos privados
    private static int _correlativoID = 1;
    private int _id;
    private string _nombreProducto;
    private int _moneda;
    private int _cantidad;
    private float _precio;
    // Constructor
    public Producto(string nombreProducto, int moneda,int cantidad, int precio)
    {
        if (moneda != 1 && moneda != 2)
        {
            throw new ArgumentException("La moneda solo puede ser 1 'GTQ' o 2 'USD' "); 
        }    
        if (string.IsNullOrWhiteSpace(nombreProducto))
        {
            throw new ArgumentException("El nombre del producto no puede estar vacío.", nameof(nombreProducto));
        }
        if (precio < 0)
        {
            throw new ArgumentException("El precio no puede ser negativo.", nameof(precio));
        }

        if (cantidad <= 0)
        {
            throw new ArgumentException("Agrega más de un producto al inventario", nameof(cantidad));   
        }
        _id = _correlativoID++;
        _nombreProducto = nombreProducto;
        _moneda = moneda;
        _precio = precio;
    }
    //propiedades publicas para solo lectura
    public int Id => _id;
    public string NombreProducto => _nombreProducto;
    public int Moneda => _moneda;
    public float Precio => _precio;
    // metodo para formatear consultas
    public override string ToString()
    {
        string divisa = _moneda == 1 ? "GTQ" : "USD";
        return $"ID: {_id} - {_nombreProducto} - {divisa} - {_precio}";
    }
    //Metodo interno encapsulado para agregar productos
    internal void AgregarProducto(int cantidad)
    {
        if (cantidad <= 0)
        {
            throw new ArgumentException("Agrega más de un producto al inventario", nameof(cantidad));
        }
        _cantidad += cantidad;
    }
    //Metodo interno encapsulado para quitar productos
    internal void QuitarProducto(int cantidad)
    {
        if (cantidad > _cantidad)
        {
            throw new ArgumentException("No hay suficientes productos en el inventario", nameof(cantidad));
        }
        _cantidad -= cantidad;
    }
}