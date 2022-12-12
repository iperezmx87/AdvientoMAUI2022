using DemoServicios.Servicios.Contractos;

namespace DemoServicios.Platforms.iOS.Servicios
{
    public class SeguridadApple : IServicioSeguridad
    {
        public async Task<bool> ValidarCredenciales(string usuario, string contrasena)
        {
            await Task.Delay(1);
            return (usuario.ToLower() == "usuario" && contrasena == "Apple");
        }
    }
}
