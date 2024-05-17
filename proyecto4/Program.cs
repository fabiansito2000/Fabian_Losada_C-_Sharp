        /*Acuario Del 21 de enero al 18 de febrero
        Piscis Del 19 de febrero al 20 de marzo
        Aries Del 21 de marzo al 20 de abril
        Tauro Del 21 de abril al 21 de mayo
        Géminis Del 22 de mayo al 21 de junio
        Cáncer Del 22 de junio al 22 de julio
        Leo Del 23 de julio al 23 de agosto
        Virgo Del 24 de agosto al 23 de septiembre
        Libra Del 24 de septiembre al 23 de octubre
        Escorpión Del 24 de octubre al 22 de noviembre
        Sagitario Del 23 de noviembre al 21 de diciembre
        Capricornio Del 22 de diciembre al 20 de enero*/
    
            int día = 0, mes = 0;

            Console.Write("Escribe tu día de nacimiento: ");
            día = int.Parse(Console.ReadLine());
            Console.Write("Escribe tu mes de nacimiento: ");
            mes = int.Parse(Console.ReadLine());

            switch(mes)
            {
                case 1:
                    if (día < 21)
                        Console.Write("Tu signo zodiacal es Capricornio");
                    else
                        Console.Write("Tu signo zodiacal es Acuario");
                    break;
                case 2: 
                    if (día < 19)
                        Console.Write("Tu signo zodiacal es Acuario");
                    else
                        Console.Write("Tu signo zodiacal es Piscis");
                    break;
                case 3:
                    if (día < 21)
                        Console.Write("Tu signo zodiacal es Piscis");
                    else
                        Console.Write("Tu signo zodiacal es Aries");
                    break;
                case 4:
                    if (día < 21)
                        Console.Write("Tu signo zodiacal es Ares");
                    else
                        Console.Write("Tu signo zodiacal es Tauro");
                    break;
                case 5:
                    if (día < 22)
                        Console.Write("Tu signo zodiacal es Tauro");
                    else
                        Console.Write("Tu signo zodiacal es Géminis");
                    break;
                case 6:
                    if (día < 22)
                        Console.Write("Tu signo zodiacal es Géminis");
                    else
                        Console.Write("Tu signo zodiacal es Cáncer");
                    break;
                case 7:
                    if (día < 23)
                        Console.Write("Tu signo zodiacal es Cáncer");
                    else
                        Console.Write("Tu signo zodiacal es Leo");
                    break;
                case 8:
                    if (día < 24)
                        Console.Write("Tu signo zodiacal es Leo");
                    else
                        Console.Write("Tu signo zodiacal es Virgo");
                    break;
                case 9:
                    if (día < 24)
                        Console.Write("Tu signo zodiacal es Virgo");
                    else
                        Console.Write("Tu signo zodiacal es Libra");
                    break;
                case 10:
                    if (día < 24)
                        Console.Write("Tu signo zodiacal es Libra");
                    else
                        Console.Write("Tu signo zodiacal es Escorpión");
                    break;
                case 11:
                    if (día < 23)
                        Console.Write("Tu signo zodiacal es Escorpión");
                    else
                        Console.Write("Tu signo zodiacal es Sagitario");
                    break;
                case 12:
                    if (día < 22)
                        Console.Write("Tu signo zodiacal es Sagitario");
                    else
                        Console.Write("Tu signo zodiacal es Capricornio");
                    break;
            }