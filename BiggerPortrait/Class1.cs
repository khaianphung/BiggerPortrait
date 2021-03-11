using Microsoft.Xna.Framework;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewModdingAPI.Utilities;
using StardewValley;
using StardewValley.Menus;
using System;
using System.Threading;
using System.Windows.Forms;

namespace BiggerPortrait
{
     
    /// <summary>The mod entry point.</summary>
    public class ModEntry : Mod
    {
        Form1 f1;
        bool running = true;
        /*********
        ** Public methods
        *********/
        /// <summary>The mod entry point, called after the mod is first loaded.</summary>
        /// <param name="helper">Provides simplified APIs for writing mods.</param>
        public override void Entry(IModHelper helper)
        {



            helper.Events.GameLoop.SaveLoaded += this.OnSaveLoaded;
            helper.Events.Input.ButtonPressed += this.OnButtonPressed;
            

        }


       //was private
        public void OnSaveLoaded(object sender, SaveLoadedEventArgs e)
        {
            
            f1 = new Form1();
            f1.emptyPictureBox();
            f1.Show();
           
        }

        /*********
        ** Private methods
        *********/
        /// <summary>Raised after the player presses a button on the keyboard, controller, or mouse.</summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event data.</param>
        /// 
        //was PRIVATE
        public void OnButtonPressed(object sender, ButtonPressedEventArgs e)
        {
            // ignore if player hasn't loaded a save yet
            if (!Context.IsWorldReady)
                return;

            this.Monitor.Log($"{f1.Enabled} {f1.IsDisposed}.", LogLevel.Debug);
            if (Game1.dialogueUp && Game1.currentSpeaker!= null)
            {




                this.Monitor.Log($"{f1.Enabled} {f1.IsDisposed}.", LogLevel.Debug);
                if (running == true)
                {
                    if (f1.IsDisposed)
                    {
                        f1 = new Form1();
                        f1.emptyPictureBox();
                        f1.Show();
                    }
                       f1.resetPicture();
                    
                }

            //this.Monitor.Log($"{Game1.player.Name} pressed {e.Button} { Game1.currentSpeaker.Name} {Game1.currentSpeaker.CurrentDialogue.Peek().CurrentEmotion} .", LogLevel.Debug);


                if (running == false && e.Button.ToString() == "H")
                {
                    //Application.Run(new BiggerPortrait.Form1());

                    f1 = new Form1();
                    f1.resetPicture();
                    f1.Show();
                    running = true;
                }
            
                else if (running == true && e.Button.ToString() == "H")
                {
                    //Application.Run(new BiggerPortrait.Form1());


                    f1.Close();
                    running = false;
                }
            }
            else if (!Game1.dialogueUp && running == true)
            {
                //Application.Run(new BiggerPortrait.Form1());


                f1.Close();
                //running = false;
            }


            // print button presses to the console window
            
            //if (e.Button.Equals("Z")) return;
        }
        /*
        public void resetPortrait()
        {
            if (Game1.currentSpeaker.Name ==("Abigail"))
            {
                if (Game1.currentSpeaker.CurrentDialogue.Peek().CurrentEmotion == "$neutral")
                {
                    f1.setPicture("Abigail", "neutral");
                }
                if (Game1.currentSpeaker.CurrentDialogue.Peek().CurrentEmotion == "$h")
                {
                    f1.setPicture("Abigail", "happy");
                }
                if (Game1.currentSpeaker.CurrentDialogue.Peek().CurrentEmotion == "$s")
                {
                    f1.setPicture("Abigail", "sad");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 3)
                {
                    f1.setPicture("Abigail", "custom");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 4)
                {
                    f1.setPicture("Abigail", "blush");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 5)
                {
                    f1.setPicture("Abigail", "angry");
                }

            }
            if (Game1.currentSpeaker.Name == ("Alex"))
            {
                if (Game1.currentSpeaker.CurrentEmoteIndex == 0)
                {
                    f1.setPicture("Alex", "neutral");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 1)
                {
                    f1.setPicture("Alex", "happy");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 2)
                {
                    f1.setPicture("Alex", "sad");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 3)
                {
                    f1.setPicture("Alex", "custom");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 4)
                {
                    f1.setPicture("Alex", "blush");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 5)
                {
                    f1.setPicture("Alex", "angry");
                }

            }
            if (Game1.currentSpeaker.Name == ("Caroline"))
            {
                if (Game1.currentSpeaker.CurrentEmoteIndex == 0)
                {
                    f1.setPicture("Caroline", "neutral");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 1)
                {
                    f1.setPicture("Caroline", "happy");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 2)
                {
                    f1.setPicture("Caroline", "sad");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 3)
                {
                    f1.setPicture("Caroline", "custom");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 4)
                {
                    f1.setPicture("Caroline", "blush");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 5)
                {
                    f1.setPicture("Caroline", "angry");
                }

            }
            if (Game1.currentSpeaker.Name == ("Clint"))
            {
                if (Game1.currentSpeaker.CurrentEmoteIndex == 0)
                {
                    f1.setPicture("Clint", "neutral");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 1)
                {
                    f1.setPicture("Clint", "happy");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 2)
                {
                    f1.setPicture("Clint", "sad");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 3)
                {
                    f1.setPicture("Clint", "custom");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 4)
                {
                    f1.setPicture("Clint", "blush");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 5)
                {
                    f1.setPicture("Clint", "angry");
                }

            }
            if (Game1.currentSpeaker.Name == ("Demetrius"))
            {
                if (Game1.currentSpeaker.CurrentEmoteIndex == 0)
                {
                    f1.setPicture("Demetrius", "neutral");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 1)
                {
                    f1.setPicture("Demetrius", "happy");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 2)
                {
                    f1.setPicture("Demetrius", "sad");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 3)
                {
                    f1.setPicture("Demetrius", "custom");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 4)
                {
                    f1.setPicture("Demetrius", "blush");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 5)
                {
                    f1.setPicture("Demetrius", "angry");
                }

            }
            if (Game1.currentSpeaker.Name == ("Dwarf"))
            {
                if (Game1.currentSpeaker.CurrentEmoteIndex == 0)
                {
                    f1.setPicture("Dwarf", "neutral");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 1)
                {
                    f1.setPicture("Dwarf", "happy");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 2)
                {
                    f1.setPicture("Dwarf", "sad");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 3)
                {
                    f1.setPicture("Dwarf", "custom");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 4)
                {
                    f1.setPicture("Dwarf", "blush");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 5)
                {
                    f1.setPicture("Dwarf", "angry");
                }

            }
            if (Game1.currentSpeaker.Name == ("Elliott"))
            {
                if (Game1.currentSpeaker.CurrentEmoteIndex == 0)
                {
                    f1.setPicture("Elliott", "neutral");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 1)
                {
                    f1.setPicture("Elliott", "happy");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 2)
                {
                    f1.setPicture("Elliott", "sad");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 3)
                {
                    f1.setPicture("Elliott", "custom");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 4)
                {
                    f1.setPicture("Elliott", "blush");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 5)
                {
                    f1.setPicture("Elliott", "angry");
                }

            }
            if (Game1.currentSpeaker.Name == ("Emily"))
            {
                if (Game1.currentSpeaker.CurrentEmoteIndex == 0)
                {
                    f1.setPicture("Emily", "neutral");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 1)
                {
                    f1.setPicture("Emily", "happy");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 2)
                {
                    f1.setPicture("Emily", "sad");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 3)
                {
                    f1.setPicture("Emily", "custom");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 4)
                {
                    f1.setPicture("Emily", "blush");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 5)
                {
                    f1.setPicture("Emily", "angry");
                }

            }
            if (Game1.currentSpeaker.Name == ("Evelyn"))
            {
                if (Game1.currentSpeaker.CurrentEmoteIndex == 0)
                {
                    f1.setPicture("Evelyn", "neutral");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 1)
                {
                    f1.setPicture("Evelyn", "happy");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 2)
                {
                    f1.setPicture("Evelyn", "sad");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 3)
                {
                    f1.setPicture("Evelyn", "custom");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 4)
                {
                    f1.setPicture("Evelyn", "blush");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 5)
                {
                    f1.setPicture("Evelyn", "angry");
                }

            }
            if (Game1.currentSpeaker.Name == ("George"))
            {
                if (Game1.currentSpeaker.CurrentEmoteIndex == 0)
                {
                    f1.setPicture("George", "neutral");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 1)
                {
                    f1.setPicture("George", "happy");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 2)
                {
                    f1.setPicture("George", "sad");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 3)
                {
                    f1.setPicture("George", "custom");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 4)
                {
                    f1.setPicture("George", "blush");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 5)
                {
                    f1.setPicture("George", "angry");
                }

            }
            if (Game1.currentSpeaker.Name == ("Gunther"))
            {
                if (Game1.currentSpeaker.CurrentEmoteIndex == 0)
                {
                    f1.setPicture("Gunther", "neutral");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 1)
                {
                    f1.setPicture("Gunther", "happy");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 2)
                {
                    f1.setPicture("Gunther", "sad");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 3)
                {
                    f1.setPicture("Gunther", "custom");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 4)
                {
                    f1.setPicture("Gunther", "blush");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 5)
                {
                    f1.setPicture("Gunther", "angry");
                }

            }
            if (Game1.currentSpeaker.Name == ("Gus"))
            {
                if (Game1.currentSpeaker.CurrentEmoteIndex == 0)
                {
                    f1.setPicture("Gus", "neutral");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 1)
                {
                    f1.setPicture("Gus", "happy");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 2)
                {
                    f1.setPicture("Gus", "sad");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 3)
                {
                    f1.setPicture("Gus", "custom");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 4)
                {
                    f1.setPicture("Gus", "blush");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 5)
                {
                    f1.setPicture("Gus", "angry");
                }

            }
            if (Game1.currentSpeaker.Name == ("Haley"))
            {
                if (Game1.currentSpeaker.CurrentEmoteIndex == 0)
                {
                    f1.setPicture("Haley", "neutral");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 1)
                {
                    f1.setPicture("Haley", "happy");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 2)
                {
                    f1.setPicture("Haley", "sad");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 3)
                {
                    f1.setPicture("Haley", "custom");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 4)
                {
                    f1.setPicture("Haley", "blush");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 5)
                {
                    f1.setPicture("Haley", "angry");
                }

            }
            if (Game1.currentSpeaker.Name == ("Harvey"))
            {
                if (Game1.currentSpeaker.CurrentEmoteIndex == 0)
                {
                    f1.setPicture("Harvey", "neutral");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 1)
                {
                    f1.setPicture("Harvey", "happy");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 2)
                {
                    f1.setPicture("Harvey", "sad");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 3)
                {
                    f1.setPicture("Harvey", "custom");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 4)
                {
                    f1.setPicture("Harvey", "blush");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 5)
                {
                    f1.setPicture("Harvey", "angry");
                }

            }
            if (Game1.currentSpeaker.Name == ("Jas"))
            {
                if (Game1.currentSpeaker.CurrentEmoteIndex == 0)
                {
                    f1.setPicture("Jas", "neutral");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 1)
                {
                    f1.setPicture("Jas", "happy");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 2)
                {
                    f1.setPicture("Jas", "sad");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 3)
                {
                    f1.setPicture("Jas", "custom");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 4)
                {
                    f1.setPicture("Jas", "blush");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 5)
                {
                    f1.setPicture("Jas", "angry");
                }

            }
            if (Game1.currentSpeaker.Name == ("Jodi"))
            {
                if (Game1.currentSpeaker.CurrentEmoteIndex == 0)
                {
                    f1.setPicture("Jodi", "neutral");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 1)
                {
                    f1.setPicture("Jodi", "happy");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 2)
                {
                    f1.setPicture("Jodi", "sad");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 3)
                {
                    f1.setPicture("Jodi", "custom");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 4)
                {
                    f1.setPicture("Jodi", "blush");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 5)
                {
                    f1.setPicture("Jodi", "angry");
                }

            }
            if (Game1.currentSpeaker.Name == ("Kent"))
            {
                if (Game1.currentSpeaker.CurrentEmoteIndex == 0)
                {
                    f1.setPicture("Kent", "neutral");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 1)
                {
                    f1.setPicture("Kent", "happy");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 2)
                {
                    f1.setPicture("Kent", "sad");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 3)
                {
                    f1.setPicture("Kent", "custom");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 4)
                {
                    f1.setPicture("Kent", "blush");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 5)
                {
                    f1.setPicture("Kent", "angry");
                }

            }
            if (Game1.currentSpeaker.Name == ("Leah"))
            {
                if (Game1.currentSpeaker.CurrentEmoteIndex == 0)
                {
                    f1.setPicture("Leah", "neutral");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 1)
                {
                    f1.setPicture("Leah", "happy");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 2)
                {
                    f1.setPicture("Leah", "sad");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 3)
                {
                    f1.setPicture("Leah", "custom");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 4)
                {
                    f1.setPicture("Leah", "blush");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 5)
                {
                    f1.setPicture("Leah", "angry");
                }

            }
            if (Game1.currentSpeaker.Name == ("Lewis"))
            {
                if (Game1.currentSpeaker.CurrentDialogue.Peek().CurrentEmotion == "$neutral")
                {
                    f1.setPicture("Lewis", "neutral");
                }
                if (Game1.currentSpeaker.CurrentDialogue.Peek().CurrentEmotion == "$h")
                {
                    f1.setPicture("Lewis", "happy");
                }
                if (Game1.currentSpeaker.CurrentDialogue.Peek().CurrentEmotion == "$s")
                {
                    f1.setPicture("Lewis", "sad");
                }
                if (Game1.currentSpeaker.CurrentDialogue.Peek().CurrentEmotion == "$custom")
                {
                    f1.setPicture("Lewis", "custom");
                }
                if (Game1.currentSpeaker.CurrentDialogue.Peek().CurrentEmotion == "$b")
                {
                    f1.setPicture("Lewis", "blush");
                }
                if (Game1.currentSpeaker.CurrentDialogue.Peek().CurrentEmotion == "$a")
                {
                    f1.setPicture("Lewis", "angry");
                }

            }
            if (Game1.currentSpeaker.Name == ("Linus"))
            {
                if (Game1.currentSpeaker.CurrentEmoteIndex == 0)
                {
                    f1.setPicture("Linus", "neutral");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 1)
                {
                    f1.setPicture("Linus", "happy");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 2)
                {
                    f1.setPicture("Linus", "sad");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 3)
                {
                    f1.setPicture("Linus", "custom");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 4)
                {
                    f1.setPicture("Linus", "blush");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 5)
                {
                    f1.setPicture("Linus", "angry");
                }

            }
            if (Game1.currentSpeaker.Name == ("Marlon"))
            {
                if (Game1.currentSpeaker.CurrentEmoteIndex == 0)
                {
                    f1.setPicture("Marlon", "neutral");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 1)
                {
                    f1.setPicture("Marlon", "happy");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 2)
                {
                    f1.setPicture("Marlon", "sad");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 3)
                {
                    f1.setPicture("Marlon", "custom");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 4)
                {
                    f1.setPicture("Marlon", "blush");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 5)
                {
                    f1.setPicture("Marlon", "angry");
                }

            }
            if (Game1.currentSpeaker.Name == ("Marnie"))
            {
                if (Game1.currentSpeaker.CurrentEmoteIndex == 0)
                {
                    f1.setPicture("Marnie", "neutral");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 1)
                {
                    f1.setPicture("Marnie", "happy");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 2)
                {
                    f1.setPicture("Marnie", "sad");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 3)
                {
                    f1.setPicture("Marnie", "custom");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 4)
                {
                    f1.setPicture("Marnie", "blush");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 5)
                {
                    f1.setPicture("Marnie", "angry");
                }

            }
            if (Game1.currentSpeaker.Name == ("Maru"))
            {
                if (Game1.currentSpeaker.CurrentEmoteIndex == 0)
                {
                    f1.setPicture("Maru", "neutral");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 1)
                {
                    f1.setPicture("Maru", "happy");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 2)
                {
                    f1.setPicture("Maru", "sad");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 3)
                {
                    f1.setPicture("Maru", "custom");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 4)
                {
                    f1.setPicture("Maru", "blush");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 5)
                {
                    f1.setPicture("Maru", "angry");
                }

            }
            if (Game1.currentSpeaker.Name == ("Morris"))
            {
                if (Game1.currentSpeaker.CurrentEmoteIndex == 0)
                {
                    f1.setPicture("Morris", "neutral");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 1)
                {
                    f1.setPicture("Morris", "happy");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 2)
                {
                    f1.setPicture("Morris", "sad");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 3)
                {
                    f1.setPicture("Morris", "custom");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 4)
                {
                    f1.setPicture("Morris", "blush");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 5)
                {
                    f1.setPicture("Morris", "angry");
                }

            }
            if (Game1.currentSpeaker.Name == ("Pam"))
            {
                if (Game1.currentSpeaker.CurrentEmoteIndex == 0)
                {
                    f1.setPicture("Pam", "neutral");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 1)
                {
                    f1.setPicture("Pam", "happy");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 2)
                {
                    f1.setPicture("Pam", "sad");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 3)
                {
                    f1.setPicture("Pam", "custom");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 4)
                {
                    f1.setPicture("Pam", "blush");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 5)
                {
                    f1.setPicture("Pam", "angry");
                }

            }
            if (Game1.currentSpeaker.Name == ("Penny"))
            {
                if (Game1.currentSpeaker.CurrentEmoteIndex == 0)
                {
                    f1.setPicture("Penny", "neutral");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 1)
                {
                    f1.setPicture("Penny", "happy");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 2)
                {
                    f1.setPicture("Penny", "sad");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 3)
                {
                    f1.setPicture("Penny", "custom");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 4)
                {
                    f1.setPicture("Penny", "blush");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 5)
                {
                    f1.setPicture("Penny", "angry");
                }

            }
            if (Game1.currentSpeaker.Name == ("Pierre"))
            {
                if (Game1.currentSpeaker.CurrentEmoteIndex == 0)
                {
                    f1.setPicture("Pierre", "neutral");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 1)
                {
                    f1.setPicture("Pierre", "happy");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 2)
                {
                    f1.setPicture("Pierre", "sad");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 3)
                {
                    f1.setPicture("Pierre", "custom");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 4)
                {
                    f1.setPicture("Pierre", "blush");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 5)
                {
                    f1.setPicture("Pierre", "angry");
                }

            }
            if (Game1.currentSpeaker.Name == ("Robin"))
            {
                if (Game1.currentSpeaker.CurrentEmoteIndex == 0)
                {
                    f1.setPicture("Robin", "neutral");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 1)
                {
                    f1.setPicture("Robin", "happy");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 2)
                {
                    f1.setPicture("Robin", "sad");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 3)
                {
                    f1.setPicture("Robin", "custom");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 4)
                {
                    f1.setPicture("Robin", "blush");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 5)
                {
                    f1.setPicture("Robin", "angry");
                }

            }
            if (Game1.currentSpeaker.Name == ("Sam"))
            {
                if (Game1.currentSpeaker.CurrentEmoteIndex == 0)
                {
                    f1.setPicture("Sam", "neutral");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 1)
                {
                    f1.setPicture("Sam", "happy");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 2)
                {
                    f1.setPicture("Sam", "sad");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 3)
                {
                    f1.setPicture("Sam", "custom");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 4)
                {
                    f1.setPicture("Sam", "blush");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 5)
                {
                    f1.setPicture("Sam", "angry");
                }

            }
            if (Game1.currentSpeaker.Name == ("Sandy"))
            {
                if (Game1.currentSpeaker.CurrentEmoteIndex == 0)
                {
                    f1.setPicture("Sandy", "neutral");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 1)
                {
                    f1.setPicture("Sandy", "happy");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 2)
                {
                    f1.setPicture("Sandy", "sad");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 3)
                {
                    f1.setPicture("Sandy", "custom");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 4)
                {
                    f1.setPicture("Sandy", "blush");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 5)
                {
                    f1.setPicture("Sandy", "angry");
                }

            }
            if (Game1.currentSpeaker.Name == ("Shane"))
            {
                if (Game1.currentSpeaker.CurrentEmoteIndex == 0)
                {
                    f1.setPicture("Shane", "neutral");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 1)
                {
                    f1.setPicture("Shane", "happy");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 2)
                {
                    f1.setPicture("Shane", "sad");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 3)
                {
                    f1.setPicture("Shane", "custom");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 4)
                {
                    f1.setPicture("Shane", "blush");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 5)
                {
                    f1.setPicture("Shane", "angry");
                }

            }
            if (Game1.currentSpeaker.Name == ("Sebastian"))
            {
                if (Game1.currentSpeaker.CurrentEmoteIndex == 0)
                {
                    f1.setPicture("Sebastian", "neutral");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 1)
                {
                    f1.setPicture("Sebastian", "happy");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 2)
                {
                    f1.setPicture("Sebastian", "sad");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 3)
                {
                    f1.setPicture("Sebastian", "custom");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 4)
                {
                    f1.setPicture("Sebastian", "blush");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 5)
                {
                    f1.setPicture("Sebastian", "angry");
                }

            }
            if (Game1.currentSpeaker.Name == ("Vincent"))
            {
                if (Game1.currentSpeaker.CurrentEmoteIndex == 0)
                {
                    f1.setPicture("Vincent", "neutral");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 1)
                {
                    f1.setPicture("Vincent", "happy");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 2)
                {
                    f1.setPicture("Vincent", "sad");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 3)
                {
                    f1.setPicture("Vincent", "custom");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 4)
                {
                    f1.setPicture("Vincent", "blush");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 5)
                {
                    f1.setPicture("Vincent", "angry");
                }

            }
            if (Game1.currentSpeaker.Name == ("Willy"))
            {
                if (Game1.currentSpeaker.CurrentEmoteIndex == 0)
                {
                    f1.setPicture("Willy", "neutral");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 1)
                {
                    f1.setPicture("Willy", "happy");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 2)
                {
                    f1.setPicture("Willy", "sad");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 3)
                {
                    f1.setPicture("Willy", "custom");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 4)
                {
                    f1.setPicture("Willy", "blush");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 5)
                {
                    f1.setPicture("Willy", "angry");
                }

            }
            if (Game1.currentSpeaker.Name == ("Wizard"))
            {
                if (Game1.currentSpeaker.CurrentEmoteIndex == 0)
                {
                    f1.setPicture("Wizard", "neutral");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 1)
                {
                    f1.setPicture("Wizard", "happy");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 2)
                {
                    f1.setPicture("Wizard", "sad");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 3)
                {
                    f1.setPicture("Wizard", "custom");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 4)
                {
                    f1.setPicture("Wizard", "blush");
                }
                if (Game1.currentSpeaker.CurrentEmoteIndex == 5)
                {
                    f1.setPicture("Wizard", "angry");
                }

            }
        }

        
        */



    }
}