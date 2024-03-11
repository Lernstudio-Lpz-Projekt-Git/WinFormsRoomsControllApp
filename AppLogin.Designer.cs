namespace WinFormsRoomsControllApp
{
    partial class AppLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppLogin));
            FirmaLBL = new Label();
            titelLbl = new Label();
            logInLbl = new Label();
            userName = new TextBox();
            label4 = new Label();
            passWord = new TextBox();
            label5 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            button1 = new Button();
            LogoBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)LogoBox).BeginInit();
            SuspendLayout();
            // 
            // FirmaLBL
            // 
            resources.ApplyResources(FirmaLBL, "FirmaLBL");
            FirmaLBL.Name = "FirmaLBL";
            FirmaLBL.Click += label1_Click;
            // 
            // titelLbl
            // 
            resources.ApplyResources(titelLbl, "titelLbl");
            titelLbl.Name = "titelLbl";
            // 
            // logInLbl
            // 
            resources.ApplyResources(logInLbl, "logInLbl");
            logInLbl.Name = "logInLbl";
            logInLbl.Click += label3_Click;
            // 
            // userName
            // 
            resources.ApplyResources(userName, "userName");
            userName.Name = "userName";
            userName.TextChanged += userName_TextChanged;
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            label4.Click += label4_Click;
            // 
            // passWord
            // 
            resources.ApplyResources(passWord, "passWord");
            passWord.Name = "passWord";
            passWord.UseSystemPasswordChar = true;
            passWord.TextChanged += passWord_TextChanged;
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // radioButton1
            // 
            resources.ApplyResources(radioButton1, "radioButton1");
            radioButton1.Checked = true;
            radioButton1.Name = "radioButton1";
            radioButton1.TabStop = true;
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            resources.ApplyResources(radioButton2, "radioButton2");
            radioButton2.Name = "radioButton2";
            radioButton2.TabStop = true;
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.AccessibleRole = AccessibleRole.Application;
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // LogoBox
            // 
            resources.ApplyResources(LogoBox, "LogoBox");
            LogoBox.Name = "LogoBox";
            LogoBox.TabStop = false;
            LogoBox.Click += pictureBox1_Click;
            // 
            // AppLogin
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(LogoBox);
            Controls.Add(button1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label5);
            Controls.Add(passWord);
            Controls.Add(label4);
            Controls.Add(userName);
            Controls.Add(logInLbl);
            Controls.Add(titelLbl);
            Controls.Add(FirmaLBL);
            Name = "AppLogin";
            ((System.ComponentModel.ISupportInitialize)LogoBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FirmaLBL;
        private Label titelLbl;
        private Label logInLbl;
        private TextBox userName;
        private Label label4;
        private TextBox passWord;
        private Label label5;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button button1;
        private PictureBox LogoBox;
    }
}
