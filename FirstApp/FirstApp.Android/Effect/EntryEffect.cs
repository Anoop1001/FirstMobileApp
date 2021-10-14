using FirstApp.Behaviors;
using FirstApp.Droid.Effect;
using FirstApp.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ResolutionGroupName(nameof(FirstApp))]
[assembly: ExportEffect(typeof(EntryEffect), nameof(EntryEffect))]

namespace FirstApp.Droid.Effect
{
    public class EntryEffect : PlatformEffect
    {
       
        protected override void OnAttached()
        {
            ApplyEffects();
        }

        protected override void OnDetached()
        {
        }

        protected override void OnElementPropertyChanged(System.ComponentModel.PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(args);
            ApplyEffects();
        }

        private void ApplyEffects()
        {
            try
            {
                var customEntry = Element as CustomControl.CustomEntry;
                if (customEntry != null)
                {
                    Control.SetBackgroundColor(customEntry.BorderColor.ToAndroid());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot set property on attached control. Error: ", ex.Message);
            }
        }
    }
}