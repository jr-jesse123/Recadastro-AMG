namespace Config
open FSharp.Data.JsonProvider

module Configuration =
    type Configurations = JsonProvider<"./appsettings.json","Config">
    let DefaultConfiguration =  Configurations.GetSample()
    



    


    
        










