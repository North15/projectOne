using System;
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

        /***************************************************************
         *                          Variables                          *
         ***************************************************************/
        public string fileText   = "";
        public string newFileText = "";
        public string newBoxText = "";
        public string userText   = "";
        public string boxText;

        public char[] convertFileText;
        public char[] convertBoxText;

        StringBuilder fromFile = new StringBuilder();
        StringBuilder fromBox  = new StringBuilder();


        /***************************************************************
         * Browses local files for the user to select a whitespace file *
         ***************************************************************/
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

        /*****************************************************************
         * Converts the WhiteSpace to the corresponding letters and back *
         *****************************************************************/
        private void convertButton_Click(object sender, EventArgs e)
        {
            //Constants
            const char space = ' ';
            const char tab = '\t';
            const char lineFeed = '\n';
            const char spaceLetter = 'S';
            const char tabLetter = 'T';
            const char lineFeedLetter = 'L';

            //Variables
            int index;

            //checks to see if the textbox has been convert to letters from a file
            if (mainText.Text == fromFile.ToString())
            {
                mainText.Text = fileText;
                mainText.Focus();
                mainText.SelectionStart = mainText.Text.Length;
            }                

            //checks to see if the textbox has been converted to letters from user input
            else if(mainText.Text == fromBox.ToString())
            {
                mainText.Text = userText;
                mainText.Focus();
                mainText.SelectionStart = mainText.Text.Length;
            }

            //if neither check is true converts the textbox from whitespace into letters
            else
            {
                //checks the textbox for text from a file
                if (mainText.Text == fileText)
                {
                    boxText = mainText.Text;

                    convertBoxText = boxText.ToCharArray();
                    fromFile = new StringBuilder(newFileText);

                    //loops through each character in the array and adds the corresponding letter
                    //to the new string
                    for (index = 0; index < fileText.Length; index++)
                    {
                        if (convertFileText[index] == space)
                            fromFile.Append(spaceLetter);
                        else if (convertFileText[index] == tab)
                            fromFile.Append(tabLetter);
                        else if (convertFileText[index] == lineFeed)
                            fromFile.Append(lineFeedLetter).Append(lineFeed);
                    }
                    mainText.Text = fromFile.ToString();
                }
                //all other inputs to the textbox are converted
                else
                {
                    userText = mainText.Text;
                    boxText = mainText.Text;

                    convertBoxText = boxText.ToCharArray();
                    fromBox = new StringBuilder(newBoxText);

                    //loops through each character in the array and adds the corresponding letter
                    //to the new string
                    for (index = 0; index < boxText.Length; index++)
                    {
                        if (convertBoxText[index] == space)
                            fromBox.Append(spaceLetter);
                        else if (convertBoxText[index] == tab)
                            fromBox.Append(tabLetter);
                        else if (convertBoxText[index] == lineFeed)
                            fromBox.Append(lineFeedLetter).Append(lineFeed);
                    }
                    //sets the textbox to the new string of letter
                    mainText.Text = fromBox.ToString();
                }
            }
        }

        /***************************************************************
         *     Browses local files for the user to save their work     *
         ***************************************************************/
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

        /***************************************************************
         *          Clears all data so the user can start again        *
         ***************************************************************/
        private void clearAllButton_Click(object sender, EventArgs e)
        {
            mainText.Clear();
            filePath.Clear();
            fileText    = "";
            newBoxText  = "";
            Array.Clear(convertBoxText, 0, convertBoxText.Length);
            mainText.Focus();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("                 \t\tINSTRUCTIONS\t\t                     \n"+
                            "------------------------------------------------------------------------------------\n\n" +
                            " How to use:\n\n" +
                            " 1. Import a WhiteSpace file from your local files with the browse\n" +
                            "       option, or copy the file path.\n\n" +
                            "               ---OR---\n\n" +
                            " 1. Write your WhiteSpace code in the textbox.\n\n" +
                            " 2. Convert the code into their corresponding letters:\n" +
                            "       Space = \'S\' Tab = \'T\' Line Feed = \'L\'\n\n" +
                            "(option) You can press the convert button again to switch between\n" +
                            "             letters and whitespace.\n\n" +
                            " 3. Save either the WhiteSpace code or the converted letters\n" +
                            "   with the save button.");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
