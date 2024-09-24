using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud16092024
{
    public partial class Form1 : Form
    {
        Lista pers = new Lista();
        public Form1()
        {
            InitializeComponent();
            this.lista.SelectedIndexChanged += new System.EventHandler(this.lista_SelectedIndexChanged);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("Lista.txt"))
            {
                var file = new FileStream("Lista.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(file);
                string riga = sr.ReadLine();
                int i = 0;
                while (riga != null)
                {
                    string[] dati = riga.Split(' ');
                    if (dati.Length == 2)
                    {
                        Persona persone = new Persona(dati[0], dati[1]);
                        pers.Perso.Add(persone);
                        lista.Items.Add(pers.Perso[i].nome + " " + pers.Perso[i].cognome);
                        i++;
                    }
                    else
                    {
                        MessageBox.Show("La riga del file non è nel formato corretto: " + riga, "Errore formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    riga = sr.ReadLine();
                }
                sr.Close();
                file.Close();
            }
        }
        class Lista
        {
            public List<Persona> Perso = new List<Persona>();
        }
        class Persona
        {
            public Persona(string nome, string cognome)
            {
                this.nome = nome;
                this.cognome = cognome;
            }
            public string nome;
            public string cognome;
            public string Nome
            {
                get { return nome; }
                set { nome = value; }
            }
            public string Cognome
            {
                get { return cognome; }
                set { cognome = value; }
            }
        }
        private void crea_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nometext.Text))
            {
                MessageBox.Show("Inserisci il nome.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(cognometext.Text))
            {
                MessageBox.Show("Inserisci il cognome.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Persona persone = new Persona(nometext.Text, cognometext.Text);
            pers.Perso.Add(persone);
            lista.Items.Add(nometext.Text + " " + cognometext.Text);
            nometext.Clear();
            cognometext.Clear();
            AggiornaFile();
        }
        private void lista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void modifica_Click(object sender, EventArgs e)
        {
            if (lista.SelectedIndex >= 0)
            {
                if (string.IsNullOrWhiteSpace(nometext.Text))
                {
                    MessageBox.Show("Inserisci il nome.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(cognometext.Text))
                {
                    MessageBox.Show("Inserisci il cognome.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int indice = lista.SelectedIndex;
                pers.Perso[indice].nome = nometext.Text;
                pers.Perso[indice].cognome = cognometext.Text;
                lista.Items[indice] = nometext.Text + " " + cognometext.Text;
                nometext.Clear();
                cognometext.Clear();
                AggiornaFile();
            }
            else
            {
                MessageBox.Show("Seleziona una persona da modificare", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void elimina_Click(object sender, EventArgs e)
        {
            if (lista.SelectedIndex >= 0)
            {
                int indice = lista.SelectedIndex;
                pers.Perso.RemoveAt(indice);
                lista.Items.RemoveAt(indice);
                nometext.Clear();
                cognometext.Clear();
                AggiornaFile();
            }
            else
            {
                MessageBox.Show("Seleziona una persona da eliminare", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void AggiornaFile()
        {
            var file = new FileStream("Lista.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(file);
            for (int i = 0; i < pers.Perso.Count; i++)
            {
                sw.WriteLine($"{pers.Perso[i].nome} {pers.Perso[i].cognome}");
            }
            sw.Close();
            file.Close();
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            AggiornaFile();
        }
        private void cerca_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nometext.Text))
            {
                MessageBox.Show("Inserisci il nome.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(cognometext.Text))
            {
                MessageBox.Show("Inserisci il cognome.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string nomericerca = nometext.Text;
            string cognomericerca = cognometext.Text;
            bool trovato = false;
            for (int i = 0; i < pers.Perso.Count; i++)
            {
                if (pers.Perso[i].nome.ToLower() == nomericerca.ToLower() &&
                    pers.Perso[i].cognome.ToLower() == cognomericerca.ToLower())
                {
                    MessageBox.Show($"{nomericerca} {cognomericerca} è presente nella lista nella posizione {i + 1}.", "Risultato ricerca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    trovato = true;
                    break;
                }
            }
            if (!trovato)
            {
                MessageBox.Show($"{nomericerca} {cognomericerca} non è presente nella lista.", "Risultato ricerca", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}