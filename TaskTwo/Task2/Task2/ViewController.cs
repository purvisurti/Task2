using System;
using System.Text;
using UIKit;

namespace Task2
{
    public partial class ViewController : UIViewController
    {
        int counter = 0;
       
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            ButtonOne.SetTitle("", UIControlState.Normal);
            ButtonTwo.SetTitle("", UIControlState.Normal);
            ButtonThree.SetTitle("", UIControlState.Normal);
            ButtonFour.SetTitle("", UIControlState.Normal);
            ButtonFive.SetTitle("", UIControlState.Normal);
            ButtonSix.SetTitle("", UIControlState.Normal);
            ButtonSeven.SetTitle("", UIControlState.Normal);
            ButtonEight.SetTitle("", UIControlState.Normal);
            ButtonNine.SetTitle("", UIControlState.Normal);
            LabelWinner.Text = "";
                // Perform any additional setup after loading the view, typically from a nib.
        }       

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
      
        
        partial void ButtonOne_TouchUpInside(UIButton sender)
        {
            if (counter == 0)
            {
                ButtonOne.SetTitle("X", UIControlState.Normal);
                ButtonOne.SetTitleColor(UIColor.Black, UIControlState.Normal);
                LabelTurn.Text = "Turn X";
                counter++;
            }
            else if (counter == 1)
            {
                ButtonOne.SetTitle("O", UIControlState.Normal);
                ButtonOne.SetTitleColor(UIColor.Black, UIControlState.Normal);
                LabelTurn.Text = "Turn O";
                counter--;
            }
           
            ButtonOne.Enabled = false;

            
            checkit();
           
        }
        partial void ButtonTwo_TouchUpInside(UIButton sender)
        {
            if (counter == 0)
            {
                ButtonTwo.SetTitle("X", UIControlState.Normal);
                ButtonTwo.SetTitleColor(UIColor.Black, UIControlState.Normal);
                LabelTurn.Text = "Turn X";
                counter++;
            }
            else if (counter == 1)
            {
                ButtonTwo.SetTitle("O", UIControlState.Normal);
                ButtonTwo.SetTitleColor(UIColor.Black, UIControlState.Normal);
                LabelTurn.Text = "Turn O";
                counter--;
            }
           
            ButtonTwo.Enabled = false;

           
            checkit();
           
        }

        partial void ButtonThree_TouchUpInside(UIButton sender)
        {
            if (counter == 0)
            {
                ButtonThree.SetTitle("X", UIControlState.Normal);
                ButtonThree.SetTitleColor(UIColor.Black, UIControlState.Normal);
                LabelTurn.Text = "Turn X";
                counter++;
            }
            else if (counter == 1)
            {
                ButtonThree.SetTitle("O", UIControlState.Normal);
                ButtonThree.SetTitleColor(UIColor.Black, UIControlState.Normal);
                LabelTurn.Text = "Turn O";
                counter--;
            }
           
            ButtonThree.Enabled = false;

           
            checkit();
           
        }
        partial void ButtonFour_TouchUpInside(UIButton sender)
        {
            if (counter == 0)
            {
                ButtonFour.SetTitle("X", UIControlState.Normal);
                ButtonFour.SetTitleColor(UIColor.Black, UIControlState.Normal);
                LabelTurn.Text = "Turn X";
                counter++;
            }
            else if (counter == 1)
            {
                ButtonFour.SetTitle("O", UIControlState.Normal);
                ButtonFour.SetTitleColor(UIColor.Black, UIControlState.Normal);
                LabelTurn.Text = "Turn O";
                counter--;
            }
            
            ButtonFour.Enabled = false;

            
            checkit();
           
        }

        partial void ButtonFive_TouchUpInside(UIButton sender)
        {
            if (counter == 0)
            {
                ButtonFive.SetTitle("X", UIControlState.Normal);
                ButtonFive.SetTitleColor(UIColor.Black, UIControlState.Normal);
                LabelTurn.Text = "Turn X";
                counter++;
            }
            else if (counter == 1)
            {
                ButtonFive.SetTitle("O", UIControlState.Normal);
                ButtonFive.SetTitleColor(UIColor.Black, UIControlState.Normal);
                LabelTurn.Text = "Turn O ";
                counter--;
            }
           
            ButtonFive.Enabled = false;

            
            checkit();
           
        }

        partial void ButtonSix_TouchUpInside(UIButton sender)
        {
            if (counter == 0)
            {
                ButtonSix.SetTitle("X", UIControlState.Normal);
                ButtonSix.SetTitleColor(UIColor.Black, UIControlState.Normal);
                counter++;
            }
            else if (counter == 1)
            {
                ButtonSix.SetTitle("O", UIControlState.Normal);
                ButtonSix.SetTitleColor(UIColor.Black, UIControlState.Normal);
                counter--;
            }
            
            ButtonSix.Enabled = false;

           
            checkit();
            
        }

        partial void ButtonSeven_TouchUpInside(UIButton sender)
        {
            if (counter == 0)
            {
                ButtonSeven.SetTitle("X", UIControlState.Normal);
                ButtonSeven.SetTitleColor(UIColor.Black, UIControlState.Normal);
                counter++;
            }
            else if (counter == 1)
            {
                ButtonSeven.SetTitle("O", UIControlState.Normal);
                ButtonSeven.SetTitleColor(UIColor.Black, UIControlState.Normal);
                counter--;
            }
            
            ButtonSeven.Enabled = false;

          
            checkit();

        }

        partial void ButtonEight_TouchUpInside(UIButton sender)
        {
            if (counter == 0)
            {
                ButtonEight.SetTitle("X", UIControlState.Normal);
                ButtonEight.SetTitleColor(UIColor.Black, UIControlState.Normal);
                counter++;
            }
            else if (counter == 1)
            {
                ButtonEight.SetTitle("O", UIControlState.Normal);
                ButtonEight.SetTitleColor(UIColor.Black, UIControlState.Normal);
                counter--;
            }
            
            ButtonEight.Enabled = false;

           
            checkit();

        }

        partial void ButtonNine_TouchUpInside(UIButton sender)
        {
            if (counter == 0)
            {
                ButtonNine.SetTitle("X", UIControlState.Normal);
                ButtonNine.SetTitleColor(UIColor.Black, UIControlState.Normal);
                counter++;
            }
            else if (counter == 1)
            {
                ButtonNine.SetTitle("O", UIControlState.Normal);
                ButtonNine.SetTitleColor(UIColor.Black, UIControlState.Normal);
                counter--;
            }
           
            ButtonNine.Enabled = false;

           
            checkit();

        }
        public void checkit()
        {
            //Check if tie
              if (!ButtonOne.Title(UIControlState.Normal).Equals("") && !ButtonTwo.Title(UIControlState.Normal).Equals("") && !ButtonThree.Title(UIControlState.Normal).Equals("") &&
                   !ButtonFour.Title(UIControlState.Normal).Equals("") && !ButtonFive.Title(UIControlState.Normal).Equals("") && !ButtonSix.Title(UIControlState.Normal).Equals("") &&
                  !ButtonSeven.Title(UIControlState.Normal).Equals("") && !ButtonEight.Title(UIControlState.Normal).Equals("") && !ButtonNine.Title(UIControlState.Normal).Equals(""))
               {
                   LabelWinner.Text = "Tie";
               }

            //Check diagonal for X
            if (!ButtonOne.Title(UIControlState.Normal).Equals("") || !ButtonFive.Title(UIControlState.Normal).Equals("") || !ButtonNine.Title(UIControlState.Normal).Equals(""))
            {
                if (ButtonOne.Title(UIControlState.Normal).Equals("X") && ButtonFive.Title(UIControlState.Normal).Equals("X") && ButtonNine.Title(UIControlState.Normal).Equals("X"))
                {
                    LabelWinner.Text = "Player X wins";
                    ButtonOne.Enabled = false;
                    ButtonTwo.Enabled = false;
                    ButtonThree.Enabled = false;
                    ButtonFour.Enabled = false;
                    ButtonFive.Enabled = false;
                    ButtonSix.Enabled = false;
                    ButtonSeven.Enabled = false;
                    ButtonEight.Enabled = false;
                    ButtonNine.Enabled = false;
                }
            }
            if (!ButtonThree.Title(UIControlState.Normal).Equals("") || !ButtonFive.Title(UIControlState.Normal).Equals("") || !ButtonSeven.Title(UIControlState.Normal).Equals(""))
            {
                if (ButtonThree.Title(UIControlState.Normal).Equals("X") && ButtonFive.Title(UIControlState.Normal).Equals("X") && ButtonSeven.Title(UIControlState.Normal).Equals("X"))
                {
                    LabelWinner.Text = "Player X wins";
                    ButtonOne.Enabled = false;
                    ButtonTwo.Enabled = false;
                    ButtonThree.Enabled = false;
                    ButtonFour.Enabled = false;
                    ButtonFive.Enabled = false;
                    ButtonSix.Enabled = false;
                    ButtonSeven.Enabled = false;
                    ButtonEight.Enabled = false;
                    ButtonNine.Enabled = false;
                }
            }
            //Check rows for X
            if (!ButtonOne.Title(UIControlState.Normal).Equals("") || !ButtonTwo.Title(UIControlState.Normal).Equals("") || !ButtonThree.Title(UIControlState.Normal).Equals(""))
            {
                if (ButtonOne.Title(UIControlState.Normal).Equals("X") && ButtonTwo.Title(UIControlState.Normal).Equals("X") && ButtonThree.Title(UIControlState.Normal).Equals("X"))
                {
                    LabelWinner.Text = "Player X wins";
                    ButtonOne.Enabled = false;
                    ButtonTwo.Enabled = false;
                    ButtonThree.Enabled = false;
                    ButtonFour.Enabled = false;
                    ButtonFive.Enabled = false;
                    ButtonSix.Enabled = false;
                    ButtonSeven.Enabled = false;
                    ButtonEight.Enabled = false;
                    ButtonNine.Enabled = false;
                }
            }
            if (!ButtonFour.Title(UIControlState.Normal).Equals("") || !ButtonFive.Title(UIControlState.Normal).Equals("") || !ButtonSix.Title(UIControlState.Normal).Equals(""))
            {
                if (ButtonFour.Title(UIControlState.Normal).Equals("X") && ButtonFive.Title(UIControlState.Normal).Equals("X") && ButtonSix.Title(UIControlState.Normal).Equals("X"))
                {
                    LabelWinner.Text = "Player X wins";
                    ButtonOne.Enabled = false;
                    ButtonTwo.Enabled = false;
                    ButtonThree.Enabled = false;
                    ButtonFour.Enabled = false;
                    ButtonFive.Enabled = false;
                    ButtonSix.Enabled = false;
                    ButtonSeven.Enabled = false;
                    ButtonEight.Enabled = false;
                    ButtonNine.Enabled = false;
                }
            }
            if (!ButtonSeven.Title(UIControlState.Normal).Equals("") || !ButtonEight.Title(UIControlState.Normal).Equals("") || !ButtonNine.Title(UIControlState.Normal).Equals(""))
            {
                if (ButtonSeven.Title(UIControlState.Normal).Equals("X") && ButtonEight.Title(UIControlState.Normal).Equals("X") && ButtonNine.Title(UIControlState.Normal).Equals("X"))
                {
                    LabelWinner.Text = "Player X wins";
                    ButtonOne.Enabled = false;
                    ButtonTwo.Enabled = false;
                    ButtonThree.Enabled = false;
                    ButtonFour.Enabled = false;
                    ButtonFive.Enabled = false;
                    ButtonSix.Enabled = false;
                    ButtonSeven.Enabled = false;
                    ButtonEight.Enabled = false;
                    ButtonNine.Enabled = false;
                }
            }
            //Check columns for X
            if (!ButtonOne.Title(UIControlState.Normal).Equals("") || !ButtonFour.Title(UIControlState.Normal).Equals("") || !ButtonSeven.Title(UIControlState.Normal).Equals(""))
            {
                if (ButtonOne.Title(UIControlState.Normal).Equals("X") && ButtonFour.Title(UIControlState.Normal).Equals("X") && ButtonSeven.Title(UIControlState.Normal).Equals("X"))
                {
                    LabelWinner.Text = "Player X wins";
                    ButtonOne.Enabled = false;
                    ButtonTwo.Enabled = false;
                    ButtonThree.Enabled = false;
                    ButtonFour.Enabled = false;
                    ButtonFive.Enabled = false;
                    ButtonSix.Enabled = false;
                    ButtonSeven.Enabled = false;
                    ButtonEight.Enabled = false;
                    ButtonNine.Enabled = false;
                }
            }
            if (!ButtonTwo.Title(UIControlState.Normal).Equals("") || !ButtonFive.Title(UIControlState.Normal).Equals("") || !ButtonEight.Title(UIControlState.Normal).Equals(""))
            {
                if (ButtonTwo.Title(UIControlState.Normal).Equals("X") && ButtonFive.Title(UIControlState.Normal).Equals("X") && ButtonEight.Title(UIControlState.Normal).Equals("X"))
                {
                    LabelWinner.Text = "Player X wins";
                    ButtonOne.Enabled = false;
                    ButtonTwo.Enabled = false;
                    ButtonThree.Enabled = false;
                    ButtonFour.Enabled = false;
                    ButtonFive.Enabled = false;
                    ButtonSix.Enabled = false;
                    ButtonSeven.Enabled = false;
                    ButtonEight.Enabled = false;
                    ButtonNine.Enabled = false;
                }
            }
            if (!ButtonThree.Title(UIControlState.Normal).Equals("") || !ButtonSix.Title(UIControlState.Normal).Equals("") || !ButtonNine.Title(UIControlState.Normal).Equals(""))
            {
                if (ButtonThree.Title(UIControlState.Normal).Equals("X") && ButtonSix.Title(UIControlState.Normal).Equals("X") && ButtonNine.Title(UIControlState.Normal).Equals("X"))
                {
                    LabelWinner.Text = "Player X wins";
                    ButtonOne.Enabled = false;
                    ButtonTwo.Enabled = false;
                    ButtonThree.Enabled = false;
                    ButtonFour.Enabled = false;
                    ButtonFive.Enabled = false;
                    ButtonSix.Enabled = false;
                    ButtonSeven.Enabled = false;
                    ButtonEight.Enabled = false;
                    ButtonNine.Enabled = false;
                }
            }
            //Check diagonal for O
            if (!ButtonOne.Title(UIControlState.Normal).Equals("") || !ButtonFive.Title(UIControlState.Normal).Equals("") || !ButtonNine.Title(UIControlState.Normal).Equals(""))
            {
                if (ButtonOne.Title(UIControlState.Normal).Equals("O") && ButtonFive.Title(UIControlState.Normal).Equals("O") && ButtonNine.Title(UIControlState.Normal).Equals("O"))
                {
                    LabelWinner.Text = "Player O wins";
                    ButtonOne.Enabled = false;
                    ButtonTwo.Enabled = false;
                    ButtonThree.Enabled = false;
                    ButtonFour.Enabled = false;
                    ButtonFive.Enabled = false;
                    ButtonSix.Enabled = false;
                    ButtonSeven.Enabled = false;
                    ButtonEight.Enabled = false;
                    ButtonNine.Enabled = false;
                }
            }
            if (!ButtonThree.Title(UIControlState.Normal).Equals("") || !ButtonFive.Title(UIControlState.Normal).Equals("") || !ButtonSeven.Title(UIControlState.Normal).Equals(""))
            {
                if (ButtonThree.Title(UIControlState.Normal).Equals("O") && ButtonFive.Title(UIControlState.Normal).Equals("O") && ButtonSeven.Title(UIControlState.Normal).Equals("O"))
                {
                    LabelWinner.Text = "Player O wins";
                    ButtonOne.Enabled = false;
                    ButtonTwo.Enabled = false;
                    ButtonThree.Enabled = false;
                    ButtonFour.Enabled = false;
                    ButtonFive.Enabled = false;
                    ButtonSix.Enabled = false;
                    ButtonSeven.Enabled = false;
                    ButtonEight.Enabled = false;
                    ButtonNine.Enabled = false;
                }
            }
            //Check rows for O
            if (!ButtonOne.Title(UIControlState.Normal).Equals("") || !ButtonTwo.Title(UIControlState.Normal).Equals("") || !ButtonThree.Title(UIControlState.Normal).Equals(""))
            {
                if (ButtonOne.Title(UIControlState.Normal).Equals("O") && ButtonTwo.Title(UIControlState.Normal).Equals("O") && ButtonThree.Title(UIControlState.Normal).Equals("O"))
                {
                    LabelWinner.Text = "Player O wins";
                    ButtonOne.Enabled = false;
                    ButtonTwo.Enabled = false;
                    ButtonThree.Enabled = false;
                    ButtonFour.Enabled = false;
                    ButtonFive.Enabled = false;
                    ButtonSix.Enabled = false;
                    ButtonSeven.Enabled = false;
                    ButtonEight.Enabled = false;
                    ButtonNine.Enabled = false;
                }
            }
            if (!ButtonFour.Title(UIControlState.Normal).Equals("") || !ButtonFive.Title(UIControlState.Normal).Equals("") || !ButtonSix.Title(UIControlState.Normal).Equals(""))
            {
                if (ButtonFour.Title(UIControlState.Normal).Equals("O") && ButtonFive.Title(UIControlState.Normal).Equals("O") && ButtonSix.Title(UIControlState.Normal).Equals("O"))
                {
                    LabelWinner.Text = "Player O wins";
                    ButtonOne.Enabled = false;
                    ButtonTwo.Enabled = false;
                    ButtonThree.Enabled = false;
                    ButtonFour.Enabled = false;
                    ButtonFive.Enabled = false;
                    ButtonSix.Enabled = false;
                    ButtonSeven.Enabled = false;
                    ButtonEight.Enabled = false;
                    ButtonNine.Enabled = false;
                }
            }
            if (!ButtonSeven.Title(UIControlState.Normal).Equals("") || !ButtonEight.Title(UIControlState.Normal).Equals("") || !ButtonNine.Title(UIControlState.Normal).Equals(""))
            {
                if (ButtonSeven.Title(UIControlState.Normal).Equals("O") && ButtonEight.Title(UIControlState.Normal).Equals("O") && ButtonNine.Title(UIControlState.Normal).Equals("O"))
                {
                    LabelWinner.Text = "Player O wins";
                    ButtonOne.Enabled = false;
                    ButtonTwo.Enabled = false;
                    ButtonThree.Enabled = false;
                    ButtonFour.Enabled = false;
                    ButtonFive.Enabled = false;
                    ButtonSix.Enabled = false;
                    ButtonSeven.Enabled = false;
                    ButtonEight.Enabled = false;
                    ButtonNine.Enabled = false;
                }
            }
            //Check columns for O
            if (!ButtonOne.Title(UIControlState.Normal).Equals("") || !ButtonFour.Title(UIControlState.Normal).Equals("") || !ButtonSeven.Title(UIControlState.Normal).Equals(""))
            {
                if (ButtonOne.Title(UIControlState.Normal).Equals("O") && ButtonFour.Title(UIControlState.Normal).Equals("O") && ButtonSeven.Title(UIControlState.Normal).Equals("O"))
                {
                    LabelWinner.Text = "Player O wins";
                    ButtonOne.Enabled = false;
                    ButtonTwo.Enabled = false;
                    ButtonThree.Enabled = false;
                    ButtonFour.Enabled = false;
                    ButtonFive.Enabled = false;
                    ButtonSix.Enabled = false;
                    ButtonSeven.Enabled = false;
                    ButtonEight.Enabled = false;
                    ButtonNine.Enabled = false;
                }
            }
            if (!ButtonTwo.Title(UIControlState.Normal).Equals("") || !ButtonFive.Title(UIControlState.Normal).Equals("") || !ButtonEight.Title(UIControlState.Normal).Equals(""))
            {
                if (ButtonTwo.Title(UIControlState.Normal).Equals("O") && ButtonFive.Title(UIControlState.Normal).Equals("O") && ButtonEight.Title(UIControlState.Normal).Equals("O"))
                {
                    LabelWinner.Text = "Player O wins";
                    ButtonOne.Enabled = false;
                    ButtonTwo.Enabled = false;
                    ButtonThree.Enabled = false;
                    ButtonFour.Enabled = false;
                    ButtonFive.Enabled = false;
                    ButtonSix.Enabled = false;
                    ButtonSeven.Enabled = false;
                    ButtonEight.Enabled = false;
                    ButtonNine.Enabled = false;
                }
            }
            if (!ButtonThree.Title(UIControlState.Normal).Equals("") || !ButtonSix.Title(UIControlState.Normal).Equals("") || !ButtonNine.Title(UIControlState.Normal).Equals(""))
            {
                if (ButtonThree.Title(UIControlState.Normal).Equals("O") && ButtonSix.Title(UIControlState.Normal).Equals("O") && ButtonNine.Title(UIControlState.Normal).Equals("O"))
                {
                    LabelWinner.Text = "Player O wins";
                    ButtonOne.Enabled = false;
                    ButtonTwo.Enabled = false;
                    ButtonThree.Enabled = false;
                    ButtonFour.Enabled = false;
                    ButtonFive.Enabled = false;
                    ButtonSix.Enabled = false;
                    ButtonSeven.Enabled = false;
                    ButtonEight.Enabled = false;
                    ButtonNine.Enabled = false;
                }
            }         
        }

        partial void ButtonRestart_TouchUpInside(UIButton sender)
        {
            LabelWinner.Text = "";
            //ButtonOne.TitleLabel.Text = "";
            ButtonOne.Enabled = true;
            ButtonOne.SetTitle("", UIControlState.Normal);
            string btnOne = ButtonOne.Title(UIControlState.Normal);

            //  ButtonTwo.TitleLabel.Text = "";
            ButtonTwo.Enabled = true;
            ButtonTwo.SetTitle("", UIControlState.Normal);
            string btnTwo = ButtonTwo.Title(UIControlState.Normal);

            // ButtonTwo.SetTitle("", UIControlState.Normal);
            // ButtonThree.TitleLabel.Text = "";
            ButtonThree.Enabled = true;
            ButtonThree.SetTitle("", UIControlState.Normal);
            string btnThree = ButtonThree.Title(UIControlState.Normal);
            //  ButtonThree.SetTitle("", UIControlState.Normal);

            // ButtonFour.TitleLabel.Text = "";
            ButtonFour.Enabled = true;
            ButtonFour.SetTitle("", UIControlState.Normal);
            string btnFour = ButtonFour.Title(UIControlState.Normal);
            // ButtonFour.SetTitle("", UIControlState.Normal);

            // ButtonFive.TitleLabel.Text = "";

            ButtonFive.SetTitle("", UIControlState.Normal);
            ButtonFive.Enabled = true;
            string btnFive = ButtonFive.Title(UIControlState.Normal);
            // ButtonSix.TitleLabel.Text = "";
            ButtonSix.Enabled = true;
            ButtonSix.SetTitle("", UIControlState.Normal);
            string btnSix = ButtonSix.Title(UIControlState.Normal);


            // ButtonSeven.TitleLabel.Text = "";
            ButtonSeven.Enabled = true;
            ButtonSeven.SetTitle("", UIControlState.Normal);
            string btnSeven = ButtonSeven.Title(UIControlState.Normal);

            //  ButtonEight.TitleLabel.Text = "";
            ButtonEight.Enabled = true;
              ButtonEight.SetTitle("", UIControlState.Normal);
            string btnEight = ButtonEight.Title(UIControlState.Normal);
            //  ButtonNine.TitleLabel.Text = "";
            ButtonNine.Enabled = true;
              ButtonNine.SetTitle("", UIControlState.Normal);
            string btnNine = ButtonNine.Title(UIControlState.Normal);
            counter = 0;
        }

        
    }
}
        