using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DepServices.iOS.DependencyServices;
using Foundation;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(IosMessage))]
namespace DepServices.iOS.DependencyServices
{
   public class IosMessage: IPlatMessage
    {
        public string GetMesagge()
        {
            return "estoy en IOs";
        }

    }
}