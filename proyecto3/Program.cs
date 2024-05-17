
            double b, a;

            Console.WriteLine("Ingrese la base: ");
            b= double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la altura: ");
            a = double.Parse(Console.ReadLine());

            if (b <= 0 || a <= 0)
            {
                Console.WriteLine("Datos incorrectos");
            }
            else
            {
                double area = b * a;

                double perimetro = 2 * (b + a);

                Console.WriteLine($"Area del rectangulo: {area}");

                Console.WriteLine($"Perimetro del rectangulo: {perimetro}");

            }


