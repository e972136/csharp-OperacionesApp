
namespace Tres;

public partial class Sumar : ContentPage
{
	public Sumar()
	{
		InitializeComponent();
	}

	private void OnButtonClicked(object sender, EventArgs e)
	{
		try
		{
            var dato1 = double.Parse(Dato1.Text);
            var dato2 = double.Parse(Dato2.Text);
            var dato3 = double.Parse(Dato3.Text);
            var resultado = dato1 + dato2 + dato3;
            Respuesta.Text = resultado.ToString();
        }catch(Exception ex)
		{
            Mensaje.MostrarNotificacion(ex.Message);         
        }
    }


}