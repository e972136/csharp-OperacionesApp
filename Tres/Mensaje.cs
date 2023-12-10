

namespace Tres
{
    static class Mensaje
    {
        public static void MostrarNotificacion(string mensaje)
        {

            MainThread.BeginInvokeOnMainThread(async () =>
            {
                await App.Current.MainPage.DisplayAlert("Notificación", mensaje, "OK");
            });
        }
    }
}
