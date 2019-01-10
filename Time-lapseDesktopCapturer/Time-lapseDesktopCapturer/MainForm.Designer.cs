namespace Time_lapseDesktopCapturer
{
    partial class MainForm
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
            this.textBoxInterval = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.labelScale = new System.Windows.Forms.Label();
            this.textBoxScale = new System.Windows.Forms.TextBox();
            this.checkBoxAbsoluteSize = new System.Windows.Forms.CheckBox();
            this.panelAbsoluteSize = new System.Windows.Forms.Panel();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.checkBoxFixAspectRatio = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSaveDir = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonStartStop = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxFormat = new System.Windows.Forms.ComboBox();
            this.panelForm = new System.Windows.Forms.Panel();
            this.panelAbsoluteSize.SuspendLayout();
            this.panelForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxInterval
            // 
            this.textBoxInterval.Location = new System.Drawing.Point(88, 0);
            this.textBoxInterval.Name = "textBoxInterval";
            this.textBoxInterval.Size = new System.Drawing.Size(68, 19);
            this.textBoxInterval.TabIndex = 0;
            this.textBoxInterval.Text = "1000";
            this.textBoxInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Interval (ms)";
            // 
            // menu
            // 
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(337, 24);
            this.menu.TabIndex = 2;
            this.menu.Text = "Menu";
            // 
            // labelScale
            // 
            this.labelScale.AutoSize = true;
            this.labelScale.Location = new System.Drawing.Point(3, 24);
            this.labelScale.Name = "labelScale";
            this.labelScale.Size = new System.Drawing.Size(33, 12);
            this.labelScale.TabIndex = 3;
            this.labelScale.Text = "Scale";
            // 
            // textBoxScale
            // 
            this.textBoxScale.Location = new System.Drawing.Point(88, 25);
            this.textBoxScale.Name = "textBoxScale";
            this.textBoxScale.Size = new System.Drawing.Size(68, 19);
            this.textBoxScale.TabIndex = 4;
            this.textBoxScale.Text = "1.0";
            this.textBoxScale.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // checkBoxAbsoluteSize
            // 
            this.checkBoxAbsoluteSize.AutoSize = true;
            this.checkBoxAbsoluteSize.Location = new System.Drawing.Point(5, 46);
            this.checkBoxAbsoluteSize.Name = "checkBoxAbsoluteSize";
            this.checkBoxAbsoluteSize.Size = new System.Drawing.Size(115, 16);
            this.checkBoxAbsoluteSize.TabIndex = 5;
            this.checkBoxAbsoluteSize.Text = "Use absolute size";
            this.checkBoxAbsoluteSize.UseVisualStyleBackColor = true;
            this.checkBoxAbsoluteSize.CheckedChanged += new System.EventHandler(this.CheckBoxAbsoluteSize_CheckedChanged);
            // 
            // panelAbsoluteSize
            // 
            this.panelAbsoluteSize.Controls.Add(this.textBoxHeight);
            this.panelAbsoluteSize.Controls.Add(this.checkBoxFixAspectRatio);
            this.panelAbsoluteSize.Controls.Add(this.label4);
            this.panelAbsoluteSize.Controls.Add(this.textBoxWidth);
            this.panelAbsoluteSize.Controls.Add(this.label3);
            this.panelAbsoluteSize.Enabled = false;
            this.panelAbsoluteSize.Location = new System.Drawing.Point(18, 68);
            this.panelAbsoluteSize.Name = "panelAbsoluteSize";
            this.panelAbsoluteSize.Size = new System.Drawing.Size(138, 73);
            this.panelAbsoluteSize.TabIndex = 6;
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(70, 29);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(67, 19);
            this.textBoxHeight.TabIndex = 9;
            this.textBoxHeight.Text = "1080";
            this.textBoxHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxHeight.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxSize_Changed);
            // 
            // checkBoxFixAspectRatio
            // 
            this.checkBoxFixAspectRatio.AutoSize = true;
            this.checkBoxFixAspectRatio.Checked = true;
            this.checkBoxFixAspectRatio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFixAspectRatio.Location = new System.Drawing.Point(0, 54);
            this.checkBoxFixAspectRatio.Name = "checkBoxFixAspectRatio";
            this.checkBoxFixAspectRatio.Size = new System.Drawing.Size(105, 16);
            this.checkBoxFixAspectRatio.TabIndex = 10;
            this.checkBoxFixAspectRatio.Text = "Fix aspect ratio";
            this.checkBoxFixAspectRatio.UseVisualStyleBackColor = true;
            this.checkBoxFixAspectRatio.CheckedChanged += new System.EventHandler(this.CheckBoxFixAspectRatio_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-2, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "Height";
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(71, 6);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(67, 19);
            this.textBoxWidth.TabIndex = 7;
            this.textBoxWidth.Text = "1920";
            this.textBoxWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxWidth.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxSize_Changed);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-2, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "Width";
            // 
            // textBoxSaveDir
            // 
            this.textBoxSaveDir.Location = new System.Drawing.Point(88, 182);
            this.textBoxSaveDir.Name = "textBoxSaveDir";
            this.textBoxSaveDir.Size = new System.Drawing.Size(133, 19);
            this.textBoxSaveDir.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "Save directory";
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(227, 180);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(63, 23);
            this.buttonBrowse.TabIndex = 9;
            this.buttonBrowse.Text = "Browse...";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.ButtonBrowse_Click);
            // 
            // buttonStartStop
            // 
            this.buttonStartStop.Location = new System.Drawing.Point(21, 253);
            this.buttonStartStop.Name = "buttonStartStop";
            this.buttonStartStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStartStop.TabIndex = 10;
            this.buttonStartStop.Text = "Start";
            this.buttonStartStop.UseVisualStyleBackColor = true;
            this.buttonStartStop.Click += new System.EventHandler(this.ButtonStartStop_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "Save format";
            // 
            // comboBoxFormat
            // 
            this.comboBoxFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFormat.FormattingEnabled = true;
            this.comboBoxFormat.Location = new System.Drawing.Point(88, 150);
            this.comboBoxFormat.Name = "comboBoxFormat";
            this.comboBoxFormat.Size = new System.Drawing.Size(68, 20);
            this.comboBoxFormat.TabIndex = 12;
            // 
            // panelForm
            // 
            this.panelForm.Controls.Add(this.comboBoxFormat);
            this.panelForm.Controls.Add(this.label1);
            this.panelForm.Controls.Add(this.label5);
            this.panelForm.Controls.Add(this.textBoxInterval);
            this.panelForm.Controls.Add(this.labelScale);
            this.panelForm.Controls.Add(this.buttonBrowse);
            this.panelForm.Controls.Add(this.textBoxScale);
            this.panelForm.Controls.Add(this.label2);
            this.panelForm.Controls.Add(this.checkBoxAbsoluteSize);
            this.panelForm.Controls.Add(this.textBoxSaveDir);
            this.panelForm.Controls.Add(this.panelAbsoluteSize);
            this.panelForm.Location = new System.Drawing.Point(21, 41);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(303, 206);
            this.panelForm.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 289);
            this.Controls.Add(this.buttonStartStop);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.panelForm);
            this.MainMenuStrip = this.menu;
            this.Name = "MainForm";
            this.Text = "Time-lapseDesktopCapturer";
            this.panelAbsoluteSize.ResumeLayout(false);
            this.panelAbsoluteSize.PerformLayout();
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInterval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.Label labelScale;
        private System.Windows.Forms.TextBox textBoxScale;
        private System.Windows.Forms.CheckBox checkBoxAbsoluteSize;
        private System.Windows.Forms.Panel panelAbsoluteSize;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.CheckBox checkBoxFixAspectRatio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSaveDir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button buttonStartStop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxFormat;
        private System.Windows.Forms.Panel panelForm;
    }
}

