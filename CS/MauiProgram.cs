﻿using DevExpress.Maui;
using DevExpress.Maui.Core;

namespace maui_data_grid_import_from_excel;

public static class MauiProgram {
    public static MauiApp CreateMauiApp() {
        ThemeManager.ApplyThemeToSystemBars = true;
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseDevExpress(useLocalization: true)
            .ConfigureFonts(fonts => {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("univia-pro-regular.ttf", "Univia-Pro");
                fonts.AddFont("roboto-bold.ttf", "Roboto-Bold");
                fonts.AddFont("roboto-regular.ttf", "Roboto");
            });

        return builder.Build();
    }
}
