//See https://aka.ms/new-console-template for more information
using datos;
using modelo;

namespace calculon_V
{
    internal class Program
    {
        static void Main(string[] args)
        {   //en el MAIN no se colca codigo solo se llama metodos o funciones
            Console.WriteLine("Hola, Bienvenido a Calculon V su calculadora\n");
            
            Ejecucion();
            
        }
        private static void Ejecucion ()
        {   // aqui ejecutamos todo antes de llamarlo en MAIN y creamos objetos.
            Operaciones operar= new Operaciones ();
            NumeroModel modelo= new NumeroModel ();
            do
            {
            Console.WriteLine("Segun la operacion que desee realizar digite la opcion: ");
            Console.WriteLine("1: Suma");
            Console.WriteLine("2: Resta");
            Console.WriteLine("3: Multiplicacion");
            Console.WriteLine("4: Division");
            Console.WriteLine("5: Modelo");
            Console.WriteLine("6: Valor Absoluto");
            Console.WriteLine("7: Potencia");
            Console.WriteLine("8: Seno");
            Console.WriteLine("9: Raiz Cuadrada");
            Console.WriteLine("10: Redondeo");
            Console.WriteLine("11: Coseno");
            Console.WriteLine("12: Tangente");
            Console.WriteLine("13: Pi");
            Console.WriteLine("14: salir");
            //declarando variable de respuesta del cliente
            int respuestaUsuario= Convert.ToInt32(Console.ReadLine());
            if (respuestaUsuario < 15 && respuestaUsuario != 14 && respuestaUsuario != 6 && respuestaUsuario != 8 && respuestaUsuario != 9 && respuestaUsuario != 10 && respuestaUsuario != 11 && respuestaUsuario != 12 && respuestaUsuario != 13)
            {
                Console.WriteLine("digite el primer numero: ");
                modelo.Numero_A= Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("digite un siguiente numero: ");
                modelo.Numero_B= Convert.ToDouble(Console.ReadLine());
                

                switch (respuestaUsuario)
                {   case 1:
                        Console.WriteLine("la suma es igual a : "+operar.Suma(modelo));
                    break;
                    case 2:
                        Console.WriteLine("la resta es igual a : "+operar.Resta(modelo));
                    break;
                    case 3:
                        Console.WriteLine("la multiplicacion es igual a: "+operar.Multiplicacion(modelo));
                    break;
                    case 4:
                        Console.WriteLine("la division es igual a : "+operar.Division(modelo));
                    break;
                    case 5:
                        Console.WriteLine("El residuo es igual a : "+operar.Modulo(modelo));
                    break;
                    /*case 6:
                        Console.WriteLine("El valor absoluto de "+modelo.Numero_A+" es igual a : "+operar.Valor_Abs(modelo));
                        */
                    case 7:
                        Console.WriteLine(modelo.Numero_A+" elevado a "+modelo.Numero_B+" es igual a : "+operar.Potenciacion(modelo));
                    break;
                    /*case 8:
                        Console.WriteLine("El seno de"+modelo.Numero_A+" es igual a : "+operar.Seno(modelo));
                    break; */  
                     
                }   
            }
            else if (respuestaUsuario == 6 || respuestaUsuario == 8 || respuestaUsuario == 9 || respuestaUsuario == 10 || respuestaUsuario == 11 || respuestaUsuario == 12)
            {
                Console.WriteLine("digite un numero: ");
                modelo.Numero_A= Convert.ToDouble(Console.ReadLine());
                
                

                switch (respuestaUsuario)
                {   
                    case 6:
                        Console.WriteLine("El valor absoluto de "+modelo.Numero_A+" es igual a : "+operar.Valor_Abs(modelo));
                    break;
                    case 8:
                        Console.WriteLine("El seno de "+modelo.Numero_A+" es igual a : "+operar.Seno(modelo));
                    break;
                    case 9:
                        Console.WriteLine("la raiz cuadrada de "+modelo.Numero_A+" es igual a : "+operar.Raiz_Cuad(modelo));
                    break;
                    case 10:
                        Console.WriteLine("el entero mas cercano a "+modelo.Numero_A+" es : "+operar.Redondeo(modelo));
                    break;
                    case 11:
                        Console.WriteLine("el coseno de "+modelo.Numero_A+" es : "+operar.Coseno(modelo));
                    break;
                    case 12:
                        Console.WriteLine("la tangente de "+modelo.Numero_A+" es : "+operar.tangente(modelo));
                    break; 
                      
                }
            }// agregamos funcion 14//
            else if (respuestaUsuario== 14)
            {
                break;
            }
            else if (respuestaUsuario== 13)
            {
                switch (respuestaUsuario)
                {
                    case 13:
                    Console.WriteLine("el valor de pi es : "+operar.Pi(modelo));
                    break;
                }
            }
            else
            {
                Console.WriteLine("opcion incorrecta por favor elige otra opcion\n");
                continue;
            }
            
            Console.WriteLine("Desea realizar otra operacion? Y/N");
            string? respuestaDosUsuario= Console.ReadLine();
        
            if (respuestaDosUsuario== "y" || respuestaDosUsuario== "Y")
            {
                continue;
            }   
            else  if (respuestaDosUsuario== "n" || respuestaDosUsuario== "N")
            {
                break;
            }
            else 
            {
                Console.WriteLine("opcion incorrecta por favor elige Y/N\n");
                Console.ReadLine();//para que nuestra app no se cierre
            }
            } while  (true);
        
             
        }
    }
}

