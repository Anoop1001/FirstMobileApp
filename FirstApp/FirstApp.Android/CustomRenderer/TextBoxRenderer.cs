using Android.Content;
using Android.Graphics.Drawables;
using FirstApp.CustomControl;
using FirstApp.Droid.CustomRenderer;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]
namespace FirstApp.Droid.CustomRenderer
{
    public class CustomEntryRenderer : EntryRenderer
    {

        public CustomEntryRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            var customControl = e.NewElement as CustomEntry;
            UpdateCustomControl(customControl);
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            var customControl = sender as CustomEntry;
            UpdateCustomControl(customControl);
        }

        private void UpdateCustomControl(CustomEntry customControl)
        {
            if (Control != null)
            {
                if (customControl != null && customControl is CustomEntry customEntry)
                {
                    base.UpdateTextColor(customEntry.BorderColor);
                }
            }
        }

    }
}