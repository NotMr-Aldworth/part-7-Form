namespace part_7_Form
{
    partial class Lists
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
            this.lblNmbr = new System.Windows.Forms.Label();
            this.lblHeroes = new System.Windows.Forms.Label();
            this.btnNewNumbers = new System.Windows.Forms.Button();
            this.btnSortNumbers = new System.Windows.Forms.Button();
            this.btnNewHeroes = new System.Windows.Forms.Button();
            this.btnSortHeroes = new System.Windows.Forms.Button();
            this.lstNumbers = new System.Windows.Forms.ListBox();
            this.lstHeroes = new System.Windows.Forms.ListBox();
            this.lblRemove = new System.Windows.Forms.Label();
            this.lblHeroName = new System.Windows.Forms.Label();
            this.btnRemoveNumber = new System.Windows.Forms.Button();
            this.btnRemoveAllNumbers = new System.Windows.Forms.Button();
            this.txtAddHeroes = new System.Windows.Forms.TextBox();
            this.btnAddHeroes = new System.Windows.Forms.Button();
            this.lblHeroRemove = new System.Windows.Forms.Label();
            this.txtRemoveHero = new System.Windows.Forms.TextBox();
            this.btnRemoveHero = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnDec = new System.Windows.Forms.Button();
            this.heroesToUpper = new System.Windows.Forms.Button();
            this.heroesToLower = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNmbr
            // 
            this.lblNmbr.AutoSize = true;
            this.lblNmbr.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNmbr.Location = new System.Drawing.Point(149, 9);
            this.lblNmbr.Name = "lblNmbr";
            this.lblNmbr.Size = new System.Drawing.Size(85, 22);
            this.lblNmbr.TabIndex = 0;
            this.lblNmbr.Text = "Numbers";
            // 
            // lblHeroes
            // 
            this.lblHeroes.AutoSize = true;
            this.lblHeroes.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeroes.Location = new System.Drawing.Point(488, 9);
            this.lblHeroes.Name = "lblHeroes";
            this.lblHeroes.Size = new System.Drawing.Size(67, 22);
            this.lblHeroes.TabIndex = 1;
            this.lblHeroes.Text = "Heroes";
            // 
            // btnNewNumbers
            // 
            this.btnNewNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewNumbers.Location = new System.Drawing.Point(142, 35);
            this.btnNewNumbers.Name = "btnNewNumbers";
            this.btnNewNumbers.Size = new System.Drawing.Size(92, 31);
            this.btnNewNumbers.TabIndex = 2;
            this.btnNewNumbers.Text = "New List";
            this.btnNewNumbers.UseVisualStyleBackColor = true;
            this.btnNewNumbers.Click += new System.EventHandler(this.btnNewNumbers_Click);
            // 
            // btnSortNumbers
            // 
            this.btnSortNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortNumbers.Location = new System.Drawing.Point(93, 72);
            this.btnSortNumbers.Name = "btnSortNumbers";
            this.btnSortNumbers.Size = new System.Drawing.Size(92, 43);
            this.btnSortNumbers.TabIndex = 3;
            this.btnSortNumbers.Text = "Ascending Sort";
            this.btnSortNumbers.UseVisualStyleBackColor = true;
            this.btnSortNumbers.Click += new System.EventHandler(this.btnSortNumbers_Click);
            // 
            // btnNewHeroes
            // 
            this.btnNewHeroes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewHeroes.Location = new System.Drawing.Point(425, 45);
            this.btnNewHeroes.Name = "btnNewHeroes";
            this.btnNewHeroes.Size = new System.Drawing.Size(92, 31);
            this.btnNewHeroes.TabIndex = 4;
            this.btnNewHeroes.Text = "New List";
            this.btnNewHeroes.UseVisualStyleBackColor = true;
            this.btnNewHeroes.Click += new System.EventHandler(this.btnNewHeroes_Click);
            // 
            // btnSortHeroes
            // 
            this.btnSortHeroes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortHeroes.Location = new System.Drawing.Point(523, 45);
            this.btnSortHeroes.Name = "btnSortHeroes";
            this.btnSortHeroes.Size = new System.Drawing.Size(92, 31);
            this.btnSortHeroes.TabIndex = 5;
            this.btnSortHeroes.Text = "Sort";
            this.btnSortHeroes.UseVisualStyleBackColor = true;
            this.btnSortHeroes.Click += new System.EventHandler(this.btnSortHeroes_Click);
            // 
            // lstNumbers
            // 
            this.lstNumbers.FormattingEnabled = true;
            this.lstNumbers.Location = new System.Drawing.Point(93, 121);
            this.lstNumbers.Name = "lstNumbers";
            this.lstNumbers.Size = new System.Drawing.Size(187, 134);
            this.lstNumbers.TabIndex = 6;
            this.lstNumbers.SelectedIndexChanged += new System.EventHandler(this.lstNumbers_SelectedIndexChanged);
            // 
            // lstHeroes
            // 
            this.lstHeroes.FormattingEnabled = true;
            this.lstHeroes.Location = new System.Drawing.Point(425, 121);
            this.lstHeroes.Name = "lstHeroes";
            this.lstHeroes.Size = new System.Drawing.Size(187, 134);
            this.lstHeroes.TabIndex = 7;
            this.lstHeroes.SelectedIndexChanged += new System.EventHandler(this.lstHeroes_SelectedIndexChanged);
            // 
            // lblRemove
            // 
            this.lblRemove.AutoSize = true;
            this.lblRemove.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemove.Location = new System.Drawing.Point(73, 258);
            this.lblRemove.Name = "lblRemove";
            this.lblRemove.Size = new System.Drawing.Size(229, 22);
            this.lblRemove.TabIndex = 8;
            this.lblRemove.Text = "Select a number to remove";
            // 
            // lblHeroName
            // 
            this.lblHeroName.AutoSize = true;
            this.lblHeroName.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeroName.Location = new System.Drawing.Point(415, 258);
            this.lblHeroName.Name = "lblHeroName";
            this.lblHeroName.Size = new System.Drawing.Size(216, 22);
            this.lblHeroName.TabIndex = 9;
            this.lblHeroName.Text = "Enter a hero name to add";
            // 
            // btnRemoveNumber
            // 
            this.btnRemoveNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveNumber.Location = new System.Drawing.Point(88, 283);
            this.btnRemoveNumber.Name = "btnRemoveNumber";
            this.btnRemoveNumber.Size = new System.Drawing.Size(92, 31);
            this.btnRemoveNumber.TabIndex = 10;
            this.btnRemoveNumber.Text = "Remove";
            this.btnRemoveNumber.UseVisualStyleBackColor = true;
            this.btnRemoveNumber.Click += new System.EventHandler(this.btnRemoveNumber_Click);
            // 
            // btnRemoveAllNumbers
            // 
            this.btnRemoveAllNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveAllNumbers.Location = new System.Drawing.Point(186, 283);
            this.btnRemoveAllNumbers.Name = "btnRemoveAllNumbers";
            this.btnRemoveAllNumbers.Size = new System.Drawing.Size(92, 31);
            this.btnRemoveAllNumbers.TabIndex = 11;
            this.btnRemoveAllNumbers.Text = "Remove All";
            this.btnRemoveAllNumbers.UseVisualStyleBackColor = true;
            this.btnRemoveAllNumbers.Click += new System.EventHandler(this.btnRemoveAllNumbers_Click);
            // 
            // txtAddHeroes
            // 
            this.txtAddHeroes.Location = new System.Drawing.Point(425, 289);
            this.txtAddHeroes.Name = "txtAddHeroes";
            this.txtAddHeroes.Size = new System.Drawing.Size(100, 20);
            this.txtAddHeroes.TabIndex = 12;
            // 
            // btnAddHeroes
            // 
            this.btnAddHeroes.Location = new System.Drawing.Point(537, 289);
            this.btnAddHeroes.Name = "btnAddHeroes";
            this.btnAddHeroes.Size = new System.Drawing.Size(75, 23);
            this.btnAddHeroes.TabIndex = 13;
            this.btnAddHeroes.Text = "Add";
            this.btnAddHeroes.UseVisualStyleBackColor = true;
            this.btnAddHeroes.Click += new System.EventHandler(this.btnAddHeroes_Click);
            // 
            // lblHeroRemove
            // 
            this.lblHeroRemove.AutoSize = true;
            this.lblHeroRemove.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeroRemove.Location = new System.Drawing.Point(400, 320);
            this.lblHeroRemove.Name = "lblHeroRemove";
            this.lblHeroRemove.Size = new System.Drawing.Size(246, 22);
            this.lblHeroRemove.TabIndex = 14;
            this.lblHeroRemove.Text = "Enter a hero name to remove";
            // 
            // txtRemoveHero
            // 
            this.txtRemoveHero.Location = new System.Drawing.Point(425, 349);
            this.txtRemoveHero.Name = "txtRemoveHero";
            this.txtRemoveHero.Size = new System.Drawing.Size(100, 20);
            this.txtRemoveHero.TabIndex = 15;
            // 
            // btnRemoveHero
            // 
            this.btnRemoveHero.Location = new System.Drawing.Point(537, 347);
            this.btnRemoveHero.Name = "btnRemoveHero";
            this.btnRemoveHero.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveHero.TabIndex = 16;
            this.btnRemoveHero.Text = "Remove";
            this.btnRemoveHero.UseVisualStyleBackColor = true;
            this.btnRemoveHero.Click += new System.EventHandler(this.btnRemoveHero_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(58, 354);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(60, 20);
            this.lblStatus.TabIndex = 17;
            this.lblStatus.Text = "Status:";
            // 
            // btnDec
            // 
            this.btnDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDec.Location = new System.Drawing.Point(188, 72);
            this.btnDec.Name = "btnDec";
            this.btnDec.Size = new System.Drawing.Size(92, 43);
            this.btnDec.TabIndex = 18;
            this.btnDec.Text = "Descending Sort";
            this.btnDec.UseVisualStyleBackColor = true;
            this.btnDec.Click += new System.EventHandler(this.btnDec_Click);
            // 
            // heroesToUpper
            // 
            this.heroesToUpper.Location = new System.Drawing.Point(523, 82);
            this.heroesToUpper.Name = "heroesToUpper";
            this.heroesToUpper.Size = new System.Drawing.Size(92, 23);
            this.heroesToUpper.TabIndex = 19;
            this.heroesToUpper.Text = "Uppercase";
            this.heroesToUpper.UseVisualStyleBackColor = true;
            this.heroesToUpper.Click += new System.EventHandler(this.button1_Click);
            // 
            // heroesToLower
            // 
            this.heroesToLower.Location = new System.Drawing.Point(425, 82);
            this.heroesToLower.Name = "heroesToLower";
            this.heroesToLower.Size = new System.Drawing.Size(92, 23);
            this.heroesToLower.TabIndex = 20;
            this.heroesToLower.Text = "Lowercase";
            this.heroesToLower.UseVisualStyleBackColor = true;
            this.heroesToLower.Click += new System.EventHandler(this.heroesToLower_Click);
            // 
            // Lists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.heroesToLower);
            this.Controls.Add(this.heroesToUpper);
            this.Controls.Add(this.btnDec);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnRemoveHero);
            this.Controls.Add(this.txtRemoveHero);
            this.Controls.Add(this.lblHeroRemove);
            this.Controls.Add(this.btnAddHeroes);
            this.Controls.Add(this.txtAddHeroes);
            this.Controls.Add(this.btnRemoveAllNumbers);
            this.Controls.Add(this.btnRemoveNumber);
            this.Controls.Add(this.lblHeroName);
            this.Controls.Add(this.lblRemove);
            this.Controls.Add(this.lstHeroes);
            this.Controls.Add(this.lstNumbers);
            this.Controls.Add(this.btnSortHeroes);
            this.Controls.Add(this.btnNewHeroes);
            this.Controls.Add(this.btnSortNumbers);
            this.Controls.Add(this.btnNewNumbers);
            this.Controls.Add(this.lblHeroes);
            this.Controls.Add(this.lblNmbr);
            this.Name = "Lists";
            this.Text = "Lists";
            this.Load += new System.EventHandler(this.Lists_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNmbr;
        private System.Windows.Forms.Label lblHeroes;
        private System.Windows.Forms.Button btnNewNumbers;
        private System.Windows.Forms.Button btnSortNumbers;
        private System.Windows.Forms.Button btnNewHeroes;
        private System.Windows.Forms.Button btnSortHeroes;
        private System.Windows.Forms.ListBox lstNumbers;
        private System.Windows.Forms.ListBox lstHeroes;
        private System.Windows.Forms.Label lblRemove;
        private System.Windows.Forms.Label lblHeroName;
        private System.Windows.Forms.Button btnRemoveNumber;
        private System.Windows.Forms.Button btnRemoveAllNumbers;
        private System.Windows.Forms.TextBox txtAddHeroes;
        private System.Windows.Forms.Button btnAddHeroes;
        private System.Windows.Forms.Label lblHeroRemove;
        private System.Windows.Forms.TextBox txtRemoveHero;
        private System.Windows.Forms.Button btnRemoveHero;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnDec;
        private System.Windows.Forms.Button heroesToUpper;
        private System.Windows.Forms.Button heroesToLower;
    }
}

