
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GeniusGame
{
    public partial class Form1 : Form
    {
        List<int> sequence = new List<int>();
        List<int> Inputjogador = new List<int>();
        Random random = new Random();
        int currentStep = 0;
        Timer timer = new Timer();

        public Form1()
        {
            InitializeComponent();
            timer.Interval = 800;
            timer.Tick += Timer_Tick;
        }

        private void ComecarJogo()
        {
            sequence.Clear();
            Inputjogador.Clear();
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
            btn.BackColor = Color.Black;

            var tempTimer = new Timer();
            tempTimer.Interval = 400;
            tempTimer.Tick += (s, e) =>
            {
                btn.BackColor = original;
                ((Timer)s).Stop();
            };
            tempTimer.Start();
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

        private void CliqueBotao(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int indiceCor = ObterIndicePorBotao(btn);
            Inputjogador.Add(indiceCor);

            if (Inputjogador[Inputjogador.Count - 1] != sequence[Inputjogador.Count - 1])
            {
                MessageBox.Show("Você errou! Fim de jogo.");
                ComecarJogo();
                return;
            }

            if (Inputjogador.Count == sequence.Count)
            {
                Inputjogador.Clear();
                AdicionarNaSequencia();
                MostrarSequencia();
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

        private void btnComeco_Click(object sender, EventArgs e)
        {
            ComecarJogo();
        }
    }
}
