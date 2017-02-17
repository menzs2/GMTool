using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GMTool.Droid
{
    [Activity(Label = "CampaignActivity")]
    public class CampaignActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            
            SetContentView(Resource.Layout.Campaign);
            Button npcButton = FindViewById<Button>(Resource.Id.buttonNpc);
            Button eventButton = FindViewById<Button>(Resource.Id.buttonEvents);


        }
    }
}