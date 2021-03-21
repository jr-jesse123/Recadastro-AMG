
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
    

    let ``Adicioanr Registro ao contexto`` (RegistroAssociado:RegistroAssociado) = 
        
        let context = BD.GetDataContext()
        let novoRegistro = context.Dbo.DadosIniciais.Create()
        novoRegistro.Nome <- RegistroAssociado.PersonalInfo.Nome
        novoRegistro.Crm <- RegistroAssociado.PersonalInfo.CRM
        novoRegistro.AnoFormatura <- RegistroAssociado.PersonalInfo.AnoFormatura
        novoRegistro.Especialidade <- int RegistroAssociado.PersonalInfo.Especialidade
        novoRegistro.Cpf <- RegistroAssociado.PersonalInfo.CPF
        novoRegistro.DataNascimento <- RegistroAssociado.PersonalInfo.DataNascimento
        novoRegistro.Sexo <-  RegistroAssociado.PersonalInfo.Sexo |> Option.map int
        
        novoRegistro.Cep <- RegistroAssociado.Endereo.CEP
        novoRegistro.Logradoutro <- RegistroAssociado.Endereo.Logradouro
        novoRegistro.Complemento <- RegistroAssociado.Endereo.Complemento
        novoRegistro.Bairro <- RegistroAssociado.Endereo.Bairro
        novoRegistro.Cidade <- RegistroAssociado.Endereo.Cidade
        novoRegistro.Estado <- int RegistroAssociado.Endereo.Estado


        
        novoRegistro.Email <- RegistroAssociado.Contato.Email
        novoRegistro.Telefone1 <- RegistroAssociado.Contato.Telefone1
        novoRegistro.Telefone2 <- RegistroAssociado.Contato.Telefone2

        context.SubmitUpdates()
    



    //let create = 
    //    let dado = context.Dbo.DadosIniciais2.Create()
    //    dado.AnoFormatura <- 1
    //    dado.Bairro <- "psul"

    //context.b
 
    




    


