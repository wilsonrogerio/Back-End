namespace CadastroPessoas.Classes
{
    public static class Utils
    {
        public static void BarraCarregamento(string texto)
        {
            Console.Write($"{texto}");

            Console.ForegroundColor = ConsoleColor.Blue; // muda cor das letras do console
            Console.BackgroundColor = ConsoleColor.Red;

            for (var contador = 0; contador < 10; contador++)
            {
                Thread.Sleep(500);
                Console.Write($"-");
            }

            Console.ResetColor(); //restaura a cor do console

        }



    }
}