namespace TriângulosCsAP
{
    internal class Program
    {
       
        public static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Calculo de Triângulos\n\n1.Calcular um Triângulo\n2.Sair da Aplicação\n");
            string answer = Console.ReadLine();
            if (answer == "1")
            {
                Methods.InputRegister();
            }
            else if (answer == "2")
            {
                Console.WriteLine("Finalizando o Programa");
                Environment.Exit(0);
            } else
            {
                Console.WriteLine("Erro, Escolha uma Opção Válida");
                Console.ReadLine();
                MainMenu();
            }
        }


        public static void Enquire()
        {
            Console.WriteLine("\nPrograma Finalizado\n\n1.Calcular outro Triângulo\n2.Voltar ao Menu");
            string answer = Console.ReadLine();
            if (answer == "1")
            {
                Methods.InputRegister();
            }
            else if (answer == "2")
            {
                Console.WriteLine("FInalizando o Programa....");
                MainMenu();
            }
            else
            {
                Console.WriteLine("Erro, Digite uma Resposta Válida\n");
                Console.ReadLine();
                Enquire();
            }

        
        
        }

        static void Main(string[] args)
        {
            MainMenu();
        }




    }
    
    }
    

