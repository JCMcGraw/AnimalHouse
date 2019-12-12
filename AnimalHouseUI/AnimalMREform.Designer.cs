namespace AnimalHouseUI
{
    partial class AnimalMREform
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
            this.animal_mrEntry = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // animal_mrEntry
            // 
            this.animal_mrEntry.Location = new System.Drawing.Point(12, 12);
            this.animal_mrEntry.Multiline = true;
            this.animal_mrEntry.Name = "animal_mrEntry";
            this.animal_mrEntry.ReadOnly = true;
            this.animal_mrEntry.Size = new System.Drawing.Size(387, 287);
            this.animal_mrEntry.TabIndex = 0;
            // 
            // AnimalMREform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 311);
            this.Controls.Add(this.animal_mrEntry);
            this.Name = "AnimalMREform";
            this.Text = "AnimalMedicalRecordEntry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox animal_mrEntry;
    }
}