using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace The_picture_Viewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int idx = 0;
        List<string> list = new List<string>();
        Dictionary<string, string> dictionary = new Dictionary<string, string>();
        private void btnchoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select Images";
            openFileDialog.Filter = "PNG & JPG Images|*.png;*.jpg|RAW Images|*.RAW|DNG Images|*.DNG|GIF Images|*.gif|BMP Images|*.BMP|TIFF Images|*.TIFF|JPEG Images|*.jpeg|All Extetions|*.*";
            openFileDialog.Multiselect = true;
            openFileDialog.ShowDialog();

            foreach (string file in openFileDialog.FileNames)
            {
                if (!list.Contains(file))
                {
                ListBox_Images.Items.Add(Path.GetFileName(file));
                list.Add(file);
                dictionary[Path.GetFileName(file)] = file;
                }
            }
            if (list.Count == 0)
            {
                DialogResult dialogResult;
                dialogResult = MessageBox.Show("You didn,t select any image\nAre you want to select images again", "Picture Viewer", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    openFileDialog.ShowDialog();
                    foreach (string file in openFileDialog.FileNames)
                    {
                        if (!list.Contains(file))
                        {
                            ListBox_Images.Items.Add(Path.GetFileName(file));
                            list.Add(file);
                            dictionary[Path.GetFileName(file)] = file;
                        }
                    }
                }
            }
        }

        private void singlebtn_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                
                if (ListBox_Images.SelectedItems.Count == 0)
                {
                    DialogResult dialogResult;
                    dialogResult = MessageBox.Show("You didn,t select any image", "Picture Viewer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ListBox_Images.SelectedItems.Count > 1)
                {
                    DialogResult dialogResult;
                    dialogResult = MessageBox.Show("Sorry!!\nYou selected more than an image", "Picture Viewer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 
                }
                else
                {

                    statusBar1.Visible = false;
                    panel3.Controls.Clear();
                    GC.Collect();GC.WaitForPendingFinalizers();
                    PictureBox picturebox = new PictureBox();
                    picturebox.BorderStyle = BorderStyle.FixedSingle;
                    picturebox.Size = new Size(600, 410);
                    picturebox.SizeMode = PictureBoxSizeMode.StretchImage;
                    picturebox.Image = Image.FromFile(dictionary[ListBox_Images.SelectedItem.ToString()]);
                    panel3.Controls.Add(picturebox);

                }
            }
           
        }
        List<string> SelectedList = new List<string>();
        private void multibtn_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                statusBar1.Visible = false;
                panel3.Controls.Clear();
                GC.Collect(); GC.WaitForPendingFinalizers();
                SelectedList.Clear();
                foreach (string s in ListBox_Images.SelectedItems)
                {
                    SelectedList.Add(dictionary[s]);
                }
                if (SelectedList.Count == 0)
                {
                    DialogResult dialogResult;
                    dialogResult = MessageBox.Show("You didn,t select any image", "Picture Viewer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int CurTop = 0, CurLeft = 0;
                    foreach (string image in SelectedList)
                    {
                        PictureBox picturebox = new PictureBox();
                        picturebox.Size = new Size(190, 170);
                        picturebox.BorderStyle = BorderStyle.FixedSingle;
                        picturebox.SizeMode = PictureBoxSizeMode.StretchImage;

                        picturebox.Location = new Point(CurLeft, CurTop);
                        CurLeft += 195;
                        if (CurLeft >= 540)
                        {
                            CurLeft = 0;
                            CurTop += 175;
                        }
                        picturebox.Image = Image.FromFile(image);
                        panel3.Controls.Add(picturebox);

                    }
                }
            }
        }

        private void slidebtn_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            GC.Collect(); GC.WaitForPendingFinalizers();
            SelectedList.Clear();
            foreach (string s in ListBox_Images.SelectedItems)
            {
                SelectedList.Add(dictionary[s]);
            }
            if (SelectedList.Count == 0)
            {
                DialogResult dialogResult;
                dialogResult = MessageBox.Show("You didn,t select any image", "Picture Viewer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else
            {
                idx = 0;
                statusBar1.Visible = true;
                timer1.Enabled = true;
            }
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            singlebtn.Enabled = false; multibtn.Enabled = false; 
            btnchoose.Enabled = false; exitbtn.Enabled = false;
            slidebtn.Enabled = false;
            contextMenuStrip1.Items[0].Enabled = false;
            contextMenuStrip1.Items[1].Enabled = false;
            contextMenuStrip1.Items[2].Enabled = false;
            PictureBox picturebox = new PictureBox();
            picturebox.Size = new Size(600, 410);
            picturebox.BorderStyle = BorderStyle.FixedSingle;
            picturebox.SizeMode = PictureBoxSizeMode.StretchImage;
            picturebox.Image = Image.FromFile(SelectedList[idx]);
            panel3.Controls.Add(picturebox);
            statusBar1.Panels[0].Text = Path.GetFileName(SelectedList[idx]).ToString();
            if (idx == SelectedList.Count-1)
            {
                timer1.Enabled = false;
                singlebtn.Enabled = true;multibtn.Enabled = true;
                btnchoose.Enabled = true; exitbtn.Enabled = true;
                slidebtn.Enabled = true;
                contextMenuStrip1.Items[0].Enabled = true;
                contextMenuStrip1.Items[1].Enabled = true;
                contextMenuStrip1.Items[2].Enabled = true;
            }
            idx++;

        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                DialogResult dialogResult;
                dialogResult=MessageBox.Show("Are you sure you want to exit picture viewer", "Picture Viewer", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if(dialogResult==DialogResult.Yes) Application.Exit();

            }
               
        }
        private void statusBar1_PanelClick(object sender, StatusBarPanelClickEventArgs e)
        {

        }
        private void contextMenuStrip1_Opening_1(object sender, CancelEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}