
namespace ClientFormTema2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonGet = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Yellow;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(69, 89);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(828, 184);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(74, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(124, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nume si Prenume";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(320, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Adresa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(559, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(679, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Facebook";
            // 
            // buttonGet
            // 
            this.buttonGet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonGet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonGet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonGet.Location = new System.Drawing.Point(47, 299);
            this.buttonGet.Name = "buttonGet";
            this.buttonGet.Size = new System.Drawing.Size(211, 57);
            this.buttonGet.TabIndex = 6;
            this.buttonGet.Text = "Afiseaza lista";
            this.buttonGet.UseVisualStyleBackColor = false;
            this.buttonGet.Click += new System.EventHandler(this.buttonGet_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAdd.ForeColor = System.Drawing.Color.Black;
            this.buttonAdd.Location = new System.Drawing.Point(273, 297);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(217, 57);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Adauga in lista";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDelete.Location = new System.Drawing.Point(506, 299);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(218, 59);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.Text = "Sterge din lista";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonEdit.Location = new System.Drawing.Point(741, 299);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(227, 59);
            this.buttonEdit.TabIndex = 9;
            this.buttonEdit.Text = "Editeaza detalii participant";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(69, 431);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(64, 26);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(152, 431);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(197, 26);
            this.textBox2.TabIndex = 11;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(376, 431);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(266, 26);
            this.textBox3.TabIndex = 12;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(670, 431);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(179, 26);
            this.textBox4.TabIndex = 13;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(882, 431);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(182, 26);
            this.textBox5.TabIndex = 14;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Fuchsia;
            this.label6.Location = new System.Drawing.Point(65, 408);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Fuchsia;
            this.label7.Location = new System.Drawing.Point(148, 408);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Nume si Prenume";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Fuchsia;
            this.label8.Location = new System.Drawing.Point(372, 408);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Adresa";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Fuchsia;
            this.label9.Location = new System.Drawing.Point(666, 408);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Username";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Fuchsia;
            this.label10.Location = new System.Drawing.Point(878, 408);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Facebook";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1114, 542);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonGet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Gaming Contest";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonGet;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

