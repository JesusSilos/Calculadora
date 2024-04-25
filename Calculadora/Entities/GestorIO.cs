
public class GestorIO : IOperarArchivos, IOperarCarpetas
    {
        public bool CrearArchivo(string rutaDeArchivo, string contenido)
        {
            File.Create(rutaDeArchivo);
            File.WriteAllText(rutaDeArchivo, contenido);
            return true;
        }

        public void ModificarArchivo(string rutaDeArchivo, string contenido, bool sobrescribir)
        {
            if (sobrescribir)
            {
                var textoActual = LeerArchivo(rutaDeArchivo);
                EliminarArchivo(rutaDeArchivo);
                CrearArchivo(rutaDeArchivo, textoActual += contenido);
            }
            else
            {
                EliminarArchivo(rutaDeArchivo);
                CrearArchivo(rutaDeArchivo, contenido);
            }
        }

        public bool EliminarArchivo(string rutaDeArchivo)
        {
            File.Delete(rutaDeArchivo);
            return true;
        }

        public string LeerArchivo(string rutaDeArchivo)
        {  
            return File.ReadAllText(rutaDeArchivo);
        }

        public bool ValidarExistenciaDeArchivo(string? rutaDeArchivo)
        {

            if (File.Exists(rutaDeArchivo))
            {
                return true;
            }
            else
            { 
                return false;
            }

        }

        public bool CrearCarpeta(string? rutaDeCarpeta)
        {
            if ((!string.IsNullOrEmpty(rutaDeCarpeta)) && !string.IsNullOrWhiteSpace(rutaDeCarpeta))
            {    
                Directory.CreateDirectory(rutaDeCarpeta);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool EliminarCarpeta(string rutaDeCarpeta)
        {
            Directory.Delete(rutaDeCarpeta);
            return true;
        }

        public bool ValidarExistenciaDeCarpeta(string rutaDeCarpeta)
        {
            if (Directory.Exists(rutaDeCarpeta))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    public bool ValidarLaRuta(string? rutaDeArchivo) 
    {
        if ((!string.IsNullOrEmpty(rutaDeArchivo)) && !string.IsNullOrWhiteSpace(rutaDeArchivo))
        {
            if (Path.Exists(rutaDeArchivo)) { return true; } else { return false; }

        }
        else
        {   
        return false;
        }
    }

}
