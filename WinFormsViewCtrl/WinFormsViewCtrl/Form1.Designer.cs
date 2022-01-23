
namespace WinFormsViewCtrl
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.btnViewA = new System.Windows.Forms.Button();
            this.btnViewB = new System.Windows.Forms.Button();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnViewB);
            this.pnlMenu.Controls.Add(this.btnViewA);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(120, 450);
            this.pnlMenu.TabIndex = 0;
            // 
            // pnlContent
            // 
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(120, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(680, 450);
            this.pnlContent.TabIndex = 1;
            // 
            // btnViewA
            // 
            this.btnViewA.Location = new System.Drawing.Point(5, 12);
            this.btnViewA.Name = "btnViewA";
            this.btnViewA.Size = new System.Drawing.Size(110, 23);
            this.btnViewA.TabIndex = 0;
            this.btnViewA.Text = "View A";
            this.btnViewA.UseVisualStyleBackColor = true;
            // 
            // btnViewB
            // 
            this.btnViewB.Location = new System.Drawing.Point(5, 41);
            this.btnViewB.Name = "btnViewB";
            this.btnViewB.Size = new System.Drawing.Size(110, 23);
            this.btnViewB.TabIndex = 1;
            this.btnViewB.Text = "View B";
            this.btnViewB.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlMenu);
            this.Name = "Form1";
            this.Text = "View controller";
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnViewB;
        private System.Windows.Forms.Button btnViewA;
        private System.Windows.Forms.Panel pnlContent;
    }
}

