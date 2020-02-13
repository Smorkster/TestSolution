namespace TestRichTextboxHighlighting
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
			this.scintilla1 = new ScintillaNET.Scintilla();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(460, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "label1";
			// 
			// scintilla1
			// 
			this.scintilla1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.scintilla1.HScrollBar = false;
			this.scintilla1.Location = new System.Drawing.Point(12, 12);
			this.scintilla1.Name = "scintilla1";
			this.scintilla1.PhasesDraw = ScintillaNET.Phases.Multiple;
			this.scintilla1.Size = new System.Drawing.Size(390, 426);
			this.scintilla1.TabIndex = 2;
			this.scintilla1.Text = "scintilla1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(571, 450);
			this.Controls.Add(this.scintilla1);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion

		public System.Windows.Forms.Label label1;
		private ScintillaNET.Scintilla scintilla1;
	}
}

