
#if ANDROID
using Microsoft.Maui.Controls.Compatibility.Platform.Android;
using Android.Content.Res;
#endif

using MAUISampleDemo.Helpers;
using MAUISampleDemo.View;

namespace MAUISampleDemo;

public partial class App : Application
{
    private static Database database;

    public static Database Database
    {
        get
        {
            if (database == null)
            {
                database = new Database(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "people_encrypted.db3"));
            }

            return database;
        }
    }
    public App()
    {
        InitializeComponent();
        Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping(nameof(BorderlessEntry), (handler, view) =>
        {
#if __ANDROID__
            //handler.PlatformView.BackgroundTintList = ColorStateList.ValueOf(Colors.Transparent.ToAndroid());
            handler.PlatformView.SetBackgroundColor(Android.Graphics.Color.Transparent);
#elif __IOS__
            handler.PlatformView.BackgroundColor = UIKit.UIColor.Clear;
            handler.PlatformView.BorderStyle = UIKit.UITextBorderStyle.None;

#endif
        });
        MainPage = new AppShell();
        //MainPage = new FlyoutDemo();
    }
}
