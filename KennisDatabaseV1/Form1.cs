using CSScriptLib;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KennisDatabaseV1
{
    public partial class Form1 : Form
    {
        public static List<string> links = new List<string>();

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();


        //Set the width as an int for the the collapsed nav panel
        private static int NavWidthSmall = 60;
        //Set the width as an int for the the uncollapsed nav panel
        private static int NavWidthBig = 540;

        private void Form1_Load(object sender, EventArgs e)
        {
            init();

            //runCode.Image.Size = new Size(20, 20);

        }

        #region moveWindow
        // Importing the ReleaseCapture method from the user32.dll library
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        // Importing the SendMessage method from the user32.dll library
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        //Als muis ingedrukt is op label1 (de titel)
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            // Calls the ReleaseCapture method from the user32.dll library
            ReleaseCapture();

            // Sends a message to the window handle specified in the Handle property
            // with the message 0x112, wParam 0xf012, and lParam 0
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion

        //When Form1 loads.
        public Form1()
        {
            InitializeComponent();
            //Set the Size of the NavMenuPnl to the collapsed size.
            NavMenuPnl.Size = new Size(NavWidthSmall, NavMenuPnl.Height);
            //Hide the searchbar.
            SearchbarTxt.Hide();
            //Hide the ListBox.
            NavMenuLBox.Hide();
        }

        #region header Buttons
        //When ClsBtn is clicked.
        private void ClsBtn_Click(object sender, EventArgs e)
        {
            //Close application.
            Application.Exit();
        }

        //When MinBtn is clicked.
        private void MinBtn_Click(object sender, EventArgs e)
        {
            //Set the window state to minimized.
            this.WindowState = FormWindowState.Minimized;
        }

        //When reloadBtn is clicked.
        private void ReloadBtn_Click(object sender, EventArgs e)
        {
            //Restart application.
            Application.Restart();
        }
        #endregion

        #region Nav Menu
        //When the HamburgerBtn (Nav Menu btn) is clicked.
        private void HamburgerBtn_Click(object sender, EventArgs e)
        {
            //Check current with of the NavMenuPnl.
            //If it has the small panel size
            if (NavMenuPnl.Size.Width == NavWidthSmall)
            {
                //Show the SearchBar
                SearchbarTxt.Show();
                //Show the ListBox.
                NavMenuLBox.Show();
                //Set the panel size to the uncollapsed version.
                NavMenuPnl.Size = new Size(NavWidthBig, NavMenuPnl.Height);
            }
            //If the size is bigger than the small panel size
            else
            {
                //Hide the searchbar.
                SearchbarTxt.Hide();
                //Hide the ListBox.
                NavMenuLBox.Hide();
                //Sets the panel size to the uncollapsed version/
                NavMenuPnl.Size = new Size(NavWidthSmall, NavMenuPnl.Height);
            }

        }


        public static Dictionary<int, string> DocumentDList = new Dictionary<int, string>();

        private void init()
        {
            // Hides the media button on boot
            btnMedia.Visible = false;
            //Run de Load functie in LoadDatabase Class.
            LoadFromDatabase.Load();
            //Foreach BsonDocument in documentList do:


            foreach (BsonDocument bsonElements in LoadFromDatabase.documentList)
            {
                //if nothing fails do this:
                try
                {
                    //Parse the BsonDocument to a string
                    string document = bsonElements["document"].AsString;

                    int chapter = 0;

                    try
                    {
                        chapter = bsonElements["chapter"].AsInt32;
                    }
                    catch
                    {
                        Random random = new Random();
                        chapter = random.Next(200, 2000);
                        //MessageBox.Show(chapter.ToString());
                    }

                    //NIET VERWIJDEREN. KUT PROGRAMMA GEEFT ANDERS ERRORS OMTREND KEYS ADDEN. IDK WHY.
                    Thread.Sleep(1);

                    //Make an array that splits the document at every new line.
                    string[] parsed = document.Split('\n');
                    //Make a new string called title and set that as the first line and remove "title: " from it.
                    string title = parsed[0].Substring(7, parsed[0].Length - 7);

                    DocumentDList.Add(chapter, title);

                    //Set it in the NavMenuListBox
                    TitleList.Add(title);

                }
                //if something fails do this:
                catch (Exception ex)
                {
                    //Add an item saying Data loaded incorrectly.
                    NavMenuLBox.Items.Add("Data loaded incorrectly");
                    MessageBox.Show(ex.ToString());
                }
            }

            //Set all Keys in een var
            var list = DocumentDList.Keys.ToList();
            //Sort all keys.
            list.Sort();
            //foreach key in list:
            foreach (int key in list)
            {
                //get the Title in DictionaryList at index of key.
                NavMenuLBox.Items.Add(DocumentDList[key]);
            }
        }

        //List with all the titels.
        public static List<string> TitleList = new List<string>();

        //When texts in Searchbar changes.
        private void SearchbarTxt_TextChanged(object sender, EventArgs e)
        {

            //If Searchbar is empty:
            if (string.IsNullOrEmpty(SearchbarTxt.Text))
            {
                //Clear the NavMenu ListBox.
                NavMenuLBox.Items.Clear();
                //Foreach title in TitleList:
                var list = DocumentDList.Keys.ToList();
                list.Sort();
                foreach (int key in list)
                {
                    NavMenuLBox.Items.Add(DocumentDList[key]);
                }
            }
            else
            {

                //Make a new list for every item that matches.
                List<string> matching = new List<string>();

                //foreach title in TitleList:
                foreach (string title in TitleList)
                {
                    //If title to lower characters has the same text as the searchbar (to lower characters).
                    if (title.ToLower().Contains(SearchbarTxt.Text.ToLower()))
                    {
                        //add it to the matching list.
                        matching.Add(title);
                    }
                }

                //Clear NavMenu ListBox.
                NavMenuLBox.Items.Clear();

                //foreach string in matching:
                foreach (string str in matching)
                {
                    //Add item to ListBox.
                    NavMenuLBox.Items.Add(str);
                }
            }

        }
        #endregion

        private void NavMenuLBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            HamburgerBtn.PerformClick();

            foreach (BsonDocument bsonElements in LoadFromDatabase.documentList)
            {
                //if nothing fails do this:
                try
                {
                    //Parse the BsonDocument to a string
                    string document = bsonElements["document"].AsString;

                    //Make an array that splits the document at every new line.
                    string[] parsed = document.Split('\n');
                    //Make a new string called title and set that as the first line and remove "title: " from it.
                    string title = parsed[0].Substring(7, parsed[0].Length - 7);

                    string curItem = NavMenuLBox.SelectedItem.ToString().ToLower();

                    if (title.ToLower() == curItem)
                    {
                        TitleLbl.Text = title;

                        int startIndex = document.IndexOf("Informatie:") + 12;


                        string tekst = document.Substring(startIndex, document.Length - startIndex);

                        tekst = tekst.Replace("\n", Environment.NewLine);
                        try
                        {
                            tekst = tekst.Remove(tekst.IndexOf("Oplossing Opdracht:"));
                        }
                        catch { }
                        links.Clear();
                        int lineforlinks = 0;
                        for (int i = 0; i < tekst.Split('\n').Length - 1; i++)
                        {
                            if (tekst.Split('\n')[i].ToLower().Contains("eventuele link")) //If the line contains the string you're looking for
                            {
                                lineforlinks = i;
                            }
                        }
                        tekst = tekst.Replace("eventuele link van filmpjes of plaatjes:", "");
                        
                        int j = 0;
                        if (tekst.Contains("http"))
                        {
                            //Assuming the string is called input and the list is called links
                            foreach (string line in tekst.Split('\n')) //Split the string by newline and loop through each line
                            {
                                j++;
                                if (line.Contains("http") && !line.ToLower().Contains("youtube") && j > lineforlinks) //Check if the line contains http
                                {
                                    int index = line.IndexOf('h'); // find the index of the first 'h'
                                    string result = line.Substring(index); // get a substring starting from that index
                                    links.Add(result); //Add the line to the list
                                    tekst = tekst.Replace(line, "");
                                }
                            }

                        }
                        if (links.Count > 0)
                        {
                            btnMedia.Visible = true;
                        }
                        else
                        {
                            btnMedia.Visible = false;
                        }
                        InformatieTxt.Clear();
                        InformatieTxt.TextAlign = HorizontalAlignment.Left;
                        InformatieTxt.Text = tekst;
                    }
                }
                //if something fails do this:
                catch (Exception ex)
            {
                //Add an item saying Data loaded incorrectly.
                NavMenuLBox.Items.Add("Data loaded incorrectly");
                MessageBox.Show(ex.ToString());
            }
        }

    }

    private void AnswerBtn_Click(object sender, EventArgs e)
    {

        if (TitleLbl.Text == "Welkom")
            return;

        foreach (BsonDocument bsonElements in LoadFromDatabase.documentList)
        {
            //if nothing fails do this:
            try
            {
                //Parse the BsonDocument to a string
                string document = bsonElements["document"].AsString;

                //Make an array that splits the document at every new line.
                string[] parsed = document.Split('\n');
                //Make a new string called title and set that as the first line and remove "title: " from it.
                string title = parsed[0].Substring(7, parsed[0].Length - 7);

                string curItem = TitleLbl.Text.ToLower();

                if (title.ToLower() == curItem)
                {
                    TitleLbl.Text = title;

                    int startIndex = document.IndexOf("Oplossing Opdracht:");


                    string tekst = document.Substring(startIndex, document.Length - startIndex);

                    tekst = tekst.Replace("\n", Environment.NewLine);

                    MessageBoxForm frm2 = new MessageBoxForm();
                    frm2.messageText = tekst;
                    frm2.Show();

                }

            }
            //if something fails do this:
            catch
            {
                MessageBox.Show("Data loaded incorrectly");
            }
        }

    }

    private void runCode_Click(object sender, EventArgs e)
    {
        //Als de titel is Welkom, Doe dan niets.
        /*if (TitleLbl.Text == "Welkom")
            return;*/
        //Als er in de titel klasse staat meld ze dan wat en doe verder niets.
        if (TitleLbl.Text.ToLower().Contains("klasse"))
        {
            MessageBox.Show("This program should be made in Visual Studio.");
            return;
        }


        AllocConsole();
        Execute(RunTxt.Text);

    }

    public static void Execute(string code)
    {
        try
        {
            dynamic block = CSScript.Evaluator
                           .ReferenceAssembliesFromCode(code)
                           .LoadCode(code);
            block.Main();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Failed to run command.");
            MessageBox.Show(ex.Message);
            Clipboard.SetText(ex.Message);
        }

    }

    private void btnMedia_Click(object sender, EventArgs e)
    {
        // This will literally just open the media window :3
        ImageViewer frm = new ImageViewer();
        frm.Show();
    }
}
}
