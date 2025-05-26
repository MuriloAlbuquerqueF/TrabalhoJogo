
namespace GeniusGame
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnVerde;
        private System.Windows.Forms.Button btnVermelho;
        private System.Windows.Forms.Button btnAmarelo;
        private System.Windows.Forms.Button btnAzul;
        private System.Windows.Forms.Button btnComeco;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnVerde = new System.Windows.Forms.Button();
            btnVermelho = new System.Windows.Forms.Button();
            btnAmarelo = new System.Windows.Forms.Button();
            btnAzul = new System.Windows.Forms.Button();
            btnComeco = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // btnVerde
            // 
            btnVerde.BackColor = System.Drawing.Color.FromArgb(128, 255, 128);
            btnVerde.Location = new System.Drawing.Point(44, 22);
            btnVerde.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnVerde.Name = "btnVerde";
            btnVerde.Size = new System.Drawing.Size(88, 75);
            btnVerde.TabIndex = 4;
            btnVerde.UseVisualStyleBackColor = false;
            btnVerde.Click += CliqueBotao;
            // 
            // btnVermelho
            // 
            btnVermelho.BackColor = System.Drawing.Color.FromArgb(255, 128, 128);
            btnVermelho.Location = new System.Drawing.Point(158, 22);
            btnVermelho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnVermelho.Name = "btnVermelho";
            btnVermelho.Size = new System.Drawing.Size(88, 75);
            btnVermelho.TabIndex = 3;
            btnVermelho.UseVisualStyleBackColor = false;
            btnVermelho.Click += CliqueBotao;
            // 
            // btnAmarelo
            // 
            btnAmarelo.BackColor = System.Drawing.Color.FromArgb(255, 255, 128);
            btnAmarelo.Location = new System.Drawing.Point(44, 112);
            btnAmarelo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnAmarelo.Name = "btnAmarelo";
            btnAmarelo.Size = new System.Drawing.Size(88, 75);
            btnAmarelo.TabIndex = 2;
            btnAmarelo.UseVisualStyleBackColor = false;
            btnAmarelo.Click += CliqueBotao;
            // 
            // btnAzul
            // 
            btnAzul.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
            btnAzul.Location = new System.Drawing.Point(158, 112);
            btnAzul.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnAzul.Name = "btnAzul";
            btnAzul.Size = new System.Drawing.Size(88, 75);
            btnAzul.TabIndex = 1;
            btnAzul.UseVisualStyleBackColor = false;
            btnAzul.Click += CliqueBotao;
            // 
            // btnComeco
            // 
            btnComeco.BackColor = System.Drawing.Color.LightGray;
            btnComeco.Location = new System.Drawing.Point(88, 202);
            btnComeco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnComeco.Name = "btnComeco";
            btnComeco.Size = new System.Drawing.Size(105, 30);
            btnComeco.TabIndex = 0;
            btnComeco.Text = "Começar";
            btnComeco.UseVisualStyleBackColor = false;
            btnComeco.Click += btnComeco_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(292, 256);
            Controls.Add(btnComeco);
            Controls.Add(btnAzul);
            Controls.Add(btnAmarelo);
            Controls.Add(btnVermelho);
            Controls.Add(btnVerde);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Jogo Genius";
            ResumeLayout(false);
        }
    }
}
