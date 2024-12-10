namespace WindowsFormsApp4
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
            this.listBoxServicos = new System.Windows.Forms.ListBox();
            this.rctVetor = new System.Windows.Forms.TextBox();
            this.ButtonCadastro = new System.Windows.Forms.Button();
            this.groupServiços = new System.Windows.Forms.GroupBox();
            this.Box_maquiagem = new System.Windows.Forms.CheckBox();
            this.Box_unhaMao = new System.Windows.Forms.CheckBox();
            this.Box_massagem = new System.Windows.Forms.CheckBox();
            this.Box_quiropraxistas = new System.Windows.Forms.CheckBox();
            this.Box_cera = new System.Windows.Forms.CheckBox();
            this.Box_barbear = new System.Windows.Forms.CheckBox();
            this.Box_facial = new System.Windows.Forms.CheckBox();
            this.Box_tintura = new System.Windows.Forms.CheckBox();
            this.Box_unhaPe = new System.Windows.Forms.CheckBox();
            this.Box_cabelo = new System.Windows.Forms.CheckBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.groupRegistro = new System.Windows.Forms.GroupBox();
            this.Mtb_cep = new System.Windows.Forms.MaskedTextBox();
            this.Radio_sem = new System.Windows.Forms.RadioButton();
            this.Radio_feminino = new System.Windows.Forms.RadioButton();
            this.Radio_masculino = new System.Windows.Forms.RadioButton();
            this.txt_nascimento = new System.Windows.Forms.TextBox();
            this.mtb_sms = new System.Windows.Forms.MaskedTextBox();
            this.Mtb_celular = new System.Windows.Forms.MaskedTextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.Mtb_cpf = new System.Windows.Forms.MaskedTextBox();
            this.Mtb_rg = new System.Windows.Forms.MaskedTextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.lblSms = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblRg = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.groupServiços.SuspendLayout();
            this.groupRegistro.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxServicos
            // 
            this.listBoxServicos.FormattingEnabled = true;
            this.listBoxServicos.Location = new System.Drawing.Point(348, 34);
            this.listBoxServicos.Name = "listBoxServicos";
            this.listBoxServicos.Size = new System.Drawing.Size(231, 264);
            this.listBoxServicos.TabIndex = 39;
            // 
            // rctVetor
            // 
            this.rctVetor.Location = new System.Drawing.Point(605, 34);
            this.rctVetor.Multiline = true;
            this.rctVetor.Name = "rctVetor";
            this.rctVetor.Size = new System.Drawing.Size(171, 108);
            this.rctVetor.TabIndex = 38;
            // 
            // ButtonCadastro
            // 
            this.ButtonCadastro.Location = new System.Drawing.Point(243, 471);
            this.ButtonCadastro.Name = "ButtonCadastro";
            this.ButtonCadastro.Size = new System.Drawing.Size(75, 23);
            this.ButtonCadastro.TabIndex = 37;
            this.ButtonCadastro.Text = "Cadastrar";
            this.ButtonCadastro.UseVisualStyleBackColor = true;
            this.ButtonCadastro.Click += new System.EventHandler(this.ButtonCadastro_Click);
            // 
            // groupServiços
            // 
            this.groupServiços.Controls.Add(this.Box_maquiagem);
            this.groupServiços.Controls.Add(this.Box_unhaMao);
            this.groupServiços.Controls.Add(this.Box_massagem);
            this.groupServiços.Controls.Add(this.Box_quiropraxistas);
            this.groupServiços.Controls.Add(this.Box_cera);
            this.groupServiços.Controls.Add(this.Box_barbear);
            this.groupServiços.Controls.Add(this.Box_facial);
            this.groupServiços.Controls.Add(this.Box_tintura);
            this.groupServiços.Controls.Add(this.Box_unhaPe);
            this.groupServiços.Controls.Add(this.Box_cabelo);
            this.groupServiços.Location = new System.Drawing.Point(46, 312);
            this.groupServiços.Name = "groupServiços";
            this.groupServiços.Size = new System.Drawing.Size(496, 140);
            this.groupServiços.TabIndex = 36;
            this.groupServiços.TabStop = false;
            this.groupServiços.Text = "Serviços";
            // 
            // Box_maquiagem
            // 
            this.Box_maquiagem.AutoSize = true;
            this.Box_maquiagem.Location = new System.Drawing.Point(311, 80);
            this.Box_maquiagem.Name = "Box_maquiagem";
            this.Box_maquiagem.Size = new System.Drawing.Size(81, 17);
            this.Box_maquiagem.TabIndex = 21;
            this.Box_maquiagem.Text = "Maquiagem";
            this.Box_maquiagem.UseVisualStyleBackColor = true;
            this.Box_maquiagem.CheckedChanged += new System.EventHandler(this.Box_maquiagem_CheckedChanged);
            // 
            // Box_unhaMao
            // 
            this.Box_unhaMao.AutoSize = true;
            this.Box_unhaMao.Location = new System.Drawing.Point(9, 79);
            this.Box_unhaMao.Name = "Box_unhaMao";
            this.Box_unhaMao.Size = new System.Drawing.Size(90, 17);
            this.Box_unhaMao.TabIndex = 20;
            this.Box_unhaMao.Text = "Unha da mão";
            this.Box_unhaMao.UseVisualStyleBackColor = true;
            this.Box_unhaMao.CheckedChanged += new System.EventHandler(this.Box_unhaMao_CheckedChanged);
            // 
            // Box_massagem
            // 
            this.Box_massagem.AutoSize = true;
            this.Box_massagem.Location = new System.Drawing.Point(197, 102);
            this.Box_massagem.Name = "Box_massagem";
            this.Box_massagem.Size = new System.Drawing.Size(77, 17);
            this.Box_massagem.TabIndex = 19;
            this.Box_massagem.Text = "Massagem";
            this.Box_massagem.UseVisualStyleBackColor = true;
            this.Box_massagem.CheckedChanged += new System.EventHandler(this.Box_massagem_CheckedChanged);
            // 
            // Box_quiropraxistas
            // 
            this.Box_quiropraxistas.AutoSize = true;
            this.Box_quiropraxistas.Location = new System.Drawing.Point(197, 79);
            this.Box_quiropraxistas.Name = "Box_quiropraxistas";
            this.Box_quiropraxistas.Size = new System.Drawing.Size(92, 17);
            this.Box_quiropraxistas.TabIndex = 18;
            this.Box_quiropraxistas.Text = "Quiropraxistas";
            this.Box_quiropraxistas.UseVisualStyleBackColor = true;
            this.Box_quiropraxistas.CheckedChanged += new System.EventHandler(this.Box_quiropraxistas_CheckedChanged);
            // 
            // Box_cera
            // 
            this.Box_cera.AutoSize = true;
            this.Box_cera.Location = new System.Drawing.Point(197, 56);
            this.Box_cera.Name = "Box_cera";
            this.Box_cera.Size = new System.Drawing.Size(48, 17);
            this.Box_cera.TabIndex = 17;
            this.Box_cera.Text = "Cera";
            this.Box_cera.UseVisualStyleBackColor = true;
            this.Box_cera.CheckedChanged += new System.EventHandler(this.Box_cera_CheckedChanged);
            // 
            // Box_barbear
            // 
            this.Box_barbear.AutoSize = true;
            this.Box_barbear.Location = new System.Drawing.Point(197, 33);
            this.Box_barbear.Name = "Box_barbear";
            this.Box_barbear.Size = new System.Drawing.Size(63, 17);
            this.Box_barbear.TabIndex = 16;
            this.Box_barbear.Text = "Barbear";
            this.Box_barbear.UseVisualStyleBackColor = true;
            this.Box_barbear.CheckedChanged += new System.EventHandler(this.Box_barbear_CheckedChanged);
            // 
            // Box_facial
            // 
            this.Box_facial.AutoSize = true;
            this.Box_facial.Location = new System.Drawing.Point(9, 103);
            this.Box_facial.Name = "Box_facial";
            this.Box_facial.Size = new System.Drawing.Size(54, 17);
            this.Box_facial.TabIndex = 15;
            this.Box_facial.Text = "Facial";
            this.Box_facial.UseVisualStyleBackColor = true;
            this.Box_facial.CheckedChanged += new System.EventHandler(this.Box_facial_CheckedChanged);
            // 
            // Box_tintura
            // 
            this.Box_tintura.AutoSize = true;
            this.Box_tintura.Location = new System.Drawing.Point(311, 56);
            this.Box_tintura.Name = "Box_tintura";
            this.Box_tintura.Size = new System.Drawing.Size(59, 17);
            this.Box_tintura.TabIndex = 14;
            this.Box_tintura.Text = "Tintura";
            this.Box_tintura.UseVisualStyleBackColor = true;
            this.Box_tintura.CheckedChanged += new System.EventHandler(this.Box_tintura_CheckedChanged);
            // 
            // Box_unhaPe
            // 
            this.Box_unhaPe.AutoSize = true;
            this.Box_unhaPe.Location = new System.Drawing.Point(9, 56);
            this.Box_unhaPe.Name = "Box_unhaPe";
            this.Box_unhaPe.Size = new System.Drawing.Size(82, 17);
            this.Box_unhaPe.TabIndex = 13;
            this.Box_unhaPe.Text = "Unha do pé";
            this.Box_unhaPe.UseVisualStyleBackColor = true;
            this.Box_unhaPe.CheckedChanged += new System.EventHandler(this.Box_unhaPe_CheckedChanged);
            // 
            // Box_cabelo
            // 
            this.Box_cabelo.AutoSize = true;
            this.Box_cabelo.Location = new System.Drawing.Point(9, 33);
            this.Box_cabelo.Name = "Box_cabelo";
            this.Box_cabelo.Size = new System.Drawing.Size(101, 17);
            this.Box_cabelo.TabIndex = 12;
            this.Box_cabelo.Text = "Corte de cabelo";
            this.Box_cabelo.UseVisualStyleBackColor = true;
            this.Box_cabelo.CheckedChanged += new System.EventHandler(this.Box_cabelo_CheckedChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(154, -44);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(348, 28);
            this.lblTitulo.TabIndex = 35;
            this.lblTitulo.Text = "Cadastro de Cliente do Salão";
            // 
            // groupRegistro
            // 
            this.groupRegistro.Controls.Add(this.Mtb_cep);
            this.groupRegistro.Controls.Add(this.Radio_sem);
            this.groupRegistro.Controls.Add(this.Radio_feminino);
            this.groupRegistro.Controls.Add(this.Radio_masculino);
            this.groupRegistro.Controls.Add(this.txt_nascimento);
            this.groupRegistro.Controls.Add(this.mtb_sms);
            this.groupRegistro.Controls.Add(this.Mtb_celular);
            this.groupRegistro.Controls.Add(this.txt_email);
            this.groupRegistro.Controls.Add(this.Mtb_cpf);
            this.groupRegistro.Controls.Add(this.Mtb_rg);
            this.groupRegistro.Controls.Add(this.txt_nome);
            this.groupRegistro.Controls.Add(this.lblSexo);
            this.groupRegistro.Controls.Add(this.lblNascimento);
            this.groupRegistro.Controls.Add(this.lblSms);
            this.groupRegistro.Controls.Add(this.lblCelular);
            this.groupRegistro.Controls.Add(this.lblEmail);
            this.groupRegistro.Controls.Add(this.lblCep);
            this.groupRegistro.Controls.Add(this.lblCpf);
            this.groupRegistro.Controls.Add(this.lblRg);
            this.groupRegistro.Controls.Add(this.lblNome);
            this.groupRegistro.Location = new System.Drawing.Point(24, 27);
            this.groupRegistro.Name = "groupRegistro";
            this.groupRegistro.Size = new System.Drawing.Size(307, 268);
            this.groupRegistro.TabIndex = 34;
            this.groupRegistro.TabStop = false;
            this.groupRegistro.Text = "Registro";
            // 
            // Mtb_cep
            // 
            this.Mtb_cep.Location = new System.Drawing.Point(80, 95);
            this.Mtb_cep.Mask = "00000000";
            this.Mtb_cep.Name = "Mtb_cep";
            this.Mtb_cep.Size = new System.Drawing.Size(100, 20);
            this.Mtb_cep.TabIndex = 39;
            // 
            // Radio_sem
            // 
            this.Radio_sem.AutoSize = true;
            this.Radio_sem.Location = new System.Drawing.Point(208, 229);
            this.Radio_sem.Name = "Radio_sem";
            this.Radio_sem.Size = new System.Drawing.Size(93, 17);
            this.Radio_sem.TabIndex = 38;
            this.Radio_sem.TabStop = true;
            this.Radio_sem.Text = "Não identificar";
            this.Radio_sem.UseVisualStyleBackColor = true;
            // 
            // Radio_feminino
            // 
            this.Radio_feminino.AutoSize = true;
            this.Radio_feminino.Location = new System.Drawing.Point(135, 229);
            this.Radio_feminino.Name = "Radio_feminino";
            this.Radio_feminino.Size = new System.Drawing.Size(67, 17);
            this.Radio_feminino.TabIndex = 37;
            this.Radio_feminino.TabStop = true;
            this.Radio_feminino.Text = "Feminino";
            this.Radio_feminino.UseVisualStyleBackColor = true;
            // 
            // Radio_masculino
            // 
            this.Radio_masculino.AutoSize = true;
            this.Radio_masculino.Location = new System.Drawing.Point(56, 229);
            this.Radio_masculino.Name = "Radio_masculino";
            this.Radio_masculino.Size = new System.Drawing.Size(73, 17);
            this.Radio_masculino.TabIndex = 36;
            this.Radio_masculino.TabStop = true;
            this.Radio_masculino.Text = "Masculino";
            this.Radio_masculino.UseVisualStyleBackColor = true;
            // 
            // txt_nascimento
            // 
            this.txt_nascimento.Location = new System.Drawing.Point(80, 199);
            this.txt_nascimento.Name = "txt_nascimento";
            this.txt_nascimento.Size = new System.Drawing.Size(100, 20);
            this.txt_nascimento.TabIndex = 35;
            // 
            // mtb_sms
            // 
            this.mtb_sms.Location = new System.Drawing.Point(80, 173);
            this.mtb_sms.Mask = "00000";
            this.mtb_sms.Name = "mtb_sms";
            this.mtb_sms.Size = new System.Drawing.Size(43, 20);
            this.mtb_sms.TabIndex = 34;
            this.mtb_sms.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Mtb_celular
            // 
            this.Mtb_celular.Location = new System.Drawing.Point(80, 147);
            this.Mtb_celular.Mask = "(00)00000-0000";
            this.Mtb_celular.Name = "Mtb_celular";
            this.Mtb_celular.Size = new System.Drawing.Size(100, 20);
            this.Mtb_celular.TabIndex = 31;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(80, 121);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(100, 20);
            this.txt_email.TabIndex = 33;
            // 
            // Mtb_cpf
            // 
            this.Mtb_cpf.Location = new System.Drawing.Point(80, 69);
            this.Mtb_cpf.Mask = "000.000.000/00";
            this.Mtb_cpf.Name = "Mtb_cpf";
            this.Mtb_cpf.Size = new System.Drawing.Size(100, 20);
            this.Mtb_cpf.TabIndex = 30;
            // 
            // Mtb_rg
            // 
            this.Mtb_rg.Location = new System.Drawing.Point(80, 43);
            this.Mtb_rg.Mask = "00.000.000-0";
            this.Mtb_rg.Name = "Mtb_rg";
            this.Mtb_rg.Size = new System.Drawing.Size(100, 20);
            this.Mtb_rg.TabIndex = 29;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(80, 17);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(177, 20);
            this.txt_nome.TabIndex = 28;
            this.txt_nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nome_KeyPress);
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(19, 229);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(31, 13);
            this.lblSexo.TabIndex = 26;
            this.lblSexo.Text = "Sexo";
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Location = new System.Drawing.Point(12, 202);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(63, 13);
            this.lblNascimento.TabIndex = 25;
            this.lblNascimento.Text = "Nascimento";
            // 
            // lblSms
            // 
            this.lblSms.AutoSize = true;
            this.lblSms.Location = new System.Drawing.Point(44, 176);
            this.lblSms.Name = "lblSms";
            this.lblSms.Size = new System.Drawing.Size(30, 13);
            this.lblSms.TabIndex = 21;
            this.lblSms.Text = "SMS";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(35, 150);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(39, 13);
            this.lblCelular.TabIndex = 24;
            this.lblCelular.Text = "Celular";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(38, 124);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(36, 13);
            this.lblEmail.TabIndex = 23;
            this.lblEmail.Text = "E-Mail";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(46, 98);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(28, 13);
            this.lblCep.TabIndex = 22;
            this.lblCep.Text = "CEP";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(47, 72);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(27, 13);
            this.lblCpf.TabIndex = 20;
            this.lblCpf.Text = "CPF";
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Location = new System.Drawing.Point(51, 43);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(23, 13);
            this.lblRg.TabIndex = 19;
            this.lblRg.Text = "RG";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(39, 20);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 18;
            this.lblNome.Text = "Nome";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 523);
            this.Controls.Add(this.listBoxServicos);
            this.Controls.Add(this.rctVetor);
            this.Controls.Add(this.ButtonCadastro);
            this.Controls.Add(this.groupServiços);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.groupRegistro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupServiços.ResumeLayout(false);
            this.groupServiços.PerformLayout();
            this.groupRegistro.ResumeLayout(false);
            this.groupRegistro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxServicos;
        private System.Windows.Forms.TextBox rctVetor;
        private System.Windows.Forms.Button ButtonCadastro;
        private System.Windows.Forms.GroupBox groupServiços;
        private System.Windows.Forms.CheckBox Box_maquiagem;
        private System.Windows.Forms.CheckBox Box_unhaMao;
        private System.Windows.Forms.CheckBox Box_massagem;
        private System.Windows.Forms.CheckBox Box_quiropraxistas;
        private System.Windows.Forms.CheckBox Box_cera;
        private System.Windows.Forms.CheckBox Box_barbear;
        private System.Windows.Forms.CheckBox Box_facial;
        private System.Windows.Forms.CheckBox Box_tintura;
        private System.Windows.Forms.CheckBox Box_unhaPe;
        private System.Windows.Forms.CheckBox Box_cabelo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox groupRegistro;
        private System.Windows.Forms.MaskedTextBox Mtb_cep;
        private System.Windows.Forms.RadioButton Radio_sem;
        private System.Windows.Forms.RadioButton Radio_feminino;
        private System.Windows.Forms.RadioButton Radio_masculino;
        private System.Windows.Forms.TextBox txt_nascimento;
        private System.Windows.Forms.MaskedTextBox mtb_sms;
        private System.Windows.Forms.MaskedTextBox Mtb_celular;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.MaskedTextBox Mtb_cpf;
        private System.Windows.Forms.MaskedTextBox Mtb_rg;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.Label lblSms;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.Label lblNome;
    }
}

