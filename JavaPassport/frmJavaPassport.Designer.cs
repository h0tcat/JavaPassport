
namespace JavaPassport
{
    partial class frmJavaPassport
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtJavacPath = new System.Windows.Forms.TextBox();
            this.btnGetJavacPath = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPatchJavaPath = new System.Windows.Forms.Button();
            this.lblFinish = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "1. javac.exeのある場所(ディレクトリ)を入力してください";
            // 
            // txtJavacPath
            // 
            this.txtJavacPath.Location = new System.Drawing.Point(221, 41);
            this.txtJavacPath.Name = "txtJavacPath";
            this.txtJavacPath.Size = new System.Drawing.Size(239, 22);
            this.txtJavacPath.TabIndex = 1;
            this.txtJavacPath.TextChanged += new System.EventHandler(this.txtJavacPath_TextChanged);
            // 
            // btnGetJavacPath
            // 
            this.btnGetJavacPath.Location = new System.Drawing.Point(466, 41);
            this.btnGetJavacPath.Name = "btnGetJavacPath";
            this.btnGetJavacPath.Size = new System.Drawing.Size(75, 23);
            this.btnGetJavacPath.TabIndex = 2;
            this.btnGetJavacPath.Text = "参照";
            this.btnGetJavacPath.UseVisualStyleBackColor = true;
            this.btnGetJavacPath.Click += new System.EventHandler(this.btnGetJavacPath_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "2.「javacを使えるようにする」ボタンを押します。";
            // 
            // btnPatchJavaPath
            // 
            this.btnPatchJavaPath.Enabled = false;
            this.btnPatchJavaPath.Location = new System.Drawing.Point(221, 118);
            this.btnPatchJavaPath.Name = "btnPatchJavaPath";
            this.btnPatchJavaPath.Size = new System.Drawing.Size(320, 77);
            this.btnPatchJavaPath.TabIndex = 4;
            this.btnPatchJavaPath.Text = "javacを使えるようにする";
            this.btnPatchJavaPath.UseVisualStyleBackColor = true;
            this.btnPatchJavaPath.Click += new System.EventHandler(this.btnPatchJavaPath_Click);
            // 
            // lblFinish
            // 
            this.lblFinish.AutoSize = true;
            this.lblFinish.Location = new System.Drawing.Point(218, 262);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(326, 15);
            this.lblFinish.TabIndex = 7;
            this.lblFinish.Text = "後は各自で動作確認をして終了です。お疲れ様でした";
            this.lblFinish.Visible = false;
            // 
            // frmJavaPassport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFinish);
            this.Controls.Add(this.btnPatchJavaPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGetJavacPath);
            this.Controls.Add(this.txtJavacPath);
            this.Controls.Add(this.label1);
            this.Name = "frmJavaPassport";
            this.Text = "JavaPassport(環境変数適用ツール)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtJavacPath;
        private System.Windows.Forms.Button btnGetJavacPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPatchJavaPath;
        private System.Windows.Forms.Label lblFinish;
    }
}

