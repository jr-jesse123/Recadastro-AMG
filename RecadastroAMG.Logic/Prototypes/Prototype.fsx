#r "nuget:System.Runtime"
#r "nuget:FSharp.Data"
#r "nuget:FSharp.Data.SqlClient"
#r "nuget: SQLProvider, 1.2.1"
#r "nuget:Cpf"
#r "nuget:CEPAberto"
#load @"D:\repos\amg\RecadastroAMG.Logic\references.fsx"




//#r @"C:\Users\JESSE JUNIOR\.nuget\packages\fsharp.data\4.0.1\lib\netstandard2.0\FSharp.Data.dll"
//#r @"C:\Users\JESSE JUNIOR\.nuget\packages\fsharp.data\4.0.1\typeproviders\fsharp41\netstandard2.0\FSharp.Data.DesignTime.dll"


open FSharp.Data
open FSharp.Data.Sql


type DadosAtuais = FSharp.Data.CsvProvider<"D:/repos/amg/associados.csv",";",0>
[<Literal>]let stringconn = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AMG;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
type BD = SqlDataProvider<Common.DatabaseProviderTypes.MSSQLSERVER,stringconn,UseOptionTypes = true>





   //let ``Novo registro`` (RegistroAssociado:RegistroAssociado) = 
    
    let context = BD.GetDataContext()
    let novoRegistro = context.Dbo.DadosIniciais.Create()
        //BD.dataContext.``dbo.DadosIniciaisEntity``
    novoRegistro.Nome <- "teste"
    novoRegistro.Nome
    novoRegistro.Estado
    context.SubmitUpdates()
            
            
            
        novoRegistro.Email <- RegistroAssociado.Contato.Email

        ()