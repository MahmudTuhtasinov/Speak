using System;
using System.Linq;
using System.Speech.Synthesis;
using System.IO;
namespace Speak.App
{
    class Program
    {
        private static readonly SpeechSynthesizer SpeechSynthesizer = new SpeechSynthesizer();

        static void Main(string[] args)
        {
            string[] filePath = File.ReadAllLines("d:\\1.txt");
            string[] filePath1 = File.ReadAllLines("d:\\1.txt");

            SpeechSynthesizer speechSynth = new SpeechSynthesizer();
            speechSynth.Volume = 100;
            speechSynth.Rate = -6;

            Random rand = new Random();
            int a, o = 0, n = 0;
            for (int i = 0; i < filePath.Length; i++)
            {
                a = rand.Next(0, filePath.Length);

                if (filePath[a] != "0")
                {
                    speechSynth.Speak(filePath[a]);

                    for (int j = 0; j < 3; j++)
                    {
                        Console.WriteLine(j + 1 + ") " + filePath1[a]);
                        a = rand.Next(0, filePath.Length);
                    }

                    int c = Convert.ToInt32(Console.ReadLine());
                    if (c == 1)
                    {
                        Console.WriteLine("Ok");
                        o++;
                    }
                    else
                    {
                        Console.WriteLine("Not");
                        n++;
                    }

                    filePath[a] = "0";
                }
            }
            Console.WriteLine("Ok = " + o + " Not = " + n);

            Console.ReadKey();
        }

    }
}
