using PacoteExtra.Componentes;
using PacoteExtra.iOS.Renderer;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(JustifyLabel), typeof(ExtendedLabelRenderer))]
namespace PacoteExtra.iOS.Renderer
{
    public class ExtendedLabelRenderer : Xamarin.Forms.Platform.iOS.LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            if (Control == null || this.Element == null) return;

            Control.TextAlignment = UITextAlignment.Justified;

        }
    }
}