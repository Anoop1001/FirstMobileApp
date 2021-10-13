using FirstApp.Models;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace FirstApp.Behaviors
{
    public class PickerBehavior : Behavior<Picker>
    {
        protected override void OnAttachedTo(Picker entry)
        {
            entry.SelectedIndexChanged += SelectedIndexChangedEvent;
        }

        public static readonly BindableProperty DisplayColorProperty =
             BindableProperty.Create(nameof(DisplayColor),
                 typeof(int),
                 typeof(DisplayColor),
                 0,
                 BindingMode.TwoWay);

        private void SelectedIndexChangedEvent(object sender, EventArgs args)
        {
            var picker = sender as Picker;
            var displayColor = picker.SelectedItem as DisplayColor;

            DisplayColor = displayColor.Id;
        }

        public static readonly BindableProperty CommandProperty = BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(PickerBehavior), (object)null);

        public static ICommand GetCommand(BindableObject view)
        {
            return (ICommand)view.GetValue(CommandProperty);
        }

        public Color DisplayColor
        {
            get => (Color)GetValue(DisplayColorProperty);

            set => SetValue(DisplayColorProperty, value);
        }
    }
}
