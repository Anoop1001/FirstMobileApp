using Xamarin.Forms;

namespace FirstApp.Behaviors
{
    class EntryBehavior : Behavior<Entry>
    {
        protected override void OnAttachedTo(Entry entry)
        {
            entry.Placeholder = "Enter text!";
            entry.TextChanged += TextChangedEvent;
        }

        private void TextChangedEvent(object sender, TextChangedEventArgs args)
        {
            var entry = sender as Entry;
            entry.Text = args.NewTextValue.Trim();
        }
    }
}
