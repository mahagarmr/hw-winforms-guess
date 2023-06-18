namespace hw_winforms_guess
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
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.AliceBlue;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Lucida Handwriting", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = Color.SkyBlue;
            textBox1.Location = new Point(20, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(194, 24);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Verdana", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Azure;
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(194, 25);
            label1.TabIndex = 1;
            label1.Text = "Enter a number";
            // 
            // button1
            // 
            button1.BackColor = Color.Azure;
            button1.Font = new Font("Verdana", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.SkyBlue;
            button1.Location = new Point(20, 217);
            button1.Name = "button1";
            button1.Size = new Size(194, 71);
            button1.TabIndex = 2;
            button1.Text = "Pick";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(234, 311);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Guess";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Button button1;
    }
}