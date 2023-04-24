using System.Linq;

namespace FreelanceTask1
{
    partial class DataEntry
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.ageTxt = new System.Windows.Forms.TextBox();
            this.phoneTxt = new System.Windows.Forms.TextBox();
            this.nameError = new System.Windows.Forms.Label();
            this.ageError = new System.Windows.Forms.Label();
            this.phoneError = new System.Windows.Forms.Label();
            this.governateBox = new System.Windows.Forms.ComboBox();
            this.cityBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(116, 128);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(100, 22);
            this.nameTxt.TabIndex = 0;
            this.nameTxt.TextChanged += new System.EventHandler(this.nameTxt_TextChanged);
            // 
            // ageTxt
            // 
            this.ageTxt.Location = new System.Drawing.Point(116, 219);
            this.ageTxt.MaxLength = 2;
            this.ageTxt.Name = "ageTxt";
            this.ageTxt.Size = new System.Drawing.Size(100, 22);
            this.ageTxt.TabIndex = 1;
            this.ageTxt.TextChanged += new System.EventHandler(this.ageTxt_TextChanged);
            // 
            // phoneTxt
            // 
            this.phoneTxt.Location = new System.Drawing.Point(116, 312);
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(100, 22);
            this.phoneTxt.TabIndex = 2;
            this.phoneTxt.TextChanged += new System.EventHandler(this.phoneTxt_TextChanged);
            // 
            // nameError
            // 
            this.nameError.AutoSize = true;
            this.nameError.Location = new System.Drawing.Point(251, 131);
            this.nameError.Name = "nameError";
            this.nameError.Size = new System.Drawing.Size(44, 16);
            this.nameError.TabIndex = 3;
            this.nameError.Text = "label1";
            this.nameError.Visible = false;
            // 
            // ageError
            // 
            this.ageError.AutoSize = true;
            this.ageError.Location = new System.Drawing.Point(251, 222);
            this.ageError.Name = "ageError";
            this.ageError.Size = new System.Drawing.Size(44, 16);
            this.ageError.TabIndex = 4;
            this.ageError.Text = "label1";
            this.ageError.Visible = false;
            // 
            // phoneError
            // 
            this.phoneError.AutoSize = true;
            this.phoneError.Location = new System.Drawing.Point(251, 315);
            this.phoneError.Name = "phoneError";
            this.phoneError.Size = new System.Drawing.Size(44, 16);
            this.phoneError.TabIndex = 5;
            this.phoneError.Text = "label1";
            this.phoneError.Visible = false;
            // 
            // governateBox
            // 
            this.governateBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.governateBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.governateBox.FormattingEnabled = true;
            this.governateBox.Location = new System.Drawing.Point(500, 122);
            this.governateBox.Name = "governateBox";
            this.governateBox.Size = new System.Drawing.Size(121, 24);
            this.governateBox.TabIndex = 6;
            this.governateBox.SelectedIndexChanged += new System.EventHandler(this.governateBox_SelectedIndexChanged);
            // 
            // cityBox
            // 
            this.cityBox.FormattingEnabled = true;
            this.cityBox.Location = new System.Drawing.Point(500, 222);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(121, 24);
            this.cityBox.TabIndex = 7;
            // 
            // DataEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cityBox);
            this.Controls.Add(this.governateBox);
            this.Controls.Add(this.phoneError);
            this.Controls.Add(this.ageError);
            this.Controls.Add(this.nameError);
            this.Controls.Add(this.phoneTxt);
            this.Controls.Add(this.ageTxt);
            this.Controls.Add(this.nameTxt);
            this.Name = "DataEntry";
            this.Size = new System.Drawing.Size(706, 448);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox ageTxt;
        private System.Windows.Forms.TextBox phoneTxt;
        private System.Windows.Forms.Label nameError;
        private System.Windows.Forms.Label ageError;
        private System.Windows.Forms.Label phoneError;
        private System.Windows.Forms.ComboBox governateBox;
        private System.Windows.Forms.ComboBox cityBox;
    }
}
