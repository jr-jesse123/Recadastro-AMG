namespace ValidationTests
open AutoFixture
open Xunit.Abstractions
open Xunit
open AutoFixture.Xunit2
open Domain
open Config.Repository
open System

type ValidationTests (outputhelper:ITestOutputHelper) =
    [<Fact>]
    let ``Telefone é corretamente validado`` ()=
    //    Telefone.Create "61999944376" |> 
    //    function 
    //    | Error x -> failwith x
    //    | Ok x -> ()
    //    ()


    //[<Fact>]
    
    //let ``String60 é corretamente validada e invalidada`` () =
    //    let resultoToOption =
    //        function |Ok x -> Some x |_ -> None 

    //    let contato:Contato =
    //        {
    //            Telefone1=  (Telefone.Create "61999944376") |> function |Ok x -> x |Error x -> printfn "%s" x;  failwith "telefone errado" ;
    //            Telefone2= None;
    //            Email = Email.Create "jesse@quatrodconsultoria.com.br" |> function |Ok x -> x |_ -> failwith "email errado"

    //        }

    //    let endereco:Endereco =
    //        { 
                
    //            CEP=    CEP.Create (CEP.DefaultCepValidator "6853a9938993caad408c4eb25703c849") "71917000" |> function |Ok x -> x |_ -> failwith "email invalido" ;
    //            Logradouro = "av. tal da cunha";
    //            Numero = Some 20;
    //            Endereco.Bairro = "psul";
    //            Endereco.Cidade = "piaúi";
    //            Endereco.Complemento = resultoToOption <| String50.Create "cadas do zé"   ;
    //            Endereco.Estado= Enums.Estado.DF
    //        }
        
    //    let personalInfo:PersonalInfo = 
    //            {
    //                Nome="jesse jr"; 
    //                CRM=321654;
    //                AnoFormatura=  match AnoFormatura.Create 2000 with |Result.Ok x -> x |_ ->0  ;
    //                Especialidade = Enums.Especialidade.Acupuntura; 
    //                CPF=  match CPF.Create "01724125109" with |Result.Ok x -> x |_ ->""  ;
    //                DataNascimento= match DataNascimento.Create(DateTime(1990,01,01)) with |Result.Ok x -> x |_ ->DateTime() ;
    //                Sexo = Some Sexo.Masculino
    //            }


    //    let registro:RegistroAssociado = {PersonalInfo= personalInfo; Contato = contato; Endereo=endereco }
        
        ()

    [<Fact>]
    let testeSp () =


        ()

    //TODO: continuar daqui implementando teste com autofixture para criar uma um registro associado validado.
    
    

