namespace UI_desgin
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.TextBoxAge = new System.Windows.Forms.TextBox();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(31, 30);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(51, 19);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAge.Location = new System.Drawing.Point(31, 60);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(38, 19);
            this.labelAge.TabIndex = 2;
            this.labelAge.Text = "Age";
            // 
            // TextBoxName
            // 
            this.TextBoxName.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxName.Location = new System.Drawing.Point(112, 27);
            this.TextBoxName.MaxLength = 10;
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(100, 27);
            this.TextBoxName.TabIndex = 1;
            this.TextBoxName.TextChanged += new System.EventHandler(this.TextBoxName_TextChanged);
            this.TextBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxName_KeyPress);
            // 
            // TextBoxAge
            // 
            this.TextBoxAge.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxAge.Location = new System.Drawing.Point(112, 60);
            this.TextBoxAge.MaxLength = 3;
            this.TextBoxAge.Name = "TextBoxAge";
            this.TextBoxAge.Size = new System.Drawing.Size(100, 27);
            this.TextBoxAge.TabIndex = 3;
            this.TextBoxAge.TextChanged += new System.EventHandler(this.TextBoxAge_TextChanged);
            this.TextBoxAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxAge_KeyPress);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSave.Location = new System.Drawing.Point(91, 94);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(70, 26);
            this.ButtonSave.TabIndex = 4;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonReset
            // 
            this.ButtonReset.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonReset.Location = new System.Drawing.Point(171, 94);
            this.ButtonReset.Name = "ButtonReset";
            this.ButtonReset.Size = new System.Drawing.Size(70, 26);
            this.ButtonReset.TabIndex = 5;
            this.ButtonReset.Text = "Reset";
            this.ButtonReset.UseVisualStyleBackColor = true;
            this.ButtonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 132);
            this.Controls.Add(this.ButtonReset);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.TextBoxAge);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.TextBox TextBoxAge;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonReset;
    }
}

