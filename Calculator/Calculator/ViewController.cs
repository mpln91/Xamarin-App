using System;
using Foundation;
using UIKit;

namespace Calculator
{
    public partial class ViewController : UIViewController
    {
        public readonly ICalculator m_calculator = new Calculator();
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
            var result = "";
            if (!string.IsNullOrWhiteSpace(InputFieldA.Text) && !string.IsNullOrWhiteSpace(InputFieldB.Text))
                result = m_calculator.Add(InputFieldA.Text, InputFieldB.Text).ToString();

            OutputField.Text = result;
        }

        partial void MultiplyButton_TouchUpInside(UIButton sender)
        {
            var result = "";
            if (!string.IsNullOrWhiteSpace(InputFieldA.Text) && !string.IsNullOrWhiteSpace(InputFieldB.Text))
                result = m_calculator.Multiply(InputFieldA.Text, InputFieldB.Text).ToString();

            OutputField.Text = result;
        }
    }
}
