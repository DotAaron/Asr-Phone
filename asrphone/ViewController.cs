using System;
using System.Drawing;
using System.Device.Location;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using UIKit;

namespace asrphone
{
    public partial class ViewController : UIViewController
    {

        bool connected = false;

        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            logField.Text = "";
            tcpcontentfield.Hidden = true;
            infocontent.Text = "";
            getidbutton.Hidden = true;
            getserverinfo.Hidden = true;
            internbutton.Hidden = true;

            UIToolbar toolbar = new UIToolbar(new RectangleF(0.0f, 0.0f, (float)(View.Frame.Size.Width / 3), 44.0f));

            toolbar.TintColor = UIColor.White;
            toolbar.BarStyle = UIBarStyle.Black;

            toolbar.Translucent = true;

            toolbar.Items = new UIBarButtonItem[]{
        new UIBarButtonItem("execute ",
            UIBarButtonItemStyle.Plain, AddBarButtonText),
                new UIBarButtonItem("sendpkg ",
            UIBarButtonItemStyle.Plain, AddBarButtonText),
                new UIBarButtonItem("id:lock ",
            UIBarButtonItemStyle.Plain, AddBarButtonText),
                new UIBarButtonItem("id:send ",
            UIBarButtonItemStyle.Plain, AddBarButtonText),
        new UIBarButtonItem(UIBarButtonSystemItem.FlexibleSpace),
        new UIBarButtonItem(UIBarButtonSystemItem.Done, delegate {
            this.tcpcontentfield.ResignFirstResponder();
    })
     };

            this.tcpcontentfield.KeyboardAppearance = UIKeyboardAppearance.Dark;
            this.tcpcontentfield.InputAccessoryView = toolbar;
        }

        partial void clearinfo(UITextField sender)
        {
            infocontent.Text = "";
        }

        public void AddBarButtonText(object sender, EventArgs e)
        {
            var barButtonItem = sender as UIBarButtonItem;
            if (barButtonItem != null)
                this.tcpcontentfield.Text += barButtonItem.Title;

        }

        partial void contentchanged(UITextField sender)
        {
            infocontent.Text = sender.Text;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        public void TestServer()
        {
            multiversprotocol.tcpsocket.srvIP = "89.92.176.192";
            multiversprotocol.tcpsocket.srvPort = 100;
            multiversprotocol.mp.tcpSend(Encoding.Unicode.GetBytes("asrphone_byte_test"));

            CallServer.SetTitle("Send", UIControlState.Normal);
            tcpcontentfield.Hidden = false;
            connected = true;
            getidbutton.Hidden = false;
            getserverinfo.Hidden = false;
            internbutton.Hidden = false;

        }

        partial void Getserverinfo_TouchUpInside(UIButton sender)
        {
            UpdateMPLogs();
            //Create Alert
            var okAlertController = UIAlertController.Create("Information", multiversprotocol.tcpsocket.GetAnswer(Encoding.Unicode.GetBytes("phone.getinfo")), UIAlertControllerStyle.Alert);
            UpdateMPLogs();
            okAlertController.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));

            PresentViewController(okAlertController, true, null);
        }

        public void SendToServer()
        {
            if(tcpcontentfield.Text != ""){
                multiversprotocol.mp.tcpSend(Encoding.Unicode.GetBytes(tcpcontentfield.Text));

                CallServer.SetTitle("Send", UIControlState.Normal);
                tcpcontentfield.Text = null;
            }
        }

        partial void UIButton8887_TouchUpInside(UIButton sender)
        {
            UpdateMPLogs();
            //Create Alert
            var okAlertController = UIAlertController.Create("Information", multiversprotocol.tcpsocket.GetAnswer(Encoding.Unicode.GetBytes("phone.getids")), UIAlertControllerStyle.Alert);
            UpdateMPLogs();
            okAlertController.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));

            PresentViewController(okAlertController, true, null);
        }

        partial void CallServer_TouchUpInside(UIButton sender)
        {
            infocontent.Text = "";
            if (!connected) { TestServer(); }
            if(connected){ SendToServer(); }

            UpdateMPLogs();
        }

        void UpdateMPLogs(){

            InvokeOnMainThread(async () =>
            {
                logField.Text = multiversprotocol.logs.stringLog;
            });
        }

        partial void Internbutton_TouchUpInside(UIButton sender)
        {
            UpdateMPLogs();
            //Create Alert
            var okAlertController = UIAlertController.Create("Information", multiversprotocol.tcpsocket.GetAnswer(Encoding.Unicode.GetBytes("phone.getinterconsole")), UIAlertControllerStyle.Alert);
            UpdateMPLogs();
            okAlertController.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));

            PresentViewController(okAlertController, true, null);
        }
    }
}
