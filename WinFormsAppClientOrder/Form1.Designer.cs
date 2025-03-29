namespace WinFormsAppClientOrder
{
    partial class FormBinding
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			btnInsert = new Button();
			btnLoad = new Button();
			btnGridView = new Button();
			dgv = new DataGridView();
			((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
			SuspendLayout();
			// 
			// btnInsert
			// 
			btnInsert.Location = new Point(20, 27);
			btnInsert.Name = "btnInsert";
			btnInsert.Size = new Size(94, 29);
			btnInsert.TabIndex = 0;
			btnInsert.Text = "Insert";
			btnInsert.UseVisualStyleBackColor = true;
			btnInsert.Click += btnInsert_Click;
			// 
			// btnLoad
			// 
			btnLoad.Location = new Point(19, 87);
			btnLoad.Name = "btnLoad";
			btnLoad.Size = new Size(94, 29);
			btnLoad.TabIndex = 1;
			btnLoad.Text = "Load";
			btnLoad.UseVisualStyleBackColor = true;
			btnLoad.Click += btnLoad_Click;
			// 
			// btnGridView
			// 
			btnGridView.Location = new Point(24, 145);
			btnGridView.Name = "btnGridView";
			btnGridView.Size = new Size(94, 29);
			btnGridView.TabIndex = 2;
			btnGridView.Text = "View Grid";
			btnGridView.UseVisualStyleBackColor = true;
			btnGridView.Click += btnGridView_Click;
			// 
			// dgv
			// 
			dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgv.Location = new Point(172, 27);
			dgv.Name = "dgv";
			dgv.RowHeadersWidth = 51;
			dgv.Size = new Size(465, 188);
			dgv.TabIndex = 3;
			dgv.CellEndEdit += dgv_CellEndEdit;
			// 
			// FormBinding
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(668, 232);
			Controls.Add(dgv);
			Controls.Add(btnGridView);
			Controls.Add(btnLoad);
			Controls.Add(btnInsert);
			Name = "FormBinding";
			Text = "SampleBinding";
			((System.ComponentModel.ISupportInitialize)dgv).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Button btnInsert;
		private Button btnLoad;
		private Button btnGridView;
		private DataGridView dgv;
	}
}
