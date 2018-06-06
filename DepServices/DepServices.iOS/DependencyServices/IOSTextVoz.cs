using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AVFoundation;
using DepServices.DependencyServices;
using DepServices.iOS.DependencyServices;
using Foundation;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(IOSTextVoz))]
namespace DepServices.iOS.DependencyServices
{
   public class IOSTextVoz : ITextVoz
    {
        public void Speak(string text)
        {
            var speechSynthesizer = new AVSpeechSynthesizer();

            var speechUtterance = new AVSpeechUtterance(text)
            {
                Rate = AVSpeechUtterance.MaximumSpeechRate / 4,
                Volume = 0.5f,
                PitchMultiplier = 1.0f
            };
            speechSynthesizer.SpeakUtterance(speechUtterance);
           
        }
    }
}