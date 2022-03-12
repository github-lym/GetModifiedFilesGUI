using IniFiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetModifiedFilesGUI
{
    public partial class Form1 : Form
    {
        IniFile ini = new IniFile("settings.ini");
        string noData = "j5W!";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_Option.Items.Add("無");
            comboBox_Option.SelectedItem = "無";

            //取得已有情境
            string ini_opt = ini.ReadString("Option", "Value");
            string[] opts = ini_opt.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            if (opts.Length > 0)
                foreach (var item in opts)
                    comboBox_Option.Items.Add(item);

            //dateTimePicker_Date.ShowUpDown = true;
            dateTimePicker_Time.Format = DateTimePickerFormat.Time;
            dateTimePicker_Time.ShowUpDown = true;
        }

        #region 選取路徑
        private void button_Source_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog_Source.ShowDialog() == DialogResult.OK)
            {
                textBox_SourcePath.Text = folderBrowserDialog_Source.SelectedPath;
            }
        }

        private void button_Destination_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog_Destination.ShowDialog() == DialogResult.OK)
            {
                textBox_DestinationPath.Text = folderBrowserDialog_Destination.SelectedPath;
            }
        }
        #endregion

        #region 重新設定介面
        private void ResetForm()
        {
            comboBox_Option.SelectedItem = "無";
            textBox_SourcePath.Text = string.Empty;
            textBox_DestinationPath.Text = string.Empty;
            textBox_ExcludeFolder.Text = string.Empty;
            textBox_ExcludeExtension.Text = string.Empty;
            dateTimePicker_Date.Value = DateTime.Now;
            dateTimePicker_Time.Value = DateTime.Now;
        }
        #endregion

        #region 情境下拉選單變更 (comboBox_Option)
        private void comboBox_Option_Change(object sender, EventArgs e)
        {
            string opt_string = comboBox_Option.Text;
            if (string.IsNullOrWhiteSpace(opt_string) || "無".Equals(opt_string))
                ResetForm();
            else
            {
                string[] opt_keys = ini.ReadKeyNames(opt_string);
                string[] opt_values = ini.ReadSectionValue(opt_string);
                Dictionary<string, string> opt_KeyValues = new Dictionary<string, string>();
                for (int i = 0; i < opt_keys.Length; i++)
                    opt_KeyValues.Add(opt_keys[i], opt_values[i]);

                if (opt_KeyValues.Keys.Contains("source_path"))
                    textBox_SourcePath.Text = opt_KeyValues["source_path"];
                if (opt_KeyValues.Keys.Contains("source_path"))
                    textBox_DestinationPath.Text = opt_KeyValues["destination_path"];
                if (opt_KeyValues.Keys.Contains("source_path"))
                    textBox_ExcludeFolder.Text = opt_KeyValues["exclude_folder"];
                if (opt_KeyValues.Keys.Contains("source_path"))
                    textBox_ExcludeExtension.Text = opt_KeyValues["exclude_extension"];

                string ddd = string.Empty;
            }
        }
        #endregion

        private void button_Execute_Click(object sender, EventArgs e)
        {
            try
            {
                //取得來源目的資料夾
                string fromPath = textBox_SourcePath.Text.Trim();
                string toPath = textBox_DestinationPath.Text.Trim();
                if(string.IsNullOrWhiteSpace(fromPath) || string.IsNullOrWhiteSpace(toPath))
                {
                    MessageBox.Show("Err:來源目標路徑不得為空");
                    return;
                }
                if (fromPath.Equals(toPath))
                {
                    MessageBox.Show("Err:來源目標路徑不得相同");
                    return;
                }

                //取得排除資料夾
                string exDir = textBox_ExcludeFolder.Text.Trim();
                string[] exDirArray;
                if (!string.IsNullOrWhiteSpace(exDir))
                    exDirArray = exDir.ToLower().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                else
                    exDirArray = new string[1] { noData };

                //取得排除副檔名
                string exFiles = textBox_ExcludeExtension.Text.Trim();
                string[] exFilesArray;
                if (!string.IsNullOrWhiteSpace(exFiles))
                    exFilesArray = exFiles.ToLower().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                else
                    exFilesArray = new string[1] { noData };

                //取得檔案存取的時間
                DateTime mTime = dateTimePicker_Time.Value;
                DateTime mDate = dateTimePicker_Date.Value.Date.AddHours(mTime.Hour).AddMinutes(mTime.Minute).AddSeconds(mTime.Second);
                //string mDt = dateTimePicker_Date.Value;
                //DateTime mDate;
                //if (!string.IsNullOrWhiteSpace(mDt))
                //    mDate = DateTime.ParseExact(mDt, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
                //else
                //    mDate = DateTime.ParseExact("1900-01-01 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);

                //目標資料夾不存在就產生
                if (!Directory.Exists(toPath))
                    Directory.CreateDirectory(toPath);

                //開始找底下包含子目錄所有檔案
                foreach (string file in Directory.EnumerateFiles(fromPath, "*.*", SearchOption.AllDirectories))
                {
                    bool ex = false;
                    string _file = file.ToLower();

                    //排除的副檔名
                    foreach (var item in exFilesArray)
                    {
                        if (_file.EndsWith(item))
                        {
                            ex = true;
                            break;
                        }
                    }
                    if (ex)
                        continue;

                    //存取時間
                    if (File.GetLastWriteTime(file) < mDate)
                        continue;

                    //檢查路徑上所有資料夾  若有排除的資料夾就跳出
                    string fromSubPath = Path.GetDirectoryName(file).Replace(fromPath, "").ToLower();
                    if (!string.IsNullOrWhiteSpace(fromSubPath))
                    {
                        string[] splitFromSubPath = fromSubPath.Split(new char[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);
                        if (splitFromSubPath.Length > 0)
                            foreach (var item in splitFromSubPath)
                            {
                                if (exDirArray.Contains(item))
                                {
                                    ex = true;
                                    break;
                                }
                            }
                    }
                    if (ex)
                        continue;

                    //在目的資料夾要架構相同
                    string toFullPath = file.Replace(fromPath, toPath);
                    string subFolder = Path.GetDirectoryName(toFullPath);
                    //DirectoryInfo info = )
                    //if (exDirArray.Contains(new DirectoryInfo(subFolder).Name.ToLower()))
                    //    continue;

                    //目標資料夾不存在就產生
                    if (!Directory.Exists(subFolder))
                        Directory.CreateDirectory(subFolder);

                    //copy overwrite
                    File.Copy(file, toFullPath, true);
                }

                MessageBox.Show("完成！!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }
    }
}
