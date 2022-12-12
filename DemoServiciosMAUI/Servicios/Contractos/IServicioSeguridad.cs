namespace DemoServicios.Servicios.Contractos
{
    public interface IServicioSeguridad
    {
        Task<bool> ValidarCredenciales(string usuario, string contrasena);
    }
}
