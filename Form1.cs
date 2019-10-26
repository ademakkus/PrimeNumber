using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DamaProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int top = 0, left = 0;
            Button[,] myButtons = new Button[8, 8];
            for (int i = 0; i < myButtons.GetUpperBound(0); i++)
            {
                #region her satırdaki 8 buton için
                for (int j = 0; j < myButtons.GetUpperBound(1); j++)
                {
                    myButtons[i, j] = new Button();
                    myButtons[i, j].Width = 100;
                    myButtons[i, j].Height = 100;
                    myButtons[i, j].Left = left;
                    myButtons[i, j].Top = top;
                    left += 100;
                    if ((i + j) % 2 == 0)
                    {
                        myButtons[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        myButtons[i, j].BackColor = Color.White;

                    }
                    this.Controls.Add(myButtons[i, j]);
                }
                #endregion

                left = 0;  //
                top += 100;
            }
        }
    }
}
