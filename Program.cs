using System;

namespace PrimeraApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("CALCULADORA");
			Console.WriteLine("********************************************");
			Console.WriteLine("Ingrese el numero de la operacion correspondiente");
			Console.WriteLine("1. Suma\t\t\t\t 2. Resta");
			Console.WriteLine("3. Multiplicacion\t\t 4. Division");
			int x;
			x = numero();

            try
            {
				if (x >= 5)
                {
					throw new ArgumentOutOfRangeException();
                }
				op(x);
            }
            catch(ArgumentOutOfRangeException e)
            {
				Console.WriteLine("Numero invalido, vuelva a ingresar un numero valido");
				x = numero();
				while(x >= 5)
                {
                    Console.WriteLine("Ingrese un numero valido");
					x = numero();
                }
				op(x);
            }
				
			
			

		}
		//para validar si es numero o caracter
		private static int numero()
        {
			int x = 1;
			try
            {

				x = int.Parse(Console.ReadLine());
				
			}
			
            catch (Exception e)
            {
				Console.WriteLine("Ingrese un valor valido");
				
				numero();

            }
			
			
			return x;
        }

		//tupla de numeros a operar
		private static Tuple<float, float> numeros()
        {
			float num1;
			float num2;
			try
			{
				Console.Write("Ingrese el primer numero: ");
				num1 = float.Parse(Console.ReadLine());

			}
			catch (Exception e)
			{
				Console.WriteLine("Ingrese un valor numerico");
				num1 = 0;
				numeros();

			}
			try
			{
				Console.Write("Ingrese el segundo numero: ");
				num2 = float.Parse(Console.ReadLine());

			}
			catch (Exception e)
			{
				Console.WriteLine("Ingrese un valor numerico");
				num2 = 0;
				numeros();

			}
			return Tuple.Create(num1, num2);
        }

		private static void divd()
		{
			var datos = numeros();
			float sad = datos.Item1;
			float qwe = datos.Item2;
			while(qwe == 0)
            {
                Console.WriteLine("Ingrese un valor diferente de cero");
				qwe = numero();
            }

            try
            {
				float sm = sad / qwe;
				Console.WriteLine($"El resultado de la division es {sm}");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Division entre 0 no valida, vuelva a ingresar los numeros correctamente");
				divd();
            }
			
		}

		private static void prod()
		{
			var datos = numeros();
			float sad = datos.Item1;
			float qwe = datos.Item2;
			float sm = sad*qwe;
			Console.WriteLine($"El resultado de la multiplicacion es {sm}");
		}

		private static void resta()
		{
			var datos = numeros();
			float sad = datos.Item1;
			float qwe = datos.Item2;
			float sm = sad - qwe;
			Console.WriteLine($"El resultado de la resta es {sm}");
		}

		private static void suma()
		{
			var datos = numeros(); 
			float sad = datos.Item1;
			float qwe = datos.Item2;
			float sm = sad + qwe;
			Console.WriteLine($"El resultado de la suma es {sm}");
		}
		private static void op(int x)
        {
			
			int a = x;
			
			//Console.Clear();
			switch (a)
			{
				case 1:
					suma();
					break;
				case 2:
					resta();
					break;
				case 3:
					prod();
					break;
				case 4:
					divd();
					break;
				default:
					throw new ArgumentOutOfRangeException();
					

			}
					
		}
    }
}
