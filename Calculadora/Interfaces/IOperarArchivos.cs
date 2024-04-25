
public interface IOperarArchivos
{

    public bool CrearArchivo(string rutaDeArchivo, string contenido);
    public void ModificarArchivo(string rutaDeArchivo, string contenido, bool sobrescribir);
    public string LeerArchivo(string rutaDeArchivo);
    public bool EliminarArchivo(string rutaDeArchivo);
    public bool ValidarExistenciaDeArchivo(string rutaDeArchivo);

}
