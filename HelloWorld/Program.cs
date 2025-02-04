using System;

namespace Calculadora
{
    internal class Program
    {
        enum Menu { Soma = 1, Subtração, Divisão, Multiplicação, Potência, Raíz, Sair }
        static void Main(string[] args)
        {
            while (Operações.escolheuSair == false)
            {
                Console.WriteLine("-CALCULADORA-\nSelecione uma opção para começar:");
                Console.WriteLine("1 - Soma\n2 - Subtração\n3 - Divisão\n4 - Multiplicação\n5 - Potência\n6 - Raíz Quadrada\n7 - Sair");

                string opStr = Console.ReadLine();
                Console.Clear();
                bool opBool = int.TryParse(opStr, out int opInt);

                if (opBool == true)
                {
                    Menu opção = (Menu)opInt;
                    Operações conta = new Operações();
                    switch (opção)
                    {
                        case Menu.Soma:
                            conta.Soma();
                            break;
                        case Menu.Subtração:
                            conta.Sub();
                            break;
                        case Menu.Divisão:
                            conta.Div();
                            break;
                        case Menu.Multiplicação:
                            conta.Mult();
                            break;
                        case Menu.Potência:
                            conta.Pow();
                            break;
                        case Menu.Raíz:
                            conta.Raiz();
                            break;
                        case Menu.Sair:
                            conta.Sair();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine(Operações.erro);
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }
    }
}





