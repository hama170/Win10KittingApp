using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Win10KittingAppWinForm.ViewModel
{
    public class MainViewModel
    {
        /// <summary>
        /// レジストリファイルの実行
        /// </summary>
        public void RegEdit()
        {
            string ProgramName = "regedit.exe";
            string RegFileName = "/s key2.reg";

            Process regeditProcess = Process.Start(ProgramName, RegFileName);
            regeditProcess.WaitForExit();
        }
        /// <summary>
        /// Adminユーザー作成バッチ起動
        /// </summary>
        public void MakeAdminUser(string adminPassword)
        {
            
            Process p = new Process();

            p.StartInfo.FileName = "Test.bat";
            p.StartInfo.Arguments = adminPassword;
            p.StartInfo.Verb = "RunAs"; //管理者として実行

            //p.Start();

        }
        /// <summary>
        /// DriveFileStreamのインストール
        /// </summary>
        public void FileStreamInstall()
        {
            //管理者として自分自身を起動
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.UseShellExecute = true;
            //バッチのパスを設定
            //psi.FileName = @"C:\Users\mikan\source\repos\Win10KittingApp\GoogleDriveFSSetup.exe";
            //psi.FileName = @"C:\Users\mikan\source\repos\Win10KittingApp\FileStreamInstall.bat";
            string exeLocation = System.Reflection.Assembly.GetEntryAssembly().Location;
            string exeDirectoryName = Path.GetDirectoryName(exeLocation);
            psi.FileName = "FileStreamInstall.bat";
            psi.WorkingDirectory = exeDirectoryName;
            //動詞に「runas」をつける
            psi.Verb = "runas";

            try
            {
                Process.Start(psi);
            }
            catch (System.ComponentModel.Win32Exception ex)
            {
                //「ユーザーアカウント制御」ダイアログでキャンセルされたなどによって
                //起動できなかった時
                MessageBox.Show("起動しませんでした: " + ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERR: " + ex.Message);
            }
        }


    }
}
