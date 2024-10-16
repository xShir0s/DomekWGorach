namespace AtrakcjeZamojskie
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        int likes = 0;

        /******************************************************* 

            nazwa funkcji:        private void IncrementLikes(object sender, EventArgs e)

                parametry wejściowe:  object sender - zawiera odwołanie do obiektu
                                      EventArgs e - przekazuje obiekt specyficzny dla obsługiwanego zdarzenia
                                       

                wartość zwracana:     brak

                informacje:           Inkrementuje wartość likes, i podstawia do wartości LblLikeCounter.Text

                autor:                Miłosz Todys 

            ****************************************************/


        private void IncrementLikes(object sender, EventArgs e)
        {
            likes++;
            LblLikeCounter.Text = $"Polubień: {likes}";

        }

        /******************************************************* 

        nazwa funkcji:               private void DecrementLikes(object sender, EventArgs e)


        parametry wejściowe:  object sender - zawiera odwołanie do obiektu
                       EventArgs e - przekazuje obiekt specyficzny dla obsługiwanego zdarzenia


        wartość zwracana:     brak

        informacje:           deInkrementuje wartość likes, i podstawia do wartości LblLikeCounter.Text

        autor:                Miłosz Todys 

        ****************************************************/
        private void DecrementLikes(object sender, EventArgs e)
        {
            if (likes == 0)
            {
                return;
            }
            likes--;
            LblLikeCounter.Text = $"Polubień: {likes}";


        }
    }

}
