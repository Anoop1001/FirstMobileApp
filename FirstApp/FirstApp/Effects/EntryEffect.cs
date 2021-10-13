using Xamarin.Forms;

namespace FirstApp.Effects
{
    public class EntryEffect : RoutingEffect
    {
        public EntryEffect() : base($"{nameof(FirstApp)}.{nameof(EntryEffect)}")
        {
        }
    }
}
