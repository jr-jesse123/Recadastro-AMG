namespace DependencyTests 
open CEPAberto
open System
open Xunit
open Xunit.Abstractions

type CepAbertoTests (outputHelper:ITestOutputHelper) =

    [<Fact>]
    let ``Cep é  corretamente validado`` () =
        let cepClient = new CEPAbertoClient("6853a9938993caad408c4eb25703c849", true)
        let result = cepClient.GetData "71917000"
        outputHelper.WriteLine <| result.Street
        Assert.NotNull result
        Assert.Equal("Avenida Flamboyant",result.Street)
        Assert.True result.Success

    [<Fact>]
    let ``Cep é corretamente invalidado`` () =
          let cepClient = new CEPAbertoClient("6853a9938993caad408c4eb25703c849", true)
          let result = cepClient.GetData "7191000" //n�emro propositalmente errado
          Assert.False result.Success


type JsonProviderTests (outputHelper:ITestOutputHelper) =
    [<Fact>]
    let ``Configuração padrão é lida corretamente`` () =
        //let teste  =  Config.Configuration.DefaultConfiguration
        //outputHelper.WriteLine teste.CepAbertoKey
        ()
    
