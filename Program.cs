// See https://aka.ms/new-console-template for more information

//Programa de salarios

//Declara las variables

string numcedula = "";
string nombre = "";
int EmployType = -1; // 0 = Correspondiendo 1 = Operario 2 = Tecnico 3 = Profesional
double n = 0; //Variable de los aumentos
int paso = 0; //Variable para poder verificar si el usuario introdujo los datos de forma correcta.
int paso_general = 0;
int operarios = 0;
int tecnicos = 0;
int profesionales = 0;

//Escribe en pantalla el título del menú
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("+------------------------[Aumentos de Salarios]---------------------------+");
Console.WriteLine("|                                                                         |       ,-.       _,---._ __  / \\");
Console.WriteLine("|                                                                         |       /  )    .-'       `./ /   \\");
Console.WriteLine("|      [Tipos de empleados]                                               |      (  (   ,'            `/    /|");
Console.WriteLine("|                                                                         |       \\  `-\"             \\'\\   / |");
Console.WriteLine("|      (1) - Operario                                                     |        `.              ,  \\ \\ /  |");
Console.WriteLine("|      (2) - Técnico                                                      |         /`.          ,'-`----Y   |");
Console.WriteLine("|      (3) - Profesional                                                  |        (            ;        |   '");
Console.WriteLine("|                                                                         |        |  ,-.    ,-'         |  /");
Console.WriteLine("+-------------------------------------------------------------------------+        |  | (   |            | /");
Console.WriteLine("                                                                                   )  |  \\  `.___________|/");
Console.WriteLine("                                                                                   `--'   `--'");

//Le solicita los datos al usuario
do
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Introduzca el número correspondiente al tipo de empleado(a): "); Console.ForegroundColor = ConsoleColor.Yellow; EmployType = int.Parse(Console.ReadLine());
    if (EmployType > 0 && EmployType < 4)
    {
        switch (EmployType)
        {
            case 1:
                n = 0.15;
                Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("El aumento del salario es del 15%");
                operarios += 1;
                paso = 1;
                break;

            case 2:
                n = 0.10;
                Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("El aumento del salario es del 10%");
                tecnicos += 1;
                paso = 1;
                break;

            case 3:
                n = 0.05;
                Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("El aumento del salario es del 5%");
                profesionales += 1;
                paso = 1;
                break;
        }
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("No hay ningún tipo de empleado para ese número. Inténtelo de nuevo");
    }

} while (paso == 0);

//Console.Clear();

//Solicita el nombre del empleado
Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine("Inserte aquí el nombre del empleado(a): ");
Console.ForegroundColor = ConsoleColor.Yellow;
nombre = Console.ReadLine();

//Console.Clear();

//Solicita la cédula del empleado
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Ingrese el número de cédula del empleado(a)");

do
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    numcedula = Console.ReadLine();
    if (numcedula.Length > 0 && numcedula.Length < 10)
    {
        paso = 2;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Esa no es una cédula válida. Debe ser de 9 carácteres.");
        paso = 1;
    }

} while (paso == 1);

//Declara las variables del salario
double salario_bruto = 0;
double ordinary_salary = 354692;
double deducciones = 0;
double salario_neto = 0;

//Calcula el salario bruto
salario_bruto = (ordinary_salary + n);

//Calcula las deducciones de ley
deducciones = (0.9 / salario_bruto);

//Calcula el salario neto
salario_neto = (salario_bruto - deducciones);

//Presenta los datos en pantalla
Console.Clear();
Console.ForegroundColor = ConsoleColor.Green;

Console.WriteLine("         [Datos del empleado]         ");
Console.WriteLine("Cédula: " + numcedula);
Console.WriteLine("Nombre del empleado: " + nombre);
Console.WriteLine("Tipo de empleado: " + EmployType);
Console.WriteLine("Salario Ordinario: " + ordinary_salary);
Console.WriteLine("Aumento: " + n);
Console.WriteLine("Salario Bruto: " + salario_bruto);
Console.WriteLine("Deducción CCSS: " + deducciones);
Console.WriteLine("Salario Neto: " + salario_neto);