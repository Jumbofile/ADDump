using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Net;
using System.Text;
using System.Windows.Forms;
/*Active Directory Dump
 * By: Gregory Plachno
 * Made: 7/6/2017
 * v1.3.0
 */
namespace ActiveDirectoryDump
{
    public partial class Form1 : Form
    {
        //Public Strings
        public String FilePathVariable = "S:/Utils/documents/Active Directory Dumps";
        public String scriptPath = "";
        public String runtimePath = "";

        //Public Booleans
        public bool userTrue = false;
        public bool computerTrue = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            folderBox.Text = FilePathVariable;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Setting output folder
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    //Setting output folder as a variable
                    FilePathVariable = fbd.SelectedPath;
                    folderBox.Text = FilePathVariable;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // run our script and put the result into our textbox 
            // NOTE: make sure to change the path to the correct location of your script 
            if (userTrue == false && computerTrue == false)
            {
                //pop up asking to select a script.
                System.Windows.Forms.MessageBox.Show("Select a group to dump.", "Error");
            }
            else
            {
                richTextBox.AppendText(Environment.NewLine + "Start.");

                //run
                if (computerTrue == true)
                {
                    folderBox.Text = RunScript(LoadScript(@"S:\Utils\software\ADDump\scripts\adcomputertocsv.ps1"));
                }
                if (userTrue == true)
                {
                    folderBox.Text = RunScript(LoadScript(@"S:\Utils\software\ADDump\scripts\adtocsv.ps1"));
                }
                //Rich text append
                richTextBox.AppendText(Environment.NewLine + "Done.");
                richTextBox.AppendText(Environment.NewLine + "File located at " + FilePathVariable);
            }
           
        }

        private string RunScript(string scriptText)
        {
            // create Powershell runspace 
            Runspace runspace = RunspaceFactory.CreateRunspace();
            richTextBox.AppendText(Environment.NewLine + "Script Started.");
            // open it 
            runspace.Open();

            // create a pipeline and feed it the script text 
            Pipeline pipeline = runspace.CreatePipeline();
            pipeline.Commands.AddScript(scriptText);

            // add an extra command to transform the script output objects into nicely formatted strings 
            // remove this line to get the actual objects that the script returns. For example, the script 
            // "Get-Process" returns a collection of System.Diagnostics.Process instances. 
            pipeline.Commands.Add("Out-String");
            runspace.SessionStateProxy.SetVariable("path", FilePathVariable);
            // execute the script 
            Collection<PSObject> results = pipeline.Invoke();

            // close the runspace 
            runspace.Close();
            richTextBox.AppendText(Environment.NewLine + "Script Compelted.");
            // convert the script result into a single string 
            StringBuilder stringBuilder = new StringBuilder();
            foreach (PSObject obj in results)
            {
                stringBuilder.AppendLine(obj.ToString());
            }

            // return the results of the script that has 
            // now been converted to text 
            return stringBuilder.ToString();
        }

        // helper method that takes your script path, loads up the script 
        // into a variable, and passes the variable to the RunScript method 
        // that will then execute the contents 
        private string LoadScript(string filename)
        {
            try
            {
                // Create an instance of StreamReader to read from our file. 
                // The using statement also closes the StreamReader. 
                using (StreamReader sr = new StreamReader(filename))
                {

                    // use a string builder to get all our lines from the file 
                    StringBuilder fileContents = new StringBuilder();

                    // string to hold the current line 
                    string curLine;

                    // loop through our file and read each line into our 
                    // stringbuilder as we go along 
                    while ((curLine = sr.ReadLine()) != null)
                    {
                        // read each line and MAKE SURE YOU ADD BACK THE 
                        // LINEFEED THAT IT THE ReadLine() METHOD STRIPS OFF 
                        fileContents.Append(curLine + "\n");
                    }

                    // call RunScript and pass in our file contents 
                    // converted to a string 
                    return fileContents.ToString();
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong. 
                string errorText = "The file could not be read:";
                errorText += e.Message + "\n";
                return errorText;
            }
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void scriptLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Setting script location
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "PowerShell Scripts (*.ps1)|*.ps1";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                scriptPath = openFileDialog1.FileName;
                richTextBox.AppendText(Environment.NewLine + "Script Location Updated.");
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void installToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //download the runtime files
            richTextBox.AppendText(Environment.NewLine + "Downloading runtime.");
            using (var client = new WebClient())
            {
                client.DownloadFile("https://download.microsoft.com/download/1/D/8/1D8B5022-5477-4B9A-8104-6A71FF9D98AB/WindowsTH-RSAT_WS2016-x64.msu", @"c:/WindowsTH-RSAT_WS2016-x64.msu");
            }
            richTextBox.AppendText(Environment.NewLine + "Download Complete.");

            //open runtime install
            richTextBox.AppendText(Environment.NewLine + "Installing Runtime.");
            System.Diagnostics.Process.Start("c:/WindowsTH-RSAT_WS2016-x64.msu");
            richTextBox.AppendText(Environment.NewLine + "Install Complete.");
        }

        private void v110ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(userTrue == false)
            {
                userTrue = true;
            }
            else
            {
                userTrue = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (computerTrue == false)
            {
                computerTrue = true;
            }
            else
            {
                computerTrue = false;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("By : Gregory Plachno","v1.3.0");
        }
    }
}
