namespace wk7_After_StrikeClass1_
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
            this.btnLoop1 = new System.Windows.Forms.Button();
            this.lblMsg1 = new System.Windows.Forms.Label();
            this.btnWhileLoop = new System.Windows.Forms.Button();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblMsg2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLoop1
            // 
            this.btnLoop1.Location = new System.Drawing.Point(68, 47);
            this.btnLoop1.Name = "btnLoop1";
            this.btnLoop1.Size = new System.Drawing.Size(117, 64);
            this.btnLoop1.TabIndex = 0;
            this.btnLoop1.Text = "Loop 1";
            this.btnLoop1.UseVisualStyleBackColor = true;
            this.btnLoop1.Click += new System.EventHandler(this.btnLoop1_Click);
            // 
            // lblMsg1
            // 
            this.lblMsg1.AutoSize = true;
            this.lblMsg1.Location = new System.Drawing.Point(63, 130);
            this.lblMsg1.Name = "lblMsg1";
            this.lblMsg1.Size = new System.Drawing.Size(293, 25);
            this.lblMsg1.TabIndex = 2;
            this.lblMsg1.Text = "Click the button to run a loop.";
            // 
            // btnWhileLoop
            // 
            this.btnWhileLoop.Location = new System.Drawing.Point(619, 47);
            this.btnWhileLoop.Name = "btnWhileLoop";
            this.btnWhileLoop.Size = new System.Drawing.Size(208, 64);
            this.btnWhileLoop.TabIndex = 3;
            this.btnWhileLoop.Text = "LoopWhile";
            this.btnWhileLoop.UseVisualStyleBackColor = true;
            this.btnWhileLoop.Click += new System.EventHandler(this.btnWhileLoop_Click);
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(68, 253);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 31);
            this.txtX.TabIndex = 4;
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(68, 304);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(100, 31);
            this.txtY.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(260, 304);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(131, 53);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblMsg2
            // 
            this.lblMsg2.AutoSize = true;
            this.lblMsg2.Location = new System.Drawing.Point(255, 253);
            this.lblMsg2.Name = "lblMsg2";
            this.lblMsg2.Size = new System.Drawing.Size(217, 25);
            this.lblMsg2.TabIndex = 7;
            this.lblMsg2.Text = "Click to add Numbers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(754, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "From Change for Git Hub";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 630);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMsg2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.btnWhileLoop);
            this.Controls.Add(this.lblMsg1);
            this.Controls.Add(this.btnLoop1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoop1;
        private System.Windows.Forms.Label lblMsg1;
        private System.Windows.Forms.Button btnWhileLoop;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblMsg2;
        private System.Windows.Forms.Label label1;
    }
}

