using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media.Animation;

namespace ATVO.ThemesSDK.Themes
{
    public static class StoryboardManager
    {
        public static DependencyProperty IdProperty = DependencyProperty.RegisterAttached("Id", typeof(string), typeof(StoryboardManager), new PropertyMetadata(null, onIdChanged));

        class StoryboardInfo
        {
            public Storyboard Storyboard { get; set; }
            public Action Callback { get; set; }
        }

        static Dictionary<string, StoryboardInfo> storyboards = new Dictionary<string, StoryboardInfo>();

        private static void onIdChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
            Storyboard sb = obj as Storyboard;
            if (sb == null)
                return;

            string key = e.NewValue as string;
            if (key == null)
                return;

            if (storyboards.ContainsKey(key))
                return;

            sb.Completed += delegate (object sender, EventArgs args)
            {
                StoryboardInfo info = storyboards[key];
                if (info.Callback != null)
                    info.Callback();
            };

            storyboards[key] = new StoryboardInfo() { Storyboard = sb, Callback = null };
        }

        public static bool PlayStoryboard(string id)
        {
            if (!storyboards.ContainsKey(id))
                return false;

            StoryboardInfo sb = storyboards[id];
            sb.Storyboard.Dispatcher.BeginInvoke(new Action(sb.Storyboard.Begin));
            return true;
        }

        public static bool PlayStoryboard(string id, Callback callback)
        {
            if (!storyboards.ContainsKey(id))
                return false;

            StoryboardInfo sb = storyboards[id];
            sb.Callback = () => callback();
            sb.Storyboard.Dispatcher.BeginInvoke(new Action(sb.Storyboard.Begin));
            return true;
        }

        public static bool PlayStoryboard(string id, ParamCallback callback, object state)
        {
            if (!storyboards.ContainsKey(id))
                return false;

            StoryboardInfo sb = storyboards[id];
            sb.Callback = () => callback(state);
            sb.Storyboard.Dispatcher.BeginInvoke(new Action(sb.Storyboard.Begin));
            return true;
        }

        public static void Register(Storyboard storyboard, string id)
        {
            storyboard.SetValue(IdProperty, id);
        }

        public static void Delete(string id)
        {
            if (!storyboards.ContainsKey(id))
                return;

            StoryboardInfo info = storyboards[id];
            info.Storyboard.SetValue(IdProperty, null);
            storyboards.Remove(id);
        }
    }

    public delegate void Callback();
    public delegate void ParamCallback(object state);
}
