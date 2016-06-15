namespace Zadanie_str_390__Go_Fish__
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
            this.textName = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.listHand = new System.Windows.Forms.ListBox();
            this.textProgress = new System.Windows.Forms.TextBox();
            this.buttonRequest = new System.Windows.Forms.Button();
            this.textGroups = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelHand = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(30, 28);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(117, 20);
            this.textName.TabIndex = 0;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(153, 26);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(89, 23);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Rozpocznij grę!";
            this.buttonStart.UseVisualStyleBackColor = true;
            // 
            // listHand
            // 
            this.listHand.FormattingEnabled = true;
            this.listHand.Location = new System.Drawing.Point(258, 41);
            this.listHand.Name = "listHand";
            this.listHand.Size = new System.Drawing.Size(190, 394);
            this.listHand.TabIndex = 2;
            // 
            // textProgress
            // 
            this.textProgress.Location = new System.Drawing.Point(31, 77);
            this.textProgress.Multiline = true;
            this.textProgress.Name = "textProgress";
            this.textProgress.ReadOnly = true;
            this.textProgress.Size = new System.Drawing.Size(211, 263);
            this.textProgress.TabIndex = 3;
            // 
            // buttonRequest
            // 
            this.buttonRequest.Enabled = false;
            this.buttonRequest.Location = new System.Drawing.Point(258, 467);
            this.buttonRequest.Name = "buttonRequest";
            this.buttonRequest.Size = new System.Drawing.Size(190, 32);
            this.buttonRequest.TabIndex = 4;
            this.buttonRequest.Text = "Żądaj karty";
            this.buttonRequest.UseVisualStyleBackColor = true;
            // 
            // textGroups
            // 
            this.textGroups.Location = new System.Drawing.Point(30, 375);
            this.textGroups.Multiline = true;
            this.textGroups.Name = "textGroups";
            this.textGroups.ReadOnly = true;
            this.textGroups.Size = new System.Drawing.Size(210, 124);
            this.textGroups.TabIndex = 5;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(32, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(63, 13);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "Imię Gracza";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Postępy Gry";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Zestawy";
            // 
            // labelHand
            // 
            this.labelHand.AutoSize = true;
            this.labelHand.Location = new System.Drawing.Point(255, 9);
            this.labelHand.Name = "labelHand";
            this.labelHand.Size = new System.Drawing.Size(70, 13);
            this.labelHand.TabIndex = 9;
            this.labelHand.Text = "Ręka Gracza";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 511);
            this.Controls.Add(this.labelHand);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textGroups);
            this.Controls.Add(this.buttonRequest);
            this.Controls.Add(this.textProgress);
            this.Controls.Add(this.listHand);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textName);
            this.Name = "Form1";
            this.Text = "Go Fish!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.ListBox listHand;
        private System.Windows.Forms.TextBox textProgress;
        private System.Windows.Forms.Button buttonRequest;
        private System.Windows.Forms.TextBox textGroups;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelHand;
    }
}

