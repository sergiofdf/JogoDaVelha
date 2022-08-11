namespace JogoDaVelhaForm
{
    public partial class frmJogoVelha : Form
    {
        private int[,] tabuleiro;
        private Jogador jogadorAtual;
        private Jogador jogador_1;
        private Jogador jogador_2;
        public frmJogoVelha()
        {
            InitializeComponent();
            tabuleiro = new int[3, 3];
            jogador_1 = new(1);
            jogador_2 = new(2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            jogadorAtual = jogador_1;
        }

        public void ControlePartida()
        {
            int resultado = FimDeJogo();
            if (resultado != 0)
            {
                switch (resultado)
                {
                    case 1:
                        MessageBox.Show("Vitória do Jogador X!!!");
                        break;
                    case 2:
                        MessageBox.Show($"Vitória do Jogador O!!!");
                        break;
                    case 3:
                        MessageBox.Show("Empate!! Fim de Jogo!!");
                        break;
                }
                Application.Exit();
            }
            jogadorAtual = InverteJogador(jogadorAtual.Id);
        }

        private Jogador InverteJogador(int id)
        {
            return id == 1 ? jogador_2 : jogador_1;
        }

        private bool ExecutaJogada(int linha, int coluna)
        {
            if (tabuleiro[linha, coluna] != 0)
            {
                MessageBox.Show("Posição Inválida");
                return false;
            }
            tabuleiro[linha, coluna] = jogadorAtual.Id;
            return true;
        }

        private int FimDeJogo()
        {
            for (int i = 0; i < 3; i++)
            {
                if ((tabuleiro[i, 0] == tabuleiro[i, 1]) && (tabuleiro[i, 0] == tabuleiro[i, 2]))
                {
                    if (tabuleiro[i, 0] != 0)
                    {
                        return tabuleiro[i, 0];
                    }
                }
            }
            for (int j = 0; j < 3; j++)
            {
                if ((tabuleiro[0, j] == tabuleiro[1, j]) && (tabuleiro[0, j] == tabuleiro[2, j]))
                {
                    if (tabuleiro[0, j] != 0)
                    {
                        return tabuleiro[0, j];
                    }
                }
            }
            if ((tabuleiro[0, 0] == tabuleiro[1, 1]) && (tabuleiro[0, 0] == tabuleiro[2, 2]) && (tabuleiro[0, 0] != 0))
            {
                return tabuleiro[0, 0];
            }
            if ((tabuleiro[0, 2] == tabuleiro[1, 1]) && (tabuleiro[0, 2] == tabuleiro[2, 0]) && (tabuleiro[0, 2] != 0))
            {
                return tabuleiro[0, 2];
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (tabuleiro[i, j] == 0)
                    {
                        return 0;
                    }
                }
            }
            return 3;
        }

        private void lbl00_Click(object sender, EventArgs e)
        {
            bool jogadaRealizada = ExecutaJogada(0, 0);
            if (jogadaRealizada)
            {
                lbl00.Text = jogadorAtual.Signal.ToString();
                ControlePartida();
            }
        }
        private void lbl01_Click(object sender, EventArgs e)
        {
            bool jogadaRealizada = ExecutaJogada(0, 1);
            if (jogadaRealizada)
            {
                lbl01.Text = jogadorAtual.Signal.ToString();
                ControlePartida();
            }
        }

        private void lbl02_Click(object sender, EventArgs e)
        {
            bool jogadaRealizada = ExecutaJogada(0, 2);
            if (jogadaRealizada)
            {
                lbl02.Text = jogadorAtual.Signal.ToString();
                ControlePartida();
            }
        }

        private void lbl10_Click(object sender, EventArgs e)
        {
            bool jogadaRealizada = ExecutaJogada(1, 0);
            if (jogadaRealizada)
            {
                lbl10.Text = jogadorAtual.Signal.ToString();
                ControlePartida();
            }
        }

        private void lbl11_Click(object sender, EventArgs e)
        {
            bool jogadaRealizada = ExecutaJogada(1, 1);
            if (jogadaRealizada)
            {
                lbl11.Text = jogadorAtual.Signal.ToString();
                ControlePartida();
            }
        }

        private void lbl12_Click(object sender, EventArgs e)
        {
            bool jogadaRealizada = ExecutaJogada(1, 2);
            if (jogadaRealizada)
            {
                lbl12.Text = jogadorAtual.Signal.ToString();
                ControlePartida();
            }
        }

        private void lbl20_Click(object sender, EventArgs e)
        {
            bool jogadaRealizada = ExecutaJogada(2, 0);
            if (jogadaRealizada)
            {
                lbl20.Text = jogadorAtual.Signal.ToString();
                ControlePartida();
            }
        }

        private void lbl21_Click(object sender, EventArgs e)
        {
            bool jogadaRealizada = ExecutaJogada(2, 1);
            if (jogadaRealizada)
            {
                lbl21.Text = jogadorAtual.Signal.ToString();
                ControlePartida();
            }
        }

        private void lbl22_Click(object sender, EventArgs e)
        {
            bool jogadaRealizada = ExecutaJogada(2, 2);
            if (jogadaRealizada)
            {
                lbl22.Text = jogadorAtual.Signal.ToString();
                ControlePartida();
            }
        }
    }
}