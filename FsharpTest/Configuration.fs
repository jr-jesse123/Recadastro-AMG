namespace Config
open System
open CEPAberto
open Microsoft.Extensions.DependencyInjection


[<AutoOpen>]
module ConfigExtension = 
    type Microsoft.Extensions.DependencyInjection.IServiceCollection with
        member this.AddDefaultValidators () =
            this.AddSingleton(typeof<int>, 1)


            //this.AddLogging()


open System.Runtime.CompilerServices

[<Extension>]
type ConfigExtension =
    [<Extension>]
    static member AddDefaultValidators (servicecollection:IServiceCollection) =
        servicecollection.AddDefaultValidators()
