
namespace ciclo1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtAnonascimento = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbFeminino = new System.Windows.Forms.RadioButton();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbPalmeiras = new System.Windows.Forms.RadioButton();
            this.rdbSantos = new System.Windows.Forms.RadioButton();
            this.rdbSaopaulo = new System.Windows.Forms.RadioButton();
            this.rdbCorinthians = new System.Windows.Forms.RadioButton();
            this.chkCursandofaculdade = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbHumanas = new System.Windows.Forms.RadioButton();
            this.rdbExatas = new System.Windows.Forms.RadioButton();
            this.rdbTecnologica = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(39, 33);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(40, 15);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(39, 51);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(212, 23);
            this.txtNome.TabIndex = 1;
            // 
            // txtAnonascimento
            // 
            this.txtAnonascimento.Location = new System.Drawing.Point(257, 51);
            this.txtAnonascimento.Name = "txtAnonascimento";
            this.txtAnonascimento.Size = new System.Drawing.Size(100, 23);
            this.txtAnonascimento.TabIndex = 2;
            this.txtAnonascimento.TextChanged += new System.EventHandler(this.txtAnonascimento_TextChanged);
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(363, 51);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 23);
            this.txtSalario.TabIndex = 3;
            this.txtSalario.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ano Nascimento";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(363, 33);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(42, 15);
            this.lblSalario.TabIndex = 5;
            this.lblSalario.Text = "Salário";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbFeminino);
            this.groupBox1.Controls.Add(this.rdbMasculino);
            this.groupBox1.Location = new System.Drawing.Point(39, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 124);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // rdbFeminino
            // 
            this.rdbFeminino.AutoSize = true;
            this.rdbFeminino.Location = new System.Drawing.Point(49, 73);
            this.rdbFeminino.Name = "rdbFeminino";
            this.rdbFeminino.Size = new System.Drawing.Size(75, 19);
            this.rdbFeminino.TabIndex = 9;
            this.rdbFeminino.TabStop = true;
            this.rdbFeminino.Text = "Feminino";
            this.rdbFeminino.UseVisualStyleBackColor = true;
            this.rdbFeminino.CheckedChanged += new System.EventHandler(this.rdbFeminino_CheckedChanged);
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Location = new System.Drawing.Point(49, 47);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(80, 19);
            this.rdbMasculino.TabIndex = 8;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            this.rdbMasculino.CheckedChanged += new System.EventHandler(this.rdbMasculino_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbPalmeiras);
            this.groupBox2.Controls.Add(this.rdbSantos);
            this.groupBox2.Controls.Add(this.rdbSaopaulo);
            this.groupBox2.Controls.Add(this.rdbCorinthians);
            this.groupBox2.Location = new System.Drawing.Point(257, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 124);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Time que Simpatiza";
            // 
            // rdbPalmeiras
            // 
            this.rdbPalmeiras.AutoSize = true;
            this.rdbPalmeiras.Location = new System.Drawing.Point(26, 99);
            this.rdbPalmeiras.Name = "rdbPalmeiras";
            this.rdbPalmeiras.Size = new System.Drawing.Size(76, 19);
            this.rdbPalmeiras.TabIndex = 3;
            this.rdbPalmeiras.TabStop = true;
            this.rdbPalmeiras.Text = "Palmeiras";
            this.rdbPalmeiras.UseVisualStyleBackColor = true;
            // 
            // rdbSantos
            // 
            this.rdbSantos.AutoSize = true;
            this.rdbSantos.Location = new System.Drawing.Point(26, 73);
            this.rdbSantos.Name = "rdbSantos";
            this.rdbSantos.Size = new System.Drawing.Size(60, 19);
            this.rdbSantos.TabIndex = 2;
            this.rdbSantos.TabStop = true;
            this.rdbSantos.Text = "Santos";
            this.rdbSantos.UseVisualStyleBackColor = true;
            this.rdbSantos.CheckedChanged += new System.EventHandler(this.rdbSantos_CheckedChanged);
            // 
            // rdbSaopaulo
            // 
            this.rdbSaopaulo.AutoSize = true;
            this.rdbSaopaulo.Location = new System.Drawing.Point(26, 47);
            this.rdbSaopaulo.Name = "rdbSaopaulo";
            this.rdbSaopaulo.Size = new System.Drawing.Size(77, 19);
            this.rdbSaopaulo.TabIndex = 1;
            this.rdbSaopaulo.TabStop = true;
            this.rdbSaopaulo.Text = "São Paulo";
            this.rdbSaopaulo.UseVisualStyleBackColor = true;
            this.rdbSaopaulo.CheckedChanged += new System.EventHandler(this.rdbSaopaulo_CheckedChanged);
            // 
            // rdbCorinthians
            // 
            this.rdbCorinthians.AutoSize = true;
            this.rdbCorinthians.Location = new System.Drawing.Point(26, 22);
            this.rdbCorinthians.Name = "rdbCorinthians";
            this.rdbCorinthians.Size = new System.Drawing.Size(86, 19);
            this.rdbCorinthians.TabIndex = 0;
            this.rdbCorinthians.TabStop = true;
            this.rdbCorinthians.Text = "Corinthians";
            this.rdbCorinthians.UseVisualStyleBackColor = true;
            this.rdbCorinthians.CheckedChanged += new System.EventHandler(this.rdbCorinthians_CheckedChanged);
            // 
            // chkCursandofaculdade
            // 
            this.chkCursandofaculdade.AutoSize = true;
            this.chkCursandofaculdade.Location = new System.Drawing.Point(39, 242);
            this.chkCursandofaculdade.Name = "chkCursandofaculdade";
            this.chkCursandofaculdade.Size = new System.Drawing.Size(134, 19);
            this.chkCursandofaculdade.TabIndex = 8;
            this.chkCursandofaculdade.Text = "Cursando Faculdade";
            this.chkCursandofaculdade.UseVisualStyleBackColor = true;
            this.chkCursandofaculdade.CheckedChanged += new System.EventHandler(this.chkCursandofaculdade_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbHumanas);
            this.groupBox3.Controls.Add(this.rdbExatas);
            this.groupBox3.Controls.Add(this.rdbTecnologica);
            this.groupBox3.Location = new System.Drawing.Point(247, 242);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(216, 100);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Área";
            this.groupBox3.Visible = false;
            // 
            // rdbHumanas
            // 
            this.rdbHumanas.AutoSize = true;
            this.rdbHumanas.Location = new System.Drawing.Point(36, 75);
            this.rdbHumanas.Name = "rdbHumanas";
            this.rdbHumanas.Size = new System.Drawing.Size(175, 19);
            this.rdbHumanas.TabIndex = 2;
            this.rdbHumanas.TabStop = true;
            this.rdbHumanas.Text = "Não Tecnológica - Humanas";
            this.rdbHumanas.UseVisualStyleBackColor = true;
            // 
            // rdbExatas
            // 
            this.rdbExatas.AutoSize = true;
            this.rdbExatas.Location = new System.Drawing.Point(36, 49);
            this.rdbExatas.Name = "rdbExatas";
            this.rdbExatas.Size = new System.Drawing.Size(157, 19);
            this.rdbExatas.TabIndex = 1;
            this.rdbExatas.TabStop = true;
            this.rdbExatas.Text = "Não Tecnológica - Exatas";
            this.rdbExatas.UseVisualStyleBackColor = true;
            // 
            // rdbTecnologica
            // 
            this.rdbTecnologica.AutoSize = true;
            this.rdbTecnologica.Location = new System.Drawing.Point(36, 23);
            this.rdbTecnologica.Name = "rdbTecnologica";
            this.rdbTecnologica.Size = new System.Drawing.Size(88, 19);
            this.rdbTecnologica.TabIndex = 0;
            this.rdbTecnologica.TabStop = true;
            this.rdbTecnologica.Text = "Tecnológica";
            this.rdbTecnologica.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCalcular.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcular.Image")));
            this.btnCalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalcular.Location = new System.Drawing.Point(60, 305);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(129, 87);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "  Calcular Valor   Bônus";
            this.btnCalcular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Valor Bônus";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.Location = new System.Drawing.Point(231, 371);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(100, 21);
            this.lblResultado.TabIndex = 12;
            this.lblResultado.Text = "R$ ???????,??";
            this.lblResultado.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 404);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.chkCursandofaculdade);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtAnonascimento);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Name = "Form1";
            this.Text = "Cálculo de bônus social";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtAnonascimento;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbFeminino;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbPalmeiras;
        private System.Windows.Forms.RadioButton rdbSantos;
        private System.Windows.Forms.RadioButton rdbSaopaulo;
        private System.Windows.Forms.RadioButton rdbCorinthians;
        private System.Windows.Forms.CheckBox chkCursandofaculdade;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdbHumanas;
        private System.Windows.Forms.RadioButton rdbExatas;
        private System.Windows.Forms.RadioButton rdbTecnologica;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResultado;
    }
}

