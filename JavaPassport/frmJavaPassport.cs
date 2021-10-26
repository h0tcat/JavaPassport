using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security;

namespace JavaPassport
{
    public partial class frmJavaPassport : Form
    {

        private FolderBrowserDialog directoryDialog;
        public frmJavaPassport()
        {
            InitializeComponent();
            directoryDialog = new FolderBrowserDialog();
        }
        private void btnGetJavacPath_Click(object sender, EventArgs e)
        {
            
            directoryDialog.Description = "javac.exeのあるディレクトリを選択してください";
            
            if(directoryDialog.ShowDialog(this) == DialogResult.OK)
            {
                if (Directory.Exists(directoryDialog.SelectedPath))
                {
                    txtJavacPath.Text = directoryDialog.SelectedPath;
                }
                else
                {
                    MessageBox.Show(
                        "読み込み失敗しました。次の理由が考えられます。\n\n・ディレクトリが存在しない。",
                        "読み取りエラー",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }

        }

        private void txtJavacPath_TextChanged(object sender, EventArgs e)
        {
            if(txtJavacPath.Text == "")
            {
                btnPatchJavaPath.Enabled = false;
            }
            else
            {
                btnPatchJavaPath.Enabled = true;
            }
        }

        private void btnPatchJavaPath_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(directoryDialog.SelectedPath))
            {
                try
                {

                    var pathScope = EnvironmentVariableTarget.Machine;
                    string oldPath = Environment.GetEnvironmentVariable("Path", pathScope);
                    Environment.SetEnvironmentVariable(
                        "Path",
                        oldPath + $";{txtJavacPath.Text}",
                        pathScope);

                    MessageBox.Show(
                        "PATHを適用しました。",
                        "成功",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    lblFinish.Visible = true;
                }
                catch (SecurityException)
                {
                    MessageBox.Show(
                        "PATHの適用に失敗しました。次の理由が考えられます。\n\nこのソフトを管理者権限でしていない。",
                        "エラー",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(
                    "読み込み失敗しました。次の理由が考えられます。\n\n・ディレクトリが存在しない。",
                    "読み取りエラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
