using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SimpleCalc
{
    public partial class MainForm : Form
    {
        private string[] _buttonNames =
        {
            "⬅", "CE", "C", "±", "√", "7", "8", "9", "/", "%", "4", "5", "6", "*", "1/x", "="
        };
        private List<Button> _buttonList = new List<Button>();
        private const int _bitDepth = 8;
        private string _currOperation = "";
        private string _leftOperand = "";
        private string _rigthOperand = "";
        public MainForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            this.Load += MainForm_Load;
            InitButtons();
        }

        private void InitButtons()
        {
            int ind = 0;
            int posX = 12;
            int posY = 50;
            foreach (var nameButton in _buttonNames)
            {
                Button tmp = new Button();
                tmp.Text = nameButton;
                tmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));

                tmp.Size = new Size(60, 40);
                tmp.Location = new Point(posX, posY);
                posX = posX + tmp.Size.Width + 6;

                ind++;
                if (ind % 5 == 0)
                {
                    posY += tmp.Size.Height + 6;
                    posX = 12;
                }

                panel.Controls.Add(tmp);
                _buttonList.Add(tmp);
                tmp.Click += Btn_Click;
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            //MessageBox.Show(btn.Text);

            switch (btn.Text)
            {
                case "0":
                    {

                        break;
                    }
                case ".":
                    {

                        break;
                    }
                case "7":
                    {
                        if(_currOperation.Length == 0)      //left
                        {
                            if(_leftOperand.Length < _bitDepth)
                            {
                                _leftOperand += "7";
                                textBoxResult.Text = _leftOperand;
                            }
                        }
                        else {                              //right
                            if (_rigthOperand.Length < _bitDepth)
                            {
                                _rigthOperand += "7";
                                textBoxResult.Text = _rigthOperand;
                            }
                        }
                        break;
                    }
                case "*":
                    {
                        _currOperation = "*";
                        textBoxResult.Text = "";
                        break;
                    }
                case "=":
                    {
                        double lOper = 0.0;
                        double rOper = 0.0;
                        double result = 0.0;
                        switch (_currOperation)
                        {
                            case "*":
                                {
                                    lOper = double.Parse(_leftOperand);
                                    rOper = double.Parse(_rigthOperand);
                                    result = lOper * rOper;
                                    textBoxResult.Text = result.ToString();
                                    break;
                                }
                            case "+":
                                {
                                    break;
                                }
                            case "-":
                                {
                                    break;
                                }
                            case "√":
                                {

                                    break;
                                }
                        }
                        break;
                    }
            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button_MC_Click(object sender, EventArgs e)
        {

        }

        private void button_MR_Click(object sender, EventArgs e)
        {

        }

        private void button_MS_Click(object sender, EventArgs e)
        {

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.StartPosition = FormStartPosition.CenterParent;
            aboutForm.ShowDialog();
        }
    }
}
