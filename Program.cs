using System;
using System.Speech.Synthesis;

namespace AidenConsoleSpeech
{
    class Program
    {
        static void Main(string[] args)
        {
            var speak = "Hey Aiden.";
            Console.WriteLine(speak);

            using (var synth = new SpeechSynthesizer())
            {
                synth.SelectVoice("Microsoft Zira Desktop");

                do
                {
                    synth.Speak(speak);
                    speak = Console.ReadLine();
                } 
                while (speak != "exit");
            }
        }
    }
}
