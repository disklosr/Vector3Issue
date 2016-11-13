# Vector3Issue
Reproducing problem with XAML designer when using Vector3 in code behind

This repo was created for the purpose of reproducing this problem:
http://stackoverflow.com/questions/40059017/using-vector3-in-code-behind-crashed-visual-studio-xaml-designer

Instructions:

- Clone repository
- Make sure build config is either x86 or x64 (with ARM the problem doesn't seem to happen)
- Build against UWP anniversary update (Build 14393)
- the MainPage.xaml designer should throw this error: MissingMethodException: Method not found: 'Void Windows.UI.Composition.DropShadow.put_Offset(System.Numerics.Vector3)'.

- Comment line 34 in ShadowControl.xaml.cs
- Build again
- MainPage.xaml designer should work normally
