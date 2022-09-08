namespace Circustrein
{
    partial class Circustrein
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
            this.meatBtn = new System.Windows.Forms.RadioButton();
            this.plantBtn = new System.Windows.Forms.RadioButton();
            this.smallBtn = new System.Windows.Forms.RadioButton();
            this.mediumBtn = new System.Windows.Forms.RadioButton();
            this.bigBtn = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addAnimalsLbl = new System.Windows.Forms.Label();
            this.nameTxtbox = new System.Windows.Forms.TextBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.animalListbox = new System.Windows.Forms.ListBox();
            this.animalListboxLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.wagonBtn = new System.Windows.Forms.Button();
            this.wagonLbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // meatBtn
            // 
            this.meatBtn.AutoSize = true;
            this.meatBtn.Location = new System.Drawing.Point(6, 26);
            this.meatBtn.Name = "meatBtn";
            this.meatBtn.Size = new System.Drawing.Size(65, 24);
            this.meatBtn.TabIndex = 0;
            this.meatBtn.TabStop = true;
            this.meatBtn.Text = "Vlees";
            this.meatBtn.UseVisualStyleBackColor = true;
            // 
            // plantBtn
            // 
            this.plantBtn.AutoSize = true;
            this.plantBtn.Location = new System.Drawing.Point(6, 56);
            this.plantBtn.Name = "plantBtn";
            this.plantBtn.Size = new System.Drawing.Size(79, 24);
            this.plantBtn.TabIndex = 1;
            this.plantBtn.TabStop = true;
            this.plantBtn.Text = "Planten";
            this.plantBtn.UseVisualStyleBackColor = true;
            // 
            // smallBtn
            // 
            this.smallBtn.AutoSize = true;
            this.smallBtn.Checked = true;
            this.smallBtn.Location = new System.Drawing.Point(6, 26);
            this.smallBtn.Name = "smallBtn";
            this.smallBtn.Size = new System.Drawing.Size(63, 24);
            this.smallBtn.TabIndex = 2;
            this.smallBtn.TabStop = true;
            this.smallBtn.Text = "Klein";
            this.smallBtn.UseVisualStyleBackColor = true;
            // 
            // mediumBtn
            // 
            this.mediumBtn.AutoSize = true;
            this.mediumBtn.Location = new System.Drawing.Point(6, 56);
            this.mediumBtn.Name = "mediumBtn";
            this.mediumBtn.Size = new System.Drawing.Size(114, 24);
            this.mediumBtn.TabIndex = 3;
            this.mediumBtn.Text = "Middelgroot";
            this.mediumBtn.UseVisualStyleBackColor = true;
            // 
            // bigBtn
            // 
            this.bigBtn.AutoSize = true;
            this.bigBtn.Location = new System.Drawing.Point(6, 86);
            this.bigBtn.Name = "bigBtn";
            this.bigBtn.Size = new System.Drawing.Size(68, 24);
            this.bigBtn.TabIndex = 4;
            this.bigBtn.Text = "Groot";
            this.bigBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.meatBtn);
            this.groupBox1.Controls.Add(this.plantBtn);
            this.groupBox1.Location = new System.Drawing.Point(192, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 125);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type eter";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.smallBtn);
            this.groupBox2.Controls.Add(this.mediumBtn);
            this.groupBox2.Controls.Add(this.bigBtn);
            this.groupBox2.Location = new System.Drawing.Point(364, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(139, 125);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Formaat";
            // 
            // addAnimalsLbl
            // 
            this.addAnimalsLbl.AutoSize = true;
            this.addAnimalsLbl.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addAnimalsLbl.Location = new System.Drawing.Point(14, 9);
            this.addAnimalsLbl.Name = "addAnimalsLbl";
            this.addAnimalsLbl.Size = new System.Drawing.Size(218, 32);
            this.addAnimalsLbl.TabIndex = 7;
            this.addAnimalsLbl.Text = "Dieren toevoegen";
            // 
            // nameTxtbox
            // 
            this.nameTxtbox.Location = new System.Drawing.Point(28, 87);
            this.nameTxtbox.Name = "nameTxtbox";
            this.nameTxtbox.Size = new System.Drawing.Size(125, 27);
            this.nameTxtbox.TabIndex = 8;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(28, 64);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(82, 20);
            this.nameLbl.TabIndex = 9;
            this.nameLbl.Text = "Naam dier:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(528, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = "Voeg toe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // animalListbox
            // 
            this.animalListbox.FormattingEnabled = true;
            this.animalListbox.ItemHeight = 20;
            this.animalListbox.Location = new System.Drawing.Point(694, 85);
            this.animalListbox.Name = "animalListbox";
            this.animalListbox.Size = new System.Drawing.Size(174, 224);
            this.animalListbox.TabIndex = 11;
            this.animalListbox.SelectedIndexChanged += new System.EventHandler(this.animalListbox_SelectedIndexChanged);
            // 
            // animalListboxLbl
            // 
            this.animalListboxLbl.AutoSize = true;
            this.animalListboxLbl.Location = new System.Drawing.Point(694, 62);
            this.animalListboxLbl.Name = "animalListboxLbl";
            this.animalListboxLbl.Size = new System.Drawing.Size(56, 20);
            this.animalListboxLbl.TabIndex = 12;
            this.animalListboxLbl.Text = "Dieren:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 32);
            this.label1.TabIndex = 13;
            this.label1.Text = "Wagons samenstellen";
            // 
            // wagonBtn
            // 
            this.wagonBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.wagonBtn.Location = new System.Drawing.Point(12, 279);
            this.wagonBtn.Name = "wagonBtn";
            this.wagonBtn.Size = new System.Drawing.Size(216, 44);
            this.wagonBtn.TabIndex = 15;
            this.wagonBtn.Text = "Stel wagons samen";
            this.wagonBtn.UseVisualStyleBackColor = false;
            this.wagonBtn.Click += new System.EventHandler(this.wagonBtn_Click);
            // 
            // wagonLbl
            // 
            this.wagonLbl.AutoSize = true;
            this.wagonLbl.Location = new System.Drawing.Point(20, 387);
            this.wagonLbl.Name = "wagonLbl";
            this.wagonLbl.Size = new System.Drawing.Size(50, 20);
            this.wagonLbl.TabIndex = 16;
            this.wagonLbl.Text = "label2";
            // 
            // Circustrein
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 564);
            this.Controls.Add(this.wagonLbl);
            this.Controls.Add(this.wagonBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.animalListboxLbl);
            this.Controls.Add(this.animalListbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.nameTxtbox);
            this.Controls.Add(this.addAnimalsLbl);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Circustrein";
            this.Text = "Circustrein";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton meatBtn;
        private RadioButton plantBtn;
        private RadioButton smallBtn;
        private RadioButton mediumBtn;
        private RadioButton bigBtn;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label addAnimalsLbl;
        private TextBox nameTxtbox;
        private Label nameLbl;
        private Button button1;
        private ListBox animalListbox;
        private Label animalListboxLbl;
        private Label label1;
        private Button wagonBtn;
        private Label wagonLbl;
    }
}