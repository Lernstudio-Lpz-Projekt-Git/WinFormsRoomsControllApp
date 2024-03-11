namespace WinFormsRoomsControllApp
{
    partial class RoomList
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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "", "IT-Medien", "20", "4" }, -1);
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "", "LS-IT", "10", "9" }, -1);
            FirmaLBL = new Label();
            titelLbl = new Label();
            listView1 = new ListView();
            cID = new ColumnHeader();
            Raum = new ColumnHeader();
            cArbeitspl = new ColumnHeader();
            Clients = new ColumnHeader();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            listBox1 = new ListBox();
            label2 = new Label();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // FirmaLBL
            // 
            FirmaLBL.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FirmaLBL.AutoSize = true;
            FirmaLBL.Font = new Font("Segoe UI Variable Text Light", 44F);
            FirmaLBL.ImeMode = ImeMode.NoControl;
            FirmaLBL.Location = new Point(142, 40);
            FirmaLBL.Name = "FirmaLBL";
            FirmaLBL.Size = new Size(676, 79);
            FirmaLBL.TabIndex = 1;
            FirmaLBL.Text = "Raum-Client-Configurator";
            // 
            // titelLbl
            // 
            titelLbl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            titelLbl.AutoSize = true;
            titelLbl.Font = new Font("Segoe UI Variable Text Light", 18F);
            titelLbl.ImeMode = ImeMode.NoControl;
            titelLbl.Location = new Point(220, 119);
            titelLbl.Name = "titelLbl";
            titelLbl.Size = new Size(499, 32);
            titelLbl.TabIndex = 2;
            titelLbl.Text = "IT-Arbeitsplätze (Clients) in Räumen bereitstellen";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { cID, Raum, cArbeitspl, Clients });
            listView1.HoverSelection = true;
            listView1.ImeMode = ImeMode.On;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2 });
            listView1.LabelWrap = false;
            listView1.Location = new Point(69, 259);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(320, 309);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // cID
            // 
            cID.Text = "Nr.";
            cID.Width = 40;
            // 
            // Raum
            // 
            Raum.Text = "Raum";
            Raum.Width = 100;
            // 
            // cArbeitspl
            // 
            cArbeitspl.Text = "Arbeitsplätze";
            cArbeitspl.Width = 90;
            // 
            // Clients
            // 
            Clients.Text = "Clients (frei)";
            Clients.Width = 80;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(69, 235);
            label1.Name = "label1";
            label1.Size = new Size(116, 21);
            label1.TabIndex = 4;
            label1.Text = "Raumbelegung";
            // 
            // button1
            // 
            button1.Location = new Point(395, 258);
            button1.Name = "button1";
            button1.Size = new Size(109, 23);
            button1.TabIndex = 5;
            button1.Text = "Hinzufügen ...";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(395, 287);
            button2.Name = "button2";
            button2.Size = new Size(109, 23);
            button2.TabIndex = 6;
            button2.Text = "Bearbeiten ...";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(395, 316);
            button3.Name = "button3";
            button3.Size = new Size(109, 23);
            button3.TabIndex = 7;
            button3.Text = "Löschen ...";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(200, 574);
            button4.Name = "button4";
            button4.Size = new Size(189, 28);
            button4.TabIndex = 8;
            button4.Text = "Raumbelegung bearbeiten ...";
            button4.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "15-Lenovo-01", "15-Lenovo-02", "15-Lenovo-03", "15-Lenovo-04", "15-Lenovo-05", "15-Lenovo-06", "15-Lenovo-07", "15-Lenovo-08", "15-Lenovo-09", "15-Lenovo-10", "15-Lenovo-11", "15-Lenovo-12", "15-Lenovo-13", "15-Lenovo-14", "15-Lenovo-15", "15-Lenovo-16", "17-HP-01", "17-HP-02", "17-HP-03", "17-HP-04", "17-HP-05", "17-HP-06", "17-HP-07", "17-HP-08", "17-HP-09", "17-HP-10", "17-HP-11", "17-HP-12", "17-HP-13", "17-HP-14", "17-HP-15", "17-HP-16", "FS-Desk-01", "FS-Desk-03", "FS-Desk-05", "FS-Desk-06", "FS-Desk-07", "FS-Desk-08", "FS-Desk-09", "FS-Desk-10", "FS-Desk-11", "FS-Desk-12", "FS-Desk-13", "FS-Desk-14", "FS-Desk-15", "FS-Desk-16", "FS-Desk-17", "FS-Desk-18", "Cube-01", "Cube-02", "Cube-03", "Cube-04", "Cube-06", "Cube-07", "Cube-08", "Cube-09", "Cube-10", "Cube-11", "Cube-12", "Cube-13", "Cube-14", "Cube-15", "Cube-16", "Cube-17", "Cube-18", "14Lap-01", "14Lap-02", "14Lap-03", "14Lap-04", "14Lap-05", "14Lap-06", "14Lap-07", "14Lap-08", "14Lap-10", "14Lap-11", "14Lap-12", "14Lap-13", "14Lap-14", "14Lap-15", "14Lap-16", "14Lap-17", "14Lap-18", "Mini03", "Mini04", "Mini05", "Mini06", "Mini07", "Mini08", "Mini09", "Mini10", "Mini11", "Mini12", "Mini13", "Mini14", "Mini15", "Mini16", "Mini17", "Mini18", "Mini19" });
            listBox1.Location = new Point(555, 258);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(216, 319);
            listBox1.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(555, 235);
            label2.Name = "label2";
            label2.Size = new Size(179, 21);
            label2.TabIndex = 10;
            label2.Text = "Liste verfügbarer Clients";
            // 
            // button5
            // 
            button5.Location = new Point(777, 256);
            button5.Name = "button5";
            button5.Size = new Size(110, 25);
            button5.TabIndex = 11;
            button5.Text = "Hinzufügen ...";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(777, 287);
            button6.Name = "button6";
            button6.Size = new Size(110, 27);
            button6.TabIndex = 12;
            button6.Text = "Bearbeiten ...";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(777, 320);
            button7.Name = "button7";
            button7.Size = new Size(109, 23);
            button7.TabIndex = 13;
            button7.Text = "Löaschen ...";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(683, 661);
            button8.Name = "button8";
            button8.Size = new Size(204, 37);
            button8.TabIndex = 14;
            button8.Text = "Abmelden";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Coral;
            label3.Location = new Point(356, 170);
            label3.Name = "label3";
            label3.Size = new Size(168, 15);
            label3.TabIndex = 15;
            label3.Text = "Angemeldet als: Administrator";
            // 
            // RoomList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 725);
            Controls.Add(label3);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(label2);
            Controls.Add(listBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(listView1);
            Controls.Add(titelLbl);
            Controls.Add(FirmaLBL);
            Name = "RoomList";
            Text = "RoomForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FirmaLBL;
        private Label titelLbl;
        private ListView listView1;
        private ColumnHeader Raum;
        private ColumnHeader Clients;
        private ColumnHeader cArbeitspl;
        private ColumnHeader cID;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private ListBox listBox1;
        private Label label2;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Label label3;
    }
}