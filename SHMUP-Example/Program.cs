using ExampleGameSHMUP;
using System;

namespace SHMUP_Example
{
#if WINDOWS || LINUX
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var game = new ExampleSHMUP())
                game.Run();
        }
    }
#endif
}
