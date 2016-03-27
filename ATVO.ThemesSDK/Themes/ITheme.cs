using System.Windows;

namespace ATVO.ThemesSDK.Themes
{
    public interface ITheme
    {
        UIElement Overlay { get; }
        UIElement Controls { get; }
        UIElement Settings { get; }

        void Load(ISimulation sim);
    }
}
