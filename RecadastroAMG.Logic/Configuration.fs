namespace Config
open FSharp.Data.JsonProvider
module Configuration =
    #r "nuget:FSharp.Data.JsonProvider"
    type Configurations = JsonProvider<"./appsettings.json">
    type Configurations2 = JsonProvider<"D:\\repos\\amg\\RecadastroAMG.Logic\\Prototypes\\Prototype.fsx">


    
        










