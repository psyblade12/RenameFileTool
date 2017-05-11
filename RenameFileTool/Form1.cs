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

namespace RenameFileTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> FilePaths = new List<string>();
        string FolderPath;
        private void button1_Click(object sender, EventArgs e)
        {
            FilePaths.Clear();
            FolderPath = "";
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Filter = "All files (*.*)|*.*";
            ofd.Title = "Please select files";
            ofd.ShowDialog();
            if (ofd.FileNames.Count() > 0)
            {
                FilePaths = ofd.FileNames.ToList();
                List<string> filenamelist = ofd.FileNames.ToList();
                foreach (string s in filenamelist)
                {
                    txtFileNames.Text = txtFileNames.Text + Algorithm.GetFileNameFromPath(s);
                    txtFileNames.Text = txtFileNames.Text + "; ";
                }
                FolderPath = Algorithm.GetFolderPathFromAFilePath(filenamelist[0]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FilePaths.Clear();
            FolderPath = "";
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            if (fbd.SelectedPath !="")
            {
                txtFolderPath.Text = fbd.SelectedPath;
                FolderPath = fbd.SelectedPath;
                DirectoryInfo di = new DirectoryInfo(fbd.SelectedPath);
                FileInfo[] files = di.GetFiles("*.*");
                FilePaths = Algorithm.GetPathsOfFilesFromAFolder(fbd.SelectedPath, files);
            }
        }
        private void HideElement()
        {
            gbAdditionalOption.Hide();
        }
        private void ShowElement()
        {
            gbAdditionalOption.Show();
        }
        private void ClearData()
        {
            txtFileNames.Clear();
            txtFolderPath.Clear();
            FilePaths.Clear();
            FolderPath = "";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (FilePaths.Count > 0)
                {
                    #region rb1
                    if (rbNumbericOrder.Checked == true)
                    {
                        if (cbNumericOrder1.Checked == true)
                        {
                            if (cbNumericOrder2.Checked == false)
                            {
                                int n;
                                int flag = 0;
                                if (int.TryParse(txtStartingNumber.Text, out n) == true)
                                {
                                    flag = n;
                                }
                                foreach (string filepath in FilePaths)
                                {
                                    string extension = Algorithm.GetExtension(filepath);
                                    string newdestination = FolderPath + "\\" + txtAdditionalText.Text + txtSepChar.Text + flag + extension;
                                    try
                                    {
                                        File.Move(filepath, newdestination);
                                        flag = flag + 1;
                                    }
                                    catch
                                    {
                                        MessageBox.Show("The file " + Algorithm.GetFileNameFromPath(filepath) + " already exists in the folder " + Algorithm.GetFolderPathFromAFilePath(filepath) + "\r\nRenaming request for this file could not be done");
                                    }
                                }
                                MessageBox.Show("Renaming successful");
                                ClearData();
                            }
                            else
                            {
                                int n;
                                int flag = 0;
                                if (int.TryParse(txtStartingNumber.Text, out n) == true)
                                {
                                    flag = n;
                                }
                                foreach (string filepath in FilePaths)
                                {
                                    string extension = Algorithm.GetExtension(filepath);
                                    string newdestination = FolderPath + "\\" + txtAdditionalText.Text + txtSepChar.Text + flag + txtSepChar.Text + txtAdditionalText.Text + extension;
                                    try
                                    {
                                        File.Move(filepath, newdestination);
                                        flag = flag + 1;
                                    }
                                    catch
                                    {
                                        MessageBox.Show("The file " + Algorithm.GetFileNameFromPath(filepath) + " already exists in the folder " + Algorithm.GetFolderPathFromAFilePath(filepath) + "\r\nRenaming request for this file could not be done");
                                    }
                                }
                                MessageBox.Show("Renaming successful");
                                ClearData();
                            }
                        }
                        else if (cbNumericOrder2.Checked == true)
                        {
                            int n;
                            int flag = 0;
                            if (int.TryParse(txtStartingNumber.Text, out n) == true)
                            {
                                flag = n;
                            }
                            foreach (string filepath in FilePaths)
                            {
                                string extension = Algorithm.GetExtension(filepath);
                                string newdestination = FolderPath + "\\" + flag + txtSepChar.Text + txtAdditionalText.Text + extension;
                                try
                                {
                                    File.Move(filepath, newdestination);
                                    flag = flag + 1;
                                }
                                catch
                                {
                                    MessageBox.Show("The file " + Algorithm.GetFileNameFromPath(filepath) + " already exists in the folder " + Algorithm.GetFolderPathFromAFilePath(filepath) + "\r\nRenaming request for this file could not be done");
                                }
                            }
                            MessageBox.Show("Renaming successful");
                            ClearData();
                        }
                        else
                        {
                            int n;
                            int flag = 0;
                            if (int.TryParse(txtStartingNumber.Text, out n) == true)
                            {
                                flag = n;
                            }
                            foreach (string filepath in FilePaths)
                            {
                                string extension = Algorithm.GetExtension(filepath);
                                string newdestination = FolderPath + "\\" + flag + extension;
                                try
                                {
                                    File.Move(filepath, newdestination);
                                    flag = flag + 1;
                                }
                                catch
                                {
                                    MessageBox.Show("The file " + Algorithm.GetFileNameFromPath(filepath) + " already exists in the folder " + Algorithm.GetFolderPathFromAFilePath(filepath) + "\r\nRenaming request for this file could not be done");
                                }
                            }
                            MessageBox.Show("Renaming successful");
                            ClearData();
                        }
                    }
                    #endregion
                    #region rb2
                    else if (rbNumbericOrderWithNChars.Checked == true)
                    {
                        int n;
                        if (int.TryParse(txtNumberOfChars.Text, out n) == true)
                        {
                            if (cbNumericOrder1.Checked == true)
                            {
                                if (cbNumericOrder2.Checked == false)
                                {
                                    int z;
                                    int flag = 0;
                                    if (int.TryParse(txtStartingNumber.Text, out z) == true)
                                    {
                                        flag = z;
                                    }
                                    foreach (string filepath in FilePaths)
                                    {
                                        string extension = Algorithm.GetExtension(filepath);
                                        string newdestination = FolderPath + "\\" + txtAdditionalText.Text + txtSepChar.Text + Algorithm.GetNewNumberString(flag, Convert.ToInt32(txtNumberOfChars.Text)) + extension;
                                        try
                                        {
                                            File.Move(filepath, newdestination);
                                            flag = flag + 1;
                                        }
                                        catch
                                        {
                                            MessageBox.Show("The file " + Algorithm.GetFileNameFromPath(filepath) + " already exists in the folder " + Algorithm.GetFolderPathFromAFilePath(filepath) + "\r\nRenaming request for this file could not be done");
                                        }
                                    }
                                    MessageBox.Show("Renaming successful");
                                    ClearData();
                                }
                                else
                                {
                                    int z;
                                    int flag = 0;
                                    if (int.TryParse(txtStartingNumber.Text, out z) == true)
                                    {
                                        flag = z;
                                    }
                                    foreach (string filepath in FilePaths)
                                    {
                                        string extension = Algorithm.GetExtension(filepath);
                                        string newdestination = FolderPath + "\\" + txtAdditionalText.Text + txtSepChar.Text + Algorithm.GetNewNumberString(flag, Convert.ToInt32(txtNumberOfChars.Text)) + txtSepChar.Text + txtAdditionalText.Text + extension;
                                        try
                                        {
                                            File.Move(filepath, newdestination);
                                            flag = flag + 1;
                                        }
                                        catch
                                        {
                                            MessageBox.Show("The file " + Algorithm.GetFileNameFromPath(filepath) + " already exists in the folder " + Algorithm.GetFolderPathFromAFilePath(filepath) + "\r\nRenaming request for this file could not be done");
                                        }
                                    }
                                    MessageBox.Show("Renaming successful");
                                    ClearData();
                                }
                            }
                            else if (cbNumericOrder2.Checked == true)
                            {
                                int z;
                                int flag = 0;
                                if (int.TryParse(txtStartingNumber.Text, out z) == true)
                                {
                                    flag = z;
                                }
                                foreach (string filepath in FilePaths)
                                {
                                    string extension = Algorithm.GetExtension(filepath);
                                    string newdestination = FolderPath + "\\" + Algorithm.GetNewNumberString(flag, Convert.ToInt32(txtNumberOfChars.Text)) + txtSepChar.Text + txtAdditionalText.Text + extension;
                                    try
                                    {
                                        File.Move(filepath, newdestination);
                                        flag = flag + 1;
                                    }
                                    catch
                                    {
                                        MessageBox.Show("The file " + Algorithm.GetFileNameFromPath(filepath) + " already exists in the folder " + Algorithm.GetFolderPathFromAFilePath(filepath) + "\r\nRenaming request for this file could not be done");
                                    }
                                }
                                MessageBox.Show("Renaming successful");
                                ClearData();
                            }
                            else
                            {
                                int z;
                                int flag = 0;
                                if (int.TryParse(txtStartingNumber.Text, out z) == true)
                                {
                                    flag = z;
                                }
                                foreach (string filepath in FilePaths)
                                {
                                    string extension = Algorithm.GetExtension(filepath);
                                    string newdestination = FolderPath + "\\" + Algorithm.GetNewNumberString(flag, Convert.ToInt32(txtNumberOfChars.Text)) + extension;
                                    try
                                    {
                                        File.Move(filepath, newdestination);
                                        flag = flag + 1;
                                    }
                                    catch
                                    {
                                        MessageBox.Show("The file " + Algorithm.GetFileNameFromPath(filepath) + " already exists in the folder " + Algorithm.GetFolderPathFromAFilePath(filepath) + "\r\nRenaming request for this file could not be done");
                                    }
                                }
                                MessageBox.Show("Renaming successful");
                                ClearData();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please type a number to textbox Char(s)");
                        }
                    }
                    #endregion
                    #region rb3
                    else if (rbReplaceExtension.Checked == true)
                    {
                        int flag = 0;
                        foreach (string filepath in FilePaths)
                        {
                            string extension = Algorithm.GetExtension(filepath);
                            string newdestination = "";
                            if (extension != "")
                            {
                                newdestination = filepath.Replace(extension, "." + txtExtension.Text);
                            }
                            else
                            {
                                newdestination = filepath + "." + txtExtension.Text;
                            }
                            try
                            {
                                File.Move(filepath, newdestination);
                                flag = flag + 1;
                            }
                            catch
                            {
                                MessageBox.Show("The file " + Algorithm.GetFileNameFromPath(filepath) + " already exists in the folder " + Algorithm.GetFolderPathFromAFilePath(filepath) + "\r\nRenaming request for this file could not be done");
                            }
                        }
                        MessageBox.Show("Renaming successful");
                        ClearData();
                    }
                    #endregion
                    #region rb4
                    else if (rbReplaceFileName.Checked)
                    {
                        if (txtStringToBeReplaced.Text != "")
                        {
                            foreach (string filepath in FilePaths)
                            {
                                string extension = Algorithm.GetExtension(filepath);
                                string newdestination = FolderPath + "\\" + Algorithm.GetFileNameWithoutExtensionFromPath(filepath).Replace(txtStringToBeReplaced.Text, txtNewString.Text) + extension;
                                try
                                {
                                    File.Move(filepath, newdestination);
                                }
                                catch
                                {
                                    MessageBox.Show("The file " + Algorithm.GetFileNameFromPath(filepath) + " already exists in the folder " + Algorithm.GetFolderPathFromAFilePath(filepath) + "\r\nRenaming request for this file could not be done");
                                }
                            }
                            MessageBox.Show("Renaming successful");
                            ClearData();
                        }
                    }
                    #endregion
                    #region rb5
                    else if (rbChangeToUpperCase.Checked)
                    {
                        foreach (string filepath in FilePaths)
                        {
                            string extension = Algorithm.GetExtension(filepath);
                            string newdestination = FolderPath + "\\" + Algorithm.GetFileNameWithoutExtensionFromPath(filepath).ToUpper() + extension;
                            try
                            {
                                File.Move(filepath, newdestination);
                            }
                            catch
                            {
                                MessageBox.Show("The file " + Algorithm.GetFileNameFromPath(filepath) + " already exists in the folder " + Algorithm.GetFolderPathFromAFilePath(filepath) + "\r\nRenaming request for this file could not be done");
                            }
                        }
                        MessageBox.Show("Renaming successful");
                        ClearData();
                    }
                    #endregion
                    #region rb6
                    else if (rbChangeToLowerCase.Checked)
                    {
                        foreach (string filepath in FilePaths)
                        {
                            string extension = Algorithm.GetExtension(filepath);
                            string newdestination = FolderPath + "\\" + Algorithm.GetFileNameWithoutExtensionFromPath(filepath).ToLower() + extension;
                            try
                            {
                                File.Move(filepath, newdestination);
                            }
                            catch
                            {
                                MessageBox.Show("The file " + Algorithm.GetFileNameFromPath(filepath) + " already exists in the folder " + Algorithm.GetFolderPathFromAFilePath(filepath) + "\r\nRenaming request for this file could not be done");
                            }
                        }
                        MessageBox.Show("Renaming successful");
                        ClearData();
                    }
                    #endregion
                    #region rb7
                    else if (rbRandomName.Checked)
                    {
                        int n;
                        if (int.TryParse(txtNumberOfRandomChars.Text, out n) == true)
                        {
                            foreach (string filepath in FilePaths)
                            {
                                DirectoryInfo di = new DirectoryInfo(FolderPath);
                                FileInfo[] tempfiles = di.GetFiles("*.*");
                                List<string> Temp = Algorithm.GetAListOfNamesOfFilesFromAFolder(FolderPath, tempfiles);
                                string extension = Algorithm.GetExtension(filepath);
                            Random:
                                string random = Algorithm.RandomString(Convert.ToInt32(txtNumberOfRandomChars.Text));
                                string a = Temp.Where(x => x.Equals(random + extension)).FirstOrDefault();
                                if (a == null)
                                {
                                    string newdestination = FolderPath + "\\" + random + extension;
                                    try
                                    {
                                        File.Move(filepath, newdestination);
                                    }
                                    catch
                                    {
                                        MessageBox.Show("The file " + Algorithm.GetFileNameFromPath(filepath) + " already exists in the folder " + Algorithm.GetFolderPathFromAFilePath(filepath) + "\r\nRenaming request for this file could not be done");
                                    }
                                }
                                else
                                {
                                    goto Random;
                                }
                            }
                            MessageBox.Show("Renaming successful");
                            ClearData();
                        }
                    }
                    #endregion
                    #region else
                    else
                    {
                        MessageBox.Show("Please Choose a method of renaming");
                    }
                    #endregion
                }
                else
                {
                    MessageBox.Show("You have not choosen any file.");
                }
            }
            catch
            {
                MessageBox.Show("An error has occurred.");
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Algorithm.GetFileNameWithoutExtensionFromPath("D:\\New Folder\\abc.txt"));
        }

        private void cbNumericOrder1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            HideElement();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rbReplaceExtension_CheckedChanged(object sender, EventArgs e)
        {
            HideElement();
        }

        private void rbChangeToUpperCase_CheckedChanged(object sender, EventArgs e)
        {
            HideElement();
        }

        private void rbChangeToLowerCase_CheckedChanged(object sender, EventArgs e)
        {
            HideElement();
        }

        private void rbRandomName_CheckedChanged(object sender, EventArgs e)
        {
            HideElement();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rbNumbericOrder_CheckedChanged(object sender, EventArgs e)
        {
            ShowElement();
        }

        private void rbNumbericOrderWithNChars_CheckedChanged(object sender, EventArgs e)
        {
            ShowElement();
        }

        private void txtSepChar_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            About form = new About();
            form.Show();
        }
    }
}
