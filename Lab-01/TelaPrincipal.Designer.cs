﻿namespace Lab_01
{
    partial class TelaPrincipal
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
            this.lb_titulo = new System.Windows.Forms.Label();
            this.lb_nome = new System.Windows.Forms.Label();
            this.lb_curso = new System.Windows.Forms.Label();
            this.lb_mensagem = new System.Windows.Forms.Label();
            this.tBox_nome = new System.Windows.Forms.TextBox();
            this.cBox_curso = new System.Windows.Forms.ComboBox();
            this.btn_exibir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_titulo.Location = new System.Drawing.Point(99, 9);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(250, 23);
            this.lb_titulo.TabIndex = 0;
            this.lb_titulo.Text = "Laboratório Teste 01";
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_nome.Location = new System.Drawing.Point(53, 57);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(57, 19);
            this.lb_nome.TabIndex = 1;
            this.lb_nome.Text = "Nome:";
            // 
            // lb_curso
            // 
            this.lb_curso.AutoSize = true;
            this.lb_curso.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_curso.Location = new System.Drawing.Point(53, 86);
            this.lb_curso.Name = "lb_curso";
            this.lb_curso.Size = new System.Drawing.Size(64, 19);
            this.lb_curso.TabIndex = 2;
            this.lb_curso.Text = "Curso:";
            // 
            // lb_mensagem
            // 
            this.lb_mensagem.BackColor = System.Drawing.Color.LightSeaGreen;
            this.lb_mensagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_mensagem.Location = new System.Drawing.Point(86, 163);
            this.lb_mensagem.Name = "lb_mensagem";
            this.lb_mensagem.Size = new System.Drawing.Size(285, 41);
            this.lb_mensagem.TabIndex = 3;
            this.lb_mensagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tBox_nome
            // 
            this.tBox_nome.Location = new System.Drawing.Point(116, 53);
            this.tBox_nome.Name = "tBox_nome";
            this.tBox_nome.Size = new System.Drawing.Size(233, 23);
            this.tBox_nome.TabIndex = 4;
            // 
            // cBox_curso
            // 
            this.cBox_curso.FormattingEnabled = true;
            this.cBox_curso.Items.AddRange(new object[] {
            "C#",
            "Lógica de programação",
            "PHP",
            "JavaScript",
            "Java",
            "C++",
            "C",
            "Python",
            "GO"});
            this.cBox_curso.Location = new System.Drawing.Point(116, 82);
            this.cBox_curso.Name = "cBox_curso";
            this.cBox_curso.Size = new System.Drawing.Size(233, 23);
            this.cBox_curso.TabIndex = 5;
            // 
            // btn_exibir
            // 
            this.btn_exibir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_exibir.Location = new System.Drawing.Point(86, 129);
            this.btn_exibir.Name = "btn_exibir";
            this.btn_exibir.Size = new System.Drawing.Size(285, 22);
            this.btn_exibir.TabIndex = 6;
            this.btn_exibir.Text = "Exibir";
            this.btn_exibir.UseVisualStyleBackColor = true;
            this.btn_exibir.Click += new System.EventHandler(this.btn_exibir_Click);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 226);
            this.Controls.Add(this.btn_exibir);
            this.Controls.Add(this.cBox_curso);
            this.Controls.Add(this.tBox_nome);
            this.Controls.Add(this.lb_mensagem);
            this.Controls.Add(this.lb_curso);
            this.Controls.Add(this.lb_nome);
            this.Controls.Add(this.lb_titulo);
            this.MaximizeBox = false;
            this.Name = "TelaPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laboratório 01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lb_titulo;
        private Label lb_nome;
        private Label lb_curso;
        private Label lb_mensagem;
        private TextBox tBox_nome;
        private ComboBox cBox_curso;
        private Button btn_exibir;
    }
}