using System;

using UIKit;

using System.Collections.Generic;

namespace IosApp
{
    
    public partial class ViewController : UIViewController
    {
        
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            btnSearch.TouchUpInside += async (object sender, EventArgs e) => {
                
                var github = new GitHubApiAppCore.GitHubApi();
                var repositories = await github.GetAsync(txtUser.Text);

                lvwRepositories.Source = new TableViewSource(repositories);
                lvwRepositories.ReloadData();
            };
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

    }

    public class TableViewSource : UITableViewSource
    {
        private List<string> _repositories;

        public TableViewSource(List<string> repositories)
        {
            _repositories = repositories;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return _repositories.Count;
        }

        public override UITableViewCell GetCell(UITableView tableView, Foundation.NSIndexPath indexPath)
        {
            var cell = tableView.DequeueReusableCell("TableViewCell");

            if (cell == null)
                cell = new UITableViewCell(UITableViewCellStyle.Default, "TableViewCell");

            cell.TextLabel.Text = _repositories[indexPath.Row];

            return cell;
        }

    }

}
