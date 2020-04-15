namespace V2Speak {
    partial class Main {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.speakContent = new System.Windows.Forms.TextBox();
            this.speakButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // speakContent
            // 
            this.speakContent.AcceptsReturn = true;
            this.speakContent.Location = new System.Drawing.Point(12, 12);
            this.speakContent.Multiline = true;
            this.speakContent.Name = "speakContent";
            this.speakContent.Size = new System.Drawing.Size(776, 397);
            this.speakContent.TabIndex = 0;
            // 
            // speakButton
            // 
            this.speakButton.Location = new System.Drawing.Point(12, 415);
            this.speakButton.Name = "speakButton";
            this.speakButton.Size = new System.Drawing.Size(776, 23);
            this.speakButton.TabIndex = 1;
            this.speakButton.Text = "Speak";
            this.speakButton.UseVisualStyleBackColor = true;
            this.speakButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.speakButton);
            this.Controls.Add(this.speakContent);
            this.Name = "Main";
            this.Text = "V2Speak";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox speakContent;
        private System.Windows.Forms.Button speakButton;
    }
}

