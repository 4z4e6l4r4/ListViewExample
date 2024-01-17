namespace ListViewExample
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.NameLbl = new System.Windows.Forms.Label();
            this.SurnameLbl = new System.Windows.Forms.Label();
            this.AgeLbl = new System.Windows.Forms.Label();
            this.StatusLbl = new System.Windows.Forms.Label();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.SurnameTxt = new System.Windows.Forms.TextBox();
            this.AgeNud = new System.Windows.Forms.NumericUpDown();
            this.StatusCb = new System.Windows.Forms.ComboBox();
            this.GULBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AgeNud)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(410, 31);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(440, 396);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(23, 42);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(44, 16);
            this.NameLbl.TabIndex = 2;
            this.NameLbl.Text = "Name";
            // 
            // SurnameLbl
            // 
            this.SurnameLbl.AutoSize = true;
            this.SurnameLbl.Location = new System.Drawing.Point(23, 109);
            this.SurnameLbl.Name = "SurnameLbl";
            this.SurnameLbl.Size = new System.Drawing.Size(61, 16);
            this.SurnameLbl.TabIndex = 3;
            this.SurnameLbl.Text = "Surname";
            // 
            // AgeLbl
            // 
            this.AgeLbl.AutoSize = true;
            this.AgeLbl.Location = new System.Drawing.Point(23, 168);
            this.AgeLbl.Name = "AgeLbl";
            this.AgeLbl.Size = new System.Drawing.Size(32, 16);
            this.AgeLbl.TabIndex = 4;
            this.AgeLbl.Text = "Age";
            // 
            // StatusLbl
            // 
            this.StatusLbl.AutoSize = true;
            this.StatusLbl.Location = new System.Drawing.Point(23, 231);
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(44, 16);
            this.StatusLbl.TabIndex = 5;
            this.StatusLbl.Text = "Status";
            // 
            // NameTxt
            // 
            this.NameTxt.Location = new System.Drawing.Point(28, 65);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(241, 22);
            this.NameTxt.TabIndex = 6;
            // 
            // SurnameTxt
            // 
            this.SurnameTxt.Location = new System.Drawing.Point(26, 128);
            this.SurnameTxt.Name = "SurnameTxt";
            this.SurnameTxt.Size = new System.Drawing.Size(243, 22);
            this.SurnameTxt.TabIndex = 7;
            // 
            // AgeNud
            // 
            this.AgeNud.Location = new System.Drawing.Point(26, 198);
            this.AgeNud.Name = "AgeNud";
            this.AgeNud.Size = new System.Drawing.Size(120, 22);
            this.AgeNud.TabIndex = 8;
            // 
            // StatusCb
            // 
            this.StatusCb.FormattingEnabled = true;
            this.StatusCb.Location = new System.Drawing.Point(26, 259);
            this.StatusCb.Name = "StatusCb";
            this.StatusCb.Size = new System.Drawing.Size(127, 24);
            this.StatusCb.TabIndex = 9;
            // 
            // GULBtn
            // 
            this.GULBtn.Location = new System.Drawing.Point(888, 214);
            this.GULBtn.Name = "GULBtn";
            this.GULBtn.Size = new System.Drawing.Size(154, 33);
            this.GULBtn.TabIndex = 10;
            this.GULBtn.Text = "button2";
            this.GULBtn.UseVisualStyleBackColor = true;
            this.GULBtn.Click += new System.EventHandler(this.GULBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 450);
            this.Controls.Add(this.GULBtn);
            this.Controls.Add(this.StatusCb);
            this.Controls.Add(this.AgeNud);
            this.Controls.Add(this.SurnameTxt);
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.StatusLbl);
            this.Controls.Add(this.AgeLbl);
            this.Controls.Add(this.SurnameLbl);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.AgeNud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label SurnameLbl;
        private System.Windows.Forms.Label AgeLbl;
        private System.Windows.Forms.Label StatusLbl;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.TextBox SurnameTxt;
        private System.Windows.Forms.NumericUpDown AgeNud;
        private System.Windows.Forms.ComboBox StatusCb;
        private System.Windows.Forms.Button GULBtn;
    }
}

