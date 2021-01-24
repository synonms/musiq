using System;
using Synonms.Musiq.Domain;
using Synonms.Musiq.Domain.Enumerations;

namespace Synonms.Musiq.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MUSIQ");

            Intonation root = Intonation.Unknown;

            while (root == Intonation.Unknown)
            {
                root = GetRoot();
            }

            Console.Clear();

            Scale scale = Scale.Unknown;

            while (scale == Scale.Unknown)
            {
                scale = GetScale();
            }

            Console.Clear();

            var key = new Key(root, scale, ModeBuilder.Create(scale));

            Console.WriteLine(key);

            Console.WriteLine("Press a key to go away...");
            Console.ReadKey();
        }

        private static Intonation GetRoot()
        {
            Console.WriteLine("Select the Root:");

            foreach (int value in Enum.GetValues(typeof(Intonation)))
            {
                Console.WriteLine($"{value}: {IntonationMapper.From(value)}");
            }

            var key = Console.ReadKey();

            return IntonationMapper.From(key.KeyChar - 48);
        }

        private static Scale GetScale()
        {
            Console.WriteLine("Select the Scale:");

            foreach (int value in Enum.GetValues(typeof(Scale)))
            {
                Console.WriteLine($"{value}: {ScaleMapper.From(value)}");
            }

            var key = Console.ReadKey();

            return ScaleMapper.From(key.KeyChar - 48);
        }
    }
}
