module Tests
open CEPAberto
open System
open Xunit
open Xunit.Abstractions


type Tests (outputHelper:ITestOutputHelper) =

    [<Fact>]
    let ``Ceps é corretamente validado`` () =
        let cepClient = new CEPAbertoClient("6853a9938993caad408c4eb25703c849", true)
        let result = cepClient.GetData "71917000"
        outputHelper.WriteLine <| result.Street
        Assert.NotNull result
        Assert.Equal("Avenida Flamboyant",result.Street)
        Assert.True result.Success

    [<Fact>]
      let ``Ceps é corretamente invalidado`` () =
          let cepClient = new CEPAbertoClient("6853a9938993caad408c4eb25703c849", true)
          let result = cepClient.GetData "7191000" //núemro propositalmente errado
          Assert.False result.Success
          