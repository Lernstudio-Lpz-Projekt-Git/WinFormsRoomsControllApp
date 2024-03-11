namespace WinFormsRoomsControllApp
{
    partial class RoomDetails
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
            FirmaLBL = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            RaumName = new TextBox();
            numericUpDownRaoomNr = new NumericUpDown();
            numericUpDownWorkplaces = new NumericUpDown();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRaoomNr).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWorkplaces).BeginInit();
            SuspendLayout();
            // 
            // FirmaLBL
            // 
            FirmaLBL.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FirmaLBL.AutoSize = true;
            FirmaLBL.Font = new Font("Segoe UI Variable Text Light", 24F);
            FirmaLBL.ImeMode = ImeMode.NoControl;
            FirmaLBL.Location = new Point(39, 26);
            FirmaLBL.Name = "FirmaLBL";
            FirmaLBL.Size = new Size(383, 43);
            FirmaLBL.TabIndex = 2;
            FirmaLBL.Text = "Neuen Raum hinzufügen ...";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(50, 121);
            label1.Name = "label1";
            label1.Size = new Size(102, 21);
            label1.TabIndex = 3;
            label1.Text = "Raum-Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(50, 194);
            label2.Name = "label2";
            label2.Size = new Size(81, 21);
            label2.TabIndex = 4;
            label2.Text = "Raum-Nr.:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(50, 265);
            label3.Name = "label3";
            label3.Size = new Size(193, 21);
            label3.TabIndex = 5;
            label3.Text = "Anzahl von Arbeitsplätzen:";
            // 
            // RaumName
            // 
            RaumName.Font = new Font("Segoe UI", 11F);
            RaumName.Location = new Point(54, 145);
            RaumName.Name = "RaumName";
            RaumName.Size = new Size(257, 27);
            RaumName.TabIndex = 6;
            // 
            // numericUpDownRaoomNr
            // 
            numericUpDownRaoomNr.Font = new Font("Segoe UI", 11F);
            numericUpDownRaoomNr.Location = new Point(54, 218);
            numericUpDownRaoomNr.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownRaoomNr.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownRaoomNr.Name = "numericUpDownRaoomNr";
            numericUpDownRaoomNr.Size = new Size(257, 27);
            numericUpDownRaoomNr.TabIndex = 7;
            numericUpDownRaoomNr.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDownWorkplaces
            // 
            numericUpDownWorkplaces.Font = new Font("Segoe UI", 11F);
            numericUpDownWorkplaces.Location = new Point(54, 289);
            numericUpDownWorkplaces.Maximum = new decimal(new int[] { 25, 0, 0, 0 });
            numericUpDownWorkplaces.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDownWorkplaces.Name = "numericUpDownWorkplaces";
            numericUpDownWorkplaces.Size = new Size(257, 27);
            numericUpDownWorkplaces.TabIndex = 8;
            numericUpDownWorkplaces.Value = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDownWorkplaces.ValueChanged += numericUpDownWorkplaces_ValueChanged;
            // 
            // button1
            // 
            button1.Location = new Point(167, 375);
            button1.Name = "button1";
            button1.Size = new Size(120, 35);
            button1.TabIndex = 9;
            button1.Text = "Abbrechen";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(293, 375);
            button2.Name = "button2";
            button2.Size = new Size(129, 35);
            button2.TabIndex = 10;
            button2.Text = "Hinzufügen";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // RoomDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 440);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(numericUpDownWorkplaces);
            Controls.Add(numericUpDownRaoomNr);
            Controls.Add(RaumName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(FirmaLBL);
            Name = "RoomDetails";
            Text = "RoomDetails";
            ((System.ComponentModel.ISupportInitialize)numericUpDownRaoomNr).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWorkplaces).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FirmaLBL;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox RaumName;
        private NumericUpDown numericUpDownRaoomNr;
        private NumericUpDown numericUpDownWorkplaces;
        private Button button1;
        private Button button2;
    }
}