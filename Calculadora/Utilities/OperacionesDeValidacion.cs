public class OperacionesDeValidacion {

    public static void ValidaElNumero(string? valorDeLaConsola, ref double numero) {

        bool esValidoElNumero = false;
        while (!esValidoElNumero)
        {
            esValidoElNumero = double.TryParse(valorDeLaConsola, out numero);
            if (!esValidoElNumero) Console.WriteLine($"El valor '{valorDeLaConsola}' que escribiste NO es válido. Escribe un número válido.");
        }

    }

}


