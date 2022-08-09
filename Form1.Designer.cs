namespace AzureADConnect
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtUsers = new System.Windows.Forms.TextBox();
            this.btnGetGroups = new System.Windows.Forms.Button();
            this.txtGroups = new System.Windows.Forms.TextBox();
            this.txtGroupname = new System.Windows.Forms.TextBox();
            this.lblUSer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsersinGroup = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(82, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Get Token and Groups";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtUsers
            // 
            this.txtUsers.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtUsers.ForeColor = System.Drawing.Color.Lime;
            this.txtUsers.Location = new System.Drawing.Point(3, 180);
            this.txtUsers.Multiline = true;
            this.txtUsers.Name = "txtUsers";
            this.txtUsers.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtUsers.Size = new System.Drawing.Size(479, 339);
            this.txtUsers.TabIndex = 1;
            // 
            // btnGetGroups
            // 
            this.btnGetGroups.Location = new System.Drawing.Point(1123, 79);
            this.btnGetGroups.Name = "btnGetGroups";
            this.btnGetGroups.Size = new System.Drawing.Size(87, 33);
            this.btnGetGroups.TabIndex = 2;
            this.btnGetGroups.Text = "Find User in group";
            this.btnGetGroups.UseVisualStyleBackColor = true;
            this.btnGetGroups.Click += new System.EventHandler(this.btnGetGroups_Click);
            // 
            // txtGroups
            // 
            this.txtGroups.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtGroups.ForeColor = System.Drawing.Color.Lime;
            this.txtGroups.Location = new System.Drawing.Point(488, 180);
            this.txtGroups.Multiline = true;
            this.txtGroups.Name = "txtGroups";
            this.txtGroups.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtGroups.Size = new System.Drawing.Size(469, 339);
            this.txtGroups.TabIndex = 3;
            // 
            // txtGroupname
            // 
            this.txtGroupname.Location = new System.Drawing.Point(1067, 123);
            this.txtGroupname.Name = "txtGroupname";
            this.txtGroupname.Size = new System.Drawing.Size(284, 22);
            this.txtGroupname.TabIndex = 4;
            // 
            // lblUSer
            // 
            this.lblUSer.AutoSize = true;
            this.lblUSer.Location = new System.Drawing.Point(972, 128);
            this.lblUSer.Name = "lblUSer";
            this.lblUSer.Size = new System.Drawing.Size(89, 17);
            this.lblUSer.TabIndex = 5;
            this.lblUSer.Text = "Group Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Token";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(516, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Groups";
            // 
            // txtUsersinGroup
            // 
            this.txtUsersinGroup.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtUsersinGroup.ForeColor = System.Drawing.Color.Lime;
            this.txtUsersinGroup.Location = new System.Drawing.Point(963, 180);
            this.txtUsersinGroup.Multiline = true;
            this.txtUsersinGroup.Name = "txtUsersinGroup";
            this.txtUsersinGroup.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtUsersinGroup.Size = new System.Drawing.Size(469, 339);
            this.txtUsersinGroup.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1473, 567);
            this.Controls.Add(this.txtUsersinGroup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUSer);
            this.Controls.Add(this.txtGroupname);
            this.Controls.Add(this.txtGroups);
            this.Controls.Add(this.btnGetGroups);
            this.Controls.Add(this.txtUsers);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtUsers;
        private System.Windows.Forms.Button btnGetGroups;
        private System.Windows.Forms.TextBox txtGroups;
        private System.Windows.Forms.TextBox txtGroupname;
        private System.Windows.Forms.Label lblUSer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsersinGroup;
    }
}

