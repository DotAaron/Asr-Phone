// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace asrphone
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel asrphonelabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton CallServer { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton getidbutton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton getserverinfo { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel infocontent { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField ipBox { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView logField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField tcpcontentfield { get; set; }

        [Action ("CallServer_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void CallServer_TouchUpInside (UIKit.UIButton sender);

        [Action ("clearinfo:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void clearinfo (UIKit.UITextField sender);

        [Action ("contentchanged:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void contentchanged (UIKit.UITextField sender);

        [Action ("Getserverinfo_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void Getserverinfo_TouchUpInside (UIKit.UIButton sender);

        [Action ("UIButton8887_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UIButton8887_TouchUpInside (UIKit.UIButton sender);

        [Action ("writeinfo:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void writeinfo (UIKit.UITextField sender);

        void ReleaseDesignerOutlets ()
        {
            if (asrphonelabel != null) {
                asrphonelabel.Dispose ();
                asrphonelabel = null;
            }

            if (CallServer != null) {
                CallServer.Dispose ();
                CallServer = null;
            }

            if (getidbutton != null) {
                getidbutton.Dispose ();
                getidbutton = null;
            }

            if (getserverinfo != null) {
                getserverinfo.Dispose ();
                getserverinfo = null;
            }

            if (infocontent != null) {
                infocontent.Dispose ();
                infocontent = null;
            }

            if (ipBox != null) {
                ipBox.Dispose ();
                ipBox = null;
            }

            if (logField != null) {
                logField.Dispose ();
                logField = null;
            }

            if (tcpcontentfield != null) {
                tcpcontentfield.Dispose ();
                tcpcontentfield = null;
            }
        }
    }
}