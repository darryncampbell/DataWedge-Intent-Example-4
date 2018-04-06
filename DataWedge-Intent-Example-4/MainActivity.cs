using Android.App;
using Android.Widget;
using Android.OS;
using Android.Util;
using Android.Content;

namespace DataWedge_Intent_Example_4
{
    [Activity(Label = "DataWedge_Intent_Example_4", MainLauncher = true)]
    public class MainActivity : Activity
    {
        private string DATAWEDGE_ACTION = "com.symbol.datawedge.api.ACTION";
        private string DATAWEDGE_EXTRA_KEY_SCANNER_TRIGGER_CONTROL = "com.symbol.datawedge.api.SOFT_SCAN_TRIGGER";
        private string DATAWEDGE_EXTRA_VALUE_TOGGLE_SCANNER = "TOGGLE_SCANNING";
        private string DATAWEDGE_EXTRA_KEY_SCANNER_CONTROL = "com.symbol.datawedge.api.SCANNER_INPUT_PLUGIN";
        private string DATAWEDGE_EXTRA_VALUE_ENABLE_SCANNER = "ENABLE_PLUGIN";
        private string DATAWEDGE_EXTRA_VALUE_DISABLE_SCANNER = "DISABLE_PLUGIN";

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            Button toggleScanner = FindViewById<Button>(Resource.Id.btnToggleTrigger);
            toggleScanner.Click += delegate { onToggleTrigger(); };
            Button enableScanner = FindViewById<Button>(Resource.Id.btnEnableScanner);
            enableScanner.Click += delegate { onEnableScanner(); };
            Button disableScanner = FindViewById<Button>(Resource.Id.btnDisableScanner);
            disableScanner.Click += delegate { onDisableScanner(); };

        }

        void onToggleTrigger()
        {
            Log.Info("DWEx4", "Toggling Scanner");
            Intent intent = new Intent();
            intent.SetAction(DATAWEDGE_ACTION);
            intent.PutExtra(DATAWEDGE_EXTRA_KEY_SCANNER_TRIGGER_CONTROL, DATAWEDGE_EXTRA_VALUE_TOGGLE_SCANNER);
            SendBroadcast(intent);
        }

        void onEnableScanner()
        {
            Log.Info("DWEx4", "Enabling Scanner");
            Intent intent = new Intent();
            intent.SetAction(DATAWEDGE_ACTION);
            intent.PutExtra(DATAWEDGE_EXTRA_KEY_SCANNER_CONTROL, DATAWEDGE_EXTRA_VALUE_ENABLE_SCANNER);
            SendBroadcast(intent);
        }

        void onDisableScanner()
        {
            Log.Info("DWEx4", "Disabling Scanner");
            Intent intent = new Intent();
            intent.SetAction(DATAWEDGE_ACTION);
            intent.PutExtra(DATAWEDGE_EXTRA_KEY_SCANNER_CONTROL, DATAWEDGE_EXTRA_VALUE_DISABLE_SCANNER);
            SendBroadcast(intent);
        }
    }
}

