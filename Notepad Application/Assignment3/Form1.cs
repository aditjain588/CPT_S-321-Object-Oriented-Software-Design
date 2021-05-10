// <copyright file="Form1.cs" company="Adit Jain">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Assignment3
{
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

    /// <summary>
    /// Form class which contains the events and functions about what has to be done when events are triggered.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Adds the text to textbox.
        /// </summary>
        /// <param name="sr">Text which is supposed to be added. </param>
        private void LoadText(TextReader sr)
        {
            this.textBox1.Clear();
            string line;
            int count = 0;
            while (true)
            {
                count += 1;
                line = sr.ReadLine();
                if (line == null)
                {
                    break;
                }

                this.textBox1.AppendText(count + "   " + line);
                this.textBox1.AppendText("\r\n");
            }
        }

        /// <summary>
        /// Function is executed when 'Load From File' option is clicked.
        /// </summary>
        /// <param name="sender">sender. </param>
        /// <param name="e">Event. </param>
        private void LoadFromFile_Click(object sender, System.EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the path of specified file
                    filePath = openFileDialog.FileName;

                    // Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        // fileContent = reader.ReadToEnd();
                        this.LoadText(reader);
                    }
                }
            }
        }

        /// <summary>
        /// Function is executed when 'Load Fibonacci Numbers(First 50) ' option is clicked.
        /// </summary>
        /// <param name="sender">sender. </param>
        /// <param name="e">Event. </param>
        private void Load50FibMenuItem_Click(object sender, EventArgs e)
        {
            using (FibonacciTextReader f = new FibonacciTextReader(50))
            {
                this.LoadText(f);
            }
        }

        /// <summary>
        /// Function is executed when 'Load Fibonacci Numbers(First 100) ' option is clicked.
        /// </summary>
        /// <param name="sender">sender. </param>
        /// <param name="e">Event. </param>
        private void Load100FibMenuItem_Click(object sender, EventArgs e)
        {
            using (FibonacciTextReader f = new FibonacciTextReader(100))
            {
                this.LoadText(f);
            }
        }

        /// <summary>
        /// Function is executed when 'Save File' option is clicked.
        /// </summary>
        /// <param name="sender">sender. </param>
        /// <param name="e">Event. </param>
        private void SaveFileMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    myStream.Close();
                    using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                    {
                            sw.Write(this.textBox1.Text);
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
