// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace IosApp
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnSearch { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView lvwRepositories { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtUser { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (btnSearch != null) {
                btnSearch.Dispose ();
                btnSearch = null;
            }

            if (lvwRepositories != null) {
                lvwRepositories.Dispose ();
                lvwRepositories = null;
            }

            if (txtUser != null) {
                txtUser.Dispose ();
                txtUser = null;
            }
        }
    }
}