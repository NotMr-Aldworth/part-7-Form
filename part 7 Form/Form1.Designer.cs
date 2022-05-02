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
            this.lblHeros = new System.Windows.Forms.Label();
            this.btnNewNumbers = new System.Windows.Forms.Button();
            this.btnSortNumbers = new System.Windows.Forms.Button();
            this.btnNewHeros = new System.Windows.Forms.Button();
            this.btnSortHeroes = new System.Windows.Forms.Button();
            this.lstNumbers = new System.Windows.Forms.ListBox();
            this.lstHeroes = new System.Windows.Forms.ListBox();
            this.lblRemove = new System.Windows.Forms.Label();
            this.lblHeroName = new System.Windows.Forms.Label();
            this.btnRemoveNumber = new System.Windows.Forms.Button();
            this.btnRemoveAllNumbers = new System.Windows.Forms.Button();
            this.txtAddHeroes = new System.Windows.Forms.TextBox();
            this.btnAddHeroes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNmbr
            // 
            this.lblNmbr.AutoSize = true;
            this.lblNmbr.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNmbr.Location = new System.Drawing.Point(62, 44);
            this.lblNmbr.Name = "lblNmbr";
            this.lblNmbr.Size = new System.Drawing.Size(85, 22);
            this.lblNmbr.TabIndex = 0;
            this.lblNmbr.Text = "Numbers";
            // 
            // lblHeros
            // 
            this.lblHeros.AutoSize = true;
            this.lblHeros.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeros.Location = new System.Drawing.Point(555, 44);
            this.lblHeros.Name = "lblHeros";
            this.lblHeros.Size = new System.Drawing.Size(58, 22);
            this.lblHeros.TabIndex = 1;
            this.lblHeros.Text = "Heros";
            // 
            // btnNewNumbers
            // 
            this.btnNewNumbers.Location = new System.Drawing.Point(28, 69);
            this.btnNewNumbers.Name = "btnNewNumbers";
            this.btnNewNumbers.Size = new System.Drawing.Size(75, 23);
            this.btnNewNumbers.TabIndex = 2;
            this.btnNewNumbers.Text = "New List";
            this.btnNewNumbers.UseVisualStyleBackColor = true;
            // 
            // btnSortNumbers
            // 
            this.btnSortNumbers.Location = new System.Drawing.Point(109, 69);
            this.btnSortNumbers.Name = "btnSortNumbers";
            this.btnSortNumbers.Size = new System.Drawing.Size(75, 23);
            this.btnSortNumbers.TabIndex = 3;
            this.btnSortNumbers.Text = "Sort";
            this.btnSortNumbers.UseVisualStyleBackColor = true;
            // 
            // btnNewHeros
            // 
            this.btnNewHeros.Location = new System.Drawing.Point(444, 86);
            this.btnNewHeros.Name = "btnNewHeros";
            this.btnNewHeros.Size = new System.Drawing.Size(75, 23);
            this.btnNewHeros.TabIndex = 4;
            this.btnNewHeros.Text = "New List";
            this.btnNewHeros.UseVisualStyleBackColor = true;
            // 
            // btnSortHeroes
            // 
            this.btnSortHeroes.Location = new System.Drawing.Point(537, 87);
            this.btnSortHeroes.Name = "btnSortHeroes";
            this.btnSortHeroes.Size = new System.Drawing.Size(75, 23);
            this.btnSortHeroes.TabIndex = 5;
            this.btnSortHeroes.Text = "Sort";
            this.btnSortHeroes.UseVisualStyleBackColor = true;
            // 
            // lstNumbers
            // 
            this.lstNumbers.FormattingEnabled = true;
            this.lstNumbers.Location = new System.Drawing.Point(28, 118);
            this.lstNumbers.Name = "lstNumbers";
            this.lstNumbers.Size = new System.Drawing.Size(120, 95);
            this.lstNumbers.TabIndex = 6;
            // 
            // lstHeroes
            // 
            this.lstHeroes.FormattingEnabled = true;
            this.lstHeroes.Location = new System.Drawing.Point(444, 145);
            this.lstHeroes.Name = "lstHeroes";
            this.lstHeroes.Size = new System.Drawing.Size(120, 95);
            this.lstHeroes.TabIndex = 7;
            // 
            // lblRemove
            // 
            this.lblRemove.AutoSize = true;
            this.lblRemove.Location = new System.Drawing.Point(28, 260);
            this.lblRemove.Name = "lblRemove";
            this.lblRemove.Size = new System.Drawing.Size(134, 13);
            this.lblRemove.TabIndex = 8;
            this.lblRemove.Text = "Select a number to remove";
            // 
            // lblHeroName
            // 
            this.lblHeroName.AutoSize = true;
            this.lblHeroName.Location = new System.Drawing.Point(444, 260);
            this.lblHeroName.Name = "lblHeroName";
            this.lblHeroName.Size = new System.Drawing.Size(127, 13);
            this.lblHeroName.TabIndex = 9;
            this.lblHeroName.Text = "Enter a hero name to add";
            // 
            // btnRemoveNumber
            // 
            this.btnRemoveNumber.Location = new System.Drawing.Point(12, 291);
            this.btnRemoveNumber.Name = "btnRemoveNumber";
            this.btnRemoveNumber.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveNumber.TabIndex = 10;
            this.btnRemoveNumber.Text = "Remove";
            this.btnRemoveNumber.UseVisualStyleBackColor = true;
            // 
            // btnRemoveAllNumbers
            // 
            this.btnRemoveAllNumbers.Location = new System.Drawing.Point(93, 291);
            this.btnRemoveAllNumbers.Name = "btnRemoveAllNumbers";
            this.btnRemoveAllNumbers.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveAllNumbers.TabIndex = 11;
            this.btnRemoveAllNumbers.Text = "Remove All";
            this.btnRemoveAllNumbers.UseVisualStyleBackColor = true;
            // 
            // txtAddHeroes
            // 
            this.txtAddHeroes.Location = new System.Drawing.Point(419, 294);
            this.txtAddHeroes.Name = "txtAddHeroes";
            this.txtAddHeroes.Size = new System.Drawing.Size(100, 20);
            this.txtAddHeroes.TabIndex = 12;
            // 
            // btnAddHeroes
            // 
            this.btnAddHeroes.Location = new System.Drawing.Point(538, 294);
            this.btnAddHeroes.Name = "btnAddHeroes";
            this.btnAddHeroes.Size = new System.Drawing.Size(75, 23);
            this.btnAddHeroes.TabIndex = 13;
            this.btnAddHeroes.Text = "Add";
            this.btnAddHeroes.UseVisualStyleBackColor = true;
            // 
            // Lists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddHeroes);
            this.Controls.Add(this.txtAddHeroes);
            this.Controls.Add(this.btnRemoveAllNumbers);
            this.Controls.Add(this.btnRemoveNumber);
            this.Controls.Add(this.lblHeroName);
            this.Controls.Add(this.lblRemove);
            this.Controls.Add(this.lstHeroes);
            this.Controls.Add(this.lstNumbers);
            this.Controls.Add(this.btnSortHeroes);
            this.Controls.Add(this.btnNewHeros);
            this.Controls.Add(this.btnSortNumbers);
            this.Controls.Add(this.btnNewNumbers);
            this.Controls.Add(this.lblHeros);
            this.Controls.Add(this.lblNmbr);
            this.Name = "Lists";
            this.Text = "Lists";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNmbr;
        private System.Windows.Forms.Label lblHeros;
        private System.Windows.Forms.Button btnNewNumbers;
        private System.Windows.Forms.Button btnSortNumbers;
        private System.Windows.Forms.Button btnNewHeros;
        private System.Windows.Forms.Button btnSortHeroes;
        private System.Windows.Forms.ListBox lstNumbers;
        private System.Windows.Forms.ListBox lstHeroes;
        private System.Windows.Forms.Label lblRemove;
        private System.Windows.Forms.Label lblHeroName;
        private System.Windows.Forms.Button btnRemoveNumber;
        private System.Windows.Forms.Button btnRemoveAllNumbers;
        private System.Windows.Forms.TextBox txtAddHeroes;
        private System.Windows.Forms.Button btnAddHeroes;
    }
}

