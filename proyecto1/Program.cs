
        float height = 0;
        float weight = 0;
        float bmiIndex = 0;

        System.Console.WriteLine ("Ingrese su altura");
        Single.TryParse (System.Console.ReadLine(), out height);

        System.Console.WriteLine ("Ingrese su peso");
        Single.TryParse (System.Console.ReadLine(), out weight);

        bmiIndex = weight /(height *height);

        if(bmiIndex < 18.5)
            Console.WriteLine ("bajo de peso");
        else if (bmiIndex >=18.5 && bmiIndex < 24.9)
            Console.WriteLine ("peso ideal");
        else if (bmiIndex >=25.5 && bmiIndex < 29.9)
            Console.WriteLine ("sobrepeso");   
        else if (bmiIndex >=30.0)
            Console.WriteLine ("Obeso");
