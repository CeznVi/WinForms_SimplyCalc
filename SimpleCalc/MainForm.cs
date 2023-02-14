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
            "±", "x²", "⬅", "C", 
            "1/x", "%", "√", "×",
            "1",   "2", "3", "/",
            "4",  "5",  "6", "+",
            "7", "8", "9", "-",
            "0" ,",", "="
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

        /// <summary>
        /// Инициализация кодом кнопок калькулятора
        /// </summary>
        private void InitButtons()
        {
            int ind = 0;
            int posX = 4;
            int posY = 4;

            foreach (string nameButton in _buttonNames)
            {
                Button tmp = new Button();

                if(nameButton == "," || nameButton == "=" || nameButton == "0")
                    tmp.Size = new Size(109, 50);
                else
                    tmp.Size = new Size(81, 50);

                if(CheckIsStringNum(nameButton))
                    tmp.BackColor = Color.LemonChiffon;
                else if(nameButton == "C")
                    tmp.BackColor = Color.LightCyan;
                else
                    tmp.BackColor = Color.PeachPuff;

                tmp.Text = nameButton;
                
                tmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));

                
                tmp.Location = new Point(posX, posY);
                posX = posX + tmp.Size.Width + 4;

                ind++;

                if (ind % 4 == 0)
                {
                    posY += tmp.Size.Height + 4;
                    posX = 4;
                }

                panel.Controls.Add(tmp);
                _buttonList.Add(tmp);
                tmp.Click += Btn_Click;
            }
        }
        /// <summary>
        /// Проверяет есть ли в строке цифры
        /// </summary>
        /// <param name="s">Строка которую требуется проверить</param>
        /// <returns>Если есть цифры то правде, иначе ложь</returns>
        private bool CheckIsStringNum(string s)
        {
            if(s == "1" || s == "2" || s == "3" || s == "4" || s == "5" || 
                s == "6" || s == "7" || s == "8" || s == "9" || s == "0")
                return true;
            else
                return false;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;






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


        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.StartPosition = FormStartPosition.CenterParent;
            aboutForm.ShowDialog();
        }

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
