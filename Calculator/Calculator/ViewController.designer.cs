// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace Calculator
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton AddButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField InputFieldA { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField InputFieldB { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton MultiplyButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField OutputField { get; set; }

        [Action ("AddButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void AddButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("MultiplyButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void MultiplyButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (AddButton != null) {
                AddButton.Dispose ();
                AddButton = null;
            }

            if (InputFieldA != null) {
                InputFieldA.Dispose ();
                InputFieldA = null;
            }

            if (InputFieldB != null) {
                InputFieldB.Dispose ();
                InputFieldB = null;
            }

            if (MultiplyButton != null) {
                MultiplyButton.Dispose ();
                MultiplyButton = null;
            }

            if (OutputField != null) {
                OutputField.Dispose ();
                OutputField = null;
            }
        }
    }
}