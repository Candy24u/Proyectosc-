using System;

namespace opeBasicas
{
    class Program
    {
        static void Main(string[] args)
        {
            int i1 = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("¡¡¡BIENVENIDO AL PROGRAMA DE OPERACIONES BASICAS!!!\n");
            Console.WriteLine("Elige una opción: \n" +
            "\n1. - SUMA" +
            "\n2. - RESTA" +
            "\n3. - MULTIPLICACIÓN" +
            "\n4. - DIVISÓN" +
            "\n5. - MODULO" +
            "\n6. - Salir \n");

            double num1 = 0, num2=0, res=0, multi=0, divi=0, sum=0, mod=0;

            i1 = Convert.ToInt16(Console.ReadLine());

            switch(i1){
                case 1:
                Console.WriteLine("---------------SUMA---------------\n");
                  Console.WriteLine("Ingrese el primer número que desea operar");
                  num1=int.Parse(Console.ReadLine());
            
                  Console.WriteLine("\nIngrese el segundo número que desea operar");
                  num2=int.Parse(Console.ReadLine());
                  sum=num1 + num2;
    
                  Console.WriteLine("\nEl resultado de {0} + {1} es: {2}", num1, num2, sum);
                  Console.WriteLine("\nPrecione enter si desea elegir otra opción");
                  Console.ReadKey();
                  break;
                  
                case 2:
                Console.WriteLine("---------------RESTA---------------\n");
                  Console.WriteLine("Ingrese el primer número que desea operar");
                  num1=int.Parse(Console.ReadLine());
            
                  Console.WriteLine("\nIngrese el segundo número que desea operar");
                  num2=int.Parse(Console.ReadLine());
                  res=num1 - num2;
    
                  Console.WriteLine("\nEl resultado de {0} - {1} es: {2}", num1, num2, res);
                  Console.WriteLine("\nPrecione enter si desea elegir otra opción");
                  Console.ReadKey();
                  break;

                case 3:
                Console.WriteLine("---------------MULTIPLICACIÓN---------------\n");
                  Console.WriteLine("Ingrese el primer número que desea operar");
                  num1=int.Parse(Console.ReadLine());
            
                  Console.WriteLine("\nIngrese el segundo número que desea operar");
                  num2=int.Parse(Console.ReadLine());
                  multi=num1 * num2;
    
                  Console.WriteLine("\nEl resultado de {0} * {1} es: {2}", num1, num2, multi);
                  Console.WriteLine("\nPrecione enter si desea elegir otra opción");
                  Console.ReadKey();
                  break;

                case 4:
                Console.WriteLine("---------------DIVISIÓN---------------\n");
                  Console.WriteLine("Ingrese el primer número que desea operar");
                  num1=int.Parse(Console.ReadLine());
            
                  Console.WriteLine("\nIngrese el segundo número que desea operar");
                  num2=int.Parse(Console.ReadLine());
                  if (num2 == 0)
                  {
                   Console.WriteLine("\n¡ERROR! No se puede realizar esta operación");
                  }else
                  {
                    divi=num1 / num2;
                    Console.WriteLine("\nEl resultado de {0} / {1} es: {2}", num1, num2, divi);
                  }
                  Console.WriteLine("\nPrecione enter si desea elegir otra opción");
                  Console.ReadKey();
                  break;

                case 5:
                Console.WriteLine("---------------MODULO---------------\n");
                  Console.WriteLine("Ingrese el primer número que desea operar");
                  num1=int.Parse(Console.ReadLine());
            
                  Console.WriteLine("\nIngrese el segundo número que desea operar");
                  num2=int.Parse(Console.ReadLine());
                  if (num1 >= num2)
                  {
                    mod=num1 % num2;
                    Console.WriteLine("\nEl resultado de {0} % {1} es: {2}", num1, num2, mod);
                  }else if (num2 > num1)
                  {
                    mod=num2 % num1;
                    Console.WriteLine("\nEl resultado de {0} % {1} es: {2}", num2, num1, mod);
                  }
                  
                  Console.WriteLine("\nPrecione enter si desea elegir otra opción");
                  Console.ReadKey();
                  break;
                
                case 6:
                Console.WriteLine("Salir\n");
                break;

                default:
                Console.WriteLine("\nOPCIÓN INVALIDA");
                Console.WriteLine("\nPrecione enter si desea elegir otra opción");
                Console.ReadKey();
                break;
                  
            }

            }while (i1 != 6);
        }
    }
}

