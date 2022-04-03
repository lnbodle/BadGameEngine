using System;

namespace BadGameEngine
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new BadGame())
                game.Run();
        }
    }
}
