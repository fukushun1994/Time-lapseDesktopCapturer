using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_lapseDesktopCapturer
{
    public partial class MainForm : Form
    {
        private bool _isRunning;
        private Size _screenSize;
        private Size _absoluteSize;
        private Timer _timer;

        public MainForm()
        {
            InitializeComponent();
            _isRunning = false;
            _screenSize = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            InitializeAbsoluteSize();
            InitializeSaveDirectory();
            AddFormatsToComboBox();
        }

        private void CheckBoxAbsoluteSize_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAbsoluteSize.Checked)
            {
                EnableAbsoluteSize();
            } else
            {
                DisableAbsoluteSize();
            }
        }

        private void AddFormatsToComboBox ()
        {
            comboBoxFormat.Items.Add(ImageFormat.Png);
            comboBoxFormat.Items.Add(ImageFormat.Jpeg);
            comboBoxFormat.Items.Add(ImageFormat.Bmp);
            comboBoxFormat.Items.Add(ImageFormat.Gif);
            comboBoxFormat.SelectedIndex = 0;
        }

        private void InitializeAbsoluteSize ()
        {
            _absoluteSize = new Size(_screenSize.Width, _screenSize.Height);
            textBoxWidth.Text = _absoluteSize.Width.ToString();
            textBoxHeight.Text = _absoluteSize.Height.ToString();
        }

        private void InitializeSaveDirectory ()
        {
            string myDocumentPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            textBoxSaveDir.Text = myDocumentPath;
        }

        private void InitializeSaveFormat ()
        {
            comboBoxFormat.Text = comboBoxFormat.Items[0].ToString();
        }

        private void EnableAbsoluteSize ()
        {
            panelAbsoluteSize.Enabled = true;
            labelScale.Enabled = false;
            textBoxScale.Enabled = false;
        }

        private void DisableAbsoluteSize ()
        {
            panelAbsoluteSize.Enabled = false;
            labelScale.Enabled = true;
            textBoxScale.Enabled = true;
        }

        private void ButtonBrowse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxSaveDir.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void ButtonStartStop_Click(object sender, EventArgs e)
        {
            if (_isRunning)
            {
                // Stop capturing
                _timer.Stop();
                buttonStartStop.Text = "Start";
                panelForm.Enabled = true;
                _isRunning = false;
            } else
            {
                // Start capturing
                ImageProcessor.ProcessInfo info = new ImageProcessor.ProcessInfo();
                if (checkBoxAbsoluteSize.Checked)
                {
                    info.useAbsoluteSize = true;
                    info.size = _absoluteSize;
                } else
                {
                    info.useAbsoluteSize = false;
                    if (!double.TryParse(textBoxScale.Text, out info.scale))
                    {
                        MessageBox.Show("Scale must be a real number");
                        return;
                    }
                }
                int interval;
                if (!int.TryParse(textBoxInterval.Text, out interval))
                {
                    MessageBox.Show("Interval must be an integer");
                    return;
                }
                string dirPath = textBoxSaveDir.Text;
                if (!Directory.Exists(dirPath))
                {
                    MessageBox.Show("Save directory path does not exist");
                    return;
                }
                _timer = CreateCaptueringTimer(info, interval, dirPath);
                _timer.Start();
                buttonStartStop.Text = "Stop";
                panelForm.Enabled = false;
                _isRunning = true;
            }
        }

        private Timer CreateCaptueringTimer(ImageProcessor.ProcessInfo info, int interval, string dirPath)
        {
            Timer timer = new Timer();
            ImageProcessor processor = new ImageProcessor(info);
            DesktopCapturer capturer = new DesktopCapturer(processor);
            ImageFormat format = (ImageFormat)comboBoxFormat.SelectedItem;
            timer.Interval = interval;
            timer.Tick += new EventHandler((sender, e) =>
            {
                // ファイル名はミリ秒までの現在時刻
                string fileName = DateTime.Now.ToString("yyyyMMddhhmmssfff") + FormatExtention(format);
                string path = Path.Combine(dirPath, fileName);
                
                capturer.CaptureAndSaveDesktop(path, format);
            });
            return timer;
        }

        private string FormatExtention (ImageFormat format)
        {
            if (format == ImageFormat.Png)
            {
                return ".png";
            } else if (format == ImageFormat.Jpeg)
            {
                return ".jpg";
            } else if (format == ImageFormat.Bmp)
            {
                return ".bmp";
            } else if (format == ImageFormat.Gif)
            {
                return ".gif";
            } else
            {
                return "";
            }
        }


        private void TextBoxSize_Changed(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            bool isWidth = (textBox == textBoxWidth);
            int inputValue;
            
            // 入力値が正整数以外なら終了
            if (!int.TryParse(textBox.Text, out inputValue) || inputValue <= 0)
            {
                e.Cancel = true;
                return;
            }
            
            if (isWidth)
            {
                // 変更がなければ終了
                if (inputValue == _absoluteSize.Width)
                {
                    return;
                }
                _absoluteSize.Width = inputValue;
            } else
            {
                // 変更がなければ終了
                if (inputValue == _absoluteSize.Height)
                {
                    return;
                }
                _absoluteSize.Height = inputValue;
            }

            if (!checkBoxFixAspectRatio.Checked)
            {
                return;
            }

            if (isWidth)
            {
                adjustHeightToWidth();
            }
            else
            {
                adjustWidthToHeight();
            }
        }
        
        private void adjustWidthToHeight ()
        {
            _absoluteSize.Width = (int)((double)_absoluteSize.Height * _screenSize.Width / _screenSize.Height);
            textBoxWidth.Text = _absoluteSize.Width.ToString();
        }

        private void adjustHeightToWidth ()
        {
            _absoluteSize.Height = (int)((double)_absoluteSize.Width * _screenSize.Height / _screenSize.Width);
            textBoxHeight.Text = _absoluteSize.Height.ToString();
        }

        private void CheckBoxFixAspectRatio_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFixAspectRatio.Checked)
            {
                adjustHeightToWidth();
            }
        }
    }
}
