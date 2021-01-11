using System;
using System.Windows.Forms;
using Win10KittingAppWinForm.ViewModel;

namespace Win10KittingAppWinForm
{
    public partial class MainView : Form
    {
        MainViewModel _viewModel = new MainViewModel();
        public MainView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AdminPasswordTextBox.Text == "")
            {
                MessageBox.Show("Adminパスワードが未入力です。");
                return;
            }
            //メッセージボックスを表示する
            DialogResult result = MessageBox.Show("処理を実行しますか",
                "質問",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                //regファイル実行
                _viewModel.RegEdit();

                //Adminユーザー作成
                _viewModel.MakeAdminUser(AdminPasswordTextBox.Text);

                //DriveFileStreamインストール
                _viewModel.FileStreamInstall();
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("中止しました");
            }

        }
    }
}
