<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128622341/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3719)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WinForms Splash Screen - Dislay a splash image with custom information

The [SplashScreenManager.ShowImage](https://docs.devexpress.com/WindowsForms/DevExpress.XtraSplashScreen.SplashScreenManager.ShowImage.overloads) method is used to display a splash image. A custom class (`SplashImagePainter`) is used to draw text labels and progress information. A `SplashImagePainter` object is passed as a parameter to the `ShowImage` method.

![WinForms Splash Screen - Dislay an image splash screen](https://raw.githubusercontent.com/DevExpress-Examples/how-to-show-an-image-as-a-splash-screen-and-draw-custom-information-over-this-image-e3719/13.1.4%2B/media/winforms-image-splash-screen.png)


## Files to Review

* [DrawImplementer.cs](./CS/DrawImplementer.cs) (VB: [DrawImplementer.vb](./VB/DrawImplementer.vb))
* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [Program.cs](./CS/Program.cs) (VB: [Program.vb](./VB/Program.vb))


## Documentation

* [Splash Image](https://docs.devexpress.com/WindowsForms/10825/controls-and-libraries/forms-and-user-controls/splash-screen-manager/splash-image)
* [Splash Screen Manager](https://docs.devexpress.com/WindowsForms/10826/controls-and-libraries/forms-and-user-controls/splash-screen-manager)
