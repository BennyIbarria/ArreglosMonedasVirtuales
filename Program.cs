//Declaramos el espacio de nombres
namespace DPRN2_U3_A2_JOIT
{
    //Creamos la clase Program
    class Program
    {
        //Creamos el metodo Main
        public static void Main(string[] args)
        {
           //Creamos un nuevo objeto de la clase MonedaVirtual
           MonedaVirtual nvaMoneda = new MonedaVirtual(); 
           MonedaVirtual[] listaMonedas = new MonedaVirtual[10];       
           
           nvaMoneda.GuardarInformacion();
           nvaMoneda.realizarCompra(listaMonedas);
           
        }
    }
}
