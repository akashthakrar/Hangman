namespace Hangman
{
    partial class new_game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.word_name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chances_left = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.wrong_guesses = new System.Windows.Forms.Label();
            this.a_label = new System.Windows.Forms.Label();
            this.b_label = new System.Windows.Forms.Label();
            this.c_label = new System.Windows.Forms.Label();
            this.d_label = new System.Windows.Forms.Label();
            this.e_label = new System.Windows.Forms.Label();
            this.j_label = new System.Windows.Forms.Label();
            this.i_label = new System.Windows.Forms.Label();
            this.h_label = new System.Windows.Forms.Label();
            this.g_label = new System.Windows.Forms.Label();
            this.f_label = new System.Windows.Forms.Label();
            this.t_label = new System.Windows.Forms.Label();
            this.s_label = new System.Windows.Forms.Label();
            this.r_label = new System.Windows.Forms.Label();
            this.q_label = new System.Windows.Forms.Label();
            this.p_label = new System.Windows.Forms.Label();
            this.o_label = new System.Windows.Forms.Label();
            this.n_label = new System.Windows.Forms.Label();
            this.m_label = new System.Windows.Forms.Label();
            this.l_label = new System.Windows.Forms.Label();
            this.k_label = new System.Windows.Forms.Label();
            this.y_label = new System.Windows.Forms.Label();
            this.x_label = new System.Windows.Forms.Label();
            this.w_label = new System.Windows.Forms.Label();
            this.v_label = new System.Windows.Forms.Label();
            this.u_label = new System.Windows.Forms.Label();
            this.z_label = new System.Windows.Forms.Label();
            this.give_up_button = new System.Windows.Forms.Button();
            this.word_choosen = new System.Windows.Forms.Label();
            this.output_word = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::Hangman.Properties.Resources.hangman_0;
            this.pictureBox.Location = new System.Drawing.Point(12, 98);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(237, 252);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // word_name
            // 
            this.word_name.AutoSize = true;
            this.word_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.word_name.Location = new System.Drawing.Point(299, 98);
            this.word_name.Name = "word_name";
            this.word_name.Size = new System.Drawing.Size(125, 25);
            this.word_name.TabIndex = 1;
            this.word_name.Text = "Word Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chances Left :";
            // 
            // chances_left
            // 
            this.chances_left.AutoSize = true;
            this.chances_left.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chances_left.Location = new System.Drawing.Point(261, 48);
            this.chances_left.Name = "chances_left";
            this.chances_left.Size = new System.Drawing.Size(24, 16);
            this.chances_left.TabIndex = 3;
            this.chances_left.Text = "10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Incorrect Guesses:";
            // 
            // wrong_guesses
            // 
            this.wrong_guesses.AutoSize = true;
            this.wrong_guesses.Location = new System.Drawing.Point(205, 372);
            this.wrong_guesses.Name = "wrong_guesses";
            this.wrong_guesses.Size = new System.Drawing.Size(78, 13);
            this.wrong_guesses.TabIndex = 5;
            this.wrong_guesses.Text = "wrong guesses";
            // 
            // a_label
            // 
            this.a_label.AutoSize = true;
            this.a_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a_label.Location = new System.Drawing.Point(280, 165);
            this.a_label.Name = "a_label";
            this.a_label.Size = new System.Drawing.Size(18, 16);
            this.a_label.TabIndex = 6;
            this.a_label.Text = "A";
            this.a_label.Click += new System.EventHandler(this.label_Click);
            // 
            // b_label
            // 
            this.b_label.AutoSize = true;
            this.b_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_label.Location = new System.Drawing.Point(314, 165);
            this.b_label.Name = "b_label";
            this.b_label.Size = new System.Drawing.Size(18, 16);
            this.b_label.TabIndex = 7;
            this.b_label.Text = "B";
            this.b_label.Click += new System.EventHandler(this.label_Click);
            // 
            // c_label
            // 
            this.c_label.AutoSize = true;
            this.c_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_label.Location = new System.Drawing.Point(349, 165);
            this.c_label.Name = "c_label";
            this.c_label.Size = new System.Drawing.Size(18, 16);
            this.c_label.TabIndex = 8;
            this.c_label.Text = "C";
            this.c_label.Click += new System.EventHandler(this.label_Click);
            // 
            // d_label
            // 
            this.d_label.AutoSize = true;
            this.d_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_label.Location = new System.Drawing.Point(383, 165);
            this.d_label.Name = "d_label";
            this.d_label.Size = new System.Drawing.Size(19, 16);
            this.d_label.TabIndex = 9;
            this.d_label.Text = "D";
            this.d_label.Click += new System.EventHandler(this.label_Click);
            // 
            // e_label
            // 
            this.e_label.AutoSize = true;
            this.e_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e_label.Location = new System.Drawing.Point(412, 165);
            this.e_label.Name = "e_label";
            this.e_label.Size = new System.Drawing.Size(18, 16);
            this.e_label.TabIndex = 10;
            this.e_label.Text = "E";
            this.e_label.Click += new System.EventHandler(this.label_Click);
            // 
            // j_label
            // 
            this.j_label.AutoSize = true;
            this.j_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.j_label.Location = new System.Drawing.Point(412, 191);
            this.j_label.Name = "j_label";
            this.j_label.Size = new System.Drawing.Size(16, 16);
            this.j_label.TabIndex = 15;
            this.j_label.Text = "J";
            this.j_label.Click += new System.EventHandler(this.label_Click);
            // 
            // i_label
            // 
            this.i_label.AutoSize = true;
            this.i_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.i_label.Location = new System.Drawing.Point(384, 191);
            this.i_label.Name = "i_label";
            this.i_label.Size = new System.Drawing.Size(12, 16);
            this.i_label.TabIndex = 14;
            this.i_label.Text = "I";
            this.i_label.Click += new System.EventHandler(this.label_Click);
            // 
            // h_label
            // 
            this.h_label.AutoSize = true;
            this.h_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.h_label.Location = new System.Drawing.Point(349, 191);
            this.h_label.Name = "h_label";
            this.h_label.Size = new System.Drawing.Size(19, 16);
            this.h_label.TabIndex = 13;
            this.h_label.Text = "H";
            this.h_label.Click += new System.EventHandler(this.label_Click);
            // 
            // g_label
            // 
            this.g_label.AutoSize = true;
            this.g_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.g_label.Location = new System.Drawing.Point(312, 191);
            this.g_label.Name = "g_label";
            this.g_label.Size = new System.Drawing.Size(19, 16);
            this.g_label.TabIndex = 12;
            this.g_label.Text = "G";
            this.g_label.Click += new System.EventHandler(this.label_Click);
            // 
            // f_label
            // 
            this.f_label.AutoSize = true;
            this.f_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f_label.Location = new System.Drawing.Point(281, 191);
            this.f_label.Name = "f_label";
            this.f_label.Size = new System.Drawing.Size(17, 16);
            this.f_label.TabIndex = 11;
            this.f_label.Text = "F";
            this.f_label.Click += new System.EventHandler(this.label_Click);
            // 
            // t_label
            // 
            this.t_label.AutoSize = true;
            this.t_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_label.Location = new System.Drawing.Point(413, 246);
            this.t_label.Name = "t_label";
            this.t_label.Size = new System.Drawing.Size(18, 16);
            this.t_label.TabIndex = 25;
            this.t_label.Text = "T";
            this.t_label.Click += new System.EventHandler(this.label_Click);
            // 
            // s_label
            // 
            this.s_label.AutoSize = true;
            this.s_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s_label.Location = new System.Drawing.Point(385, 246);
            this.s_label.Name = "s_label";
            this.s_label.Size = new System.Drawing.Size(18, 16);
            this.s_label.TabIndex = 24;
            this.s_label.Text = "S";
            this.s_label.Click += new System.EventHandler(this.label_Click);
            // 
            // r_label
            // 
            this.r_label.AutoSize = true;
            this.r_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r_label.Location = new System.Drawing.Point(349, 246);
            this.r_label.Name = "r_label";
            this.r_label.Size = new System.Drawing.Size(19, 16);
            this.r_label.TabIndex = 23;
            this.r_label.Text = "R";
            this.r_label.Click += new System.EventHandler(this.label_Click);
            // 
            // q_label
            // 
            this.q_label.AutoSize = true;
            this.q_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q_label.Location = new System.Drawing.Point(312, 246);
            this.q_label.Name = "q_label";
            this.q_label.Size = new System.Drawing.Size(19, 16);
            this.q_label.TabIndex = 22;
            this.q_label.Text = "Q";
            this.q_label.Click += new System.EventHandler(this.label_Click);
            // 
            // p_label
            // 
            this.p_label.AutoSize = true;
            this.p_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_label.Location = new System.Drawing.Point(280, 246);
            this.p_label.Name = "p_label";
            this.p_label.Size = new System.Drawing.Size(18, 16);
            this.p_label.TabIndex = 21;
            this.p_label.Text = "P";
            this.p_label.Click += new System.EventHandler(this.label_Click);
            // 
            // o_label
            // 
            this.o_label.AutoSize = true;
            this.o_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.o_label.Location = new System.Drawing.Point(413, 216);
            this.o_label.Name = "o_label";
            this.o_label.Size = new System.Drawing.Size(19, 16);
            this.o_label.TabIndex = 20;
            this.o_label.Text = "O";
            this.o_label.Click += new System.EventHandler(this.label_Click);
            // 
            // n_label
            // 
            this.n_label.AutoSize = true;
            this.n_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n_label.Location = new System.Drawing.Point(385, 216);
            this.n_label.Name = "n_label";
            this.n_label.Size = new System.Drawing.Size(19, 16);
            this.n_label.TabIndex = 19;
            this.n_label.Text = "N";
            this.n_label.Click += new System.EventHandler(this.label_Click);
            // 
            // m_label
            // 
            this.m_label.AutoSize = true;
            this.m_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_label.Location = new System.Drawing.Point(349, 216);
            this.m_label.Name = "m_label";
            this.m_label.Size = new System.Drawing.Size(20, 16);
            this.m_label.TabIndex = 18;
            this.m_label.Text = "M";
            this.m_label.Click += new System.EventHandler(this.label_Click);
            // 
            // l_label
            // 
            this.l_label.AutoSize = true;
            this.l_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_label.Location = new System.Drawing.Point(314, 216);
            this.l_label.Name = "l_label";
            this.l_label.Size = new System.Drawing.Size(16, 16);
            this.l_label.TabIndex = 17;
            this.l_label.Text = "L";
            this.l_label.Click += new System.EventHandler(this.label_Click);
            // 
            // k_label
            // 
            this.k_label.AutoSize = true;
            this.k_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.k_label.Location = new System.Drawing.Point(280, 216);
            this.k_label.Name = "k_label";
            this.k_label.Size = new System.Drawing.Size(17, 16);
            this.k_label.TabIndex = 16;
            this.k_label.Text = "K";
            this.k_label.Click += new System.EventHandler(this.label_Click);
            // 
            // y_label
            // 
            this.y_label.AutoSize = true;
            this.y_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.y_label.Location = new System.Drawing.Point(412, 272);
            this.y_label.Name = "y_label";
            this.y_label.Size = new System.Drawing.Size(18, 16);
            this.y_label.TabIndex = 30;
            this.y_label.Text = "Y";
            this.y_label.Click += new System.EventHandler(this.label_Click);
            // 
            // x_label
            // 
            this.x_label.AutoSize = true;
            this.x_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x_label.Location = new System.Drawing.Point(384, 272);
            this.x_label.Name = "x_label";
            this.x_label.Size = new System.Drawing.Size(17, 16);
            this.x_label.TabIndex = 29;
            this.x_label.Text = "X";
            this.x_label.Click += new System.EventHandler(this.label_Click);
            // 
            // w_label
            // 
            this.w_label.AutoSize = true;
            this.w_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.w_label.Location = new System.Drawing.Point(349, 272);
            this.w_label.Name = "w_label";
            this.w_label.Size = new System.Drawing.Size(22, 16);
            this.w_label.TabIndex = 28;
            this.w_label.Text = "W";
            this.w_label.Click += new System.EventHandler(this.label_Click);
            // 
            // v_label
            // 
            this.v_label.AutoSize = true;
            this.v_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_label.Location = new System.Drawing.Point(312, 272);
            this.v_label.Name = "v_label";
            this.v_label.Size = new System.Drawing.Size(18, 16);
            this.v_label.TabIndex = 27;
            this.v_label.Text = "V";
            this.v_label.Click += new System.EventHandler(this.label_Click);
            // 
            // u_label
            // 
            this.u_label.AutoSize = true;
            this.u_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.u_label.Location = new System.Drawing.Point(279, 272);
            this.u_label.Name = "u_label";
            this.u_label.Size = new System.Drawing.Size(19, 16);
            this.u_label.TabIndex = 26;
            this.u_label.Text = "U";
            this.u_label.Click += new System.EventHandler(this.label_Click);
            // 
            // z_label
            // 
            this.z_label.AutoSize = true;
            this.z_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.z_label.Location = new System.Drawing.Point(349, 299);
            this.z_label.Name = "z_label";
            this.z_label.Size = new System.Drawing.Size(17, 16);
            this.z_label.TabIndex = 31;
            this.z_label.Text = "Z";
            this.z_label.Click += new System.EventHandler(this.label_Click);
            // 
            // give_up_button
            // 
            this.give_up_button.Location = new System.Drawing.Point(12, 12);
            this.give_up_button.Name = "give_up_button";
            this.give_up_button.Size = new System.Drawing.Size(75, 23);
            this.give_up_button.TabIndex = 32;
            this.give_up_button.Text = "Give Up!";
            this.give_up_button.UseVisualStyleBackColor = true;
            this.give_up_button.Click += new System.EventHandler(this.give_up_button_Click);
            // 
            // word_choosen
            // 
            this.word_choosen.AutoSize = true;
            this.word_choosen.Location = new System.Drawing.Point(314, 17);
            this.word_choosen.Name = "word_choosen";
            this.word_choosen.Size = new System.Drawing.Size(78, 13);
            this.word_choosen.TabIndex = 33;
            this.word_choosen.Text = "Choosen Word";
            this.word_choosen.Visible = false;
            // 
            // output_word
            // 
            this.output_word.AutoSize = true;
            this.output_word.Location = new System.Drawing.Point(314, 30);
            this.output_word.Name = "output_word";
            this.output_word.Size = new System.Drawing.Size(68, 13);
            this.output_word.TabIndex = 34;
            this.output_word.Text = "Output Word";
            this.output_word.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(426, 389);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // new_game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 459);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.output_word);
            this.Controls.Add(this.word_choosen);
            this.Controls.Add(this.give_up_button);
            this.Controls.Add(this.z_label);
            this.Controls.Add(this.y_label);
            this.Controls.Add(this.x_label);
            this.Controls.Add(this.w_label);
            this.Controls.Add(this.v_label);
            this.Controls.Add(this.u_label);
            this.Controls.Add(this.t_label);
            this.Controls.Add(this.s_label);
            this.Controls.Add(this.r_label);
            this.Controls.Add(this.q_label);
            this.Controls.Add(this.p_label);
            this.Controls.Add(this.o_label);
            this.Controls.Add(this.n_label);
            this.Controls.Add(this.m_label);
            this.Controls.Add(this.l_label);
            this.Controls.Add(this.k_label);
            this.Controls.Add(this.j_label);
            this.Controls.Add(this.i_label);
            this.Controls.Add(this.h_label);
            this.Controls.Add(this.g_label);
            this.Controls.Add(this.f_label);
            this.Controls.Add(this.e_label);
            this.Controls.Add(this.d_label);
            this.Controls.Add(this.c_label);
            this.Controls.Add(this.b_label);
            this.Controls.Add(this.a_label);
            this.Controls.Add(this.wrong_guesses);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chances_left);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.word_name);
            this.Controls.Add(this.pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "new_game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label word_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label chances_left;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label wrong_guesses;
        private System.Windows.Forms.Label a_label;
        private System.Windows.Forms.Label b_label;
        private System.Windows.Forms.Label c_label;
        private System.Windows.Forms.Label d_label;
        private System.Windows.Forms.Label e_label;
        private System.Windows.Forms.Label j_label;
        private System.Windows.Forms.Label i_label;
        private System.Windows.Forms.Label h_label;
        private System.Windows.Forms.Label g_label;
        private System.Windows.Forms.Label f_label;
        private System.Windows.Forms.Label t_label;
        private System.Windows.Forms.Label s_label;
        private System.Windows.Forms.Label r_label;
        private System.Windows.Forms.Label q_label;
        private System.Windows.Forms.Label p_label;
        private System.Windows.Forms.Label o_label;
        private System.Windows.Forms.Label n_label;
        private System.Windows.Forms.Label m_label;
        private System.Windows.Forms.Label l_label;
        private System.Windows.Forms.Label k_label;
        private System.Windows.Forms.Label y_label;
        private System.Windows.Forms.Label x_label;
        private System.Windows.Forms.Label w_label;
        private System.Windows.Forms.Label v_label;
        private System.Windows.Forms.Label u_label;
        private System.Windows.Forms.Label z_label;
        private System.Windows.Forms.Button give_up_button;
        private System.Windows.Forms.Label word_choosen;
        private System.Windows.Forms.Label output_word;
        private System.Windows.Forms.Label label1;
    }
}

