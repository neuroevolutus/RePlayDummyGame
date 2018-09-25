using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;
using Android.Util;

namespace DummyGame.Android
{
    [Activity(Label = "DummyGame.Android"]
    public class Activity1 : Microsoft.Xna.Framework.AndroidGameActivity
    {
        Game1 g;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            string contentDir = "Content";
            if (Intent.HasExtra("CONTENT_DIR"))
            {
                contentDir = Intent.GetStringExtra("CONTENT_DIR");
            }

            for (int i = 0; i < 50; i++)
            {
                System.Console.WriteLine("I'm starting the game bois.");
            }

            var g = new Game1(contentDir);
            SetContentView((View)g.Services.GetService(typeof(View)));
            g.Run();
        }
        protected override void OnBackPressed()
        {
            for (int i = 0; i < 50; i++)
            {
                System.Console.WriteLine("I'm in OnBackPressed.");
            }
        }
    }
}