namespace Palkanlaskenta
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
            TyonTekijatComboBox = new ComboBox();
            label1 = new Label();
            txtTyotunnit = new TextBox();
            txtTuntipalkka = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnLaske = new Button();
            txtResult = new TextBox();
            btnUusiTyontekija = new Button();
            label5 = new Label();
            txtUusiTyontekija = new TextBox();
            btnPoistatyontekija = new Button();
            btnTallenna = new Button();
            SuspendLayout();
            // 
            // TyonTekijatComboBox
            // 
            TyonTekijatComboBox.FormattingEnabled = true;
            TyonTekijatComboBox.Location = new Point(111, 20);
            TyonTekijatComboBox.Margin = new Padding(4, 5, 4, 5);
            TyonTekijatComboBox.Name = "TyonTekijatComboBox";
            TyonTekijatComboBox.Size = new Size(137, 33);
            TyonTekijatComboBox.TabIndex = 0;
            TyonTekijatComboBox.SelectedIndexChanged += TyonTekijatComboBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 25);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(95, 25);
            label1.TabIndex = 1;
            label1.Text = "Työntekijä:";
            // 
            // txtTyotunnit
            // 
            txtTyotunnit.Location = new Point(111, 110);
            txtTyotunnit.Margin = new Padding(4, 5, 4, 5);
            txtTyotunnit.Name = "txtTyotunnit";
            txtTyotunnit.PlaceholderText = "Työ tunnit";
            txtTyotunnit.Size = new Size(141, 31);
            txtTyotunnit.TabIndex = 2;
            txtTyotunnit.TextAlign = HorizontalAlignment.Center;
            // 
            // txtTuntipalkka
            // 
            txtTuntipalkka.Location = new Point(111, 178);
            txtTuntipalkka.Margin = new Padding(4, 5, 4, 5);
            txtTuntipalkka.Name = "txtTuntipalkka";
            txtTuntipalkka.PlaceholderText = "Tuntipalkka";
            txtTuntipalkka.Size = new Size(141, 31);
            txtTuntipalkka.TabIndex = 3;
            txtTuntipalkka.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 115);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(90, 25);
            label2.TabIndex = 4;
            label2.Text = "Työtunnit:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 183);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(106, 25);
            label3.TabIndex = 5;
            label3.Text = "Tuntipalkka:";
            // 
            // btnLaske
            // 
            btnLaske.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLaske.Location = new Point(43, 242);
            btnLaske.Margin = new Padding(4, 5, 4, 5);
            btnLaske.Name = "btnLaske";
            btnLaske.Size = new Size(191, 50);
            btnLaske.TabIndex = 8;
            btnLaske.Text = "Laske palkka";
            btnLaske.UseVisualStyleBackColor = true;
            btnLaske.Click += btnLaske_Click;
            // 
            // txtResult
            // 
            txtResult.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtResult.Location = new Point(273, 25);
            txtResult.Margin = new Padding(4, 5, 4, 5);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(254, 264);
            txtResult.TabIndex = 9;
            // 
            // btnUusiTyontekija
            // 
            btnUusiTyontekija.Location = new Point(557, 92);
            btnUusiTyontekija.Margin = new Padding(4, 5, 4, 5);
            btnUusiTyontekija.Name = "btnUusiTyontekija";
            btnUusiTyontekija.Size = new Size(107, 38);
            btnUusiTyontekija.TabIndex = 10;
            btnUusiTyontekija.Text = "Lisää";
            btnUusiTyontekija.UseVisualStyleBackColor = true;
            btnUusiTyontekija.Click += btnUusiTyontekija_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(573, 13);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(214, 25);
            label5.TabIndex = 11;
            label5.Text = "Lisää tai poista työntekijä:";
            label5.Click += label5_Click;
            // 
            // txtUusiTyontekija
            // 
            txtUusiTyontekija.Location = new Point(594, 43);
            txtUusiTyontekija.Margin = new Padding(4, 5, 4, 5);
            txtUusiTyontekija.Multiline = true;
            txtUusiTyontekija.Name = "txtUusiTyontekija";
            txtUusiTyontekija.PlaceholderText = "Työntekijan nimi";
            txtUusiTyontekija.Size = new Size(141, 36);
            txtUusiTyontekija.TabIndex = 12;
            txtUusiTyontekija.TextAlign = HorizontalAlignment.Center;
            txtUusiTyontekija.TextChanged += txtUusiTyontekija_TextChanged;
            // 
            // btnPoistatyontekija
            // 
            btnPoistatyontekija.Location = new Point(673, 92);
            btnPoistatyontekija.Margin = new Padding(4, 5, 4, 5);
            btnPoistatyontekija.Name = "btnPoistatyontekija";
            btnPoistatyontekija.Size = new Size(107, 38);
            btnPoistatyontekija.TabIndex = 13;
            btnPoistatyontekija.Text = "Poista";
            btnPoistatyontekija.UseVisualStyleBackColor = true;
            btnPoistatyontekija.Click += btnPoistatyontekija_Click;
            // 
            // btnTallenna
            // 
            btnTallenna.Location = new Point(559, 258);
            btnTallenna.Name = "btnTallenna";
            btnTallenna.Size = new Size(228, 34);
            btnTallenna.TabIndex = 14;
            btnTallenna.Text = "Tallenna palkka tiedot";
            btnTallenna.UseVisualStyleBackColor = true;
            btnTallenna.Click += btnTallenna_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 440);
            Controls.Add(btnTallenna);
            Controls.Add(btnPoistatyontekija);
            Controls.Add(txtUusiTyontekija);
            Controls.Add(label5);
            Controls.Add(btnUusiTyontekija);
            Controls.Add(txtResult);
            Controls.Add(btnLaske);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtTuntipalkka);
            Controls.Add(txtTyotunnit);
            Controls.Add(label1);
            Controls.Add(TyonTekijatComboBox);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox TyonTekijatComboBox;
        private Label label1;
        private TextBox txtTyotunnit;
        private TextBox txtTuntipalkka;
        private Label label2;
        private Label label3;
        private Button btnLaske;
        private TextBox txtResult;
        private Button btnUusiTyontekija;
        private Label label5;
        private TextBox txtUusiTyontekija;
        private Button btnPoistatyontekija;
        private Button btnTallenna;
    }
}
