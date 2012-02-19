/*
 * G_View
 * Written by Cathal McNally
 * mcnallycathal@yahoo.ie
 * Feb 17th 2012
 * */

using System;
using System.Xml;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GView
{
    public partial class G_View : Form
    {
        #region Variables
        /// <Variables>
        ///  Set all of the variable values or just initialize them!
        /// </Variables>
        
        // used for parsing the xml document
        private XmlDocument doc = new XmlDocument();

        // nodes used for relaying parsed text from the XML docs into textboxs
        private XmlNode nameNode,yearNode,devNode,pubNode,engineNode,genreNode,modesNode,ratingNode,thoughtsNode;

        // counter has to be set to -1 since 0 is the first Element in the array
        // So when the Button up is clicked both the Array and Counter's position will be in sync
        // or something like that ^^
        private int counter = -1;

        // set the current directory that the program resides is in
        private static string currentDir = Directory.GetCurrentDirectory();

        // String Arrays used to hold Directory paths
        // NOTE: .gvi is really just a .jpg renamed to prevent the program picking up other jpgs that might be in the directory that are not cover art!
        // NOTE: .gvx is really just a .xml renamed to prevent the program attempting to parse xml files that it wont be able to load!
        private static string[] imgPaths = Directory.GetFiles(currentDir, "*.gvi", SearchOption.AllDirectories);
        private static string[] xmlPaths = Directory.GetFiles(currentDir, "*.gvx", SearchOption.AllDirectories);
        private static string[] paths = Directory.GetDirectories(currentDir);

        //holds a single directory
        private static string path;
        #endregion

        // Start Main
        public G_View()
        {
            InitializeComponent();         
        }

        // DO whats below when the Up button is clicked!
        private void btnImgUp_Click(object sender, EventArgs e)
        {
            // increment the Counter in order to sync it with the array
            // We increment for every Button UP click (this is used to track what array position we are now at)
            counter++;
            try
            {

                // For loop that loops through each Image path held by "imgPaths"
                for (int i = 0; i < imgPaths.Length; i++)
                {
                    // if counter is the same as i
                    // this checks to see if the counter for a button click is in sync with the current array position
                    if (counter == i)
                    {
                        // Load into the PictureBox "imgPhoto" each image of type .gvi held in imgPaths
                        imgPhoto.Load(imgPaths[i]);
                    }
                    // if the Counter is greater or equal to the array Size
                    else if (counter >= imgPaths.Length)
                    {
                        // Set the counter to the array length -1
                        // This prevents the Counter from going out of sync with the top of the array
                        counter = imgPaths.Length - 1;
                    }
                }
            }
            catch(Exception u)
            {
                MessageBox.Show("Exception Text : "+u.ToString(), "Image Path Array UP Button Error ^^ soz", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning);
            }

            try
            {
                // For loop that loops through each xml document (*.gvx) path held by "xmlPaths"
                for (int i = 0; i < xmlPaths.Length; i++)
                {
                    // if counter is the same as i
                    // this checks to see if the counter for a button click is in sync with the current array position
                    if (counter == i)
                    {
                        // Load the .gvx files from "xmlPaths" into the XML Document 
                        doc.Load(xmlPaths[i]);

                        // Tell each node specifically where it should source its data from the XML document
                        nameNode = doc.SelectSingleNode("//name/text()");
                        yearNode = doc.SelectSingleNode("//year/text()");
                        devNode = doc.SelectSingleNode("//developer/text()");
                        pubNode = doc.SelectSingleNode("//publisher/text()");
                        engineNode = doc.SelectSingleNode("//engine/text()");
                        genreNode = doc.SelectSingleNode("//genre/text()");
                        modesNode = doc.SelectSingleNode("//modes/text()");
                        ratingNode = doc.SelectSingleNode("//personalRating/text()");
                        thoughtsNode = doc.SelectSingleNode("//thoughts/text()");

                        // Set each TextBox's Text value to the value imported inot the xml nodes
                        nameBox.Text = nameNode.Value;
                        yearBox.Text = yearNode.Value;
                        devBox.Text = devNode.Value;
                        pubBox.Text = pubNode.Value;
                        engineBox.Text = engineNode.Value;
                        genreBox.Text = genreNode.Value;
                        modeBox.Text = modesNode.Value;
                        ratingBox.Text = ratingNode.Value;
                        thoughtsBox.Text = thoughtsNode.Value;
                    }
                }
            }
            catch (Exception u)
            {
                MessageBox.Show("Exception Text : "+u.ToString(), "Xml Path Array UP Button Error ^^ soz", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning);
            }
            
            try
            {
                // For loop that loops through each directory held by "paths"
                for (int i = 0; i < paths.Length; i++)
                {
                    // if counter is the same as i
                    // this checks to see if the counter for a button click is in sync with the current array position
                    if (counter == i)
                    {
                        // Set "path" equal to the current array position
                        path = paths[i];
                    }
                }
            }
            catch (Exception u)
            {
                MessageBox.Show("Exception Text : " + u.ToString(), "Directory Open Path Array UP Button Error ^^ soz", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning);
            }
        }

        private void btnImgDown_Click(object sender, EventArgs e)
        {
            // This check prevents the Counter from going below 0 (the bottom most array position) 
            // if counter is greater or equal to 0
            if (counter <= 0)
            {
                // set the counter equal to 1
                counter = 1;
            }

            // decrement the Counter in order to sync it with the array
            // We decrement for every Button DOWN click (this is used to track what array position we are now at)
            counter--;

            try
            {
                // For loop that loops through each Image path held by "imgPaths"
                for (int i = counter; i >= 0; i--)
                {
                    // If counter equals 1 (i.e. its in sync)
                    if (counter == i)
                    {
                        // Load the image from the current array position into the PictureBox
                        imgPhoto.Load(imgPaths[i]);
                    }
                }
            }
            catch (Exception u)
            {
                MessageBox.Show("Exception Text : " + u.ToString(), "Image Path Array DOWN Button Error ^^ soz", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning);
            }

            try
            {
                // For loop that loops through each xml document (*.gvx) path held by "xmlPaths"
                // We use "counter" here rather than xmlPaths.Length since we are going down the array
                for (int i = counter; i >= 0; i--)
                {
                    // If counter equals i
                    if (counter == i)
                    {
                        // Load the .gvx files from "xmlPaths" into the XML Document 
                        doc.Load(xmlPaths[i]);

                        // Tell each node specifically where it should source its data from the XML document
                        nameNode = doc.SelectSingleNode("//name/text()");
                        yearNode = doc.SelectSingleNode("//year/text()");
                        devNode = doc.SelectSingleNode("//developer/text()");
                        pubNode = doc.SelectSingleNode("//publisher/text()");
                        engineNode = doc.SelectSingleNode("//engine/text()");
                        genreNode = doc.SelectSingleNode("//genre/text()");
                        modesNode = doc.SelectSingleNode("//modes/text()");
                        ratingNode = doc.SelectSingleNode("//personalRating/text()");
                        thoughtsNode = doc.SelectSingleNode("//thoughts/text()");

                        // Set each TextBox's Text value to the value imported inot the xml nodes
                        nameBox.Text = nameNode.Value;
                        yearBox.Text = yearNode.Value;
                        devBox.Text = devNode.Value;
                        pubBox.Text = pubNode.Value;
                        engineBox.Text = engineNode.Value;
                        genreBox.Text = genreNode.Value;
                        modeBox.Text = modesNode.Value;
                        ratingBox.Text = ratingNode.Value;
                        thoughtsBox.Text = thoughtsNode.Value;
                    }
                }
            }
            catch (Exception u)
            {
                MessageBox.Show("Exception Text : " + u.ToString(), "XML Path Array DOWN Button Error ^^ soz", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning);
            }

            try
            {
                // For loop that loops through each directory held by "paths"
                for (int i = 0; i < paths.Length; i++)
                {
                    // if counter is the same as i
                    // this checks to see if the counter for a button click is in sync with the current array position
                    if (counter == i)
                    {
                        // Set "path" equal to the current array position
                        path = paths[i];
                    }
                }
            }
            catch (Exception u)
            {
                MessageBox.Show("Exception Text : " + u.ToString(), "Directory Open Path Array DOWN Button Error ^^ soz", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning);
            }
        }

        // Do the following if the Open folder button is clicked
        private void openBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Open the directory currently held by path
                // Path is updated every time UP or DOWN is clicked to the current directory path
                System.Diagnostics.Process.Start("explorer.exe", path);
            }
            catch (Exception u)
            {
                MessageBox.Show("Exception Text : " + u.ToString(), "Couldnt Open directory ^^ Soz!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning);
            }
        }

        // Do the following if the About button is clicked
        private void aboutBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Set the message
                const string message = "Game Viewer (G_View)\nVersion 1.0a\nA basic XML parsing and image loading program written in C#\nDeveloped by Cathal McNally (mcnallycathal@yahoo.ie)";
                // Set the messageBox title
                const string caption = "About G_View";
                // Show the Message box with the message, title, an Ok button and an Information Logo
                var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception u)
            {
                MessageBox.Show("Exception Text : " + u.ToString(), "About Button Failed? Lol! Soz.....", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning);
            }
        }
    }
}
