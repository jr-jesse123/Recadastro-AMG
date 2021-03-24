
namespace Config
open Microsoft.Extensions.DependencyInjection
open Domain
open System



type Iapelido<'apelido> = 
    abstract Mtd:'apelido

type conversao = Conversao of(string -> int) with interface Iapelido<string -> int> with member t.Mtd = let (Conversao x) = t in x 


type conversao2 = Conversao2 of(string -> int) with interface Iapelido<string -> int> with member t.Mtd = let (Conversao2 x) = t in x 
//type conversao2 = Conversao2 of (string -> int)



module implementation =
    
    let cepvalidatorImplementation = fun (x:string) -> 3
    let teste:conversao = Conversao (fun x -> 3 )
    let teste2:conversao2 = Conversao2 (fun x -> 4 )
    
    
    //let x (z:FSharp.Core.FSharpFunc<string,int>) = FSharp.Core.FSharpFunc.ToConverter(fun x-> x).
[<AutoOpen>]
module ConfigExtension = 
    type Microsoft.Extensions.DependencyInjection.IServiceCollection with
        member this.AddDefaultValidators1 (cepVAlidatorKey:string option) =
            
            this.AddTransient<conversao>(Func<IServiceProvider,conversao>(fun sp -> implementation.teste)) |> ignore
            this.AddTransient<conversao2>(Func<IServiceProvider,conversao2>(fun sp -> implementation.teste2)) |> ignore


            this.AddTransient<string>(fun sp ->
                let teste = sp.GetRequiredService<conversao>()
                let teste2 = sp.GetRequiredService<conversao2>()

                let (Conversao x) =  teste

                let result = x("u")

                let (Conversao2 y) =  teste2
                let result2 = y("u")


                "fumo") |> ignore

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

open Domain

module Repository= 
    
    open FSharp.Data
    open FSharp.Data.Sql
    open FSharp.Data.SqlClient
    
    
    //type DadosAtuais = FSharp.Data.CsvProvider<"D:/repos/amg/associados.csv",";",0>
    [<Literal>] let stringconn = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AMG;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
    [<Literal>] let FindByCRMCommand = "select * from DadosIniciais WHERE CONVERT(VARCHAR, crm) =  @CRM"

    [<Literal>] let updateCRMHashCommand = "UPDATE  DadosIniciais SET CRMHASH = 'TESTE' WHERE (CONVERT(nvarchar,CRM) = @crm)"
    type CrmHashUpdater = FSharp.Data.SqlCommandProvider<updateCRMHashCommand,stringconn>
    let UpdateCRMHash crm = 
        use cmd = new CrmHashUpdater(stringconn)
        cmd.Execute crm 


    type BDReader = FSharp.Data.SqlCommandProvider<FindByCRMCommand,stringconn>
    //let GetByCRMSerialized = BDReader(stringconn).Execute >> Seq.head >> Newtonsoft.Json.JsonConvert.SerializeObject
    type BDWritter = SqlDataProvider<Common.DatabaseProviderTypes.MSSQLSERVER,stringconn,UseOptionTypes = true>
    let Context = BDWritter.GetDataContext()
    
    //let teste = 
    //    Context.
        
   