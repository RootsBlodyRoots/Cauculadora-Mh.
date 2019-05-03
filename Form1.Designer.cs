using System;

namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Btnsinn2 = new System.Windows.Forms.Button();
            this.Btncos = new System.Windows.Forms.Button();
            this.Btntangente = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblmemoria = new System.Windows.Forms.Button();
            this.BtnMC = new System.Windows.Forms.Button();
            this.BtnMR = new System.Windows.Forms.Button();
            this.Btnsin = new System.Windows.Forms.Button();
            this.BtnMS = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.BtnC = new System.Windows.Forms.Button();
            this.Btntan = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.labelmemoria = new System.Windows.Forms.Button();
            this.BtnCE = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.BtnRaiz = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.button35 = new System.Windows.Forms.Button();
            this.button36 = new System.Windows.Forms.Button();
            this.button37 = new System.Windows.Forms.Button();
            this.button38 = new System.Windows.Forms.Button();
            this.button39 = new System.Windows.Forms.Button();
            this.button40 = new System.Windows.Forms.Button();
            this.button41 = new System.Windows.Forms.Button();
            this.button42 = new System.Windows.Forms.Button();
            this.button43 = new System.Windows.Forms.Button();
            this.button44 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // Btnsinn2
            // 
            this.Btnsinn2.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnsinn2.Location = new System.Drawing.Point(26, 129);
            this.Btnsinn2.Name = "Btnsinn2";
            this.Btnsinn2.Size = new System.Drawing.Size(50, 50);
            this.Btnsinn2.TabIndex = 0;
            this.Btnsinn2.Text = "sinh";
            this.Btnsinn2.UseVisualStyleBackColor = true;
            this.Btnsinn2.BackColorChanged += new System.EventHandler(this.Form1_Load);
            this.Btnsinn2.Click += new System.EventHandler(this.Btnsinn_Click);
            // 
            // Btncos
            // 
            this.Btncos.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btncos.Location = new System.Drawing.Point(93, 129);
            this.Btncos.Name = "Btncos";
            this.Btncos.Size = new System.Drawing.Size(50, 50);
            this.Btncos.TabIndex = 1;
            this.Btncos.Tag = "";
            this.Btncos.Text = "cosh";
            this.Btncos.UseVisualStyleBackColor = true;
            this.Btncos.BackColorChanged += new System.EventHandler(this.Form1_Load);
            this.Btncos.Click += new System.EventHandler(this.buttoncosh_click);
            // 
            // Btntangente
            // 
            this.Btntangente.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btntangente.Location = new System.Drawing.Point(159, 129);
            this.Btntangente.Name = "Btntangente";
            this.Btntangente.Size = new System.Drawing.Size(50, 50);
            this.Btntangente.TabIndex = 2;
            this.Btntangente.Text = "tanh";
            this.Btntangente.UseVisualStyleBackColor = true;
            this.Btntangente.BackColorChanged += new System.EventHandler(this.Form1_Load);
            this.Btntangente.Click += new System.EventHandler(this.buttontanh_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 41);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(519, 68);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblmemoria
            // 
            this.lblmemoria.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmemoria.Location = new System.Drawing.Point(429, 129);
            this.lblmemoria.Name = "lblmemoria";
            this.lblmemoria.Size = new System.Drawing.Size(50, 50);
            this.lblmemoria.TabIndex = 4;
            this.lblmemoria.Text = "M+";
            this.lblmemoria.UseVisualStyleBackColor = true;
            this.lblmemoria.Click += new System.EventHandler(this.buttonMmais_Click);
            // 
            // BtnMC
            // 
            this.BtnMC.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMC.Location = new System.Drawing.Point(225, 129);
            this.BtnMC.Name = "BtnMC";
            this.BtnMC.Size = new System.Drawing.Size(50, 50);
            this.BtnMC.TabIndex = 5;
            this.BtnMC.Text = "MC";
            this.BtnMC.UseVisualStyleBackColor = true;
            this.BtnMC.BackColorChanged += new System.EventHandler(this.Form1_Load);
            this.BtnMC.Click += new System.EventHandler(this.buttonMC_Click);
            // 
            // BtnMR
            // 
            this.BtnMR.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMR.Location = new System.Drawing.Point(289, 129);
            this.BtnMR.Name = "BtnMR";
            this.BtnMR.Size = new System.Drawing.Size(50, 50);
            this.BtnMR.TabIndex = 6;
            this.BtnMR.Text = "MR";
            this.BtnMR.UseVisualStyleBackColor = true;
            this.BtnMR.Click += new System.EventHandler(this.BtnMR_Click);
            // 
            // Btnsin
            // 
            this.Btnsin.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnsin.Location = new System.Drawing.Point(26, 196);
            this.Btnsin.Name = "Btnsin";
            this.Btnsin.Size = new System.Drawing.Size(50, 50);
            this.Btnsin.TabIndex = 7;
            this.Btnsin.Text = "sin";
            this.Btnsin.UseVisualStyleBackColor = true;
            this.Btnsin.BackColorChanged += new System.EventHandler(this.Form1_Load);
            this.Btnsin.Click += new System.EventHandler(this.buttonsin_Click);
            // 
            // BtnMS
            // 
            this.BtnMS.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMS.Location = new System.Drawing.Point(358, 129);
            this.BtnMS.Name = "BtnMS";
            this.BtnMS.Size = new System.Drawing.Size(50, 50);
            this.BtnMS.TabIndex = 8;
            this.BtnMS.Text = "MS";
            this.BtnMS.UseVisualStyleBackColor = true;
            this.BtnMS.Click += new System.EventHandler(this.BtnMS_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(93, 196);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(50, 50);
            this.button9.TabIndex = 9;
            this.button9.Text = "cos";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.BackColorChanged += new System.EventHandler(this.Form1_Load);
            this.button9.Click += new System.EventHandler(this.btncos_click);
            // 
            // BtnC
            // 
            this.BtnC.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnC.ForeColor = System.Drawing.Color.Red;
            this.BtnC.Location = new System.Drawing.Point(358, 196);
            this.BtnC.Name = "BtnC";
            this.BtnC.Size = new System.Drawing.Size(50, 50);
            this.BtnC.TabIndex = 10;
            this.BtnC.Text = "C";
            this.BtnC.UseVisualStyleBackColor = true;
            // 
            // Btntan
            // 
            this.Btntan.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btntan.Location = new System.Drawing.Point(159, 196);
            this.Btntan.Name = "Btntan";
            this.Btntan.Size = new System.Drawing.Size(50, 50);
            this.Btntan.TabIndex = 11;
            this.Btntan.Text = "tan";
            this.Btntan.UseVisualStyleBackColor = true;
            this.Btntan.BackColorChanged += new System.EventHandler(this.Form1_Load);
            this.Btntan.Click += new System.EventHandler(this.btntan_click);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(225, 196);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(50, 50);
            this.button12.TabIndex = 12;
            this.button12.Text = "<-";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.BackColorChanged += new System.EventHandler(this.Form1_Load);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(429, 196);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(50, 50);
            this.button13.TabIndex = 13;
            this.button13.Text = "+-";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // labelmemoria
            // 
            this.labelmemoria.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmemoria.Location = new System.Drawing.Point(495, 129);
            this.labelmemoria.Name = "labelmemoria";
            this.labelmemoria.Size = new System.Drawing.Size(50, 50);
            this.labelmemoria.TabIndex = 14;
            this.labelmemoria.Text = "M-";
            this.labelmemoria.UseVisualStyleBackColor = true;
            this.labelmemoria.Click += new System.EventHandler(this.btnMmenos_click);
            this.labelmemoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tevv);
            // 
            // BtnCE
            // 
            this.BtnCE.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCE.ForeColor = System.Drawing.Color.OrangeRed;
            this.BtnCE.Location = new System.Drawing.Point(289, 196);
            this.BtnCE.Name = "BtnCE";
            this.BtnCE.Size = new System.Drawing.Size(50, 50);
            this.BtnCE.TabIndex = 15;
            this.BtnCE.Text = "CE";
            this.BtnCE.UseVisualStyleBackColor = true;
            this.BtnCE.Click += new System.EventHandler(this.buttonCE_Click);
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Location = new System.Drawing.Point(225, 257);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(50, 50);
            this.button16.TabIndex = 16;
            this.button16.Text = "7";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button7_Click);
            // 
            // button17
            // 
            this.button17.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.Location = new System.Drawing.Point(159, 259);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(50, 50);
            this.button17.TabIndex = 17;
            this.button17.Text = "x^y";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.BtnXelevY_Click);
            // 
            // BtnRaiz
            // 
            this.BtnRaiz.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRaiz.Location = new System.Drawing.Point(495, 196);
            this.BtnRaiz.Name = "BtnRaiz";
            this.BtnRaiz.Size = new System.Drawing.Size(50, 50);
            this.BtnRaiz.TabIndex = 18;
            this.BtnRaiz.Text = "Raiz";
            this.BtnRaiz.UseVisualStyleBackColor = true;
            this.BtnRaiz.Click += new System.EventHandler(this.btnRaiz_click);
            // 
            // button19
            // 
            this.button19.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.Location = new System.Drawing.Point(289, 257);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(50, 50);
            this.button19.TabIndex = 19;
            this.button19.Text = "8";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.btn8_click);
            // 
            // button21
            // 
            this.button21.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.Location = new System.Drawing.Point(93, 259);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(50, 50);
            this.button21.TabIndex = 21;
            this.button21.Text = "x^-1";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button22
            // 
            this.button22.Font = new System.Drawing.Font("Javanese Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button22.Location = new System.Drawing.Point(26, 258);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(50, 50);
            this.button22.TabIndex = 22;
            this.button22.Text = "pi(n)";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.btnPi_click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(358, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 26;
            this.button1.Text = "9";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn9_click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(26, 319);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 27;
            this.button2.Text = "e";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.Location = new System.Drawing.Point(429, 259);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(50, 50);
            this.button20.TabIndex = 28;
            this.button20.Text = "/";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.btnDivisao_click);
            // 
            // button23
            // 
            this.button23.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button23.Location = new System.Drawing.Point(93, 319);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(50, 50);
            this.button23.TabIndex = 29;
            this.button23.Text = "sin";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // button24
            // 
            this.button24.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button24.Location = new System.Drawing.Point(159, 319);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(50, 50);
            this.button24.TabIndex = 30;
            this.button24.Text = "x^3";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.buttonPow_Click);
            // 
            // button25
            // 
            this.button25.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button25.Location = new System.Drawing.Point(225, 319);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(50, 50);
            this.button25.TabIndex = 31;
            this.button25.Text = "4";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.button4_Click);
            // 
            // button26
            // 
            this.button26.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button26.Location = new System.Drawing.Point(289, 319);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(50, 50);
            this.button26.TabIndex = 32;
            this.button26.Text = "5";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.button5_Click);
            // 
            // button27
            // 
            this.button27.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button27.Location = new System.Drawing.Point(358, 319);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(50, 50);
            this.button27.TabIndex = 33;
            this.button27.Text = "6";
            this.button27.UseVisualStyleBackColor = true;
            this.button27.Click += new System.EventHandler(this.button6_click);
            // 
            // button28
            // 
            this.button28.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button28.Location = new System.Drawing.Point(495, 259);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(50, 50);
            this.button28.TabIndex = 34;
            this.button28.Text = "%";
            this.button28.UseVisualStyleBackColor = true;
            this.button28.Click += new System.EventHandler(this.buttonporcento_Click);
            // 
            // button29
            // 
            this.button29.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button29.Location = new System.Drawing.Point(429, 319);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(50, 50);
            this.button29.TabIndex = 35;
            this.button29.Text = "*";
            this.button29.UseVisualStyleBackColor = true;
            this.button29.Click += new System.EventHandler(this.btnVezes_click);
            // 
            // button30
            // 
            this.button30.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button30.Location = new System.Drawing.Point(495, 319);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(50, 50);
            this.button30.TabIndex = 36;
            this.button30.Text = "1/x";
            this.button30.UseVisualStyleBackColor = true;
            // 
            // Btn1
            // 
            this.Btn1.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1.Location = new System.Drawing.Point(225, 382);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(50, 50);
            this.Btn1.TabIndex = 37;
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button32
            // 
            this.button32.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button32.Location = new System.Drawing.Point(290, 382);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(50, 50);
            this.button32.TabIndex = 38;
            this.button32.Text = "2";
            this.button32.UseVisualStyleBackColor = true;
            this.button32.Click += new System.EventHandler(this.button2_Click);
            // 
            // button33
            // 
            this.button33.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button33.Location = new System.Drawing.Point(358, 382);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(50, 50);
            this.button33.TabIndex = 39;
            this.button33.Text = "3";
            this.button33.UseVisualStyleBackColor = true;
            this.button33.Click += new System.EventHandler(this.button3_Click);
            // 
            // button34
            // 
            this.button34.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button34.Location = new System.Drawing.Point(429, 382);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(50, 50);
            this.button34.TabIndex = 40;
            this.button34.Text = "+";
            this.button34.UseVisualStyleBackColor = true;
            this.button34.Click += new System.EventHandler(this.buttonMais_Click);
            // 
            // button35
            // 
            this.button35.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button35.Location = new System.Drawing.Point(495, 382);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(50, 106);
            this.button35.TabIndex = 41;
            this.button35.Text = "=";
            this.button35.UseVisualStyleBackColor = true;
            this.button35.Click += new System.EventHandler(this.btnIgual_click);
            // 
            // button36
            // 
            this.button36.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button36.Location = new System.Drawing.Point(429, 438);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(50, 50);
            this.button36.TabIndex = 42;
            this.button36.Text = "-";
            this.button36.UseVisualStyleBackColor = true;
            this.button36.Click += new System.EventHandler(this.btnMenos_click);
            // 
            // button37
            // 
            this.button37.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button37.Location = new System.Drawing.Point(358, 438);
            this.button37.Name = "button37";
            this.button37.Size = new System.Drawing.Size(50, 50);
            this.button37.TabIndex = 43;
            this.button37.Text = ".";
            this.button37.UseVisualStyleBackColor = true;
            this.button37.Click += new System.EventHandler(this.BtnPonto_Click);
            // 
            // button38
            // 
            this.button38.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button38.Location = new System.Drawing.Point(225, 438);
            this.button38.Name = "button38";
            this.button38.Size = new System.Drawing.Size(114, 50);
            this.button38.TabIndex = 44;
            this.button38.Text = "0";
            this.button38.UseVisualStyleBackColor = true;
            this.button38.Click += new System.EventHandler(this.button38_Click);
            // 
            // button39
            // 
            this.button39.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button39.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button39.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button39.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button39.Location = new System.Drawing.Point(26, 382);
            this.button39.Name = "button39";
            this.button39.Size = new System.Drawing.Size(50, 50);
            this.button39.TabIndex = 45;
            this.button39.Text = "n!";
            this.button39.UseVisualStyleBackColor = true;
            this.button39.Click += new System.EventHandler(this.button39_Click);
            // 
            // button40
            // 
            this.button40.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button40.Location = new System.Drawing.Point(92, 382);
            this.button40.Name = "button40";
            this.button40.Size = new System.Drawing.Size(50, 50);
            this.button40.TabIndex = 46;
            this.button40.Text = "sin";
            this.button40.UseVisualStyleBackColor = true;
            // 
            // button41
            // 
            this.button41.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button41.Location = new System.Drawing.Point(159, 382);
            this.button41.Name = "button41";
            this.button41.Size = new System.Drawing.Size(50, 50);
            this.button41.TabIndex = 47;
            this.button41.Text = "x^2";
            this.button41.UseVisualStyleBackColor = true;
            this.button41.Click += new System.EventHandler(this.button41_Click);
            // 
            // button42
            // 
            this.button42.Font = new System.Drawing.Font("Javanese Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button42.Location = new System.Drawing.Point(26, 438);
            this.button42.Name = "button42";
            this.button42.Size = new System.Drawing.Size(50, 50);
            this.button42.TabIndex = 48;
            this.button42.Text = "10^x";
            this.button42.UseVisualStyleBackColor = true;
            this.button42.Click += new System.EventHandler(this.button10elevadoax_Click);
            // 
            // button43
            // 
            this.button43.Font = new System.Drawing.Font("Javanese Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button43.Location = new System.Drawing.Point(92, 438);
            this.button43.Name = "button43";
            this.button43.Size = new System.Drawing.Size(50, 50);
            this.button43.TabIndex = 49;
            this.button43.Text = "EXP";
            this.button43.UseVisualStyleBackColor = true;
            this.button43.Click += new System.EventHandler(this.btnEXP_click);
            // 
            // button44
            // 
            this.button44.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button44.Location = new System.Drawing.Point(159, 438);
            this.button44.Name = "button44";
            this.button44.Size = new System.Drawing.Size(50, 50);
            this.button44.TabIndex = 50;
            this.button44.Text = "log";
            this.button44.UseVisualStyleBackColor = true;
            this.button44.Click += new System.EventHandler(this.btnLog_click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(483, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(62, 23);
            this.button3.TabIndex = 51;
            this.button3.Text = "Next";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonNext_Click_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(566, 514);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button44);
            this.Controls.Add(this.button43);
            this.Controls.Add(this.button42);
            this.Controls.Add(this.button41);
            this.Controls.Add(this.button40);
            this.Controls.Add(this.button39);
            this.Controls.Add(this.button38);
            this.Controls.Add(this.button37);
            this.Controls.Add(this.button36);
            this.Controls.Add(this.button35);
            this.Controls.Add(this.button34);
            this.Controls.Add(this.button33);
            this.Controls.Add(this.button32);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.button30);
            this.Controls.Add(this.button29);
            this.Controls.Add(this.button28);
            this.Controls.Add(this.button27);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.BtnRaiz);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.BtnCE);
            this.Controls.Add(this.labelmemoria);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.Btntan);
            this.Controls.Add(this.BtnC);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.BtnMS);
            this.Controls.Add(this.Btnsin);
            this.Controls.Add(this.BtnMR);
            this.Controls.Add(this.BtnMC);
            this.Controls.Add(this.lblmemoria);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Btntangente);
            this.Controls.Add(this.Btncos);
            this.Controls.Add(this.Btnsinn2);
            this.MaximumSize = new System.Drawing.Size(582, 553);
            this.MinimumSize = new System.Drawing.Size(582, 553);
            this.Name = "Form1";
            this.Tag = "";
            this.Text = "Calculadora C.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btnsinn2;
        private System.Windows.Forms.Button Btncos;
        private System.Windows.Forms.Button Btntangente;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button lblmemoria;
        private System.Windows.Forms.Button BtnMC;
        private System.Windows.Forms.Button BtnMR;
        private System.Windows.Forms.Button Btnsin;
        private System.Windows.Forms.Button BtnMS;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button BtnC;
        private System.Windows.Forms.Button Btntan;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button labelmemoria;
        private System.Windows.Forms.Button BtnCE;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button BtnRaiz;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.Button button35;
        private System.Windows.Forms.Button button36;
        private System.Windows.Forms.Button button37;
        private System.Windows.Forms.Button button38;
        private System.Windows.Forms.Button button39;
        private System.Windows.Forms.Button button40;
        private System.Windows.Forms.Button button41;
        private System.Windows.Forms.Button button42;
        private System.Windows.Forms.Button button43;
        private System.Windows.Forms.Button button44;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

