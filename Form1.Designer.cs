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
            this.btn_Copy1.Location = new System.Drawing.Point(558, 21);
            this.btn_Copy1.Name = "btn_Copy1";
            this.btn_Copy1.Size = new System.Drawing.Size(94, 29);
            this.btn_Copy1.TabIndex = 2;
            this.btn_Copy1.Text = "Copy";
            this.btn_Copy1.UseVisualStyleBackColor = true;
            this.btn_Copy1.Click += new System.EventHandler(this.btn_Copy1_Click);
            // 
            // btn_Paste1
            // 
            this.btn_Paste1.Location = new System.Drawing.Point(558, 73);
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
            this.btn_Copy2.Location = new System.Drawing.Point(558, 204);
            this.btn_Copy2.Name = "btn_Copy2";
            this.btn_Copy2.Size = new System.Drawing.Size(94, 29);
            this.btn_Copy2.TabIndex = 2;
            this.btn_Copy2.Text = "Copy";
            this.btn_Copy2.UseVisualStyleBackColor = true;
            this.btn_Copy2.Click += new System.EventHandler(this.btn_Copy2_Click);
            // 
            // btn_Paste2
            // 
            this.btn_Paste2.Location = new System.Drawing.Point(558, 256);
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
            this.label1.Location = new System.Drawing.Point(938, 516);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "You\'ll see copied text here";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(1076, 26);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(125, 24);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Always on top";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(938, 116);
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
            this.label2.Location = new System.Drawing.Point(997, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Opacity";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 770);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Paste2);
            this.Controls.Add(this.btn_Paste1);
            this.Controls.Add(this.btn_Copy2);
            this.Controls.Add(this.btn_Copy1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
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
    }
}