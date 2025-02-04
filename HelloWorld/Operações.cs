using System;

namespace Calculadora
{
    internal class Operações
    {
        public static string erro = "Opção inválida. Pressione ENTER para retornar ao menu inicial.";
        public static string retornar = "Pressione ENTER para retornar ao menu inicial.";
        public static bool escolheuSair = false;

        enum SairOp { Sim = 1, Não }

        public void Soma()
        {
            Console.Clear();
            Console.WriteLine("-SOMA-");
            Console.WriteLine("Informe a primeira parcela:");
            string a = Console.ReadLine();
            bool aB = float.TryParse(a, out float aF);
            if (aB == false)
            {
                Console.WriteLine(erro);
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Informe a segunda parcela:");
                string b = Console.ReadLine();
                bool bB = float.TryParse(b, out float bF);
                if (bB == false)
                {
                    Console.WriteLine(erro);
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    float resultado = aF + bF;
                    Console.WriteLine($"O total é: {resultado}!");
                    Console.WriteLine(retornar);
                    Console.ReadLine();
                    Console.Clear();
                }

            }
        }
        public void Sub()
        {
            Console.Clear();
            Console.WriteLine("-SUBTRAÇÃO-");
            Console.WriteLine("Informe o minuendo:");
            string a = Console.ReadLine();
            bool aB = float.TryParse(a, out float aF);
            if (aB == false)
            {
                Console.WriteLine(erro);
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Informe o subtraendo:");
                string b = Console.ReadLine();
                bool bB = float.TryParse(b, out float bF);
                if (bB == false)
                {
                    Console.WriteLine(erro);
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    float resultado = aF - bF;
                    Console.WriteLine($"A diferença é: {resultado}!");
                    Console.WriteLine(retornar);
                    Console.ReadLine();
                    Console.Clear();
                }

            }
        }
        public void Div()
        {
            {
                Console.Clear();
                Console.WriteLine("-DIVISÃO-");
                Console.WriteLine("Informe o dividendo:");
                string a = Console.ReadLine();
                bool aB = float.TryParse(a, out float aF);
                if (aB == false)
                {
                    Console.WriteLine(erro);
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Informe o divisor:");
                    string b = Console.ReadLine();
                    bool bB = float.TryParse(b, out float bF);
                    if (bB == false)
                    {
                        Console.WriteLine(erro);
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else
                    {
                        float resultado = aF / bF;
                        Console.WriteLine($"O quociente é: {resultado}!");
                        Console.WriteLine(retornar);
                        Console.ReadLine();
                        Console.Clear();
                    }

                }
            }
        }
        public void Mult()
        {
            Console.Clear();
            Console.WriteLine("-MULTIPLICAÇÃO-");
            Console.WriteLine("Informe o multiplicando:");
            string a = Console.ReadLine();
            bool aB = float.TryParse(a, out float aF);
            if (aB == false)
            {
                Console.WriteLine(erro);
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Informe o multiplicador:");
                string b = Console.ReadLine();
                bool bB = float.TryParse(b, out float bF);
                if (bB == false)
                {
                    Console.WriteLine(erro);
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    float resultado = aF * bF;
                    Console.WriteLine($"O produto é: {resultado}!");
                    Console.WriteLine(retornar);
                    Console.ReadLine();
                    Console.Clear();
                }

            }
        }
        public void Pow()
        {
            {
                Console.Clear();
                Console.WriteLine("-POTÊNCIA-");
                Console.WriteLine("Informe a base:");
                string a = Console.ReadLine();
                bool aB = float.TryParse(a, out float aF);
                if (aB == false)
                {
                    Console.WriteLine(erro);
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Informe o expoente:");
                    string b = Console.ReadLine();
                    bool bB = float.TryParse(b, out float bF);
                    if (bB == false)
                    {
                        Console.WriteLine(erro);
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else
                    {
                        float resultado = (float)Math.Pow(aF, bF);
                        Console.WriteLine($"O total é: {resultado}!");
                        Console.WriteLine(retornar);
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
            }
        }
        public void Raiz()
        {
            Console.Clear();
            Console.WriteLine("-RAÍZ QUADRADA-");
            Console.WriteLine("Informe o radicando:");
            string a = Console.ReadLine();
            bool aB = float.TryParse(a, out float aF);
            if (aB == false)
            {
                Console.WriteLine(erro);
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                float resultado = (float)Math.Sqrt(aF);
                Console.WriteLine($"O total é: {resultado}!");
                Console.WriteLine(retornar);
                Console.ReadLine();
                Console.Clear();
            }

        }
        public void Sair()
        {
            Console.Clear();
            Console.WriteLine("-SAIR-");
            Console.WriteLine("Você tem certeza que deseja sair?\n1 - Sim\n2 - Não");
            string opStr2 = Console.ReadLine();
            bool opBool2 = int.TryParse(opStr2, out int opInt2);
            if (opBool2 == false)
            {
                Console.WriteLine(erro);
                Console.ReadLine();
            }
            else
            {
                SairOp opção2 = (SairOp)opInt2;
                if (opção2 == SairOp.Não)
                {
                    Console.WriteLine(retornar);
                    Console.ReadLine();
                }
                else
                {
                    escolheuSair = true;
                }
            }
            Console.Clear();
        }
    }
}

