// Declaramos el espacio de nombres
namespace DPRN2_U3_A2_JOIT
{
    // Declaramos la clase MonedaVirtual
    class MonedaVirtual
    {
    //Declaramos los atributos de la clase MonedaVirtual del tipo privado
     private int numero;
     private string nombre;
     private string id;
     private float precio;
     private float montoDlls;
     private float cantidadMonedas;
     //Creacion del nuevo atributo de tipo privado fechaPrecio
     private DateTime fechaPrecio;
    
     //Declaramos las propiedades para los atributos de la clase MonedaVirtual
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public float MontoDlls
        {
            get { return montoDlls; }
            set { montoDlls = value; }
        }
        public float CantidadMonedas
        {
            get { return cantidadMonedas; }
            set { cantidadMonedas = value; }
        }
        //Creacion de la propiedad encapsulada para el nuevo atributo fechaPrecio
        public DateTime FechaPrecio
        {
            get { return fechaPrecio; }
            set { fechaPrecio = value; }
        }
        
        
        //Declaramos un metodo para capturar los datos de la moneda virtual
        public void CapturarMoneda(){
            //Creamos un bloque try-catch para capturar una excepcion del tipo formatException en caso de que el usuario no capture un numero para la variable numero
            try{
                Console.Write("Ingrese el numero que ocupa la moneda virtual por capitalización de mercado: ");
                this.numero = int.Parse(Console.ReadLine());
            }catch(FormatException e){
                Console.WriteLine("El caracter capturado no es un numero "+ "'" + e.Message + "'");
                Menu();                
            }

            //Creamos un bloque try-catch para capturar una excepcion del tipo formatException en caso de que el usuario no capture una cadena de caracteres para la variable nombre y variable ID
            try{
            Console.Write("Ingrese el nombre de la moneda virtual: ");
            this.nombre = Console.ReadLine();
            }catch(FormatException e){
                Console.WriteLine("No se ha capturado una cadena de caracteres correcto para la moneda virtual "+ "'" + e.Message + "'");
                Menu();
                
            }try{
                Console.Write("Ingrese el id de la moneda virtual por ejemplo BTC, ETH ó XRP: ");
            this.id = Console.ReadLine();
            }catch(FormatException e){
                Console.WriteLine("No se ha capturado una cadena de caracteres correcto para el id de la moneda virtual " + "'" + e.Message + "'");
                Menu();                
            }

            //Creamos un bloque try-catch para capturar una excepcion del tipo formatException en caso de que el usuario no capture un numero flotante para la variable precio
            try{
            Console.Write("Ingrese el precio de la moneda virtual: ");
            this.precio = float.Parse(Console.ReadLine());
            }catch(FormatException e){
                Console.WriteLine("El precio capturado debe ser númerico y del tipo $125.10 "+ "'" + e.Message + "'");
                Menu();
            }
            GuardarInformacion();
            Menu();
        }
    //Declaramos el metodo guardarInformación para almacenar los datos de la moneda virtual
    public void GuardarInformacion()
    {
        
       // III. Modificamos el metodo guardarInformacion para que permita guardar informacion de las primeras 10 monedas virtuales que aparecen en CoinMarketCap
        
        MonedaVirtual[] nuevaMoneda = 
        {
                    new MonedaVirtual(){Nombre = "Bitcoin", Id = "BTC", Precio=15343.45f},
                    new MonedaVirtual(){Nombre = "Ethereum", Id = "ETH",Precio = 12957.74f},
                    new MonedaVirtual(){Nombre = "Tether",Id = "USDT", Precio = 1.0f},
                    new MonedaVirtual(){Nombre = "BNB", Id = "BNB",Precio = 303.90f},
                    new MonedaVirtual(){Nombre = "USDCOIN", Id = "USDC", Precio = 1.0f},
                    new MonedaVirtual(){Nombre = "BINANCEUSD", Id = "BUSD", Precio = 1.0f},
                    new MonedaVirtual(){Nombre = "XRP", Id = "XRP", Precio = 0.3962f},
                    new MonedaVirtual(){Nombre = "Cardano", Id = "ADA", Precio = 0.3718f},
                    new MonedaVirtual(){Nombre = "Dogecoin", Id = "DOGE", Precio = 0.09072f},   
        };          
        //Imprimir en consola el precio de las primeras 10 monedas virtuales
        int contador = 0;
        while (contador < nuevaMoneda.Length)
        {
            //Imprimimos en consola el precio de las primeras 10 monedas virtuales
            Console.WriteLine("El precio de la moneda virtual " + nuevaMoneda[contador].Nombre + " es de " + nuevaMoneda[contador].Precio);
            contador = contador + 1;
        }
        Menu();
    }
    
        public void realizarCompra(MonedaVirtual[] nuevaMoneda)
        {
            //Creamos un bloque try-catch para capturar una excepcion del tipo formatException en caso de que el usuario no capture un numero flotante para la variable montoDlls
            int i;
            try{
           Console.Write("Ingrese el monto en dolares que desea invertir: ");
           this.montoDlls = float.Parse(Console.ReadLine());
            }catch(FormatException e){
                Console.WriteLine("El monto capturado en dolares debe contener valores del tipo $125.10 "+ "'" + e.Message + "'");
                Menu(); 
            }
              //Creamos un ciclo for para mostrar las monedas virtuales disponibles
            for ( i = 0; i < nuevaMoneda.Length; i++){
                Console.WriteLine("Moneda virtual: " + nuevaMoneda[i].Nombre + " ID: " + nuevaMoneda[i].Id + " Precio: " + nuevaMoneda[i].Precio);
            }
            //Le pedimos al usuario que capture el id de la moneda virtual que desea comprar
            Console.WriteLine("Capture el precio actual de la moneda que desea comprar: ");
            this.precio = float.Parse(Console.ReadLine());
            //Asignamos el id que eligio el usuario 
            
            if(this.montoDlls<this.precio){
                Console.WriteLine("No cuenta con los recursos suficientes para realizar la compra");
            }else{
                cantidadMonedas = this.montoDlls/this.precio;
                Console.WriteLine("La cantidad de monedas que se pueden comprar es: " + cantidadMonedas);
            }                           
        }
        //Creamos un metodo que contenga un menu para que el usuario pueda elegir que desea hacer
        public void Menu(){
            //Creamos un bloque try-catch para capturar una excepcion del tipo formatException en caso de que el usuario no capture un numero para la variable opcion
            try{
            Console.WriteLine("1. Capturar moneda virtual");
            Console.WriteLine("2. Guardar información");
            Console.WriteLine("3. Realizar compra");
            Console.WriteLine("4. Salir");
            Console.Write("Ingrese la opción que desea realizar: ");
            int opcion = int.Parse(Console.ReadLine());
            //Creamos un bloque switch para que el usuario pueda elegir que desea hacer
            switch(opcion){
                case 1:
                CapturarMoneda();
                break;
                case 2:
                GuardarInformacion();
                break;
                case 3:
               //Opcion para realizar compra de monedas virtuales
                      
                                
                break;
                case 4:
                Environment.Exit(0);
                break;
                default:
                Console.WriteLine("La opción que ingresó no es correcta");
                Menu();
                break;
            }
            }catch(FormatException e){
                Console.WriteLine("La opción que ingresó no es correcta, capture un numero del 1 al 4"+e.Message);
                Menu();
            }finally{
                System.Console.Read();
            }
        }

    }
}