using MudBlazor;

namespace StrokeSense.UI.Themes;

public static class StrokeSenseTheme
{
    public static readonly MudTheme Theme = new()
    {
        PaletteLight = new PaletteLight
        {
            // Brand blues
            Primary = "#1565C0",          // deep medical blue
            PrimaryDarken = "#0D47A1",
            PrimaryLighten = "#42A5F5",

            Secondary = "#0277BD",        // teal-blue for secondary actions
            SecondaryDarken = "#01579B",
            SecondaryLighten = "#4FC3F7",

            // Backgrounds — keep near-white so risk colours pop
            Background = "#F7F9FC",       // very light blue-grey
            Surface = "#FFFFFF",
            AppbarBackground = "#1565C0",
            AppbarText = "#FFFFFF",
            DrawerBackground = "#FFFFFF",
            DrawerText = "#1A1A1A",

            // Text
            TextPrimary = "#1A1A1A",
            TextSecondary = "#495057",
            TextDisabled = "#9E9E9E",

            // Actions / states
            ActionDefault = "#546E7A",
            Success = "#2E7D32",
            Info = "#0277BD",
            Warning = "#EF6C00",
            Error = "#C62828",

            LinesDefault = "#E0E0E0",
            Divider = "#E0E0E0",
        },

        Typography = new Typography
        {
            Default = new DefaultTypography
            {
                FontFamily = new[] { "Segoe UI", "Roboto", "Helvetica", "Arial", "sans-serif" },
                FontSize = "18px",       // accessibility baseline (US7001)
                LineHeight = "1.6",
            },
            H3 = new H3Typography
            {
                FontSize = "2.5rem",
                FontWeight = "600",
            },
            H4 = new H4Typography
            {
                FontSize = "2rem",
                FontWeight = "600",
            },
            H5 = new H5Typography
            {
                FontSize = "1.5rem",
                FontWeight = "600",
            },
            H6 = new H6Typography
            {
                FontSize = "1.25rem",
                FontWeight = "600",
            },
            Body1 = new Body1Typography
            {
                FontSize = "18px",
                LineHeight = "1.6",
            },
            Body2 = new Body2Typography
            {
                FontSize = "16px",
                LineHeight = "1.5",
            },
            Button = new ButtonTypography
            {
                FontSize = "16px",
                FontWeight = "600",
                TextTransform = "none",  // avoid ALL CAPS buttons — friendlier
            },
        },

        LayoutProperties = new LayoutProperties
        {
            DefaultBorderRadius = "12px",
        },
    };
}