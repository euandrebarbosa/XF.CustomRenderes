using Xamarin.Forms;

namespace XF.CustomRenderes.Views.Shared
{
    public partial class TextInputView : ContentView
    {
        public TextInputView()
        {
            InitializeComponent();
        }

        #region Properties

        public string Icon
        {
            get => (string)GetValue(IconProperty);
            set => SetValue(IconProperty, value);
        }

        public static readonly BindableProperty IconProperty =
            BindableProperty.Create(nameof(Icon), typeof(string), typeof(TextInputView), string.Empty, propertyChanged: OnIconChanged);

        private static void OnIconChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var view = (TextInputView)bindable;

            view.imgIcon.Source = (string)newValue;
        }

        public string PlaceholderText
        {
            get => (string)GetValue(PlaceholderTextProperty);
            set => SetValue(PlaceholderTextProperty, value);
        }

        public static readonly BindableProperty PlaceholderTextProperty =
            BindableProperty.Create(nameof(PlaceholderText), typeof(string), typeof(TextInputView), string.Empty, propertyChanged: OnPlaceholderTextChanged);

        private static void OnPlaceholderTextChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var view = (TextInputView)bindable;

            view.entryText.Placeholder = (string)newValue;
        }

        #endregion
    }
}