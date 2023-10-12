
class Programa
{
    static void Main()
    {
        List<object> listaVacia = new List<object>();

        // Agregando valores a la lista
        listaVacia.Add(7);
        listaVacia.Add(28);
        listaVacia.Add(-1);
        listaVacia.Add(true);
        listaVacia.Add("silla");

        int suma = 0;

        foreach (var elemento in listaVacia)
        {
            if (elemento is int)
            {
                suma += (int)elemento;
            }
        }

        Console.WriteLine("La suma de los valores int es: " + suma);
    }
}
