namespace MauiAppJogoDaVelha
{
    public partial class MainPage : ContentPage
    {
        string vez = "X";

        public MainPage()
        {
            InitializeComponent();
        }

        public void BloquearCampos()
        {
            Button[] botoes =
            {
                btn10, btn11, btn12,
                btn20, btn21, btn22,
                btn30, btn31, btn32
            };
            foreach (Button b in botoes) 
            {
                b.IsEnabled = false;
            }
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            Button clicado = (Button)sender;

            clicado.Text = vez;
			clicado.IsEnabled = false;

			if (
				(btn10.Text == vez && btn11.Text == vez && btn12.Text == vez) ||
				(btn20.Text == vez && btn21.Text == vez && btn22.Text == vez) ||
				(btn30.Text == vez && btn31.Text == vez && btn32.Text == vez) ||

				(btn10.Text == vez && btn20.Text == vez && btn30.Text == vez) ||
				(btn11.Text == vez && btn21.Text == vez && btn31.Text == vez) ||
				(btn12.Text == vez && btn22.Text == vez && btn32.Text == vez) ||

				(btn10.Text == vez && btn21.Text == vez && btn32.Text == vez) ||
				(btn12.Text == vez && btn21.Text == vez && btn30.Text == vez)
				)
			{
                textoInferior.Text = $"O jogador {vez} Ganhou";
                BloquearCampos();
                resetar.IsVisible = true;
                return;
            }
            else if (
                !btn10.IsEnabled && !btn11.IsEnabled && !btn12.IsEnabled && 
                !btn20.IsEnabled && !btn21.IsEnabled && !btn22.IsEnabled &&
                !btn30.IsEnabled && !btn31.IsEnabled && !btn32.IsEnabled
            )
            {
                textoInferior.Text = $"Deu empate";
                BloquearCampos();
                resetar.IsVisible = true;
                return;
            }
            vez = (vez == "X") ? "O" : "X";
            textoInferior.Text = $"É a vez do jogador {vez}";
		}

        private void resetar_Clicked(object sender, EventArgs e)
        {
            Button[] botoes =
            {
                btn10, btn11, btn12,
                btn20, btn21, btn22,
                btn30, btn31, btn32
            };

            foreach (Button b in botoes)
            {
                b.Text = "";
                b.IsEnabled = true;   
            }

            vez = "X";
            resetar.IsVisible = false;
            textoInferior.Text = $"É a vez do jogador {vez}";
        }
    }
}
