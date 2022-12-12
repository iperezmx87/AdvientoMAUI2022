using DemoServicios.Servicios.Contractos;

namespace DemoServicios;

public partial class MainPage : ContentPage
{
    private IServicioSeguridad servicioSeguridad;

    public MainPage(IServicioSeguridad _servicioSeguridad)
	{
		InitializeComponent();

		servicioSeguridad = _servicioSeguridad;
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        // validando el login

        if (await servicioSeguridad.ValidarCredenciales(txtEmail.Text, txtContra.Text))
        {
            await DisplayAlert("App chida", "Credenciales correctas, bienvenido", "Aceptar");
        }
        else
        {
            await DisplayAlert("App chida", "Credenciales inválidas", "Aceptar");
        }
    }
}

