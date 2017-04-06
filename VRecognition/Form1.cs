using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using VRecognition;

namespace VRecognition
{
    public partial class Form1 : Form
    {
        SpeechRecognitionEngine eSpec = new SpeechRecognitionEngine();
        SpeechRecognizer eSpeech = new SpeechRecognizer();
        SpeechSynthesizer eSyth = new SpeechSynthesizer();
       /* public FunctionsEvents returnFunctions(string serverString, string databaseString) {
          FunctionsEvents func = new FunctionsEvents(serverString, databaseString);
            return func;
        }*/
        

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            Choices cmd = new Choices();
            cmd.Add(new String[] {"display all", "sort", "clear", "sortdown", "exit" });
            GrammarBuilder bld = new GrammarBuilder();
            bld.Append(cmd);

            Grammar gm = new Grammar(bld);

            eSpeech.LoadGrammarAsync(gm);
            eSpeech.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(ESpeech_SpeechRecognized);

        }

        private void ESpeech_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            FunctionsEvents func = new FunctionsEvents("LAPTOP-38MBSCBD\\LISASQL", "AdventureWorks2012");
            switch (e.Result.Text) {
                case "display all":
                    eSyth.SpeakAsync("displaying all records");
                    func.DisplayAll(gridStuff);
                    break;
                case "sort":
                    eSyth.SpeakAsync("your records has been sorted");
                    func.SortAsced(gridStuff);     
                    break;
                case "sortdown":
                    eSyth.SpeakAsync("your records has been sorted in descending order");
                    func.SortDescend(gridStuff);
                    break;
                case "clear":
                    eSyth.SpeakAsync("your current set has been cleared");
                    func.clear(gridStuff);
                    break;
                case "exit":
                    eSyth.SpeakAsync("exiting program");
                    func.exitData();
                    break;                
                default:
                    eSyth.SpeakAsync("your command is not recongnized");
                    break;
            }
        }

       
        private void checkEnable_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEnable.Checked)
            {
                // eSpeech.RecognizeAsync();
                
                eSpeech.Enabled = true;
                eSyth.SelectVoiceByHints(VoiceGender.Female);
            }
            else
            {
                //eSpeech.RecognizeAsyncStop();
                
                eSpeech.Enabled = false;
            }

        }

        
    }
}
