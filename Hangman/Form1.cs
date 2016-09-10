using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hangman
{
    public partial class new_game : Form
    {
        public new_game()
        {
            InitializeComponent();
        }

        private int length;
        public int Length
        {
            get { return length; }
            set { length = value; }
        }
        private int tries;
        public int Tries
        {
            get { return tries; }
            set { tries = value; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string[] words = {"INDIA", "PAKISTAN", "BANGLADESH", "SRILANKA", "FRANCE", "GERMANY", "ENGLAND", "AMERICA", "CHINA", "JAPAN",
                              "INDONESIA", "MALAYSIA", "SINGAPORE", "SWITZERLAND", "DUBAI", "AFRICA", "MYNMAR", "NEPAL", "AFGHANISTAN",
                              "MOZAMBIQUE", "PORTUGAL", "BRAZIL"};
            int choosen = rnd.Next(words.Length);
            Length = words[choosen].Length;
            chances_left.Text = "10";
            wrong_guesses.Text = "";
            word_name.Text = "";
            word_choosen.Text = words[choosen];
            char[] wc = word_choosen.Text.ToCharArray();
            output_word.Text = "";
            for (int i = 0; i < words[choosen].Length; i++)
            {
                word_name.Text += "_";
                word_name.Text += " ";
                output_word.Text += "_";
            }
        }

        private void label_Click(object sender, EventArgs e)
        {
            Label l1 = (Label)sender;
            label1.Text = l1.Text;
            char[] selected_letter = l1.Text.ToCharArray();
            char[] name = word_name.Text.ToCharArray();
            char[] choosen = word_choosen.Text.ToCharArray();
            char[] output = output_word.Text.ToCharArray();
            int f = 0;
            for (int i = 0; i < choosen.Length; i++ )
            {
                if (choosen[i] == selected_letter[0])
                {
                    output[i] = selected_letter[0];
                    f = 1;
                    Tries++;
                }
            }
            word_name.Text = "";
            output_word.Text = "";
            for (int i = 0; i < choosen.Length; i++)
            {
                word_name.Text += output[i];
                word_name.Text += " ";
                output_word.Text += output[i];
            }
            l1.Visible = false;
            if (f == 0)
            {
                wrong_guesses.Text += " " + l1.Text;
                int chances = Convert.ToInt32(chances_left.Text);
                if (Convert.ToInt32(chances_left.Text) == 11)
                {
                    pictureBox.Image = Hangman.Properties.Resources.hangman_0;
                }
                if (Convert.ToInt32(chances_left.Text) == 10)
                {
                    pictureBox.Image = Hangman.Properties.Resources.hangman_1;
                }
                if (Convert.ToInt32(chances_left.Text) == 9)
                {
                    pictureBox.Image = Hangman.Properties.Resources.hangman_2;
                }
                if (Convert.ToInt32(chances_left.Text) == 8)
                {
                    pictureBox.Image = Hangman.Properties.Resources.hangman_3;
                }
                if (Convert.ToInt32(chances_left.Text) == 7)
                {
                    pictureBox.Image = Hangman.Properties.Resources.hangman_4;
                }
                if (Convert.ToInt32(chances_left.Text) == 6)
                {
                    pictureBox.Image = Hangman.Properties.Resources.hangman_5;
                }
                if (Convert.ToInt32(chances_left.Text) == 5)
                {
                    pictureBox.Image = Hangman.Properties.Resources.hangman_6;
                }
                if (Convert.ToInt32(chances_left.Text) == 4)
                {
                    pictureBox.Image = Hangman.Properties.Resources.hangman_7;
                }
                if (Convert.ToInt32(chances_left.Text) == 3)
                {
                    pictureBox.Image = Hangman.Properties.Resources.hangman_8;
                }
                if (Convert.ToInt32(chances_left.Text) == 2)
                {
                    pictureBox.Image = Hangman.Properties.Resources.hangman_9;
                }
                if (Convert.ToInt32(chances_left.Text) == 1)
                {
                    pictureBox.Image = Hangman.Properties.Resources.hangman_10;
                }
                chances--;
                chances_left.Text = chances.ToString();
            }
            if (Convert.ToInt32(chances_left.Text) == 0)
            {
                give_up();
            }
            if (Tries == Length)
            {
                won();
            }
        }

        private void won()
        {
            MessageBox.Show("Congratulations! You Won...", "Winner");
            this.Close();
        }

        private void give_up()
        {
            MessageBox.Show("The Word was " + word_choosen.Text, "You Loose!");
            this.Close();
        }

        private void give_up_button_Click(object sender, EventArgs e)
        {
            give_up();
        }
    }
}
