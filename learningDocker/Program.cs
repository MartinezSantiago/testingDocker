
namespace learningDocker
{
    internal class Program
    {
        const string format = " ---------- ";
        static void Main(string[] args)
        {
            char input;
            Console.WriteLine("Examen 27/09/2023"+format + "SANTIAGO MARTINEZ"+ format);

            Console.WriteLine(format+"CALCULADORA DE SUELDO NETO"+format);

            do
            {
                Console.WriteLine("Ingrese: \n s: Para calcular sueldo neto. \n e: Para salir del menú");
                input = Console.ReadKey().KeyChar;
                switch (input)
                {
                    case 's':CalcularSueldoNeto();break ;
                    default:
                        break;
                }
            } while (input=='s');
            Console.WriteLine(format + "Cerrando Aplicación..." + format);
            Console.ReadLine();
        }

        static public float CalcularSueldoNeto()
        {
            float sueldoBruto;
            Console.WriteLine(format + "Ingrese su sueldo bruto" + format);
            string? input = Console.ReadLine();
            if (string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input))
            {
                sueldoBruto = 0;

            }
            else
            {
                sueldoBruto = float.Parse(input);
            }
            float sueldo = sueldoBruto;
            Console.WriteLine(format + "Calculando Sueldo Neto..." + format);
            Console.WriteLine("Sueldo Bruto: " + sueldoBruto);
            sueldo = sueldo - Ganancias(sueldoBruto);
            sueldo = sueldo - Jubilacion(sueldoBruto);
            Console.WriteLine(format + "Sueldo Neto: " + sueldo + format);
            return sueldo;
        }
        static float Jubilacion(float sueldo)
        {
            Console.WriteLine(format + "Calculando Jubilación..." + format);
            const float percentage = 20;
            float jubilacion = sueldo * percentage / 100;
            Console.WriteLine("Importe a descontar: "+jubilacion);
            return jubilacion;

        }
        static float Ganancias(float sueldo)
        {
            Console.WriteLine(format + "Calculando Ganancias..." + format);
            const float sueldoPisoGanancias= 400000;
            const float percentage = 10;
            float ganancias = 0;
            if(sueldo>= sueldoPisoGanancias)
            {
                Console.WriteLine( "Aplica Ganancias");
                ganancias = sueldo * percentage / 100;
                Console.WriteLine("Importe a descontar: "+ ganancias);   
            }
            else
            {
                Console.WriteLine( "No aplica Ganancias" );
            }
            return ganancias;
        }
    }
}