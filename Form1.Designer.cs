namespace AesCryptCSharp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labeltitle = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_read_result = new System.Windows.Forms.Button();
            this.TB_result = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_read_txt = new System.Windows.Forms.Button();
            this.TB_txt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TB_passphrase = new System.Windows.Forms.TextBox();
            this.labelpassphrase = new System.Windows.Forms.Label();
            this.CloseApp = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SwitchText = new System.Windows.Forms.PictureBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SwitchText)).BeginInit();
            this.SuspendLayout();
            // 
            // labeltitle
            // 
            this.labeltitle.AutoSize = true;
            this.labeltitle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labeltitle.Font = new System.Drawing.Font("Chiller", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labeltitle.ForeColor = System.Drawing.Color.Red;
            this.labeltitle.Location = new System.Drawing.Point(240, 9);
            this.labeltitle.Name = "labeltitle";
            this.labeltitle.Size = new System.Drawing.Size(475, 97);
            this.labeltitle.TabIndex = 0;
            this.labeltitle.Text = "AES Crypt C#";
            this.labeltitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_read_result);
            this.groupBox3.Controls.Add(this.TB_result);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Chiller", 24.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.ForeColor = System.Drawing.Color.Red;
            this.groupBox3.Location = new System.Drawing.Point(489, 218);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(472, 287);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Result";
            // 
            // btn_read_result
            // 
            this.btn_read_result.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_read_result.Font = new System.Drawing.Font("Chiller", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_read_result.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_read_result.Location = new System.Drawing.Point(279, 246);
            this.btn_read_result.Name = "btn_read_result";
            this.btn_read_result.Size = new System.Drawing.Size(187, 35);
            this.btn_read_result.TabIndex = 3;
            this.btn_read_result.Text = "Read From File";
            this.btn_read_result.UseVisualStyleBackColor = true;
            this.btn_read_result.Click += new System.EventHandler(this.btn_read_result_Click);
            // 
            // TB_result
            // 
            this.TB_result.BackColor = System.Drawing.Color.Black;
            this.TB_result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_result.Font = new System.Drawing.Font("Chiller", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TB_result.ForeColor = System.Drawing.Color.Red;
            this.TB_result.Location = new System.Drawing.Point(6, 53);
            this.TB_result.Multiline = true;
            this.TB_result.Name = "TB_result";
            this.TB_result.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TB_result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TB_result.Size = new System.Drawing.Size(460, 187);
            this.TB_result.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_read_txt);
            this.groupBox2.Controls.Add(this.TB_txt);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Chiller", 24.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(12, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(471, 287);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Text";
            // 
            // btn_read_txt
            // 
            this.btn_read_txt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_read_txt.Font = new System.Drawing.Font("Chiller", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_read_txt.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_read_txt.Location = new System.Drawing.Point(278, 246);
            this.btn_read_txt.Name = "btn_read_txt";
            this.btn_read_txt.Size = new System.Drawing.Size(187, 35);
            this.btn_read_txt.TabIndex = 2;
            this.btn_read_txt.Text = "Read From File";
            this.btn_read_txt.UseVisualStyleBackColor = true;
            this.btn_read_txt.Click += new System.EventHandler(this.btn_read_txt_Click);
            // 
            // TB_txt
            // 
            this.TB_txt.BackColor = System.Drawing.Color.Black;
            this.TB_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_txt.Font = new System.Drawing.Font("Chiller", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TB_txt.ForeColor = System.Drawing.Color.Red;
            this.TB_txt.Location = new System.Drawing.Point(10, 53);
            this.TB_txt.Multiline = true;
            this.TB_txt.Name = "TB_txt";
            this.TB_txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TB_txt.Size = new System.Drawing.Size(455, 187);
            this.TB_txt.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Chiller", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(768, 516);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 71);
            this.button1.TabIndex = 7;
            this.button1.Text = "DeCrypt";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.decrypt_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Chiller", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(571, 516);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 71);
            this.button2.TabIndex = 8;
            this.button2.Text = "Encrypt";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.encrypt_Click);
            // 
            // TB_passphrase
            // 
            this.TB_passphrase.BackColor = System.Drawing.Color.Black;
            this.TB_passphrase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_passphrase.Font = new System.Drawing.Font("Chiller", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TB_passphrase.ForeColor = System.Drawing.Color.Red;
            this.TB_passphrase.Location = new System.Drawing.Point(135, 533);
            this.TB_passphrase.Name = "TB_passphrase";
            this.TB_passphrase.Size = new System.Drawing.Size(430, 39);
            this.TB_passphrase.TabIndex = 9;
            // 
            // labelpassphrase
            // 
            this.labelpassphrase.AutoSize = true;
            this.labelpassphrase.Font = new System.Drawing.Font("Chiller", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelpassphrase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelpassphrase.Location = new System.Drawing.Point(22, 533);
            this.labelpassphrase.Name = "labelpassphrase";
            this.labelpassphrase.Size = new System.Drawing.Size(107, 33);
            this.labelpassphrase.TabIndex = 10;
            this.labelpassphrase.Text = "PassPhrase:";
            // 
            // CloseApp
            // 
            this.CloseApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CloseApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseApp.Image = global::AesCryptCSharp.Properties.Resources._6010029;
            this.CloseApp.Location = new System.Drawing.Point(841, 9);
            this.CloseApp.Name = "CloseApp";
            this.CloseApp.Size = new System.Drawing.Size(120, 86);
            this.CloseApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseApp.TabIndex = 11;
            this.CloseApp.TabStop = false;
            this.CloseApp.Click += new System.EventHandler(this.CloseApp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Chiller", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(849, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 33);
            this.label1.TabIndex = 13;
            this.label1.Text = "KILL APP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SwitchText
            // 
            this.SwitchText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SwitchText.Image = global::AesCryptCSharp.Properties.Resources.imageedit_2_5693601749;
            this.SwitchText.Location = new System.Drawing.Point(453, 155);
            this.SwitchText.Name = "SwitchText";
            this.SwitchText.Size = new System.Drawing.Size(64, 57);
            this.SwitchText.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SwitchText.TabIndex = 14;
            this.SwitchText.TabStop = false;
            this.SwitchText.Click += new System.EventHandler(this.SwitchText_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(973, 621);
            this.Controls.Add(this.SwitchText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CloseApp);
            this.Controls.Add(this.labelpassphrase);
            this.Controls.Add(this.TB_passphrase);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.labeltitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SwitchText)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labeltitle;
        private GroupBox groupBox3;
        private TextBox TB_result;
        private GroupBox groupBox2;
        private TextBox TB_txt;
        private Button button1;
        private Button button2;
        private TextBox TB_passphrase;
        private Label labelpassphrase;
        private PictureBox CloseApp;
        private Label label1;
        private Button btn_read_result;
        private Button btn_read_txt;
        private PictureBox SwitchText;
    }
}