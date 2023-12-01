namespace Exmn3unidad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Cuando hay r de la r?");

            ListaCarros listac = new ListaCarros();
            Console.WriteLine("Porfavor aqui abajo ingresa los datos de el carro a agregar: ");
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine($"Ingresa la marca: ");
                string marca = Console.ReadLine();
                Console.WriteLine($"Ingresa el modelo: ");
                string modelo = Console.ReadLine();
                Console.WriteLine($"Ingresa el año de lanzamiento:");
                int año = int.Parse( Console.ReadLine() );  
                listac.AgregarCarro(marca,modelo,año);
            }
        }
    }
}