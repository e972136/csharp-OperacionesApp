namespace Tres;

public partial class Division : ContentPage
{
	public Division()
	{
		InitializeComponent();
	}

    private void OnButtonClicked(object sender, EventArgs e)
    {
        try
        {
            var dato1 = double.Parse(Dato1.Text);
            var dato2 = double.Parse(Dato2.Text);
            if (dato2 == 0)
            {
                Mensaje.MostrarNotificacion("No se puede divir con 0");
                return;
            }
            var resultado = dato1 / dato2;
            Respuesta.Text = resultado.ToString();
        }
        catch (Exception ex)
        {
            Mensaje.MostrarNotificacion(ex.Message);
        }

    }
}