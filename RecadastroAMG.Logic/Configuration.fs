namespace Config
open FSharp.Data.JsonProvider
open Microsoft.Extensions.Hosting
open Microsoft.Extensions.Configuration
open System
open CEPAberto

module Configuration =
    type Configurations = JsonProvider<"./appsettings.json","Config">
    let DefaultConfiguration =  Configurations.GetSample()
 

    
    //let host = 
    //    let Host = HostBuilder().ConfigureAppConfiguration 
    //                (fun x y -> ignore <| y.AddUserSecrets<teste>()  )
        
    //    Host.Build().Run()
    //    Host
        