using DemoServicios.Servicios.Contractos;

namespace DemoServicios;

public partial class App : Application
{
	private IServicioSeguridad servicioSeguridad;

	public App(IServicioSeguridad _servicioSeguridad)
	{
		InitializeComponent();

		servicioSeguridad = _servicioSeguridad;

		MainPage = new MainPage(servicioSeguridad);
	}
}
