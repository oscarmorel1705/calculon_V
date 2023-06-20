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
            Console.WriteLine("6: Salir");
            //declarando variable de respuesta del cliente
            int respuestaUsuario= Convert.ToInt32(Console.ReadLine());
            if (respuestaUsuario < 7 && respuestaUsuario != 6)
            {
                Console.WriteLine("digite el primer numero: ");
                modelo.Numero_A= Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("digite un siguiente numero: ");
                modelo.Numero_B= Convert.ToDecimal(Console.ReadLine());
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
                }   
            } 
            else if (respuestaUsuario== 6)
            {
                break;
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

