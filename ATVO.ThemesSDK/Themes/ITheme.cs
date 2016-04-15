using System;
using System.Windows;
using Prism.Modularity;

namespace ATVO.ThemesSDK.Themes
{
    public interface ITheme : IModule, IDisposable
    {
        UIElement Overlay { get; }
        UIElement Controls { get; }
        UIElement Settings { get; }
    }
}
