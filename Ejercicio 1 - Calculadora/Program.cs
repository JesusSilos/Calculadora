
double numero1 = 0, numero2 = 0;
bool detenerCalculadora = false;
string? opcionElegidaEnLaConsola = string.Empty, valorDeLaConsola = string.Empty;

while (detenerCalculadora == false) { 
    Console.WriteLine("*********************************");
    Console.WriteLine("CALCULADORA DEVORAHOMBRES");
    Console.WriteLine("*********************************");
    Console.WriteLine("Este programa trabaja con 2 números. Elige una opción:");
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    Console.WriteLine("5. Salir de la calculadora");
    Console.WriteLine("*********************************");

    opcionElegidaEnLaConsola = Console.ReadLine();

    if (opcionElegidaEnLaConsola != "5") {
       
        Console.WriteLine("Dame el primer número");
        OperacionesDeValidacion.ValidaElNumero(Console.ReadLine(), ref numero1);


        Console.WriteLine("Dame el segundo número");
        OperacionesDeValidacion.ValidaElNumero(Console.ReadLine(), ref numero2);

        switch (opcionElegidaEnLaConsola)
        {
            case "1":
                Console.WriteLine($"El resultado de la suma es: {OperacionesMatematicas.SumarNumeros(numero1, numero2)}");
                break;
            case "2":
                Console.WriteLine($"El resultado de la resta es: {OperacionesMatematicas.RestarNumeros(numero1, numero2)}");
                break;
            case "3":
                Console.WriteLine($"El resultado de la multiplicación es: {OperacionesMatematicas.MultiplicarNumeros(numero1, numero2)}");
                break;
            case "4":
                Console.WriteLine($"El resultado de la división es: {OperacionesMatematicas.DividirNumeros(numero1, numero2)}");
                break;
        }

        Console.WriteLine("Presiona Enter para hacer otra operación");
        Console.ReadLine();
        Console.Clear();

    } else {
        detenerCalculadora = true;
        Console.WriteLine("Presiona Enter para salir...");
    }
}

Console.ReadLine();
