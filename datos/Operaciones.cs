using modelo;

namespace datos
{
    public class Operaciones
    {   /* parametro modelo hace referencia a los numeros a sumar
    y aplica para todas las operaciones */

        // return hace alucion al resultado de la operacion
        public decimal Suma (NumeroModel modelo) 
        {
            return modelo.Numero_A + modelo.Numero_B;
        }
            public decimal Resta (NumeroModel modelo) 
        {
            return modelo.Numero_A - modelo.Numero_B;
        }
            public decimal Multiplicacion (NumeroModel modelo) 
        {
            return modelo.Numero_A * modelo.Numero_B;
        }   
            public decimal Division (NumeroModel modelo) 
        {
            return modelo.Numero_A / modelo.Numero_B;
        }
           public decimal Modulo (NumeroModel modelo) 
        {
            return modelo.Numero_A % modelo.Numero_B;
        }


   }
}