
#r "nuget:FSharp.Data"
#r "nuget:Cpf"
#r "nuget:CEPAberto"
#r "nuget:FSharp.Data.JsonProvider"
open FSharp.Data
open System
open FSharp.Data.JsonProvider

module PrototypeConfiguration =
    type Configurations = JsonProvider<"D:/repos/amg/RecadastroAMG.Logic/appsettings.json","Config">
    let DefaultConfiguration =  Configurations.GetSample()
    


    //type Reader<'env,'a> = Reader of action:('env -> 'a)
    


//não dar informações resulta em desligamento. resulta em desligamento.