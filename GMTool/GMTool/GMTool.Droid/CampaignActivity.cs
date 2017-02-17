using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using GMToolShared.Business_Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GMToolAndroid
{
    [Activity(Label = "CampaignActivity")]
    public class CampaignActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Campaign);
            Button npcButton = FindViewById<Button>(Resource.Id.buttonNpc);
            Button eventButton = FindViewById<Button>(Resource.Id.buttonEvents);
            var campaign = new Campaign();
            
        }
    }
}