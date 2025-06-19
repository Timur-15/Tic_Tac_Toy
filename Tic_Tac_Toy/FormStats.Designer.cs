
namespace Tic_Tac_Toy
{
    partial class FormStats
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
            this.listBoxWinners = new System.Windows.Forms.ListBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxWinners
            // 
            this.listBoxWinners.FormattingEnabled = true;
            this.listBoxWinners.Location = new System.Drawing.Point(36, 12);
            this.listBoxWinners.Name = "listBoxWinners";
            this.listBoxWinners.Size = new System.Drawing.Size(289, 277);
            this.listBoxWinners.TabIndex = 0;
            this.listBoxWinners.SelectedIndexChanged += new System.EventHandler(this.listBoxWinners_SelectedIndexChanged);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Maroon;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose.Location = new System.Drawing.Point(116, 312);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(132, 35);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "ЗАКРЫТЬ";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // FormStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(392, 354);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.listBoxWinners);
            this.Name = "FormStats";
            this.Text = "Статистика";
            this.Load += new System.EventHandler(this.FormStats_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxWinners;
        private System.Windows.Forms.Button buttonClose;
    }
}