
namespace GetModifiedFilesGUI
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBox_Option = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker_Date = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker_Time = new System.Windows.Forms.DateTimePicker();
            this.folderBrowserDialog_Source = new System.Windows.Forms.FolderBrowserDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_SourcePath = new System.Windows.Forms.TextBox();
            this.button_Source = new System.Windows.Forms.Button();
            this.button_Destination = new System.Windows.Forms.Button();
            this.textBox_DestinationPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.folderBrowserDialog_Destination = new System.Windows.Forms.FolderBrowserDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_ExcludeFolder = new System.Windows.Forms.TextBox();
            this.textBox_ExcludeExtension = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_Execute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_Option
            // 
            this.comboBox_Option.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox_Option.FormattingEnabled = true;
            this.comboBox_Option.Location = new System.Drawing.Point(152, 14);
            this.comboBox_Option.Name = "comboBox_Option";
            this.comboBox_Option.Size = new System.Drawing.Size(306, 37);
            this.comboBox_Option.TabIndex = 0;
            this.comboBox_Option.SelectedIndexChanged += new System.EventHandler(this.comboBox_Option_Change);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "選擇情境";
            // 
            // dateTimePicker_Date
            // 
            this.dateTimePicker_Date.CalendarFont = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePicker_Date.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePicker_Date.Location = new System.Drawing.Point(18, 276);
            this.dateTimePicker_Date.Name = "dateTimePicker_Date";
            this.dateTimePicker_Date.Size = new System.Drawing.Size(188, 31);
            this.dateTimePicker_Date.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "取出此時間後的檔案";
            // 
            // dateTimePicker_Time
            // 
            this.dateTimePicker_Time.CalendarFont = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePicker_Time.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePicker_Time.Location = new System.Drawing.Point(224, 276);
            this.dateTimePicker_Time.Name = "dateTimePicker_Time";
            this.dateTimePicker_Time.Size = new System.Drawing.Size(188, 31);
            this.dateTimePicker_Time.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 35);
            this.label3.TabIndex = 5;
            this.label3.Text = "選擇來源路徑";
            // 
            // textBox_SourcePath
            // 
            this.textBox_SourcePath.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SourcePath.Location = new System.Drawing.Point(18, 106);
            this.textBox_SourcePath.Name = "textBox_SourcePath";
            this.textBox_SourcePath.Size = new System.Drawing.Size(564, 31);
            this.textBox_SourcePath.TabIndex = 6;
            // 
            // button_Source
            // 
            this.button_Source.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Source.Location = new System.Drawing.Point(213, 64);
            this.button_Source.Name = "button_Source";
            this.button_Source.Size = new System.Drawing.Size(101, 36);
            this.button_Source.TabIndex = 7;
            this.button_Source.Text = "瀏覽";
            this.button_Source.UseVisualStyleBackColor = true;
            this.button_Source.Click += new System.EventHandler(this.button_Source_Click);
            // 
            // button_Destination
            // 
            this.button_Destination.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Destination.Location = new System.Drawing.Point(213, 155);
            this.button_Destination.Name = "button_Destination";
            this.button_Destination.Size = new System.Drawing.Size(101, 36);
            this.button_Destination.TabIndex = 10;
            this.button_Destination.Text = "瀏覽";
            this.button_Destination.UseVisualStyleBackColor = true;
            this.button_Destination.Click += new System.EventHandler(this.button_Destination_Click);
            // 
            // textBox_DestinationPath
            // 
            this.textBox_DestinationPath.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_DestinationPath.Location = new System.Drawing.Point(18, 197);
            this.textBox_DestinationPath.Name = "textBox_DestinationPath";
            this.textBox_DestinationPath.Size = new System.Drawing.Size(564, 31);
            this.textBox_DestinationPath.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 35);
            this.label4.TabIndex = 8;
            this.label4.Text = "選擇目的路徑";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 35);
            this.label5.TabIndex = 11;
            this.label5.Text = "排除的資料夾";
            // 
            // textBox_ExcludeFolder
            // 
            this.textBox_ExcludeFolder.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ExcludeFolder.Location = new System.Drawing.Point(19, 368);
            this.textBox_ExcludeFolder.Name = "textBox_ExcludeFolder";
            this.textBox_ExcludeFolder.Size = new System.Drawing.Size(564, 31);
            this.textBox_ExcludeFolder.TabIndex = 12;
            // 
            // textBox_ExcludeExtension
            // 
            this.textBox_ExcludeExtension.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ExcludeExtension.Location = new System.Drawing.Point(19, 458);
            this.textBox_ExcludeExtension.Name = "textBox_ExcludeExtension";
            this.textBox_ExcludeExtension.Size = new System.Drawing.Size(564, 31);
            this.textBox_ExcludeExtension.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 420);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 35);
            this.label6.TabIndex = 13;
            this.label6.Text = "排除的副檔名";
            // 
            // button_Execute
            // 
            this.button_Execute.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Execute.Location = new System.Drawing.Point(481, 15);
            this.button_Execute.Name = "button_Execute";
            this.button_Execute.Size = new System.Drawing.Size(101, 36);
            this.button_Execute.TabIndex = 15;
            this.button_Execute.Text = "執行";
            this.button_Execute.UseVisualStyleBackColor = true;
            this.button_Execute.Click += new System.EventHandler(this.button_Execute_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 499);
            this.Controls.Add(this.button_Execute);
            this.Controls.Add(this.textBox_ExcludeExtension);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_ExcludeFolder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_Destination);
            this.Controls.Add(this.textBox_DestinationPath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_Source);
            this.Controls.Add(this.textBox_SourcePath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker_Time);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker_Date);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Option);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "GetModifiedFilesGUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Option;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Time;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_Source;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_SourcePath;
        private System.Windows.Forms.Button button_Source;
        private System.Windows.Forms.Button button_Destination;
        private System.Windows.Forms.TextBox textBox_DestinationPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_Destination;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_ExcludeFolder;
        private System.Windows.Forms.TextBox textBox_ExcludeExtension;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_Execute;
    }
}

