namespace Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Label1Name = new System.Windows.Forms.Label();
            this.label2Age = new System.Windows.Forms.Label();
            this.label3Mobile_Number = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1Reset = new System.Windows.Forms.Button();
            this.button2Save = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label1Name
            // 
            this.Label1Name.AutoSize = true;
            this.Label1Name.Location = new System.Drawing.Point(150, 24);
            this.Label1Name.Name = "Label1Name";
            this.Label1Name.Size = new System.Drawing.Size(44, 16);
            this.Label1Name.TabIndex = 0;
            this.Label1Name.Text = "Name";
            // 
            // label2Age
            // 
            this.label2Age.AutoSize = true;
            this.label2Age.Location = new System.Drawing.Point(150, 55);
            this.label2Age.Name = "label2Age";
            this.label2Age.Size = new System.Drawing.Size(32, 16);
            this.label2Age.TabIndex = 2;
            this.label2Age.Text = "Age";
            // 
            // label3Mobile_Number
            // 
            this.label3Mobile_Number.AutoSize = true;
            this.label3Mobile_Number.Location = new System.Drawing.Point(150, 89);
            this.label3Mobile_Number.Name = "label3Mobile_Number";
            this.label3Mobile_Number.Size = new System.Drawing.Size(99, 16);
            this.label3Mobile_Number.TabIndex = 4;
            this.label3Mobile_Number.Text = "Mobile Number";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(273, 18);
            this.textBox1.MaxLength = 50;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(273, 49);
            this.textBox2.MaxLength = 3;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 22);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(273, 83);
            this.textBox3.MaxLength = 10;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(200, 22);
            this.textBox3.TabIndex = 5;
            // 
            // button1Reset
            // 
            this.button1Reset.Location = new System.Drawing.Point(643, 169);
            this.button1Reset.Name = "button1Reset";
            this.button1Reset.Size = new System.Drawing.Size(75, 23);
            this.button1Reset.TabIndex = 6;
            this.button1Reset.Text = "Reset";
            this.button1Reset.UseVisualStyleBackColor = true;
            this.button1Reset.Click += new System.EventHandler(this.button1Reset_Click);
            // 
            // button2Save
            // 
            this.button2Save.Location = new System.Drawing.Point(551, 169);
            this.button2Save.Name = "button2Save";
            this.button2Save.Size = new System.Drawing.Size(75, 23);
            this.button2Save.TabIndex = 7;
            this.button2Save.Text = "Save";
            this.button2Save.UseVisualStyleBackColor = true;
            this.button2Save.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label3Mobile_Number);
            this.groupBox1.Controls.Add(this.label2Age);
            this.groupBox1.Controls.Add(this.Label1Name);
            this.groupBox1.Location = new System.Drawing.Point(61, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(657, 119);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registration Form";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(330, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Registration";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 201);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2Save);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1Reset);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label1Name;
        private System.Windows.Forms.Label label2Age;
        private System.Windows.Forms.Label label3Mobile_Number;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1Reset;
        private System.Windows.Forms.Button button2Save;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}

