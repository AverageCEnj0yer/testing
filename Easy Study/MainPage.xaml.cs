namespace Easy_Study
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
                CounterBtn.Text = $"This is a test: {count} time";
            else
                CounterBtn.Text = $"You have clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
