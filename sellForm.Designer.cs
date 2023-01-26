
namespace CGS_Win
{
    partial class sellForm
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.displayBtn = new System.Windows.Forms.Button();
            this.estimate_textbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pieceID_textbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.sellBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(74, 56);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(715, 285);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // displayBtn
            // 
            this.displayBtn.Location = new System.Drawing.Point(257, 373);
            this.displayBtn.Name = "displayBtn";
            this.displayBtn.Size = new System.Drawing.Size(336, 108);
            this.displayBtn.TabIndex = 1;
            this.displayBtn.Text = "Display";
            this.displayBtn.UseVisualStyleBackColor = true;
            // 
            // estimate_textbox
            // 
            this.estimate_textbox.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estimate_textbox.Location = new System.Drawing.Point(364, 612);
            this.estimate_textbox.Name = "estimate_textbox";
            this.estimate_textbox.Size = new System.Drawing.Size(371, 58);
            this.estimate_textbox.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(117, 618);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 46);
            this.label7.TabIndex = 17;
            this.label7.Text = "Estimate";
            // 
            // pieceID_textbox
            // 
            this.pieceID_textbox.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pieceID_textbox.Location = new System.Drawing.Point(364, 521);
            this.pieceID_textbox.Name = "pieceID_textbox";
            this.pieceID_textbox.Size = new System.Drawing.Size(371, 58);
            this.pieceID_textbox.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(117, 527);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 46);
            this.label8.TabIndex = 15;
            this.label8.Text = "Piece ID:";
            // 
            // sellBtn
            // 
            this.sellBtn.Location = new System.Drawing.Point(21, 716);
            this.sellBtn.Name = "sellBtn";
            this.sellBtn.Size = new System.Drawing.Size(298, 96);
            this.sellBtn.TabIndex = 19;
            this.sellBtn.Text = "Sell";
            this.sellBtn.UseVisualStyleBackColor = true;
            this.sellBtn.Click += new System.EventHandler(this.sellBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(491, 779);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(298, 96);
            this.cancelBtn.TabIndex = 20;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(21, 853);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(298, 96);
            this.update_btn.TabIndex = 21;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // sellForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 979);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.sellBtn);
            this.Controls.Add(this.estimate_textbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pieceID_textbox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.displayBtn);
            this.Controls.Add(this.richTextBox1);
            this.Name = "sellForm";
            this.Text = "sellForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button displayBtn;
        private System.Windows.Forms.TextBox estimate_textbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox pieceID_textbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button sellBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button update_btn;
    }
}