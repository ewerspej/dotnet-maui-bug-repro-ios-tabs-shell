# dotnet-maui-bug-repro-ios-tabs-shell

Tab Icons do not show up on iOS when using FontIconSource with an icon font

**Screenshot**
<div>
<img align="top" src="missing_tab_icons.PNG" width="400"/>
</div>

**MauiProgram.cs**
```c#
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("materialdesignicons-webfont.ttf", "materialdesignicons");
            });

        return builder.Build();
    }
}

```

**App.xaml**

```xml
  <Application.Resources>
    <ResourceDictionary>
      <ResourceDictionary.MergedDictionaries>
        <ResourceDictionary Source="Resources/Styles/Colors.xaml" />
        <ResourceDictionary Source="Resources/Styles/Styles.xaml" />
      </ResourceDictionary.MergedDictionaries>

      <x:String x:Key="HomeIcon">&#xF02DC;</x:String>
      <x:String x:Key="SettingsIcon">&#xF0493;</x:String>

    </ResourceDictionary>
  </Application.Resources>
```

**AppShell.xaml**

```xml
  <TabBar>
    <Tab
      Title="Home">
      <Tab.Icon>
        <FontImageSource
          FontFamily="materialdesignicons"
          Glyph="{StaticResource HomeIcon}"/>
      </Tab.Icon>
      <ShellContent
        ContentTemplate="{DataTemplate local:MainPage}"
        Route="MainPage"/>
    </Tab>
    <Tab
      Title="Settings">
      <Tab.Icon>
        <FontImageSource
          FontFamily="materialdesignicons"
          Glyph="{StaticResource SettingsIcon}"/>
      </Tab.Icon>
      <ShellContent
        Title="Settings"
        ContentTemplate="{DataTemplate local:SettingsPage}"
        Route="SettingsPage"/>
    </Tab>
  </TabBar>
```

