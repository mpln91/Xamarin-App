﻿using System;
using Foundation;
using UIKit;

namespace Calculator
{
    public partial class ViewController : UIViewController
    {

        protected ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void AddButton_TouchUpInside(UIButton sender)
        {
            var a = Int32.Parse(InputFieldA.Text);
            var b = Int32.Parse(InputFieldB.Text);

            InputFieldA.ResignFirstResponder();
            InputFieldB.ResignFirstResponder();
            var result = "";
            var m_calculator = new Calculator();
            if (!string.IsNullOrWhiteSpace(a.ToString()) && !string.IsNullOrWhiteSpace(b.ToString()))
                result = m_calculator.Add(a, b).ToString();

            OutputField.Text = result;
        }

    }
}