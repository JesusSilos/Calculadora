using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class OperacionesMatematicas
{

    public static double SumarNumeros(double numeroUno, double numeroDos) => numeroUno + numeroDos;
        
    public static double RestarNumeros(double numeroUno, double numeroDos) => numeroUno - numeroDos;
      
    public static double MultiplicarNumeros(double numeroUno, double numeroDos) => numeroUno * numeroDos;

    public static double DividirNumeros(double numeroUno, double numeroDos) => numeroUno / numeroDos;

}

internal class OperacionesDeValidacion {

    public static void ValidaElNumero(string? valorDeLaConsola, ref double numero) {

        bool esValidoElNumero = false;
        while (!esValidoElNumero)
        {
            esValidoElNumero = double.TryParse(valorDeLaConsola, out numero);
            if (!esValidoElNumero) Console.WriteLine($"El valor '{valorDeLaConsola}' que escribiste NO es válido. Escribe un número válido.");
        }

    }

}


