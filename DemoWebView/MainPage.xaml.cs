namespace DemoWebView
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void WebViewBtn_Clicked(object sender, EventArgs e) {
            myMediaFrame.IsVisible = !myMediaFrame.IsVisible;
            if (myMediaFrame.IsVisible) {
                myWebView.Source = new UrlWebViewSource
                {
                    Url = $"https://en.m.wikipedia.org/wiki/{count}"
                };

            }
        }
    }

}
