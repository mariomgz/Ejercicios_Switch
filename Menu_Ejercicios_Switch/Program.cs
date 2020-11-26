using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_Ejercicios_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double r;
            int r1;

            Console.WriteLine("Seleccione una opción del MENU\n");
            Console.WriteLine("|*******  PREGUNTAS  *******| \n" +
                              "|*                         *| \n" +
                              "|* 1. Saludo               *| \n" +
                              "|* 2. Círculo              *| \n" +
                              "|* 3. Promedio Notas       *| \n" +
                              "|* 4. Convertir Cms        *| \n" +
                              "|* 5. Invertir Número      *| \n" +
                              "|* 6. Hipotenusa           *| \n" +
                              "|* 7. Hora                 *| \n" +
                              "|* 8. Decimal              *| \n" +
                              "|* 9. Intercambiar Número  *| \n" +
                              "|*10. Operaciones          *| \n" +
                              "|*11. Porcentaje           *| \n" +
                              "|*12. Descuento Octubre    *| \n" +
                              "|*13. Ingreso Bar          *| \n" +
                              "|*14. EXIT                 *| \n" +
                              "|*                         *| \n" +
                              "|***************************| \n");

            n = Convert.ToInt32(Console.ReadLine());

            switch (n)

            {
                case 1:

                    Console.Clear();
                    Console.WriteLine("Ejercicio 1: Saludo\n");
                    string nombre;
                    Console.WriteLine("Digite su nombre");
                    nombre = Console.ReadLine();
                    Console.WriteLine("Hola " + nombre + ", En qué te puedo ayudar?");

                    break;

                case 2:

                    Console.Clear();
                    Console.WriteLine("Ejercicio 2: Círculo (Área y Perímetro)\n");
                    double radio = 0;
                    double perimetro, area;
                    Console.WriteLine("Escriba el radio del círculo");
                    radio = Convert.ToDouble(Console.ReadLine());
                    perimetro = 2 * Math.PI * radio;
                    area = Math.PI * Math.Pow(radio, 2);
                    Console.WriteLine("El área del círculo es " + Math.Round(area, 2) + " y el perímetro es " + Math.Round(perimetro, 2));

                    break;

                case 3:

                    Console.Clear();
                    Console.WriteLine("Ejercicio 3: Promedio\n");
                    double n1, n2, n3, n4, promedio;
                    Console.WriteLine("Ingrese Nota 1");
                    n1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese Nota 2");
                    n2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese Nota 3");
                    n3 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese Nota 4");
                    n4 = Convert.ToDouble(Console.ReadLine());
                    promedio = (n1 + n2 + n3 + n4) / 4;
                    Console.WriteLine("El Promedio de Notas es: " + Math.Round(promedio, 2));

                    break;

                case 4:

                    Console.Clear();
                    Console.WriteLine("Ejercicio 4: Convertir Centímetros a Pulgadas\n");
                    double cms, pulgada;
                    Console.WriteLine("Esciba los Centímetros");
                    cms = Convert.ToDouble(Console.ReadLine());
                    pulgada = 2.54;
                    r = cms / pulgada;
                    Console.WriteLine("El resultado es pulgadas es: " + Math.Round(r, 2));

                    break;

                case 5:

                    Console.Clear();
                    Console.WriteLine("Ejercicio 5: Invertir Número\n");
                    int ne, residuo, centena, decena, unidad;
                    Console.WriteLine("Ingrese un número entero de tres dígitos");
                    ne = Convert.ToInt16(Console.ReadLine());
                    centena = ne / 100;
                    residuo = ne % 100;
                    decena = residuo / 10;
                    unidad = residuo % 10;
                    r1 = unidad * 100 + decena * 10 + centena;
                    Console.WriteLine("El núnero invertido es igual a: " + r1);

                    break;

                case 6:

                    Console.Clear();
                    Console.WriteLine("Ejercicio 6: Hipotenusa\n");
                    double a, b;
                    Console.WriteLine("Ingrese la Longitud del Cateto a");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese la Longitud del Cateto b");
                    b = Convert.ToDouble(Console.ReadLine());
                    r = Math.Sqrt((Math.Pow(a, 2) + Math.Pow(b, 2)));
                    Console.WriteLine("La Hipotenusa es igual a: " + Math.Round(r, 2));

                    break;

                case 7:

                    Console.Clear();
                    Console.WriteLine("Ejercicio 6: Hora\n");
                    int t, h, m;
                    Console.WriteLine("Ingrese la hora actual");
                    t = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Ingrese número de horas futuras");
                    h = Convert.ToInt16(Console.ReadLine());
                    m = h % 24;
                    r1 = (t + m);
                    if (r1 > 24)
                        Console.WriteLine("El reloj marcará: " + (r1 - 24) + " horas");
                    else
                        Console.WriteLine("El reloj marcará: " + r1 + " horas");

                    break;

                case 8:

                    Console.Clear();
                    Console.WriteLine("Ejercicio 8: Decimal\n");
                    double nr, d;
                    nr = 0;
                    Console.WriteLine("Ingrese un número real");
                    nr = Convert.ToDouble(Console.ReadLine());
                    r1 = Convert.ToInt16(nr / 1);
                    d = nr - r1;
                    Console.WriteLine("La parte decimal es igual a : " + d);

                    break;

                case 9:

                    Console.Clear();
                    Console.WriteLine("Ejercicio 9: Intercambiar Número\n");
                    string v1, v2;
                    Console.WriteLine("Ingrese variable 1");
                    v1 = Console.ReadLine();
                    Console.WriteLine("Ingrese variable 2");
                    v2 = Console.ReadLine();
                    Console.WriteLine("El resultado es: " + v2 + v1);

                    break;

                case 10:

                    Console.Clear();
                    Console.WriteLine("Ejercicio 10: Operaciones\n");
                    double num1, num2, s, m1, d1;
                    Console.WriteLine("Ingrese el primer número");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo número");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    s = num1 + num2;
                    r = num1 - num2;
                    m1 = num1 * num2;
                    d1 = num1 / num2;
                    Console.WriteLine("La suma es igual a: " + s + ", La resta es igual a: " + r +
                        ", La multiplicación es igual a: " + m1 + ", La división es igual a: " + d1);

                    break;

                case 11:

                    Console.Clear();
                    Console.WriteLine("Ejercicio 11: Porcentaje\n");
                    double nn1, nn2, suma, pn1, pn2;
                    Console.WriteLine("Ingrese el número de niños");
                    nn1 = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Ingrese el número de niñas");
                    nn2 = Convert.ToInt16(Console.ReadLine());
                    suma = nn1 + nn2;
                    pn1 = nn1 / suma * 100;
                    pn2 = nn2 / suma * 100;
                    Console.WriteLine("El porcentaje de niños es: " + pn1 + "%" +
                        "y el porcentaje de niñas es: " + pn2 + "%");

                    break;

                case 12:

                    Console.Clear();
                    Console.WriteLine("Ejercicio 12: Descuento Octubre\n");
                    double compra, dcto, total;
                    Console.WriteLine("Ingrese el valor de la compra");
                    compra = Convert.ToDouble(Console.ReadLine());
                    dcto = compra * 0.15;
                    total = compra - dcto;
                    Console.WriteLine("En octubre, el valor de su compra fue de: $" + compra +
                        ", con un descuento de: " + dcto + "%" + ". Para un total a cancelar de: $" + total);

                    break;

                case 13:

                    Console.Clear();
                    Console.WriteLine("Ejercicio 13: Ingreso Bar\n");
                    int edad, compras;
                    double cedula;
                    compras = 0;
                    cedula = 0;

                    Console.WriteLine("Digite su edad");
                    edad = Convert.ToInt32(Console.ReadLine());

                    if (edad >= 18)
                    {
                        Console.WriteLine("Tiene cédula?\n" +
                            "En caso afirmativo escriba su Número de Cédula, sino escriba 0");
                        cedula = Convert.ToDouble((Console.ReadLine()));

                        if (cedula > 0)

                        {
                            Console.WriteLine("¿Cuantas botellas de guaro o ron van a comprar?:");
                            compras = Convert.ToInt32(Console.ReadLine());

                            Console.Clear();

                            if (compras >= 2)
                            {
                                Console.WriteLine("-----Bienvenido al BAR CORONA-----\n" +
                                  "\n" +
                                    "Usted ahora es un cliente VIP\n" +
                                  "\n" +
                                  "EN HORA BUENA!!\n" +
                                  "Por haber comprado " + compras + " unidades,\n" +
                                  "le hemos obsequiado *MEDIA BOTELLA* de ron o guaro.\n");

                            }
                            else if (compras < 2)
                            {
                                Console.WriteLine("-----Bienvenido al BAR CORONA-----\n" +
                                   "\n" +
                                   "Usted ahora es un cliente VIP\n");

                            }

                        }
                        else
                        {
                            Console.WriteLine("*Para ingresar al BAR CORONA usted debe tener Cédula*");
                        }

                    }

                    else
                    {
                        Console.WriteLine("*Para ingresar al BAR CORONA usted debe ser mayor de edad*");
                    }

                    break;

                default:

                    Console.Clear();
                    Console.WriteLine("Vuelva Pronto!");

                    break;

            }


            Console.ReadKey();

        }
    }
}
