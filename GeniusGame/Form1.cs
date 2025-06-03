
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using WMPLib;

namespace GeniusGame
{
    public partial class Form1 : Form
    {
        // Áudio
        WindowsMediaPlayer playerVerde = new WindowsMediaPlayer();
        WindowsMediaPlayer playerVermelho = new WindowsMediaPlayer();
        WindowsMediaPlayer playerAmarelo = new WindowsMediaPlayer();
        WindowsMediaPlayer playerAzul = new WindowsMediaPlayer();

        // Lógica do jogo
        List<int> sequence = new List<int>();
        List<int> inputJogador = new List<int>();
        Random random = new Random();
        int currentStep = 0;

        // Timer principal
        Timer timer = new Timer();

        public Form1()
        {
            InitializeComponent();
            timer.Interval = 800;
            timer.Tick += Timer_Tick;

            // Carregar áudios
            playerVerde.URL = "audioVerde.mp3";
            playerVermelho.URL = "audioVermelho.mp3";
            playerAmarelo.URL = "audioAmarelo.mp3";
            playerAzul.URL = "audioAzul.mp3";

            playerVerde.settings.volume = 100;
            playerVermelho.settings.volume = 100;
            playerAmarelo.settings.volume = 100;
            playerAzul.settings.volume = 100;
        }

        private void ComecarJogo()
        {
            sequence.Clear();
            inputJogador.Clear();
            currentStep = 0;
            AdicionarNaSequencia();
            MostrarSequencia();
        }

        private void AdicionarNaSequencia()
        {
            sequence.Add(random.Next(0, 4)); // 0=Verde, 1=Vermelho, 2=Amarelo, 3=Azul
        }

        private void MostrarSequencia()
        {
            currentStep = 0;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (currentStep >= sequence.Count)
            {
                timer.Stop();
                return;
            }

            AcenderBotao(sequence[currentStep]);
            currentStep++;
        }

        private void AcenderBotao(int indiceCor)
        {
            Button btn = ObterBotaoPorIndice(indiceCor);
            Color original = btn.BackColor;
            btn.BackColor = Color.White;

            TocarSom(indiceCor);

            var tempTimer = new Timer();
            tempTimer.Interval = 400;
            tempTimer.Tick += (s, e) =>
            {
                btn.BackColor = original;
                ((Timer)s).Stop();
                tempTimer.Dispose();
            };
            tempTimer.Start();
        }

        private void TocarSom(int indiceCor)
        {
            switch (indiceCor)
            {
                case 0: playerVerde.controls.play(); break;
                case 1: playerVermelho.controls.play(); break;
                case 2: playerAmarelo.controls.play(); break;
                case 3: playerAzul.controls.play(); break;
            }
        }

        private Button ObterBotaoPorIndice(int indice)
        {
            switch (indice)
            {
                case 0: return btnVerde;
                case 1: return btnVermelho;
                case 2: return btnAmarelo;
                case 3: return btnAzul;
                default: return null;
            }
        }

        private int ObterIndicePorBotao(Button btn)
        {
            if (btn == btnVerde) return 0;
            if (btn == btnVermelho) return 1;
            if (btn == btnAmarelo) return 2;
            if (btn == btnAzul) return 3;
            return -1;
        }

        private void CliqueBotao(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int indiceCor = ObterIndicePorBotao(btn);

            TocarSom(indiceCor);

            inputJogador.Add(indiceCor);

            if (inputJogador[inputJogador.Count - 1] != sequence[inputJogador.Count - 1])
            {
                MessageBox.Show("Você errou! Fim de jogo.");
                ComecarJogo();
                return;
            }

            if (inputJogador.Count == sequence.Count)
            {
                inputJogador.Clear();
                AdicionarNaSequencia();
                MostrarSequencia();
            }
        }

        private void btnComeco_Click(object sender, EventArgs e)
        {
            ComecarJogo();
        }
    }
}
