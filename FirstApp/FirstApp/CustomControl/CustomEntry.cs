using Xamarin.Forms;

namespace FirstApp.CustomControl
{
    public class CustomEntry : Entry
    {
        public static readonly BindableProperty CornerRadiusProperty =
           BindableProperty.Create(nameof(CornerRadius), typeof(int), typeof(CustomEntry));

        public static readonly BindableProperty BorderColorProperty =
            BindableProperty.Create(nameof(BorderColor), typeof(Color), typeof(CustomEntry), null, BindingMode.TwoWay);

        public static readonly BindableProperty BorderWidthProperty =
            BindableProperty.Create(nameof(BorderWidth), typeof(int), typeof(CustomEntry));

        public int CornerRadius
        {
            get
            {
                return GetValue<int>(CornerRadiusProperty);
            }
            set
            {
                SetValue(CornerRadiusProperty, value);
            }
        }


        public Color BorderColor
        {
            get
            {
                return GetValue<Color>(BorderColorProperty);
            }
            set
            {
                SetValue(BorderColorProperty, value);
            }
        }


        public int BorderWidth
        {
            get
            {
                return GetValue<int>(BorderWidthProperty);
            }
            set
            {
                SetValue(BorderWidthProperty, value);
            }
        }


        #region Methods

        public T GetValue<T>(BindableProperty property)
        {
            return (T)GetValue(property);
        }

        #endregion
    }
}
