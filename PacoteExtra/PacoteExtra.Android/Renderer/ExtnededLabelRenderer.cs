using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using PacoteExtra.Componentes;
using PacoteExtra.Droid.Renderer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(PacoteExtra.Componentes.JustifyLabel), typeof(PacoteExtra.Droid.Renderer.ExtnededLabelRenderer))]
namespace PacoteExtra.Droid.Renderer
{
    public class ExtnededLabelRenderer : Xamarin.Forms.Platform.Android.LabelRenderer
    {
        public ExtnededLabelRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            var el = (Element as JustifyLabel);

            if (el != null && el.JustifyText)
            {
                if (Android.OS.Build.VERSION.SdkInt >= Android.OS.BuildVersionCodes.O)
                {
                    Control.JustificationMode = Android.Text.JustificationMode.InterWord;
                }

            }
        }
    }
}