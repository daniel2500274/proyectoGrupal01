namespace proyectoGrupal01.components;

public class Producto
{  
    // Atributos privados
    private static int _correlativoID = 1;
    private int _id;
    private string _nombreProducto;
    private int _moneda;
    private float _precio;
    // Constructor
    public Producto(string nombreProducto, int moneda, int precio)
    {
        if (moneda == 1 || moneda == 2)
        {
           
        }
        else
        {
            throw new ArgumentException("La moneda solo puede ser 1 'GTG' o 2 'USD$' "); 
        }    
    }
}