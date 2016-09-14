using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech;
using System.Speech.Synthesis;
//using System.Speech.Recognition;

namespace SpeechTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //SpeechRecognitionEngine speechRecognitionEngine = null;
            SpeechSynthesizer ss = new SpeechSynthesizer();
            //ss.Rate()
            foreach (var v in ss.GetInstalledVoices().Select(v => v.VoiceInfo))
            {
                Console.WriteLine("Name:{0}, Gender:{1}, Age:{2}",
                  v.Description, v.Gender, v.Age);
            }
            //ss.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Child);
            //ss.Speak("This is a test.");
            for (int i = -10; i < 10; i++)
            {
                ss.Rate = i;
                ss.Speak("faster");
            }

            Console.ReadKey();
        }
    }
}
