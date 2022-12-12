using DemoServicios.Servicios.Contractos;

namespace DemoServicios.Platforms.Android.Servicios
{
    public class SeguridadDroid : IServicioSeguridad
    {
        public async Task<bool> ValidarCredenciales(string usuario, string contrasena)
        {
            await Task.Delay(1);
            return (usuario == "usuario" && contrasena == "Android");
        }
    }
}
