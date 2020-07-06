namespace Cryptographie
{
    partial class FEncryptage
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbEncrypt = new System.Windows.Forms.TextBox();
            this.tbTexte = new System.Windows.Forms.TextBox();
            this.bCryptPerso = new System.Windows.Forms.Button();
            this.bCryptC = new System.Windows.Forms.Button();
            this.lEncrypt = new System.Windows.Forms.Label();
            this.lValue = new System.Windows.Forms.Label();
            this.lClé = new System.Windows.Forms.Label();
            this.lNomClé = new System.Windows.Forms.Label();
            this.bClé = new System.Windows.Forms.Button();
            this.tbDecrypt = new System.Windows.Forms.TextBox();
            this.lDecrypt = new System.Windows.Forms.Label();
            this.bDecryptC = new System.Windows.Forms.Button();
            this.bDecryptPerso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbEncrypt
            // 
            this.tbEncrypt.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEncrypt.Location = new System.Drawing.Point(197, 365);
            this.tbEncrypt.Multiline = true;
            this.tbEncrypt.Name = "tbEncrypt";
            this.tbEncrypt.Size = new System.Drawing.Size(664, 109);
            this.tbEncrypt.TabIndex = 1;
            // 
            // tbTexte
            // 
            this.tbTexte.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTexte.Location = new System.Drawing.Point(197, 51);
            this.tbTexte.Multiline = true;
            this.tbTexte.Name = "tbTexte";
            this.tbTexte.Size = new System.Drawing.Size(664, 153);
            this.tbTexte.TabIndex = 2;
            // 
            // bCryptPerso
            // 
            this.bCryptPerso.BackColor = System.Drawing.Color.Red;
            this.bCryptPerso.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCryptPerso.Location = new System.Drawing.Point(910, 376);
            this.bCryptPerso.Name = "bCryptPerso";
            this.bCryptPerso.Size = new System.Drawing.Size(187, 110);
            this.bCryptPerso.TabIndex = 3;
            this.bCryptPerso.Text = "Encryptage";
            this.bCryptPerso.UseVisualStyleBackColor = false;
            this.bCryptPerso.Click += new System.EventHandler(this.bCryptPerso_Click);
            // 
            // bCryptC
            // 
            this.bCryptC.BackColor = System.Drawing.SystemColors.Highlight;
            this.bCryptC.Font = new System.Drawing.Font("Calibri", 14F);
            this.bCryptC.Location = new System.Drawing.Point(910, 53);
            this.bCryptC.Name = "bCryptC";
            this.bCryptC.Size = new System.Drawing.Size(187, 110);
            this.bCryptC.TabIndex = 4;
            this.bCryptC.Text = "Encryptage C#";
            this.bCryptC.UseVisualStyleBackColor = false;
            this.bCryptC.Click += new System.EventHandler(this.bCryptC_Click);
            // 
            // lEncrypt
            // 
            this.lEncrypt.AutoSize = true;
            this.lEncrypt.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEncrypt.Location = new System.Drawing.Point(12, 398);
            this.lEncrypt.Name = "lEncrypt";
            this.lEncrypt.Size = new System.Drawing.Size(149, 39);
            this.lEncrypt.TabIndex = 7;
            this.lEncrypt.Text = "Encrypté :";
            // 
            // lValue
            // 
            this.lValue.AutoSize = true;
            this.lValue.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lValue.Location = new System.Drawing.Point(48, 124);
            this.lValue.Name = "lValue";
            this.lValue.Size = new System.Drawing.Size(104, 39);
            this.lValue.TabIndex = 8;
            this.lValue.Text = "Texte :";
            this.lValue.Click += new System.EventHandler(this.lValue_Click);
            // 
            // lClé
            // 
            this.lClé.AutoSize = true;
            this.lClé.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lClé.Location = new System.Drawing.Point(346, 268);
            this.lClé.Name = "lClé";
            this.lClé.Size = new System.Drawing.Size(0, 35);
            this.lClé.TabIndex = 10;
            // 
            // lNomClé
            // 
            this.lNomClé.AutoSize = true;
            this.lNomClé.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNomClé.Location = new System.Drawing.Point(236, 264);
            this.lNomClé.Name = "lNomClé";
            this.lNomClé.Size = new System.Drawing.Size(74, 39);
            this.lNomClé.TabIndex = 11;
            this.lNomClé.Text = "Clé :";
            // 
            // bClé
            // 
            this.bClé.BackColor = System.Drawing.Color.Red;
            this.bClé.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClé.Location = new System.Drawing.Point(554, 230);
            this.bClé.Name = "bClé";
            this.bClé.Size = new System.Drawing.Size(187, 110);
            this.bClé.TabIndex = 12;
            this.bClé.Text = "Générer une clé";
            this.bClé.UseVisualStyleBackColor = false;
            this.bClé.Click += new System.EventHandler(this.bClé_Click);
            // 
            // tbDecrypt
            // 
            this.tbDecrypt.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDecrypt.Location = new System.Drawing.Point(197, 526);
            this.tbDecrypt.Multiline = true;
            this.tbDecrypt.Name = "tbDecrypt";
            this.tbDecrypt.Size = new System.Drawing.Size(664, 109);
            this.tbDecrypt.TabIndex = 13;
            // 
            // lDecrypt
            // 
            this.lDecrypt.AutoSize = true;
            this.lDecrypt.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDecrypt.Location = new System.Drawing.Point(12, 566);
            this.lDecrypt.Name = "lDecrypt";
            this.lDecrypt.Size = new System.Drawing.Size(152, 39);
            this.lDecrypt.TabIndex = 14;
            this.lDecrypt.Text = "Décrypté :";
            this.lDecrypt.Click += new System.EventHandler(this.label1_Click);
            // 
            // bDecryptC
            // 
            this.bDecryptC.BackColor = System.Drawing.SystemColors.Highlight;
            this.bDecryptC.Font = new System.Drawing.Font("Calibri", 14F);
            this.bDecryptC.Location = new System.Drawing.Point(910, 208);
            this.bDecryptC.Name = "bDecryptC";
            this.bDecryptC.Size = new System.Drawing.Size(187, 110);
            this.bDecryptC.TabIndex = 15;
            this.bDecryptC.Text = "Decryptage C#";
            this.bDecryptC.UseVisualStyleBackColor = false;
            this.bDecryptC.Click += new System.EventHandler(this.bDecryptC_Click);
            // 
            // bDecryptPerso
            // 
            this.bDecryptPerso.BackColor = System.Drawing.Color.Red;
            this.bDecryptPerso.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDecryptPerso.Location = new System.Drawing.Point(910, 531);
            this.bDecryptPerso.Name = "bDecryptPerso";
            this.bDecryptPerso.Size = new System.Drawing.Size(187, 110);
            this.bDecryptPerso.TabIndex = 16;
            this.bDecryptPerso.Text = "Decryptage";
            this.bDecryptPerso.UseVisualStyleBackColor = false;
            this.bDecryptPerso.Click += new System.EventHandler(this.bDecryptPerso_Click);
            // 
            // FEncryptage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1140, 679);
            this.Controls.Add(this.bDecryptPerso);
            this.Controls.Add(this.bDecryptC);
            this.Controls.Add(this.lDecrypt);
            this.Controls.Add(this.tbDecrypt);
            this.Controls.Add(this.bClé);
            this.Controls.Add(this.lNomClé);
            this.Controls.Add(this.lClé);
            this.Controls.Add(this.lValue);
            this.Controls.Add(this.lEncrypt);
            this.Controls.Add(this.bCryptC);
            this.Controls.Add(this.bCryptPerso);
            this.Controls.Add(this.tbTexte);
            this.Controls.Add(this.tbEncrypt);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FEncryptage";
            this.Text = "Application d\'encryptage";
            this.Load += new System.EventHandler(this.FEncryptage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbEncrypt;
        private System.Windows.Forms.TextBox tbTexte;
        private System.Windows.Forms.Button bCryptPerso;
        private System.Windows.Forms.Button bCryptC;
        private System.Windows.Forms.Label lEncrypt;
        private System.Windows.Forms.Label lValue;
        private System.Windows.Forms.Label lClé;
        private System.Windows.Forms.Label lNomClé;
        private System.Windows.Forms.Button bClé;
        private System.Windows.Forms.TextBox tbDecrypt;
        private System.Windows.Forms.Label lDecrypt;
        private System.Windows.Forms.Button bDecryptC;
        private System.Windows.Forms.Button bDecryptPerso;
    }
}

