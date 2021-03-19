
namespace Config
open FSharp.Data.JsonProvider
open Microsoft.Extensions.Hosting
open Microsoft.Extensions.Configuration
open System
open CEPAberto
open Microsoft.Extensions.DependencyInjection
open Microsoft.Extensions.DependencyInjection.Extensions

type unvalidatedcep = string
type CepValidator = CepValidator of ( unvalidatedcep -> bool)
module implementation =
    let cepvalidatorImplementation = fun x -> true

//type Domain (CepValidator:ICepValidator) =
    
    let teste = fun str y ->  true


[<AutoOpen>]
module ConfigExtension = 
    type Microsoft.Extensions.DependencyInjection.IServiceCollection with
        member this.AddDefaultValidators1 () =
            //failwith "teste"
       //     this.AddTransient<unvalidatedcep -> bool>(new Func<IServiceProvider,(unvalidatedcep -> bool)>(implementation.teste))

            this.AddTransient<CepValidator>(fun sp -> CepValidator(fun x -> true)) |> ignore
            

open System.Runtime.CompilerServices

[<Extension>]
type ConfigExtension =
    [<Extension>]
    static member AddDefaultValidators (servicecollection:IServiceCollection) =
        servicecollection.AddDefaultValidators1()
        ()
