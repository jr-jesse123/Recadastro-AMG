
#r "nuget:System.Runtime"
#r "nuget:FSharp.Data"
#r "nuget:FSharp.Data.SqlClient"
#r "nuget: SQLProvider, 1.2.1"
#r "nuget:Cpf"
#r "nuget:CEPAberto"
#load @"D:\repos\amg\RecadastroAMG.Logic\references.fsx"
#load @"D:\repos\amg\RecadastroAMG.Logic\Types.fs"



open Domain
open Domain.CPF

let cpr = CPF.Create "01724125109" 

        //Option.isSome cpr