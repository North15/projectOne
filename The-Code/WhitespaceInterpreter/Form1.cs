﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WhitespaceInterpreter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string fileText   = "";
        public string newFileText = "";
        public string newBoxText = "";
        public string userText   = "";
        public string boxText;

        public char[] convertFileText;
        public char[] convertBoxText;

        StringBuilder fromFile = new StringBuilder();
        StringBuilder fromBox  = new StringBuilder();

        private void browseButton_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                filePath.Text = file;
                try
                {
                    fileText = File.ReadAllText(file);
                    mainText.Text = fileText;
                }
                catch (IOException)
                {
                }
            }
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            int index;

            if (mainText.Text == fromFile.ToString())
            {
                mainText.Text = fileText;
                mainText.Focus();
                mainText.SelectionStart = mainText.Text.Length;
            }                
            else if (mainText.Text == fromBox.ToString())
            {
                mainText.Text = userText;
                mainText.Focus();
                mainText.SelectionStart = mainText.Text.Length;
            }
            else
            {
                if (mainText.Text == fileText)
                {
                    boxText = mainText.Text;

                    convertBoxText = boxText.ToCharArray();
                    fromFile = new StringBuilder(newFileText);

                    for (index = 0; index < fileText.Length; index++)
                    {
                        if (convertFileText[index] == ' ')
                            fromFile.Append('S');
                        else if (convertFileText[index] == '\t')
                            fromFile.Append('T');
                        else if (convertFileText[index] == '\n')
                            fromFile.Append('L').Append('\n');
                    }
                    mainText.Text = fromFile.ToString();
                }
                else
                {
                    userText = mainText.Text;
                    boxText = mainText.Text;

                    convertBoxText = boxText.ToCharArray();
                    fromBox = new StringBuilder(newBoxText);

                    for (index = 0; index < boxText.Length; index++)
                    {
                        if (convertBoxText[index] == ' ')
                            fromBox.Append('S');
                        else if (convertBoxText[index] == '\t')
                            fromBox.Append('T');
                        else if (convertBoxText[index] == '\n')
                            fromBox.Append('L').Append('\n');
                    }
                    mainText.Text = fromBox.ToString();
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|Whitespace (*.ws)|*.ws";
            saveFileDialog1.AddExtension = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var extension = System.IO.Path.GetExtension(saveFileDialog1.FileName);
                if (extension.ToLower() == ".txt")
                    mainText.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                else if (extension.ToLower() == ".ws")
                    mainText.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            mainText.Clear();
            filePath.Clear();
            fileText    = "";
            newBoxText  = "";
            Array.Clear(convertBoxText, 0, convertBoxText.Length);
        }
    }
}
