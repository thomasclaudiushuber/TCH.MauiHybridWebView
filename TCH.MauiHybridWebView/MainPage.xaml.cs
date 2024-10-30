namespace TCH.MauiHybridWebView
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }



        private void Button_Clicked(object sender, EventArgs e)
        {
            hybridWebView.SendRawMessage(messageForJS.Text);
        }

        private void hybridWebView_RawMessageReceived(object sender, HybridWebViewRawMessageReceivedEventArgs e)
        {
            messagesFromJs.Text = e.Message + Environment.NewLine + messagesFromJs.Text;
        }
    }

}
