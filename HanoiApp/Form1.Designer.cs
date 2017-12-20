namespace HanoiApp
{
    partial class TowerOfHanoiForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.Executionbutton = new System.Windows.Forms.Button();
            this.ResultrichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Executionbutton
            // 
            this.Executionbutton.Location = new System.Drawing.Point(197, 227);
            this.Executionbutton.Name = "Executionbutton";
            this.Executionbutton.Size = new System.Drawing.Size(75, 23);
            this.Executionbutton.TabIndex = 0;
            this.Executionbutton.Text = "実行";
            this.Executionbutton.UseVisualStyleBackColor = true;
            this.Executionbutton.Click += new System.EventHandler(this.Executionbutton_Click);
            // 
            // ResultrichTextBox
            // 
            this.ResultrichTextBox.Location = new System.Drawing.Point(13, 13);
            this.ResultrichTextBox.Name = "ResultrichTextBox";
            this.ResultrichTextBox.ReadOnly = true;
            this.ResultrichTextBox.Size = new System.Drawing.Size(259, 208);
            this.ResultrichTextBox.TabIndex = 1;
            this.ResultrichTextBox.Text = "";
            // 
            // TowerOfHanoiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.ResultrichTextBox);
            this.Controls.Add(this.Executionbutton);
            this.Name = "TowerOfHanoiForm";
            this.Text = "ハノイの塔";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Executionbutton;
        private System.Windows.Forms.RichTextBox ResultrichTextBox;
    }
}

