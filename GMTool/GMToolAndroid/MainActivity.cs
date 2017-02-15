using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace GMToolAndroid
{
    [Activity(Label = "GM Tool" , MainLauncher = true, Icon = "@drawable/dice")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);

            Button newCampaign = FindViewById<Button>(Resource.Id.buttonNewCampaign);
            Button openCampaign = FindViewById<Button>(Resource.Id.buttonOpenCampaign);

            openCampaign.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(CampaignActivity));
                StartActivity(intent);
            };
        }
    }
}