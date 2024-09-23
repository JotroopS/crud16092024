namespace crud16092024
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.nometext = new System.Windows.Forms.TextBox();
            this.cognometext = new System.Windows.Forms.TextBox();
            this.crea = new System.Windows.Forms.Button();
            this.modifica = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.elimina = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lista = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // nometext
            // 
            this.nometext.Location = new System.Drawing.Point(12, 149);
            this.nometext.Name = "nometext";
            this.nometext.Size = new System.Drawing.Size(174, 22);
            this.nometext.TabIndex = 0;
            // 
            // cognometext
            // 
            this.cognometext.Location = new System.Drawing.Point(12, 242);
            this.cognometext.Name = "cognometext";
            this.cognometext.Size = new System.Drawing.Size(174, 22);
            this.cognometext.TabIndex = 1;
            // 
            // crea
            // 
            this.crea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crea.Location = new System.Drawing.Point(213, 22);
            this.crea.Name = "crea";
            this.crea.Size = new System.Drawing.Size(176, 88);
            this.crea.TabIndex = 2;
            this.crea.Text = "Crea";
            this.crea.UseVisualStyleBackColor = true;
            this.crea.Click += new System.EventHandler(this.crea_Click);
            // 
            // modifica
            // 
            this.modifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifica.Location = new System.Drawing.Point(213, 116);
            this.modifica.Name = "modifica";
            this.modifica.Size = new System.Drawing.Size(176, 88);
            this.modifica.TabIndex = 3;
            this.modifica.Text = "Modifica";
            this.modifica.UseVisualStyleBackColor = true;
            this.modifica.Click += new System.EventHandler(this.modifica_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(213, 210);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(176, 87);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // elimina
            // 
            this.elimina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elimina.Location = new System.Drawing.Point(213, 303);
            this.elimina.Name = "elimina";
            this.elimina.Size = new System.Drawing.Size(176, 86);
            this.elimina.TabIndex = 5;
            this.elimina.Text = "Elimina";
            this.elimina.UseVisualStyleBackColor = true;
            this.elimina.Click += new System.EventHandler(this.elimina_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Inserisci il nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Inserisci il cognome";
            // 
            // lista
            // 
            this.lista.FormattingEnabled = true;
            this.lista.ItemHeight = 16;
            this.lista.Location = new System.Drawing.Point(395, 22);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(393, 420);
            this.lista.TabIndex = 8;
            this.lista.SelectedIndexChanged += new System.EventHandler(this.lista_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.elimina);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.modifica);
            this.Controls.Add(this.crea);
            this.Controls.Add(this.cognometext);
            this.Controls.Add(this.nometext);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nometext;
        private System.Windows.Forms.TextBox cognometext;
        private System.Windows.Forms.Button crea;
        private System.Windows.Forms.Button modifica;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button elimina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lista;
    }
}

