using System;
using System.Collections.Generic;

namespace proyectoGrupal01.components
{
    public class Producto
    {
        public string Nombre { get; }
        public int Cantidad { get; set; }

        public Producto(string nombre, int cantidad)
        {
            Nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            Cantidad = cantidad >= 0 ? cantidad : throw new ArgumentException("La cantidad no puede ser negativa.");
        }
    }

    public class Inventario
    {
        private readonly Dictionary<string, Producto> _productos;

        public Inventario()
        {
            _productos = new Dictionary<string, Producto>();
        }

        public void AgregarProducto(string nombre, int cantidad)
        {
            if (string.IsNullOrEmpty(nombre))
                throw new ArgumentNullException(nameof(nombre), "El nombre del producto no puede estar vacío.");
            if (cantidad <= 0)
                throw new ArgumentException("La cantidad debe ser mayor que cero.", nameof(cantidad));

            if (_productos.TryGetValue(nombre, out var productoExistente))
            {
                productoExistente.Cantidad += cantidad;
            }
            else
            {
                _productos.Add(nombre, new Producto(nombre, cantidad));
            }
        }

        public void RetirarProducto(string nombre, int cantidad)
        {
            if (string.IsNullOrEmpty(nombre))
                throw new ArgumentNullException(nameof(nombre), "El nombre del producto no puede estar vacío.");
            if (cantidad <= 0)
                throw new ArgumentException("La cantidad debe ser mayor que cero.", nameof(cantidad));

            if (_productos.TryGetValue(nombre, out var productoExistente))
            {
                if (productoExistente.Cantidad < cantidad)
                    throw new InvalidOperationException("No hay suficiente cantidad del producto en el inventario.");
                productoExistente.Cantidad -= cantidad;
                if (productoExistente.Cantidad == 0)
                    _productos.Remove(nombre);
            }
            else
            {
                throw new InvalidOperationException("El producto no existe en el inventario.");
            }
        }

        public void MostrarInventario()
        {
            Console.WriteLine("Inventario actual:");
            foreach (var producto in _productos.Values)
            {
                Console.WriteLine($"Producto: {producto.Nombre}, Cantidad: {producto.Cantidad}");
            }
        }
    }
}
