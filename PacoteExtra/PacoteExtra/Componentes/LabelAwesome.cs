using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace PacoteExtra.Componentes
{
    public class LabelAwesome : Label
    {
        public LabelAwesome() : base()
        {
            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    FontFamily = "Font Awesome 5 Free";
                    break;
                case Device.Android:
                    FontFamily = "fa-solid-900.ttf#Font Awesome 5 Free Solid";
                    break;
                default:
                    throw new Exception("Font não registrada para este OS");
            }
        }
    }
}
