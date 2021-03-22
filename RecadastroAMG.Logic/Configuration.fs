
namespace Config
open Microsoft.Extensions.DependencyInjection
open Domain
open System

[<CompiledName("conversao")>]
type conversao = string -> int
type conversao2 = string -> int



module implementation =
    let cepvalidatorImplementation = fun (x:string) -> 3
    let teste:conversao = fun x -> 3 
    let teste2:conversao2 = fun x -> 4 
    
    
    //let x (z:FSharp.Core.FSharpFunc<string,int>) = FSharp.Core.FSharpFunc.ToConverter(fun x-> x).
[<AutoOpen>]
module ConfigExtension = 
    type Microsoft.Extensions.DependencyInjection.IServiceCollection with
        member this.AddDefaultValidators1 (cepVAlidatorKey:string option) =
            
            this.AddTransient<conversao>(Func<IServiceProvider,conversao>(fun sp -> implementation.teste)) |> ignore
            this.AddTransient<conversao2>(Func<IServiceProvider,conversao>(fun sp -> implementation.teste2)) |> ignore


            this.AddTransient<string>(fun sp ->
                let teste = sp.GetRequiredService<conversao>()
                let teste2 = sp.GetRequiredService<conversao2>()

                let result = teste("ha")
                let restul2 = teste2("ye")


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
    //type DadosValidados = FSharp.Data.SqlCommandProvider<"SELECT * FROM [AMG].[dbo].[DadosIniciais2]",stringconn>
    [<Literal>]let stringconn = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AMG;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
    type BD = SqlDataProvider<Common.DatabaseProviderTypes.MSSQLSERVER,stringconn,UseOptionTypes = true>
   
   
   
       let ``Iniciar banco de dados`` (RegistroAssociado:RegistroAssociadoLegado) = 
           let someSenaoempty (str:obj) =
            match str with
            | :?  string as xis when not <| System.String.IsNullOrWhiteSpace xis -> Some <| string str
            | _ -> None

            

           let context = BD.GetDataContext()
           for associado in RegistroAssociado.Rows do
              printfn "%s" <| associado.ToString()
              printfn "%s" associado.DataNascimento
              let novoRegistro = context.Dbo.DadosIniciais.Create()
              
              let nascimento =  
                try
                    Some   <|  System.DateTime.Parse associado.DataNascimento
                with ex -> None

              novoRegistro.Nome <- someSenaoempty  associado.Nome
              novoRegistro.Crm <- Some <| associado.Crm.ToString()
              
              novoRegistro.Cpf <- someSenaoempty associado.Cpf

              


              
              novoRegistro.DataNascimento <- someSenaoempty associado.DataNascimento

                
              
              novoRegistro.Cep <- someSenaoempty associado.Cep

              novoRegistro.Logradoutro <- someSenaoempty associado.Logradouro
              novoRegistro.Complemento <- someSenaoempty associado.Complemento
              novoRegistro.Bairro <- someSenaoempty associado.Bairro
              novoRegistro.Cidade <- someSenaoempty associado.Cidade
              novoRegistro.Estado <- someSenaoempty associado.Estado
   
   
              
              novoRegistro.Email <- someSenaoempty associado.Email
              novoRegistro.Telefone1 <- someSenaoempty associado.Telefone
              novoRegistro.Telefone2 <- someSenaoempty associado.Celular
              printfn "%A" novoRegistro
              
            
              context.SubmitUpdates()  
                

           
           
       


    //let ``Adicioanr Registro ao contexto`` (RegistroAssociado:RegistroAssociado) = 
        
    //    let context = BD.GetDataContext()
    //    let novoRegistro = context.Dbo.DadosIniciais.Create()
        
    //    novoRegistro.Nome <- RegistroAssociado.PersonalInfo.Nome
    //    novoRegistro.Crm <- RegistroAssociado.PersonalInfo.CRM
    //    novoRegistro.AnoFormatura <- RegistroAssociado.PersonalInfo.AnoFormatura
    //    novoRegistro.Especialidade <- int RegistroAssociado.PersonalInfo.Especialidade
    //    novoRegistro.Cpf <- RegistroAssociado.PersonalInfo.CPF
    //    novoRegistro.DataNascimento <- RegistroAssociado.PersonalInfo.DataNascimento
    //    novoRegistro.Sexo <-  RegistroAssociado.PersonalInfo.Sexo |> Option.map int
        
    //    novoRegistro.Cep <- RegistroAssociado.Endereo.CEP
    //    novoRegistro.Logradoutro <- RegistroAssociado.Endereo.Logradouro
    //    novoRegistro.Complemento <- RegistroAssociado.Endereo.Complemento
    //    novoRegistro.Bairro <- RegistroAssociado.Endereo.Bairro
    //    novoRegistro.Cidade <- RegistroAssociado.Endereo.Cidade
    //    novoRegistro.Estado <- int RegistroAssociado.Endereo.Estado


        
    //    novoRegistro.Email <- RegistroAssociado.Contato.Email
    //    novoRegistro.Telefone1 <- RegistroAssociado.Contato.Telefone1
    //    novoRegistro.Telefone2 <- RegistroAssociado.Contato.Telefone2

    //    context.SubmitUpdates()
    



    //let create = 
    //    let dado = context.Dbo.DadosIniciais2.Create()
    //    dado.AnoFormatura <- 1
    //    dado.Bairro <- "psul"

    //context.b
 
    




    


