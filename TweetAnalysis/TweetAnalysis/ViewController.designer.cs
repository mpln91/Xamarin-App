// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace TweetAnalysis
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField THandleName { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView TopTweet { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (THandleName != null) {
                THandleName.Dispose ();
                THandleName = null;
            }

            if (TopTweet != null) {
                TopTweet.Dispose ();
                TopTweet = null;
            }
        }
    }
}