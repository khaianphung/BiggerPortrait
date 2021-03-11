using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using System.Threading.Tasks;
using StardewValley;
using KeyEventArgs = System.Windows.Forms.KeyEventArgs;
using System.IO;

namespace BiggerPortrait
{

    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            SetProcessDPIAware();
            Rectangle appRect;
            GetWindowRect(GetForegroundWindow(), out appRect);
            //Rectangle appRect = getActiveWindowBounds();
            this.Size= new Size(appRect.Width, appRect.Height);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Opacity = 0.99;
            this.TopMost = true;

           
            this.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;
            this.BackgroundImageLayout = ImageLayout.Center;




            
            //Bitmap b = CaptureApplication();
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Location = new Point((this.Width - pictureBox1.Width) /2, (this.Height - pictureBox1.Height) / 2);
            pictureBox1.Size = new Size(1, 1);
            //resetPicture();
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            //pictureBox1.Image= (Image)b;
            //this.Show();

            //System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            //timer1.Interval = 5000;//5 seconds
            //timer1.Tick += new System.EventHandler(timer1_Tick);

            //timer1.Start();


            
            //if (Game1.dialogueUp && Game1.currentSpeaker != null)
            //{
             //   resetPicture();
            //}

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //do whatever you want 
            if (Game1.dialogueUp && Game1.currentSpeaker != null)
            {
                resetPicture();
                //Form1 NewForm = new Form1();
                //NewForm.resetPicture();
                //NewForm.Show();
                //this.Dispose();

            }
        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Game1.dialogueUp && Game1.currentSpeaker != null)
            {
                resetPicture();
                //this.Show();
            }
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            if (Game1.dialogueUp && Game1.currentSpeaker != null)
            {
                resetPicture();
                //this.Show();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (Game1.dialogueUp && Game1.currentSpeaker != null)
            {
                resetPicture();
                //this.Show();
            }
        }

        public void emptyPictureBox()
        {
            pictureBox1.Image = null;
            //pictureBox1.InitialImage = null;
        }
        public void resetPicture()
        {
            string emotion="";
            string characterName = Game1.currentSpeaker.Name;
            string path = Directory.GetCurrentDirectory();
            //MessageBox.Show(path);

            if (Game1.currentSpeaker.CurrentDialogue.Peek().CurrentEmotion == "$neutral")
            {
                emotion = "neutral";
            }
            else if (Game1.currentSpeaker.CurrentDialogue.Peek().CurrentEmotion == "$h")
            {
                emotion = "happy";
            }
            else if (Game1.currentSpeaker.CurrentDialogue.Peek().CurrentEmotion == "$s")
            {
                emotion = "sad";
            }
            else if (Game1.currentSpeaker.CurrentDialogue.Peek().CurrentEmotion == "$custom")
            {
                emotion = "custom";
            }
            else if (Game1.currentSpeaker.CurrentDialogue.Peek().CurrentEmotion == "$a")
            {
                emotion = "angry";
            }

            if (characterName==("Abigail"))
            {

                if (emotion==("neutral"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Abigail\neutral.gif");

                }
                if (emotion==("happy"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Abigail\happy.gif");
                }
                if (emotion==("sad"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Abigail\sad.gif");
                }
                if (emotion==("custom"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Abigail\custom.gif");
                }
                if (emotion==("blush"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Abigail\blush.gif");
                }
                if (emotion==("angry"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Abigail\angry.gif");
                }
            }
            else if (characterName == ("Alex"))
            {
                if (emotion==("neutral"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Alex\neutral.gif");

                }
                if (emotion==("happy"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Alex\happy.gif");
                }
                if (emotion==("sad"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Alex\sad.gif");
                }
                if (emotion==("custom"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Alex\custom.gif");
                }
                if (emotion==("blush"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Alex\blush.gif");
                }
                if (emotion==("angry"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Alex\angry.gif");
                }
            }
            else if (characterName == ("Caroline"))
            {
                if (emotion==("neutral"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Caroline\neutral.gif");

                }
                if (emotion==("happy"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Caroline\happy.gif");
                }
                if (emotion==("sad"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Caroline\sad.gif");
                }
                if (emotion==("custom"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Caroline\custom.gif");
                }
                if (emotion==("blush"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Caroline\blush.gif");
                }
                if (emotion==("angry"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Caroline\angry.gif");
                }
            }
            else if (characterName == ("Clint"))
            {
                if (emotion==("neutral"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Clint\neutral.gif");

                }
                if (emotion==("happy"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Clint\happy.gif");
                }
                if (emotion==("sad"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Clint\sad.gif");
                }
                if (emotion==("custom"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Clint\custom.gif");
                }
                if (emotion==("blush"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Clint\blush.gif");
                }
                if (emotion==("angry"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Clint\angry.gif");
                }
            }
            else if (characterName == ("Demetrius"))
            {
                if (emotion==("neutral"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Demetrius\neutral.gif");

                }
                if (emotion==("happy"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Demetrius\happy.gif");
                }
                if (emotion==("sad"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Demetrius\sad.gif");
                }
                if (emotion==("custom"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Demetrius\custom.gif");
                }
                if (emotion==("blush"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Demetrius\blush.gif");
                }
                if (emotion==("angry"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Demetrius\angry.gif");
                }
            }
            else if (characterName == ("Dwarf"))
            {
                if (emotion==("neutral"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Dwarf\neutral.gif");

                }
                if (emotion==("happy"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Dwarf\happy.gif");
                }
                if (emotion==("sad"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Dwarf\sad.gif");
                }
                if (emotion==("custom"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Dwarf\custom.gif");
                }
                if (emotion==("blush"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Dwarf\blush.gif");
                }
                if (emotion==("angry"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Dwarf\angry.gif");
                }
            }
            else if (characterName == ("Elliott"))
            {
                if (emotion==("neutral"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Elliott\neutral.gif");

                }
                if (emotion==("happy"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Elliott\happy.gif");
                }
                if (emotion==("sad"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Elliott\sad.gif");
                }
                if (emotion==("custom"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Elliott\custom.gif");
                }
                if (emotion==("blush"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Elliott\blush.gif");
                }
                if (emotion==("angry"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Elliott\angry.gif");
                }
            }
            else if (characterName == ("Emily"))
            {
                if (emotion==("neutral"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Emily\neutral.gif");

                }
                if (emotion==("happy"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Emily\happy.gif");
                }
                if (emotion==("sad"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Emily\sad.gif");
                }
                if (emotion==("custom"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Emily\custom.gif");
                }
                if (emotion==("blush"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Emily\blush.gif");
                }
                if (emotion==("angry"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Emily\angry.gif");
                }
            }
            else if (characterName == ("Evelyn"))
            {
                if (emotion==("neutral"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Evelyn\neutral.gif");

                }
                if (emotion==("happy"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Evelyn\happy.gif");
                }
                if (emotion==("sad"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Evelyn\sad.gif");
                }
                if (emotion==("custom"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Evelyn\custom.gif");
                }
                if (emotion==("blush"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Evelyn\blush.gif");
                }
                if (emotion==("angry"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Evelyn\angry.gif");
                }
            }
            else if (characterName == ("George"))
            {
                if (emotion==("neutral"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\George\neutral.gif");

                }
                if (emotion==("happy"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\George\happy.gif");
                }
                if (emotion==("sad"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\George\sad.gif");
                }
                if (emotion==("custom"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\George\custom.gif");
                }
                if (emotion==("blush"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\George\blush.gif");
                }
                if (emotion==("angry"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\George\angry.gif");
                }
            }
            else if (characterName == ("Gunther"))
            {
                if (emotion==("neutral"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Gunther\neutral.gif");

                }
                if (emotion==("happy"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Gunther\happy.gif");
                }
                if (emotion==("sad"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Gunther\sad.gif");
                }
                if (emotion==("custom"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Gunther\custom.gif");
                }
                if (emotion==("blush"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Gunther\blush.gif");
                }
                if (emotion==("angry"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Gunther\angry.gif");
                }
            }
            else if (characterName == ("Gus"))
            {
                if (emotion==("neutral"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Gus\neutral.gif");

                }
                if (emotion==("happy"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Gus\happy.gif");
                }
                if (emotion==("sad"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Gus\sad.gif");
                }
                if (emotion==("custom"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Gus\custom.gif");
                }
                if (emotion==("blush"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Gus\blush.gif");
                }
                if (emotion==("angry"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Gus\angry.gif");
                }
            }
            else if (characterName == ("Haley"))
            {
                if (emotion==("neutral"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Haley\neutral.gif");

                }
                if (emotion==("happy"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Haley\happy.gif");
                }
                if (emotion==("sad"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Haley\sad.gif");
                }
                if (emotion==("custom"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Haley\custom.gif");
                }
                if (emotion==("blush"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Haley\blush.gif");
                }
                if (emotion==("angry"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Haley\angry.gif");
                }
            }
            else if (characterName == ("Harvey"))
            {
                if (emotion==("neutral"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Harvey\neutral.gif");

                }
                if (emotion==("happy"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Harvey\happy.gif");
                }
                if (emotion==("sad"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Harvey\sad.gif");
                }
                if (emotion==("custom"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Harvey\custom.gif");
                }
                if (emotion==("blush"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Harvey\blush.gif");
                }
                if (emotion==("angry"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Harvey\angry.gif");
                }
            }
            else if (characterName == ("Jas"))
            {
                if (emotion==("neutral"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Jas\neutral.gif");

                }
                if (emotion==("happy"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Jas\happy.gif");
                }
                if (emotion==("sad"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Jas\sad.gif");
                }
                if (emotion==("custom"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Jas\custom.gif");
                }
                if (emotion==("blush"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Jas\blush.gif");
                }
                if (emotion==("angry"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Jas\angry.gif");
                }
            }
            else if (characterName == ("Jodi"))
            {
                if (emotion==("neutral"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Jodi\neutral.gif");

                }
                if (emotion==("happy"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Jodi\happy.gif");
                }
                if (emotion==("sad"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Jodi\sad.gif");
                }
                if (emotion==("custom"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Jodi\custom.gif");
                }
                if (emotion==("blush"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Jodi\blush.gif");
                }
                if (emotion==("angry"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Jodi\angry.gif");
                }
            }
            else if (characterName == ("Kent"))
            {
                if (emotion==("neutral"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Kent\neutral.gif");

                }
                if (emotion==("happy"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Kent\happy.gif");
                }
                if (emotion==("sad"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Kent\sad.gif");
                }
                if (emotion==("custom"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Kent\custom.gif");
                }
                if (emotion==("blush"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Kent\blush.gif");
                }
                if (emotion==("angry"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Kent\angry.gif");
                }
            }
            else if (characterName == ("Leah"))
            {
                if (emotion==("neutral"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Leah\neutral.gif");

                }
                if (emotion==("happy"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Leah\happy.gif");
                }
                if (emotion==("sad"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Leah\sad.gif");
                }
                if (emotion==("custom"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Leah\custom.gif");
                }
                if (emotion==("blush"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Leah\blush.gif");
                }
                if (emotion==("angry"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Leah\angry.gif");
                }
            }
            else if (characterName == ("Lewis"))
            {
                if (emotion==("neutral"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Lewis\neutral.gif");

                }
                if (emotion==("happy"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Lewis\happy.gif");
                }
                if (emotion==("sad"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Lewis\sad.gif");
                }
                if (emotion==("custom"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Lewis\custom.gif");
                }
                if (emotion==("blush"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Lewis\blush.gif");
                }
                if (emotion==("angry"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Lewis\angry.gif");
                }
            }
            else if (characterName == ("Linus"))
            {
                if (emotion==("neutral"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Linus\neutral.gif");

                }
                if (emotion==("happy"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Linus\happy.gif");
                }
                if (emotion==("sad"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Linus\sad.gif");
                }
                if (emotion==("custom"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Linus\custom.gif");
                }
                if (emotion==("blush"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Linus\blush.gif");
                }
                if (emotion==("angry"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Linus\angry.gif");
                }
            }
            else if (characterName==("Marlon"))
            {
                if (emotion==("neutral"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Marlon\neutral.gif");

                }
                if (emotion==("happy"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Marlon\happy.gif");
                }
                if (emotion==("sad"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Marlon\sad.gif");
                }
                if (emotion==("custom"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Marlon\custom.gif");
                }
                if (emotion==("blush"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Marlon\blush.gif");
                }
                if (emotion==("angry"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Marlon\angry.gif");
                }
            }
            else if (characterName==("Marnie"))
            {
                if (emotion==("neutral"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Marnie\neutral.gif");

                }
                if (emotion==("happy"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Marnie\happy.gif");
                }
                if (emotion==("sad"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Marnie\sad.gif");
                }
                if (emotion==("custom"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Marnie\custom.gif");
                }
                if (emotion==("blush"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Marnie\blush.gif");
                }
                if (emotion==("angry"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Marnie\angry.gif");
                }
            }
            else if (characterName==("Maru"))
            {
                if (emotion==("neutral"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Maru\neutral.gif");

                }
                if (emotion==("happy"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Maru\happy.gif");
                }
                if (emotion==("sad"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Maru\sad.gif");
                }
                if (emotion==("custom"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Maru\custom.gif");
                }
                if (emotion==("blush"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Maru\blush.gif");
                }
                if (emotion==("angry"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Maru\angry.gif");
                }
            }
            else if (characterName==("Morris"))
            {
                if (emotion==("neutral"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Morris\neutral.gif");

                }
                if (emotion==("happy"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Morris\happy.gif");
                }
                if (emotion==("sad"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Morris\sad.gif");
                }
                if (emotion==("custom"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Morris\custom.gif");
                }
                if (emotion==("blush"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Morris\blush.gif");
                }
                if (emotion==("angry"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Morris\angry.gif");
                }
            }
            else if (characterName==("Pam"))
            {
                if (emotion==("neutral"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Pam\neutral.gif");

                }
                if (emotion==("happy"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Pam\happy.gif");
                }
                if (emotion==("sad"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Pam\sad.gif");
                }
                if (emotion==("custom"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Pam\custom.gif");
                }
                if (emotion==("blush"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Pam\blush.gif");
                }
                if (emotion==("angry"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Pam\angry.gif");
                }
            }
            else if (characterName==("Penny"))
            {
                if (emotion==("neutral"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Penny\neutral.gif");

                }
                if (emotion==("happy"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Penny\happy.gif");
                }
                if (emotion==("sad"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Penny\sad.gif");
                }
                if (emotion==("custom"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Penny\custom.gif");
                }
                if (emotion==("blush"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Penny\blush.gif");
                }
                if (emotion==("angry"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Penny\angry.gif");
                }
            }
            else if (characterName==("Pierre"))
            {
                if (emotion==("neutral"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Pierre\neutral.gif");

                }
                if (emotion==("happy"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Pierre\happy.gif");
                }
                if (emotion==("sad"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Pierre\sad.gif");
                }
                if (emotion==("custom"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Pierre\custom.gif");
                }
                if (emotion==("blush"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Pierre\blush.gif");
                }
                if (emotion==("angry"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Pierre\angry.gif");
                }
            }
            else if (characterName==("Robin"))
            {
                if (emotion==("neutral"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Robin\neutral.gif");

                }
                if (emotion==("happy"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Robin\happy.gif");
                }
                if (emotion==("sad"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Robin\sad.gif");
                }
                if (emotion==("custom"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Robin\custom.gif");
                }
                if (emotion==("blush"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Robin\blush.gif");
                }
                if (emotion==("angry"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Robin\angry.gif");
                }
            }
            else if (characterName==("Sam"))
            {
                if (emotion==("neutral"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Sam\neutral.gif");

                }
                if (emotion==("happy"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Sam\happy.gif");
                }
                if (emotion==("sad"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Sam\sad.gif");
                }
                if (emotion==("custom"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Sam\custom.gif");
                }
                if (emotion==("blush"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Sam\blush.gif");
                }
                if (emotion==("angry"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Sam\angry.gif");
                }
            }
            else if (characterName==("Sandy"))
            {
                if (emotion==("neutral"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Sandy\neutral.gif");

                }
                if (emotion==("happy"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Sandy\happy.gif");
                }
                if (emotion==("sad"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Sandy\sad.gif");
                }
                if (emotion==("custom"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Sandy\custom.gif");
                }
                if (emotion==("blush"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Sandy\blush.gif");
                }
                if (emotion==("angry"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Sandy\angry.gif");
                }
            }
            else if (characterName==("Shane"))
            {
                if (emotion==("neutral"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Shane\neutral.gif");

                }
                if (emotion==("happy"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Shane\happy.gif");
                }
                if (emotion==("sad"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Shane\sad.gif");
                }
                if (emotion==("custom"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Shane\custom.gif");
                }
                if (emotion==("blush"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Shane\blush.gif");
                }
                if (emotion==("angry"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Shane\angry.gif");
                }
            }
            else if (characterName==("Sebastian"))
            {
                if (emotion==("neutral"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Sebastian\neutral.gif");

                }
                if (emotion==("happy"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Sebastian\happy.gif");
                }
                if (emotion==("sad"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Sebastian\sad.gif");
                }
                if (emotion==("custom"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Sebastian\custom.gif");
                }
                if (emotion==("blush"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Sebastian\blush.gif");
                }
                if (emotion==("angry"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Sebastian\angry.gif");
                }
            }
            else if (characterName==("Vincent"))
            {
                if (emotion==("neutral"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Vincent\neutral.gif");

                }
                if (emotion==("happy"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Vincent\happy.gif");
                }
                if (emotion==("sad"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Vincent\sad.gif");
                }
                if (emotion==("custom"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Vincent\custom.gif");
                }
                if (emotion==("blush"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Vincent\blush.gif");
                }
                if (emotion==("angry"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Vincent\angry.gif");
                }
            }
            else if (characterName==("Willy"))
            {
                if (emotion==("neutral"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Willy\neutral.gif");

                }
                if (emotion==("happy"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Willy\happy.gif");
                }
                if (emotion==("sad"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Willy\sad.gif");
                }
                if (emotion==("custom"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Willy\custom.gif");
                }
                if (emotion==("blush"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Willy\blush.gif");
                }
                if (emotion==("angry"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Willy\angry.gif");
                }
            }
            else if (characterName==("Wizard"))
            {
                if (emotion==("neutral"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Wizard\neutral.gif");

                }
                if (emotion==("happy"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Wizard\happy.gif");
                }
                if (emotion==("sad"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Wizard\sad.gif");
                }
                if (emotion==("custom"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Wizard\custom.gif");
                }
                if (emotion==("blush"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Wizard\blush.gif");
                }
                if (emotion==("angry"))
                {
                    pictureBox1.Image = Image.FromFile(path + @"\Mods\BiggerPortrait\assets\Pics\Wizard\angry.gif");
                }
            }
            pictureBox1.Location = new Point((this.Width - pictureBox1.Image.Width) / 2, (this.Height - pictureBox1.Image.Height) / 2);
        }
      


        [DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetWindowRect(IntPtr hWnd, out Rectangle lpRect);




       

        public Bitmap CaptureApplication()
        {

            Rectangle bounds = this.Bounds;
            using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    
                    g.CopyFromScreen(new Point(bounds.Right * 592 / 1000, bounds.Bottom * 708 / 1000), Point.Empty, bounds.Size);
                }


                Bitmap bmp1 = bitmap.Clone(new Rectangle(bounds.Left, bounds.Top, bounds.Right*115/1000, bounds.Bottom*22/100), bitmap.PixelFormat);

                int zoomFactor = 3;
                Size newSize = new Size((int)(bmp1.Width * zoomFactor), (int)(bmp1.Height * zoomFactor));
                Bitmap bmp2 = new Bitmap(bmp1, newSize);


                return bmp2;


            }
        }

        
    }
}