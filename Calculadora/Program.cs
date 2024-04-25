
double numero1 = 0, numero2 = 0;
bool ubicacionValida = false, detenerCalculadora = false;
string? opcionElegidaEnLaConsola = string.Empty, valorDeLaConsola = string.Empty, resultado = string.Empty, ruta = string.Empty, archivo = string.Empty;
GestorIO gestorIO = new GestorIO();

while (!detenerCalculadora) { 
    Console.WriteLine("*********************************");
    Console.WriteLine("CALCULADORA");
    Console.WriteLine("*********************************");
    Console.WriteLine("Este programa trabaja con 2 números. Elige una opción:");
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    Console.WriteLine("5. Salir de la calculadora");
    Console.WriteLine("*********************************");

    opcionElegidaEnLaConsola = Console.ReadLine();

        switch (opcionElegidaEnLaConsola)
        {
            case "1":
                //Console.WriteLine($"El resultado de la suma es: {OperacionesMatematicas.SumarNumeros(numero1, numero2)}");
                PedirNumeros();
                resultado = $"El resultado de la suma es: {OperacionesMatematicas.SumarNumeros(numero1, numero2)}";
                break;
            case "2":
                //Console.WriteLine($"El resultado de la resta es: {OperacionesMatematicas.RestarNumeros(numero1, numero2)}");
                PedirNumeros();
                resultado = $"El resultado de la resta es: {OperacionesMatematicas.RestarNumeros(numero1, numero2)}";
                break;
            case "3":
                //Console.WriteLine($"El resultado de la multiplicación es: {OperacionesMatematicas.MultiplicarNumeros(numero1, numero2)}");
                PedirNumeros();
                resultado = $"El resultado de la multiplicación es: {OperacionesMatematicas.MultiplicarNumeros(numero1, numero2)}";
                break;
            case "4":
                //Console.WriteLine($"El resultado de la división es: {OperacionesMatematicas.DividirNumeros(numero1, numero2)}");
                PedirNumeros();
                resultado = $"El resultado de la división es: {OperacionesMatematicas.DividirNumeros(numero1, numero2)}";
                break;
            case "5":
                detenerCalculadora = true;
                Console.WriteLine("Presiona Enter para salir...");
                break;
            default:
                Console.WriteLine("Operación inválida");
                break;
        }

        DefinirRutaDeCarpeta();
        DefinirArchivo();
        
        Console.WriteLine("Presiona Enter para hacer otra operación");
        Console.ReadLine();
        Console.Clear();

    }

void PedirNumeros(){
    Console.WriteLine("Dame el primer número");
    OperacionesDeValidacion.ValidaElNumero(Console.ReadLine(), ref numero1);


    Console.WriteLine("Dame el segundo número");
    OperacionesDeValidacion.ValidaElNumero(Console.ReadLine(), ref numero2);
}

void DefinirRutaDeCarpeta() {

    Console.WriteLine("Escribe la ruta de la carpeta donde se almacenará el resultado:");
    while (!ubicacionValida)
    {
        ruta = Console.ReadLine();
        if (!gestorIO.ValidarLaRuta(ruta))
        {
            Console.WriteLine("Ruta inválida, escribe una ruta válida.");
        }
    };

}

void DefinirArchivo() {

    Console.WriteLine("Escribe el nombre del archivo que será creado");
    string? respuesta = string.Empty;
    archivo = Console.ReadLine();

    if (gestorIO.ValidarExistenciaDeArchivo(string.Concat(ruta, @"\", archivo)))
    {
        Console.WriteLine("El archivo ya existe. ¿Quieres agregar la información (1) o crear el archivo nuevamente (2)?");
        while (respuesta != "1" && respuesta != "2")
        {
            respuesta = Console.ReadLine();
            if (respuesta != "1" && respuesta != "2")
            {
                Console.WriteLine("Elige una opción válida. Agregar la información (1) o crear el archivo nuevamente (2)");
            }
        }

        if (respuesta == "1")
        {
            gestorIO.ModificarArchivo(string.Concat(ruta, @"\", archivo), resultado, true);
            Console.WriteLine("Archivo actualizado.");
        }
        else
        {
            gestorIO.ModificarArchivo(string.Concat(ruta, @"\", archivo), resultado, false);
            Console.WriteLine("Archivo creado correctamente.");
        }

    }
    else
    {
        if (gestorIO.CrearCarpeta(ruta))
        {
            if (gestorIO.CrearArchivo(string.Concat(ruta, @"\", archivo), resultado))
            {
                Console.WriteLine("Archivo creado correctamente.");
            }
        }
    }

}

Console.ReadLine();

//Guardar lo de console writeline en una variable
//Si existe el archivo, lo sobrescribe
//Si no existe el archivo, lo crea