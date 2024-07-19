namespace Tarea1.Views;

public partial class vHome : ContentPage
{
    public vHome()
    {
        InitializeComponent();
    }

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {
        string nombre = txtNombre.Text;
        string apellido = txtApellido.Text;
        string importe = txtImporte.Text;
        int edad = Convert.ToInt32(txtedad.Text);

        decimal salarioMensual = Convert.ToDecimal(importe.ToString());
        decimal porcentaje = 0.0945m;
        decimal resultado = salarioMensual * porcentaje;

        DisplayAlert("MENSAJE DE BIENVENIDA", "BIENVENID@ " + nombre + apellido + "\nTIENES " + edad + " AÑOS" + "\nTU IMPORTE MENSUAL ES: " + resultado, "CERRAR");

    }
}