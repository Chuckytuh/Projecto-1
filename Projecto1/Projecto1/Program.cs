using System;
using System.Diagnostics;
using System.Reflection;

namespace Projecto1
{
#if WINDOWS || XBOX
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {

            AssemblyName name = Assembly.GetExecutingAssembly().GetName();
            string str1 = string.Format("{0} (ver. {1})", (object)name.Name, (object)((object)name.Version).ToString());

            //using (Game1 game = new Game1())
            //{
            //    game.Run();
            //}
        }
    }
#endif
}

