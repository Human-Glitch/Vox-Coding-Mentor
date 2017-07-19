namespace WindowsFormsApplication1
{
    partial class Voice2Calc
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
            this.btnEnable = new System.Windows.Forms.Button();
            this.btnDisable = new System.Windows.Forms.Button();
            this.queryBox = new System.Windows.Forms.RichTextBox();
            this.queryResultBox = new System.Windows.Forms.RichTextBox();
            this.commandListbox = new Toolset.Controls.CustomDrawListBox();
            this.choiceCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnEnable
            // 
            this.btnEnable.Location = new System.Drawing.Point(156, 355);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(167, 67);
            this.btnEnable.TabIndex = 0;
            this.btnEnable.Text = "Enable Voice Control";
            this.btnEnable.UseVisualStyleBackColor = true;
            this.btnEnable.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDisable
            // 
            this.btnDisable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisable.Location = new System.Drawing.Point(933, 355);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(183, 67);
            this.btnDisable.TabIndex = 1;
            this.btnDisable.Text = "Disable Voice Control";
            this.btnDisable.UseVisualStyleBackColor = true;
            this.btnDisable.Click += new System.EventHandler(this.button2_Click);
            // 
            // queryBox
            // 
            this.queryBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.queryBox.Font = new System.Drawing.Font("Roboto Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queryBox.Location = new System.Drawing.Point(329, 355);
            this.queryBox.Name = "queryBox";
            this.queryBox.Size = new System.Drawing.Size(598, 67);
            this.queryBox.TabIndex = 2;
            this.queryBox.Text = "";
            this.queryBox.TextChanged += new System.EventHandler(this.queryBox_TextChanged);
            // 
            // queryResultBox
            // 
            this.queryResultBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.queryResultBox.Font = new System.Drawing.Font("Roboto", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queryResultBox.Location = new System.Drawing.Point(0, 472);
            this.queryResultBox.Margin = new System.Windows.Forms.Padding(20);
            this.queryResultBox.Name = "queryResultBox";
            this.queryResultBox.Size = new System.Drawing.Size(1249, 485);
            this.queryResultBox.TabIndex = 3;
            this.queryResultBox.Text = "";
            // 
            // commandListbox
            // 
            this.commandListbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.commandListbox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.commandListbox.Font = new System.Drawing.Font("Roboto Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commandListbox.FormattingEnabled = true;
            this.commandListbox.ItemHeight = 40;
            this.commandListbox.Location = new System.Drawing.Point(213, 95);
            this.commandListbox.Name = "commandListbox";
            this.commandListbox.Size = new System.Drawing.Size(858, 244);
            this.commandListbox.Sorted = true;
            this.commandListbox.TabIndex = 4;
            // 
            // choiceCB
            // 
            this.choiceCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.choiceCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.choiceCB.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choiceCB.FormattingEnabled = true;
            this.choiceCB.Items.AddRange(new object[] {
            "C# Language",
            "C++ Language"});
            this.choiceCB.Location = new System.Drawing.Point(480, 37);
            this.choiceCB.Name = "choiceCB";
            this.choiceCB.Size = new System.Drawing.Size(299, 45);
            this.choiceCB.TabIndex = 5;
            this.choiceCB.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Voice2Calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 957);
            this.Controls.Add(this.choiceCB);
            this.Controls.Add(this.commandListbox);
            this.Controls.Add(this.queryResultBox);
            this.Controls.Add(this.queryBox);
            this.Controls.Add(this.btnDisable);
            this.Controls.Add(this.btnEnable);
            this.Name = "Voice2Calc";
            this.Text = "Voice2Calc";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEnable;
        private System.Windows.Forms.Button btnDisable;
        private System.Windows.Forms.RichTextBox queryBox;
        private System.Windows.Forms.RichTextBox queryResultBox;
        private Toolset.Controls.CustomDrawListBox commandListbox;
        private System.Windows.Forms.ComboBox choiceCB;
    }
}

