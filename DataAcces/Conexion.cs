
namespace Proyecto_CRUD.DataAcces;

public class Conexion
{
    //La idea es obtener la cadena de conexión de appsettings.json
    private readonly string _cadenaSQL = string.Empty;

    //IConfiguration es una interfaz que te permite acceder fácilmente a la configuración
    //de tu aplicación (como appsettings.json) usando inyección de dependencia

    public Conexion(IConfiguration configuration)
    {
        _cadenaSQL = configuration.GetConnectionString("CadenaSQL");
    }

    public string GetCadetaSQL()
    {
        return _cadenaSQL;
    }
}