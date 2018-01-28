using System;
using Foundation;
using UIKit;

namespace Calculator
{
    public partial class ViewController : UIViewController
    {
        public readonly ICalculator m_calculator;
        public readonly IHelper m_helper;
        protected ViewController(IntPtr handle) : base(handle)
        {
        }

        public ViewController(ICalculator m_calculator, IHelper m_helper)
        {
            m_calculator = new Calculator();
            m_helper = new Helper();
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
            var a = m_helper.ConvertStringToInt(InputFieldA.Text);
            var b = m_helper.ConvertStringToInt(InputFieldB.Text);

            InputFieldA.ResignFirstResponder();
            InputFieldB.ResignFirstResponder();
            var result = "";
            var m_calculator = new Calculator();
            if (!string.IsNullOrWhiteSpace(a.ToString()) && !string.IsNullOrWhiteSpace(b.ToString()))
                result = m_calculator.Add(a, b).ToString();

            OutputField.Text = result;
        }

        partial void MultiplyButton_TouchUpInside(UIButton sender)
        {
            var a = m_helper.ConvertStringToInt(InputFieldA.Text);
            var b = m_helper.ConvertStringToInt(InputFieldB.Text);

            InputFieldA.ResignFirstResponder();
            InputFieldB.ResignFirstResponder();
            var result = "";
            var m_calculator = new Calculator();
            if (!string.IsNullOrWhiteSpace(a.ToString()) && !string.IsNullOrWhiteSpace(b.ToString()))
                result = m_calculator.Multiply(a, b).ToString();

            OutputField.Text = result;
        }
    }
}
