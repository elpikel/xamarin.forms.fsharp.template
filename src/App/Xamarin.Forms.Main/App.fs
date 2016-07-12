namespace $safeprojectname$

open Xamarin.Forms
open Xamarin.Forms.Xaml

open $ext_safeprojectname$.Pages

type App() as this =
    inherit Application()
    
    do this.Initialize()

    member this.Initialize() =
        this.MainPage <- NavigationPage(Home())