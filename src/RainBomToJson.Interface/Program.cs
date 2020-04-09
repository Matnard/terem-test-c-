using System;

namespace RainBomToJson.Interface
{
    class Program
    {
        static int Main(string[] args)
        {
            var bootstrapper = new Bootstrapper();
            
            try
            {
                Bootstrapper.Start(args);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return 1;
            }

            return 0;
        }
    }
}
