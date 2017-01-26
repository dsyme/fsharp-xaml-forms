namespace fsharp_xaml_forms_app

open Xamarin.Forms
open Xamarin.Forms.Xaml

type fsharp_xaml_forms_appPage() =
    inherit ContentPage()
    let _ = base.LoadFromXaml(typeof<fsharp_xaml_forms_appPage>)
