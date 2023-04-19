using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova1PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int pro;

            Console.WriteLine("qual o programa que você deseja utilizar: ");
            pro = int.Parse(Console.ReadLine());


            switch (pro)
            {

                case 1:


                    int num1, nump;


                    Console.WriteLine("qual o numero desejado: ");
                    num1 = int.Parse(Console.ReadLine());

                    if( num1 >= 0)
                    {
                        Console.WriteLine(num1);
                    }
                    else
                    {
                        nump = num1 * (-1);
                        Console.WriteLine(nump);
                    }



                    break;

                    case 2: 


                    int num2;

                    Console.WriteLine("qual o numero desejado: ");
                    num2 = int.Parse(Console.ReadLine());


                      if(num2 % 3 != 0 && num2 % 4 != 0 && num2 % 5 != 0 && num2 % 7 != 0)
                    {
                        Console.WriteLine("o numero nao é multiplo de 3,4,5,7 e consequentimente nao é divisivel por nenhum deles");
                    }

                    if (num2 % 3 == 0)
                    {

                        Console.WriteLine("o numero é multiplo de 3 e é divisivel por 3 ");


                        if (num2 % 4 == 0)
                        {

                            Console.WriteLine("o numero é multiplo de 4 e é divisivel por 4");



                            if (num2 % 5 == 0)
                            {

                                Console.WriteLine("o numero é multiplo de 5 e é divisivel por 5 ");



                                if (num2 % 7 == 0)
                                {

                                    Console.WriteLine("o numero é multiplo de 7 e é divisivel por 7 ");
                                }
                             


                            }
                        }
                    }



                    break;

                case 3:

                    int a, b, c;

                    Console.WriteLine("qual o valor do primeiro numero ");
                    a = int.Parse(Console.ReadLine());
                    Console.WriteLine("qual o valor do segundo numero ");
                    b = int.Parse(Console.ReadLine());
                    Console.WriteLine("qual o valor do terceiro numero ");
                    c = int.Parse(Console.ReadLine());

                    if (a > b && b > c)
                        Console.WriteLine(a);

                    else if (a > b && b < c)
                        Console.WriteLine(a );
                    else if (b > a && a > c)
                        Console.WriteLine(b);
                    else if (b > a && a < c)
                        Console.WriteLine(b );
                    else if (c > a && a > b)
                        Console.WriteLine(c );
                    else if (c > a && a < b)
                        Console.WriteLine(c );





                    break;

                case 4:
                    int dia;

                    Console.WriteLine("qual o dia da semana voce deseja saber as aulas (EX: 1 = domingo,2 = segunda...)");
                    dia = int.Parse(Console.ReadLine());


                    if (dia != 1 && dia != 2 && dia != 3 && dia != 4 && dia != 5 && dia != 6 && dia != 7)
                    {
                        Console.WriteLine("o dia è invalido");

                        break;
                    }


                    switch (dia)
                    {
                        case 1:

                            Console.WriteLine("nesse dia nos ficamos em casa dormindo o dia todo :)");

                            break;

                        case 2:
                            Console.WriteLine("nesse dia temos: filosofia,portugues e matematica");

                            break;

                        case 3:

                            Console.WriteLine("nesse dia temos: quimica, historia e imi");

                            break;

                        case 4:
                            Console.WriteLine("nesse dia temos: biologia, portugues e pr2");

                            break;
                        case 5:
                            Console.WriteLine("nesse dia temos: fisica, redes e sociologia");

                            break;
                        case 6:
                            Console.WriteLine("nesse dia temos: geografia, matematica e bds");
                            break;
                        case 7:
                            Console.WriteLine("nesse dia nos comemos pastel na feira :)");
                            break;











                    }





                    break;


                case 5:

                    int numa, numaior, numenor;

                    Console.WriteLine("digete um numero base: ");
                    numa = int.Parse(Console.ReadLine());
                    numenor = numa;
                    numaior = numa;

                    
                    for(; ; )
                    {

                        Console.WriteLine("qual o numero desejado(se o numero for zero o programa ira parar) :");
                        numa = int.Parse((Console.ReadLine()));

                        if(numa == 0 )

                            break;
                        if(numa > numaior)
                        {
                            numaior = numa;
                        }
                        else if(numa < numenor)
                        {

                            numenor = numa;
                        }

                        Console.WriteLine("o maior numero è : " + numaior + " e o menor é : " + numenor);

                    }

                 


                    break;

                case 6:

                    int num3, numtotal =0 ;

                    Console.WriteLine("qual o numero desejado: ");
                    num3 = int.Parse(Console.ReadLine());
                    for (int i = 1; ; i++)

                        if (num3 % i == 0 && i != num3)
                            numtotal = numtotal + i;

                    else if(numtotal == num3)
                    {
                        Console.WriteLine("o numero é perfeito ");
                            break ;
                    }
                        else
                        {
                            Console.WriteLine("o numero nao è perfeito ");
                            break;
                        }
                  

                    break;

                case 7:

                    int not, med = 0, quantnot = 0;



                    for (; ; quantnot++)
                    {

                        Console.WriteLine("qual a nota :(notas impares nao serao computadas e se a nota for zero o programa ira parar )");
                        not = int.Parse(Console.ReadLine());

                        if (not == 0)
                            break;

                        if (not % 2 == 0)
                        {

                            med = med + not;
                        }
                        


                    }

                    med = med / quantnot;
                    if(med == 0)
                    {
                        Console.WriteLine("nao foi possivel calcular a media");
                    }

                    Console.WriteLine("a media sera de:" + med);
                    

                    break;

            }


        }
    }
}
