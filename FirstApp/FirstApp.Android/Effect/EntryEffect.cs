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
        Android.Graphics.Color originalBackgroundColor = new Android.Graphics.Color(0, 0, 0, 0);
        Android.Graphics.Color backgroundColor;
       

        private static void OnEventNameChanged(BindableObject bindable, object oldValue, object newValue)
        {
            
        }

        protected override void OnAttached()
        {
            try
            {
                backgroundColor = originalBackgroundColor;
                var obj = PickerBehavior.GetCommand(Element);
                Control.SetBackgroundColor(backgroundColor);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot set property on attached control. Error: ", ex.Message);
            }
        }

        protected override void OnDetached()
        {
        }

        protected override void OnElementPropertyChanged(System.ComponentModel.PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(args);
            try
            {
                if (args.PropertyName == "IsFocused")
                {
                    if (((Android.Graphics.Drawables.ColorDrawable)Control.Background).Color == backgroundColor)
                    {
                        Control.SetBackgroundColor(originalBackgroundColor);
                    }
                    else
                    {
                        Control.SetBackgroundColor(backgroundColor);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot set property on attached control. Error: ", ex.Message);
            }
        }
    }
}