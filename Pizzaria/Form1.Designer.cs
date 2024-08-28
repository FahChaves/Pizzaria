namespace Pizzaria
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCalcular = new Button();
            cbCebola = new CheckBox();
            label1 = new Label();
            rbNormal = new RadioButton();
            groupBox1 = new GroupBox();
            rbfamilia = new RadioButton();
            rbGrande = new RadioButton();
            gbTipo = new GroupBox();
            rbRetirada = new RadioButton();
            rbEntrega = new RadioButton();
            cbBordaRecheada = new CheckBox();
            cbMolho = new CheckBox();
            cbQueijo = new CheckBox();
            linkLabel1 = new LinkLabel();
            texDistancia = new TextBox();
            texTotal = new TextBox();
            label2 = new Label();
            lbKm = new Label();
            label5 = new Label();
            lbDistancia = new Label();
            groupBox1.SuspendLayout();
            gbTipo.SuspendLayout();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(24, 390);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // cbCebola
            // 
            cbCebola.AutoSize = true;
            cbCebola.Location = new Point(33, 183);
            cbCebola.Name = "cbCebola";
            cbCebola.Size = new Size(63, 19);
            cbCebola.TabIndex = 1;
            cbCebola.Text = "Cebola";
            cbCebola.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(155, 26);
            label1.Margin = new Padding(7, 0, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(70, 21);
            label1.TabIndex = 2;
            label1.Text = "Pizzaria";
            // 
            // rbNormal
            // 
            rbNormal.AutoSize = true;
            rbNormal.Checked = true;
            rbNormal.Location = new Point(11, 22);
            rbNormal.Name = "rbNormal";
            rbNormal.Size = new Size(65, 19);
            rbNormal.TabIndex = 3;
            rbNormal.TabStop = true;
            rbNormal.Text = "Normal";
            rbNormal.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbfamilia);
            groupBox1.Controls.Add(rbGrande);
            groupBox1.Controls.Add(rbNormal);
            groupBox1.Location = new Point(22, 83);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(367, 50);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Escolha o tamanho";
            // 
            // rbfamilia
            // 
            rbfamilia.AutoSize = true;
            rbfamilia.Location = new Point(253, 22);
            rbfamilia.Name = "rbfamilia";
            rbfamilia.Size = new Size(63, 19);
            rbfamilia.TabIndex = 5;
            rbfamilia.Text = "Família";
            rbfamilia.UseVisualStyleBackColor = true;
            // 
            // rbGrande
            // 
            rbGrande.AutoSize = true;
            rbGrande.Location = new Point(133, 22);
            rbGrande.Name = "rbGrande";
            rbGrande.Size = new Size(63, 19);
            rbGrande.TabIndex = 4;
            rbGrande.Text = "Grande";
            rbGrande.UseVisualStyleBackColor = true;
            // 
            // gbTipo
            // 
            gbTipo.Controls.Add(rbRetirada);
            gbTipo.Controls.Add(rbEntrega);
            gbTipo.Location = new Point(22, 264);
            gbTipo.Name = "gbTipo";
            gbTipo.Size = new Size(367, 50);
            gbTipo.TabIndex = 5;
            gbTipo.TabStop = false;
            gbTipo.Text = "Tipo";
            // 
            // rbRetirada
            // 
            rbRetirada.AutoSize = true;
            rbRetirada.Checked = true;
            rbRetirada.Location = new Point(225, 22);
            rbRetirada.Name = "rbRetirada";
            rbRetirada.Size = new Size(68, 19);
            rbRetirada.TabIndex = 7;
            rbRetirada.TabStop = true;
            rbRetirada.Text = "Retirada";
            rbRetirada.UseVisualStyleBackColor = true;
            // 
            // rbEntrega
            // 
            rbEntrega.AutoSize = true;
            rbEntrega.Location = new Point(25, 22);
            rbEntrega.Name = "rbEntrega";
            rbEntrega.Size = new Size(65, 19);
            rbEntrega.TabIndex = 6;
            rbEntrega.Text = "Entrega";
            rbEntrega.UseVisualStyleBackColor = true;
            rbEntrega.CheckedChanged += rbEntrega_CheckedChanged;
            // 
            // cbBordaRecheada
            // 
            cbBordaRecheada.AutoSize = true;
            cbBordaRecheada.Location = new Point(33, 223);
            cbBordaRecheada.Name = "cbBordaRecheada";
            cbBordaRecheada.Size = new Size(111, 19);
            cbBordaRecheada.TabIndex = 6;
            cbBordaRecheada.Text = "Borda Recheada";
            cbBordaRecheada.UseVisualStyleBackColor = true;
            // 
            // cbMolho
            // 
            cbMolho.AutoSize = true;
            cbMolho.Location = new Point(155, 223);
            cbMolho.Name = "cbMolho";
            cbMolho.Size = new Size(72, 19);
            cbMolho.TabIndex = 8;
            cbMolho.Text = "+ Molho";
            cbMolho.UseVisualStyleBackColor = true;
            // 
            // cbQueijo
            // 
            cbQueijo.AutoSize = true;
            cbQueijo.Location = new Point(155, 183);
            cbQueijo.Name = "cbQueijo";
            cbQueijo.Size = new Size(72, 19);
            cbQueijo.TabIndex = 7;
            cbQueijo.Text = "+ Queijo";
            cbQueijo.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(221, 398);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 15);
            linkLabel1.TabIndex = 9;
            // 
            // texDistancia
            // 
            texDistancia.Location = new Point(58, 344);
            texDistancia.Name = "texDistancia";
            texDistancia.Size = new Size(100, 23);
            texDistancia.TabIndex = 10;
            texDistancia.Visible = false;
            // 
            // texTotal
            // 
            texTotal.Location = new Point(262, 408);
            texTotal.Name = "texTotal";
            texTotal.Size = new Size(100, 23);
            texTotal.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 149);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 12;
            label2.Text = "Adicionais";
            // 
            // lbKm
            // 
            lbKm.AutoSize = true;
            lbKm.Location = new Point(178, 350);
            lbKm.Name = "lbKm";
            lbKm.Size = new Size(30, 15);
            lbKm.TabIndex = 14;
            lbKm.Text = "Kms";
            lbKm.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(199, 408);
            label5.Name = "label5";
            label5.Size = new Size(43, 17);
            label5.TabIndex = 15;
            label5.Text = "Total: ";
            // 
            // lbDistancia
            // 
            lbDistancia.AutoSize = true;
            lbDistancia.Location = new Point(33, 326);
            lbDistancia.Name = "lbDistancia";
            lbDistancia.Size = new Size(55, 15);
            lbDistancia.TabIndex = 16;
            lbDistancia.Text = "Distancia";
            lbDistancia.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(414, 462);
            Controls.Add(lbDistancia);
            Controls.Add(texDistancia);
            Controls.Add(lbKm);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(texTotal);
            Controls.Add(linkLabel1);
            Controls.Add(cbMolho);
            Controls.Add(cbQueijo);
            Controls.Add(cbBordaRecheada);
            Controls.Add(gbTipo);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(cbCebola);
            Controls.Add(btnCalcular);
            Name = "Form1";
            Text = "Pizzaria";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gbTipo.ResumeLayout(false);
            gbTipo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private CheckBox cbCebola;
        private Label label1;
        private RadioButton rbNormal;
        private GroupBox groupBox1;
        private GroupBox gbTipo;
        private RadioButton rbfamilia;
        private RadioButton rbGrande;
        private RadioButton rbRetirada;
        private RadioButton rbEntrega;
        private CheckBox cbBordaRecheada;
        private CheckBox cbMolho;
        private CheckBox cbQueijo;
        private LinkLabel linkLabel1;
        private TextBox texDistancia;
        private TextBox texTotal;
        private Label label2;
        private Label lbKm;
        private Label label5;
        private Label lbDistancia;
    }
}
