using modelo;

namespace datos
{
    public class Operaciones
    {   /* parametro modelo hace referencia a los numeros a sumar
    y aplica para todas las operaciones */

        // return hace alucion al resultado de la operacion
        public double Suma (NumeroModel modelo) 
        {
            return modelo.Numero_A + modelo.Numero_B;
        }
            public double Resta (NumeroModel modelo) 
        {
            return modelo.Numero_A - modelo.Numero_B;
        }
            public double Multiplicacion (NumeroModel modelo) 
        {
            return modelo.Numero_A * modelo.Numero_B;
        }   
            public double Division (NumeroModel modelo) 
        {
            return modelo.Numero_A / modelo.Numero_B;
        }
           public double Modulo (NumeroModel modelo) 
        {
            return modelo.Numero_A % modelo.Numero_B;
        }
           public double Valor_Abs (NumeroModel modelo) 
        {
            return Math.Abs(modelo.Numero_A);
        }
           public double Potenciacion (NumeroModel modelo) 
        {
            return Math.Pow(modelo.Numero_A, modelo.Numero_B);
        }
          public double Raiz_Cuad (NumeroModel modelo) 
        {
            return Math.Sqrt(modelo.Numero_A);
        }
        public double Redondeo (NumeroModel modelo) 
        {
            return Math.Round(modelo.Numero_A);
        }
           public double Seno (NumeroModel modelo) 
        {
            return Math.Sin(modelo.Numero_A*Math.PI/180);
        }
            public double Coseno (NumeroModel modelo) 
        {
            return Math.Cos(modelo.Numero_A*Math.PI/180);
        }
         public double tangente (NumeroModel modelo) 
        {
            return Math.Tan(modelo.Numero_A*Math.PI/180);
        }
        public double Pi (NumeroModel modelo) 
        {
            return Math.PI;
        }

   }
}