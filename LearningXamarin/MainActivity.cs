using Android.App;
using Android.Widget;
using Android.OS;

namespace LearningXamarin
{
    [Activity(Label = "GitHub Repos", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var txtUser = FindViewById<EditText>(Resource.Id.txtUser);
            var btnSearch = FindViewById<Button>(Resource.Id.btnSearch);
            var lvwRepositories = FindViewById<ListView>(Resource.Id.lvwRepositories);

            btnSearch.Click += async (object sender, System.EventArgs e) => {

                var github = new GitHubApiAppCore.GitHubApi();
                var repositories = await github.GetAsync(txtUser.Text);

                lvwRepositories.Adapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItemSingleChoice, repositories);
            };
        }

    }
}
