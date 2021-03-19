
namespace Config
open Microsoft.Extensions.DependencyInjection
open Domain

module implementation =
    let cepvalidatorImplementation = fun x -> true



    


[<AutoOpen>]
module ConfigExtension = 
    type Microsoft.Extensions.DependencyInjection.IServiceCollection with
        member this.AddDefaultValidators1 (cepVAlidatorKey:string option) =
            
            match cepVAlidatorKey with
            |Some key-> this.AddTransient<CEP.CepValidatorNet>(fun sp -> CEP.DefaultCepValidator key) |> ignore
            |None -> ()
            
            

open System.Runtime.CompilerServices

[<Extension>]
type ConfigExtension =
    [<Extension>]
    static member AddDefaultValidators (servicecollection:IServiceCollection) (cepVAlidatorKey:string option) =
        servicecollection.AddDefaultValidators1 cepVAlidatorKey

        ()
