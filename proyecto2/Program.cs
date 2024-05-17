
        int num1, num2, resultado;
        Console.WriteLine("Ingresar el numero 1: ");
        num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingresar el numero 2: ");
        num2 = int.Parse(Console.ReadLine());

        resultado = num1 + num2;
        Console.WriteLine("La suma es {0}", resultado);
        resultado = num1 - num2;
        Console.WriteLine("La resta es {0}", resultado);
        resultado = num1 * num2;
        Console.WriteLine("La multiplicacion es {0}", resultado);


            if (num2 !=0)
            {
            resultado = num1/num2;
            Console.WriteLine("La division es {0}", resultado);
            }
            else
            {
            Console.WriteLine("no se puede dividir un" + "numero entre cero");   
            }
