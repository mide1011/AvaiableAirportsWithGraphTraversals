namespace TaskB_Week5
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
            this.label1 = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.AddID_Button = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.FromTextBox = new System.Windows.Forms.TextBox();
            this.ToTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DisplayConnectionsButton = new System.Windows.Forms.Button();
            this.MotherButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Airport ID";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(288, 130);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(100, 26);
            this.IDTextBox.TabIndex = 2;
            // 
            // AddID_Button
            // 
            this.AddID_Button.Location = new System.Drawing.Point(495, 112);
            this.AddID_Button.Name = "AddID_Button";
            this.AddID_Button.Size = new System.Drawing.Size(117, 52);
            this.AddID_Button.TabIndex = 3;
            this.AddID_Button.Text = "Insert Airport";
            this.AddID_Button.UseVisualStyleBackColor = true;
            this.AddID_Button.Click += new System.EventHandler(this.AddID_Button_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(615, 170);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(112, 85);
            this.RemoveButton.TabIndex = 4;
            this.RemoveButton.Text = "Remove Connection";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // FromTextBox
            // 
            this.FromTextBox.Location = new System.Drawing.Point(288, 187);
            this.FromTextBox.Name = "FromTextBox";
            this.FromTextBox.Size = new System.Drawing.Size(38, 26);
            this.FromTextBox.TabIndex = 5;
            // 
            // ToTextBox
            // 
            this.ToTextBox.Location = new System.Drawing.Point(387, 187);
            this.ToTextBox.Name = "ToTextBox";
            this.ToTextBox.Size = new System.Drawing.Size(38, 26);
            this.ToTextBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(345, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "To";
            // 
            // DisplayConnectionsButton
            // 
            this.DisplayConnectionsButton.Location = new System.Drawing.Point(495, 279);
            this.DisplayConnectionsButton.Name = "DisplayConnectionsButton";
            this.DisplayConnectionsButton.Size = new System.Drawing.Size(173, 33);
            this.DisplayConnectionsButton.TabIndex = 9;
            this.DisplayConnectionsButton.Text = "Possible Airports ";
            this.DisplayConnectionsButton.UseVisualStyleBackColor = true;
            this.DisplayConnectionsButton.Click += new System.EventHandler(this.DisplayConnectionsButton_Click);
            // 
            // MotherButton
            // 
            this.MotherButton.Location = new System.Drawing.Point(495, 318);
            this.MotherButton.Name = "MotherButton";
            this.MotherButton.Size = new System.Drawing.Size(173, 34);
            this.MotherButton.TabIndex = 10;
            this.MotherButton.Text = "Reach All Airports ";
            this.MotherButton.UseVisualStyleBackColor = true;
            this.MotherButton.Click += new System.EventHandler(this.MotherButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(495, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 85);
            this.button1.TabIndex = 11;
            this.button1.Text = "Add Connection";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MotherButton);
            this.Controls.Add(this.DisplayConnectionsButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ToTextBox);
            this.Controls.Add(this.FromTextBox);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddID_Button);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Button AddID_Button;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.TextBox FromTextBox;
        private System.Windows.Forms.TextBox ToTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DisplayConnectionsButton;
        private System.Windows.Forms.Button MotherButton;
        private System.Windows.Forms.Button button1;
    }
}

