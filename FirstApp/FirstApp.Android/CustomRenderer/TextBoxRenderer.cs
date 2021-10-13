using Android.Content;
using FirstApp.Droid.CustomRenderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Entry), typeof(TextBoxRenderer))]
namespace FirstApp.Droid.CustomRenderer
{
    public class TextBoxRenderer : EntryRenderer
    {

        public TextBoxRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            //base.UpdateTextColor(Color.Blue);
            this.SetFocusable();
        }
    }
}