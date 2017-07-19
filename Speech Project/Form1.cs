using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Text.RegularExpressions;
using Toolset.Controls;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Voice2Calc : Form
    {
        SpeechRecognitionEngine speechRec = new SpeechRecognitionEngine();
        
        // Create an OpenFileDialog object.
        OpenFileDialog openFile = new OpenFileDialog();

        private string[] aiResponses =
        {
            //0: Hello
            "Feeble Mortal!!!",

            //1: What's my name?
            "Hello, Feeble Mortal. Each dying breath brings you closer to my doorstep.",

            //2: ???
            "I don't understand."
        };

        private string[] filePaths =
        {
            //0: How do I write a class in C#?
            "C:\\Users\\Kody\\Voice2Calc Query Possibilities\\cSharpClass.txt",

            //1: Show me a C# guide
            "C:\\Users\\Kody\\Voice2Calc Query Possibilities\\cSharpUses.txt",

            //2: Show me C# syntax
            "C:\\Users\\Kody\\Voice2Calc Query Possibilities\\cSharpSyntax.txt"
        };

        private string[] commandView = { "Hello", "What's my name?", "How do I write a class?", "Show me a guide." };

        private string[] commandList = { "hello", "what's my name", "how do I write a class", "show me a guide" };

        private const string choseCSharp = "C# Language";
        private const string choseCPP = "C++ Language";
     
        private string chosenLanguage = "";

        public Voice2Calc()
        {
            InitializeComponent();
            btnDisable.Enabled = false;

            // Initialize the filter to look for text files.
            openFile.Filter = "Text Files|*.txt";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Determine possible choices
            Choices commands = new Choices();
            commands.Add(commandList);

            foreach (var command in commandView)
                commandListbox.Items.Add(command);

            //Create Grammar bot and teach it possible commands
            GrammarBuilder gBuilder = new GrammarBuilder();
            gBuilder.Append(commands);

            //Create object to hold grammar 
            Grammar grammar = new Grammar(gBuilder);

            //Provide text input to text engine and choose where it comes from
            speechRec.LoadGrammarAsync(grammar);
            speechRec.SetInputToDefaultAudioDevice();
            speechRec.SpeechRecognized += SpeechRec_SpeechRecognized;
        }

        private void SpeechRec_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string fileName = "";
            if ((choiceCB.Text != "" || choiceCB.Text != null) && chosenLanguage == choseCSharp)
            {
                switch (e.Result.Text)
                {
                    case "hello":
                        queryBox.Text = "Hello";
                        queryResultBox.Text = aiResponses[0];
                        break;

                    case "what's my name":
                        queryBox.Text = "What's my name?";
                        queryResultBox.Text = aiResponses[1];
                        break;

                    //C# Queries
                    case ("how do I write a class"):
                        fileName = File.ReadAllText("C:\\Users\\Kody\\Voice2Calc Query Possibilities\\cSharpClass.txt");

                        queryBox.Text = "How do I write a class in C#?";
                        queryResultBox.Text = fileName + "\n";
                        break;

                    case "show me a guide":
                        fileName = File.ReadAllText("C:\\Users\\Kody\\Voice2Calc Query Possibilities\\cSharpUses.txt");

                        queryBox.Text = "Show me a C# guide";
                        queryResultBox.Text = fileName + "\n";
                        break;

                    case "show me c sharp syntax":
                        fileName = File.ReadAllText("C:\\Users\\Kody\\Voice2Calc Query Possibilities\\cSharpSyntax.txt");

                        queryBox.Text = "Show me C# syntax.";
                        queryResultBox.Text = fileName + "\n";
                        break;

                    default:
                        queryBox.Text = "???";
                        queryResultBox.Text = "I don't understand";
                        break;
                }
            }
            else if ((choiceCB.Text != "" || choiceCB.Text != null) && chosenLanguage == choseCPP)
            {
                switch (e.Result.Text)
                {
                    case ("how do I write a class"):
                        fileName = File.ReadAllText("C:\\Users\\Kody\\Voice2Calc Query Possibilities\\cSharpClass.txt");

                        queryBox.Text = "How do I write a class in CPP?";
                        //queryResultBox.Text = fileName + "\n";
                        break;

                    case "show me a guide":
                        fileName = File.ReadAllText("C:\\Users\\Kody\\Voice2Calc Query Possibilities\\cSharpUses.txt");

                        queryBox.Text = "Show me a C# guide";
                        //queryResultBox.Text = fileName + "\n";
                        break;

                    case "show me c sharp syntax":
                        fileName = File.ReadAllText("C:\\Users\\Kody\\Voice2Calc Query Possibilities\\cSharpSyntax.txt");

                        queryBox.Text = "Show me C# syntax.";
                        //queryResultBox.Text = fileName + "\n";
                        break;

                    default:
                        queryBox.Text = "???";
                        queryResultBox.Text = aiResponses[2];
                        break;
                }
            }
            else
            {
                queryResultBox.Text = "Please choose a language in the drop down menu.";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            speechRec.RecognizeAsyncStop();
            btnDisable.Enabled = false;
            btnEnable.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            speechRec.RecognizeAsync(RecognizeMode.Multiple);
            btnDisable.Enabled = true;
            btnEnable.Enabled = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void queryBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (choiceCB.Text == choseCSharp)
                chosenLanguage = choseCSharp;

            else if (choiceCB.Text == choseCPP)
                chosenLanguage = choseCPP;

        }

        //private processCSharpQuery(File filename, string )
    }
}

