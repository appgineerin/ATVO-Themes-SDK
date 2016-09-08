using System;
using System.Windows;
using Prism.Modularity;

namespace ATVO.ThemesSDK.Themes
{
    public interface ITheme : IModule, IDisposable
    {
        FrameworkElement Overlay { get; }
        FrameworkElement Controls { get; }
        FrameworkElement Settings { get; }

        Version Version { get; }
        Version SdkVersion { get; }

        void SaveSettings();
        void HandleRemoteEvent(string name, params string[] args);
    }
}
