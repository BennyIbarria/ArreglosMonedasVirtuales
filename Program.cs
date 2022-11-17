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
           
           //Llamamos al metodo Menu y accedemos a toda la clase MonedaVirtual
           nvaMoneda.GuardarInformacion();
        }
    }
}
