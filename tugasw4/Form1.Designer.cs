namespace tugasw4
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
            this.labelNama = new System.Windows.Forms.Label();
            this.labelAlamat = new System.Windows.Forms.Label();
            this.labelTelp = new System.Windows.Forms.Label();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.textBoxAlamat = new System.Windows.Forms.TextBox();
            this.textBoxTelp = new System.Windows.Forms.TextBox();
            this.buttonLihat = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.buttonKembali = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Location = new System.Drawing.Point(89, 62);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(80, 25);
            this.labelNama.TabIndex = 0;
            this.labelNama.Text = "Nama :";
            // 
            // labelAlamat
            // 
            this.labelAlamat.AutoSize = true;
            this.labelAlamat.Location = new System.Drawing.Point(89, 126);
            this.labelAlamat.Name = "labelAlamat";
            this.labelAlamat.Size = new System.Drawing.Size(90, 25);
            this.labelAlamat.TabIndex = 0;
            this.labelAlamat.Text = "Alamat :";
            // 
            // labelTelp
            // 
            this.labelTelp.AutoSize = true;
            this.labelTelp.Location = new System.Drawing.Point(89, 189);
            this.labelTelp.Name = "labelTelp";
            this.labelTelp.Size = new System.Drawing.Size(66, 25);
            this.labelTelp.TabIndex = 0;
            this.labelTelp.Text = "Telp :";
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(195, 62);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(281, 31);
            this.textBoxNama.TabIndex = 1;
            // 
            // textBoxAlamat
            // 
            this.textBoxAlamat.Location = new System.Drawing.Point(195, 123);
            this.textBoxAlamat.Name = "textBoxAlamat";
            this.textBoxAlamat.Size = new System.Drawing.Size(381, 31);
            this.textBoxAlamat.TabIndex = 2;
            // 
            // textBoxTelp
            // 
            this.textBoxTelp.Location = new System.Drawing.Point(195, 186);
            this.textBoxTelp.Name = "textBoxTelp";
            this.textBoxTelp.Size = new System.Drawing.Size(225, 31);
            this.textBoxTelp.TabIndex = 3;
            // 
            // buttonLihat
            // 
            this.buttonLihat.Location = new System.Drawing.Point(405, 271);
            this.buttonLihat.Name = "buttonLihat";
            this.buttonLihat.Size = new System.Drawing.Size(171, 44);
            this.buttonLihat.TabIndex = 2;
            this.buttonLihat.Text = "Lihat Data";
            this.buttonLihat.UseVisualStyleBackColor = true;
            this.buttonLihat.Click += new System.EventHandler(this.buttonLihat_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.Location = new System.Drawing.Point(94, 271);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(171, 44);
            this.buttonSimpan.TabIndex = 2;
            this.buttonSimpan.Text = "Simpan";
            this.buttonSimpan.UseVisualStyleBackColor = true;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // buttonKembali
            // 
            this.buttonKembali.Location = new System.Drawing.Point(94, 271);
            this.buttonKembali.Name = "buttonKembali";
            this.buttonKembali.Size = new System.Drawing.Size(171, 44);
            this.buttonKembali.TabIndex = 3;
            this.buttonKembali.Text = "Kembali";
            this.buttonKembali.UseVisualStyleBackColor = true;
            this.buttonKembali.Click += new System.EventHandler(this.buttonKembali_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Location = new System.Drawing.Point(305, 271);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(171, 44);
            this.buttonPrev.TabIndex = 3;
            this.buttonPrev.Text = "Prev Data";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(512, 271);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(171, 44);
            this.buttonNext.TabIndex = 3;
            this.buttonNext.Text = "Next Data";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonKembali);
            this.Controls.Add(this.buttonLihat);
            this.Controls.Add(this.buttonSimpan);
            this.Controls.Add(this.textBoxTelp);
            this.Controls.Add(this.textBoxAlamat);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.labelTelp);
            this.Controls.Add(this.labelAlamat);
            this.Controls.Add(this.labelNama);
            this.Name = "Form1";
            this.Text = "Form Penambahan Data";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Label labelAlamat;
        private System.Windows.Forms.Label labelTelp;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.TextBox textBoxAlamat;
        private System.Windows.Forms.TextBox textBoxTelp;
        private System.Windows.Forms.Button buttonLihat;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonKembali;
        private System.Windows.Forms.Button buttonSimpan;
    }
}

