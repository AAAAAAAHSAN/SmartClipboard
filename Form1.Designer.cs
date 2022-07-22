namespace Smart_Clip_Board
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btn_Copy1 = new System.Windows.Forms.Button();
            this.btn_Paste1 = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.btn_Copy2 = new System.Windows.Forms.Button();
            this.btn_Paste2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Clear1 = new System.Windows.Forms.Button();
            this.btn_Clear2 = new System.Windows.Forms.Button();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.btn_Copy3 = new System.Windows.Forms.Button();
            this.btn_Clear3 = new System.Windows.Forms.Button();
            this.btn_Paste3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(24, 21);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(516, 151);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // btn_Copy1
            // 
            this.btn_Copy1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Copy1.Location = new System.Drawing.Point(558, 21);
            this.btn_Copy1.Name = "btn_Copy1";
            this.btn_Copy1.Size = new System.Drawing.Size(94, 29);
            this.btn_Copy1.TabIndex = 2;
            this.btn_Copy1.Text = "Copy";
            this.btn_Copy1.UseVisualStyleBackColor = false;
            this.btn_Copy1.Click += new System.EventHandler(this.btn_Copy1_Click);
            // 
            // btn_Paste1
            // 
            this.btn_Paste1.Location = new System.Drawing.Point(558, 68);
            this.btn_Paste1.Name = "btn_Paste1";
            this.btn_Paste1.Size = new System.Drawing.Size(94, 29);
            this.btn_Paste1.TabIndex = 2;
            this.btn_Paste1.Text = "Paste";
            this.btn_Paste1.UseVisualStyleBackColor = true;
            this.btn_Paste1.Click += new System.EventHandler(this.btn_Paste1_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(24, 204);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(516, 151);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // btn_Copy2
            // 
            this.btn_Copy2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Copy2.Location = new System.Drawing.Point(558, 204);
            this.btn_Copy2.Name = "btn_Copy2";
            this.btn_Copy2.Size = new System.Drawing.Size(94, 29);
            this.btn_Copy2.TabIndex = 2;
            this.btn_Copy2.Text = "Copy";
            this.btn_Copy2.UseVisualStyleBackColor = false;
            this.btn_Copy2.Click += new System.EventHandler(this.btn_Copy2_Click);
            // 
            // btn_Paste2
            // 
            this.btn_Paste2.Location = new System.Drawing.Point(558, 252);
            this.btn_Paste2.Name = "btn_Paste2";
            this.btn_Paste2.Size = new System.Drawing.Size(94, 29);
            this.btn_Paste2.TabIndex = 2;
            this.btn_Paste2.Text = "Paste";
            this.btn_Paste2.UseVisualStyleBackColor = true;
            this.btn_Paste2.Click += new System.EventHandler(this.btn_Paste2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 657);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "You\'ll see copied text here";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(558, 598);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(125, 24);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Always on top";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(490, 696);
            this.trackBar1.Minimum = 4;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(217, 56);
            this.trackBar1.TabIndex = 5;
            this.trackBar1.Value = 4;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(540, 673);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Opacity";
            // 
            // btn_Clear1
            // 
            this.btn_Clear1.BackColor = System.Drawing.Color.Gray;
            this.btn_Clear1.Location = new System.Drawing.Point(558, 115);
            this.btn_Clear1.Name = "btn_Clear1";
            this.btn_Clear1.Size = new System.Drawing.Size(94, 29);
            this.btn_Clear1.TabIndex = 2;
            this.btn_Clear1.Text = "Clear";
            this.btn_Clear1.UseVisualStyleBackColor = false;
            this.btn_Clear1.Click += new System.EventHandler(this.btn_Clear1_Click);
            // 
            // btn_Clear2
            // 
            this.btn_Clear2.BackColor = System.Drawing.Color.Gray;
            this.btn_Clear2.Location = new System.Drawing.Point(558, 300);
            this.btn_Clear2.Name = "btn_Clear2";
            this.btn_Clear2.Size = new System.Drawing.Size(94, 29);
            this.btn_Clear2.TabIndex = 2;
            this.btn_Clear2.Text = "Clear";
            this.btn_Clear2.UseVisualStyleBackColor = false;
            this.btn_Clear2.Click += new System.EventHandler(this.btn_Clear2_Click);
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(24, 401);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(516, 151);
            this.richTextBox3.TabIndex = 1;
            this.richTextBox3.Text = "";
            // 
            // btn_Copy3
            // 
            this.btn_Copy3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Copy3.Location = new System.Drawing.Point(558, 401);
            this.btn_Copy3.Name = "btn_Copy3";
            this.btn_Copy3.Size = new System.Drawing.Size(94, 29);
            this.btn_Copy3.TabIndex = 2;
            this.btn_Copy3.Text = "Copy";
            this.btn_Copy3.UseVisualStyleBackColor = false;
            this.btn_Copy3.Click += new System.EventHandler(this.btn_Copy3_Click);
            // 
            // btn_Clear3
            // 
            this.btn_Clear3.BackColor = System.Drawing.Color.Gray;
            this.btn_Clear3.Location = new System.Drawing.Point(558, 497);
            this.btn_Clear3.Name = "btn_Clear3";
            this.btn_Clear3.Size = new System.Drawing.Size(94, 29);
            this.btn_Clear3.TabIndex = 2;
            this.btn_Clear3.Text = "Clear";
            this.btn_Clear3.UseVisualStyleBackColor = false;
            this.btn_Clear3.Click += new System.EventHandler(this.btn_Clear3_Click);
            // 
            // btn_Paste3
            // 
            this.btn_Paste3.Location = new System.Drawing.Point(558, 449);
            this.btn_Paste3.Name = "btn_Paste3";
            this.btn_Paste3.Size = new System.Drawing.Size(94, 29);
            this.btn_Paste3.TabIndex = 2;
            this.btn_Paste3.Text = "Paste";
            this.btn_Paste3.UseVisualStyleBackColor = true;
            this.btn_Paste3.Click += new System.EventHandler(this.btn_Paste3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 729);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "About me";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 770);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Paste3);
            this.Controls.Add(this.btn_Paste2);
            this.Controls.Add(this.btn_Clear3);
            this.Controls.Add(this.btn_Clear2);
            this.Controls.Add(this.btn_Clear1);
            this.Controls.Add(this.btn_Paste1);
            this.Controls.Add(this.btn_Copy3);
            this.Controls.Add(this.btn_Copy2);
            this.Controls.Add(this.btn_Copy1);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Smart Clipboard by AHSAN";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RichTextBox richTextBox1;
        private Button btn_Copy1;
        private Button btn_Paste1;
        private RichTextBox richTextBox2;
        private Button btn_Copy2;
        private Button btn_Paste2;
        private Label label1;
        private CheckBox checkBox1;
        private TrackBar trackBar1;
        private Label label2;
        private Button btn_Clear1;
        private Button btn_Clear2;
        private RichTextBox richTextBox3;
        private Button btn_Copy3;
        private Button btn_Clear3;
        private Button btn_Paste3;
        private Button button1;
    }
}