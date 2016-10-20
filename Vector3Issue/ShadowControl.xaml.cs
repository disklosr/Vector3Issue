using System.Numerics;
using Windows.UI.Composition;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Hosting;

namespace Vector3Issue
{
    public sealed partial class ShadowControl : ContentControl
    {
        public ShadowControl()
        {
            InitializeComponent();
        }

        protected override void OnApplyTemplate()
        {
            var source = (Grid)GetTemplateChild("CardRoot");
            var target = (Canvas)GetTemplateChild("ShadowHost");

            InitializeDropShadow(source, target);

            base.OnApplyTemplate();
        }

        private void InitializeDropShadow(UIElement shadowShape, UIElement shadowHost)
        {
            Visual hostVisual = ElementCompositionPreview.GetElementVisual(shadowShape);
            Compositor compositor = hostVisual.Compositor;

            var dropShadow = compositor.CreateDropShadow();

            //Commenting this line will make the xaml designer of MainPage.xaml happy
            dropShadow.Offset = new Vector3(0f, 2f, 2f);
        }
    }
}