namespace LLCharReplace
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
            this.label1 = new System.Windows.Forms.Label();
            this.input_gamefolder = new System.Windows.Forms.TextBox();
            this.btn_choosegamefolder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ddl_charReplace = new System.Windows.Forms.ComboBox();
            this.ddl_charTarget = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_restore = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnLoadCharList = new System.Windows.Forms.Button();
            this.ddl_char = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_replace_group = new System.Windows.Forms.Button();
            this.btn_restore_group = new System.Windows.Forms.Button();
            this.ddl_replace_group = new System.Windows.Forms.ComboBox();
            this.ddl_target_group = new System.Windows.Forms.ComboBox();
            this.ddl_group = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "game folder";
            // 
            // input_gamefolder
            // 
            this.input_gamefolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.input_gamefolder.Location = new System.Drawing.Point(99, 9);
            this.input_gamefolder.Name = "input_gamefolder";
            this.input_gamefolder.Size = new System.Drawing.Size(615, 23);
            this.input_gamefolder.TabIndex = 1;
            this.input_gamefolder.TextChanged += new System.EventHandler(this.input_gamefolder_TextChanged);
            // 
            // btn_choosegamefolder
            // 
            this.btn_choosegamefolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_choosegamefolder.Location = new System.Drawing.Point(720, 9);
            this.btn_choosegamefolder.Name = "btn_choosegamefolder";
            this.btn_choosegamefolder.Size = new System.Drawing.Size(75, 23);
            this.btn_choosegamefolder.TabIndex = 2;
            this.btn_choosegamefolder.Text = "choose";
            this.btn_choosegamefolder.UseVisualStyleBackColor = true;
            this.btn_choosegamefolder.Click += new System.EventHandler(this.btn_choosegamefolder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "char list";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(11, 38);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 400);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ddl_charReplace);
            this.tabPage1.Controls.Add(this.ddl_charTarget);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btn_restore);
            this.tabPage1.Controls.Add(this.btnGo);
            this.tabPage1.Controls.Add(this.btnLoadCharList);
            this.tabPage1.Controls.Add(this.ddl_char);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(776, 370);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "solo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ddl_charReplace
            // 
            this.ddl_charReplace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl_charReplace.FormattingEnabled = true;
            this.ddl_charReplace.Location = new System.Drawing.Point(61, 86);
            this.ddl_charReplace.Name = "ddl_charReplace";
            this.ddl_charReplace.Size = new System.Drawing.Size(173, 25);
            this.ddl_charReplace.TabIndex = 4;
            // 
            // ddl_charTarget
            // 
            this.ddl_charTarget.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl_charTarget.FormattingEnabled = true;
            this.ddl_charTarget.Location = new System.Drawing.Point(61, 48);
            this.ddl_charTarget.Name = "ddl_charTarget";
            this.ddl_charTarget.Size = new System.Drawing.Size(173, 25);
            this.ddl_charTarget.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "replace";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "target";
            // 
            // btn_restore
            // 
            this.btn_restore.Location = new System.Drawing.Point(240, 48);
            this.btn_restore.Name = "btn_restore";
            this.btn_restore.Size = new System.Drawing.Size(75, 23);
            this.btn_restore.TabIndex = 2;
            this.btn_restore.Text = "restore";
            this.btn_restore.UseVisualStyleBackColor = true;
            this.btn_restore.Click += new System.EventHandler(this.btn_restore_Click);
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(240, 88);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnLoadCharList
            // 
            this.btnLoadCharList.Location = new System.Drawing.Point(240, 12);
            this.btnLoadCharList.Name = "btnLoadCharList";
            this.btnLoadCharList.Size = new System.Drawing.Size(75, 23);
            this.btnLoadCharList.TabIndex = 2;
            this.btnLoadCharList.Text = "load";
            this.btnLoadCharList.UseVisualStyleBackColor = true;
            this.btnLoadCharList.Click += new System.EventHandler(this.btnLoadCharList_Click);
            // 
            // ddl_char
            // 
            this.ddl_char.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl_char.FormattingEnabled = true;
            this.ddl_char.Location = new System.Drawing.Point(61, 12);
            this.ddl_char.Name = "ddl_char";
            this.ddl_char.Size = new System.Drawing.Size(173, 25);
            this.ddl_char.TabIndex = 1;
            this.ddl_char.SelectedIndexChanged += new System.EventHandler(this.ddl_char_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_replace_group);
            this.tabPage2.Controls.Add(this.btn_restore_group);
            this.tabPage2.Controls.Add(this.ddl_replace_group);
            this.tabPage2.Controls.Add(this.ddl_target_group);
            this.tabPage2.Controls.Add(this.ddl_group);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(776, 370);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "group";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_replace_group
            // 
            this.btn_replace_group.Location = new System.Drawing.Point(183, 82);
            this.btn_replace_group.Name = "btn_replace_group";
            this.btn_replace_group.Size = new System.Drawing.Size(75, 23);
            this.btn_replace_group.TabIndex = 2;
            this.btn_replace_group.Text = "go";
            this.btn_replace_group.UseVisualStyleBackColor = true;
            this.btn_replace_group.Click += new System.EventHandler(this.btn_replace_group_Click);
            // 
            // btn_restore_group
            // 
            this.btn_restore_group.Location = new System.Drawing.Point(183, 45);
            this.btn_restore_group.Name = "btn_restore_group";
            this.btn_restore_group.Size = new System.Drawing.Size(75, 23);
            this.btn_restore_group.TabIndex = 2;
            this.btn_restore_group.Text = "restore";
            this.btn_restore_group.UseVisualStyleBackColor = true;
            this.btn_restore_group.Click += new System.EventHandler(this.btn_restore_group_Click);
            // 
            // ddl_replace_group
            // 
            this.ddl_replace_group.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl_replace_group.FormattingEnabled = true;
            this.ddl_replace_group.Items.AddRange(new object[] {
            "μ\'s",
            "Aqours",
            "Saint Snow"});
            this.ddl_replace_group.Location = new System.Drawing.Point(56, 80);
            this.ddl_replace_group.Name = "ddl_replace_group";
            this.ddl_replace_group.Size = new System.Drawing.Size(121, 25);
            this.ddl_replace_group.TabIndex = 1;
            // 
            // ddl_target_group
            // 
            this.ddl_target_group.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl_target_group.FormattingEnabled = true;
            this.ddl_target_group.Items.AddRange(new object[] {
            "μ\'s",
            "Aqours",
            "Saint Snow"});
            this.ddl_target_group.Location = new System.Drawing.Point(56, 42);
            this.ddl_target_group.Name = "ddl_target_group";
            this.ddl_target_group.Size = new System.Drawing.Size(121, 25);
            this.ddl_target_group.TabIndex = 1;
            // 
            // ddl_group
            // 
            this.ddl_group.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl_group.FormattingEnabled = true;
            this.ddl_group.Items.AddRange(new object[] {
            "μ\'s",
            "Aqours",
            "Saint Snow"});
            this.ddl_group.Location = new System.Drawing.Point(56, 7);
            this.ddl_group.Name = "ddl_group";
            this.ddl_group.Size = new System.Drawing.Size(121, 25);
            this.ddl_group.TabIndex = 1;
            this.ddl_group.SelectedIndexChanged += new System.EventHandler(this.ddl_group_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "replace";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "target";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "group";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_choosegamefolder);
            this.Controls.Add(this.input_gamefolder);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIFAC Char Replace";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox input_gamefolder;
        private Button btn_choosegamefolder;
        private Label label2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ComboBox ddl_char;
        private Button btnLoadCharList;
        private Label label3;
        private ComboBox ddl_charTarget;
        private ComboBox ddl_charReplace;
        private Label label4;
        private Button btnGo;
        private Button btn_restore;
        private Label label5;
        private ComboBox ddl_group;
        private Label label6;
        private ComboBox ddl_replace_group;
        private ComboBox ddl_target_group;
        private Label label7;
        private Button btn_replace_group;
        private Button btn_restore_group;
    }
}