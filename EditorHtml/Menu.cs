using System;

namespace EditorHtml
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Black;

            DrawScreen(30, 10);
            WriteOptions();

            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);
        }



        public static void DrawScreen(int cols, int lines)
        {
            DrawHeaderFooter(cols);
            for (int line = 0; line < lines; line++)
            {
                DrawLine(cols, '|', ' ');
            }
            DrawHeaderFooter(cols);


        }

        public static void DrawLine(int cols, char border, char midle)
        {

            Console.Write(border);

            for (int i = 0; i <= cols; i++)
            {
                Console.Write(midle);
            }
            Console.Write(border);

            Console.Write("\n");
        }

        public static void DrawHeaderFooter(int cols)
        {
            DrawLine(cols, '+', '-');
        }

        public static void WriteOptions()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("================");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("Selecione uma opção abaixo.");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(3, 5);
            Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 8);
            Console.WriteLine("Opção: ");
            Console.SetCursorPosition(10, 8);

        }

        public static void OpenViewer()
        {
            Console.Clear();
            Console.WriteLine("Informe o caminho do arquivo que desja visualizar");
            string path = Console.ReadLine();

            using (var file = new StreamReader(path))
            {
                string text = file.ReadToEnd();
                Viewer.Show(text);
            }
        }

        public static void HandleMenuOption(short option)
        {
            switch (option)
            {
                case 1: Editor.Show(); break;
                case 2: Menu.OpenViewer(); break;
                case 0: Environment.Exit(0); break;
                default: Menu.Show(); break;

            }
        }
    }


}