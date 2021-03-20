
namespace Config
open Microsoft.Extensions.DependencyInjection
open Domain

module implementation =
    let cepvalidatorImplementation = fun x -> true
    type conversao = string -> int

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

open Domain

module Repository= 
    
    open FSharp.Data
    open FSharp.Data.Sql
    open FSharp.Data.SqlClient
    
    
    //type DadosAtuais = FSharp.Data.CsvProvider<"D:/repos/amg/associados.csv",";",0>
    //type DadosValidados = FSharp.Data.SqlCommandProvider<"SELECT * FROM [AMG].[dbo].[DadosIniciais2]",stringconn>
    [<Literal>]let stringconn = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AMG;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
    type BD = SqlDataProvider<Common.DatabaseProviderTypes.MSSQLSERVER,stringconn,UseOptionTypes = true>
    

    let ``Novo registro`` (RegistroAssociado:RegistroAssociado) = 
        
        let context = BD.GetDataContext()
        let novoRegistro = context.Dbo.DadosIniciais.Create()
        novoRegistro.Nome <- "teste"
            //RegistroAssociado.Contato.Email
        //novoRegistro.Estado <- 2 // RegistroAssociado.Endereo.Estado 
        //novoRegistro.Nome <- RegistroAssociado.PersonalInfo.nome
        
            
        ()
    




    //let create = 
    //    let dado = context.Dbo.DadosIniciais2.Create()
    //    dado.AnoFormatura <- 1
    //    dado.Bairro <- "psul"

    //context.b
 
    




    


