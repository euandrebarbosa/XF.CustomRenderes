using Android.Graphics.Drawables;

using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

using XF.CustomRenderes.CustomRenderes;
using XF.CustomRenderes.Droid.CustomRenderes;

[assembly: ExportRenderer(typeof(BorderlessEntry), typeof(BorderlessEntryRenderer))]
namespace XF.CustomRenderes.Droid.CustomRenderes
{
    public class BorderlessEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            /*base.OnElementChanged(e);
            if (e.OldElement == null)
            {
                Control.Background = null;
            }*/

            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.Background = new ColorDrawable(Android.Graphics.Color.Transparent);
            }
        }
    }
}