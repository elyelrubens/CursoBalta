using System;
using System.Text;

namespace EditorHtml
{
    public static class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO EDITOR");
            Console.WriteLine("-----------");
            Start();
        }

        public static void Start()
        {
            var file = new StringBuilder();

            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            var invalidOption = true;
            do
            {
                Console.WriteLine("-----------");
                Console.WriteLine("Deseja salvar o arquivo?");
                Console.WriteLine("[S]=Sim, [N]=Não");
                Char option = char.Parse(Console.ReadLine());

                switch (option)
                {
                    case 'S': Save(file.ToString()); invalidOption = false; break;
                    case 'N': Menu.Show(); invalidOption = false; break;
                    default: Console.WriteLine("Opção inválida"); break;
                }
            } while (invalidOption);
        }

        static void Save(string text)
        {
            string? path = null;

            while (path == null)
            {
                Console.Clear();
                Console.WriteLine("Informe o caminho para salvar o arquivo");
                path = Console.ReadLine();

                if (path == null)
                {
                    Console.WriteLine("Caminho inválido");
                }
            }

            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            }

            Console.WriteLine($"Arquivo {path} salvo com sucesso!");
            Console.ReadLine();
            Menu.Show();
        }
    }
}