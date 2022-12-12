using DemoServicios.Servicios.Contractos;

namespace DemoServicios.Platforms.Windows.Servicios
{
    public class SeguridadWindows : IServicioSeguridad
    {
        public async Task<bool> ValidarCredenciales(string usuario, string contrasena)
        {
            await Task.Delay(1);
            return (usuario == "usuario" && contrasena == "Windows");
        }
    }
}
