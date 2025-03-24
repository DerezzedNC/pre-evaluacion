using System;
using System.IO;

class InventarioTienda
{
    static void Main()
    {
        string archivo = "inventario.json";

        Console.Write("Código del producto: ");
        string codigo = Console.ReadLine();

        Console.Write("Nombre del producto: ");
        string nombre = Console.ReadLine();

        Console.Write("Cantidad en stock: ");
        string cantidad = Console.ReadLine();

        Console.Write("Precio unitario: ");
        string precio = Console.ReadLine();

        
        string linea = $"{codigo},{nombre},{cantidad},{precio}";
        File.AppendAllText(archivo, linea + Environment.NewLine);

      
        Console.WriteLine("\nProductos registrados:");
        string[] lineas = File.ReadAllLines(archivo);
        foreach (string l in lineas)
        {
            string[] datos = l.Split(',');
            Console.WriteLine($"Código: {datos[0]}, Nombre: {datos[1]}, Stock: {datos[2]}, Precio: {datos[3]}");
        }
    }
}
