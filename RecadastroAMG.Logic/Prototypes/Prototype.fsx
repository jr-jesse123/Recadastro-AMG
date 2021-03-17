
//#r @"C:\Users\JESSE JUNIOR\.nuget\packages\fsharp.data\4.0.1\lib\netstandard2.0\FSharp.Data.dll"
//#r @"C:\Users\JESSE JUNIOR\.nuget\packages\fsharp.data\4.0.1\typeproviders\fsharp41\netstandard2.0\FSharp.Data.DesignTime.dll"
#r "nuget:FSharp.Data"

open FSharp.Data

type DadosAtuais = FSharp.Data.CsvProvider<"D:/repos/amg/associados.csv",";">


let dados = DadosAtuais.GetSample()

dados.Skip(14).Take(2)


