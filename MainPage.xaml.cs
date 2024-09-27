namespace AtrakcjeZamojskie
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
                Polubienia.Text = $"Polubienia: {count} ";
            else
                Polubienia.Text = $"Polubienia {count} ";

            SemanticScreenReader.Announce(Like.Text);
        }
        private void OnDisCounterClicked(object sender, EventArgs e)
        {


            if (count >= 1)
            {
                Polubienia.Text = $"Polubienia: {count} ";
                count--;
            }

            SemanticScreenReader.Announce(Like.Text);
        }
    }

}
