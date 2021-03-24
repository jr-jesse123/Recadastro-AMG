namespace DependencyTests 
open CEPAberto
open System
open Xunit
open Xunit.Abstractions
open Config.Repository
open FsCheck
open FsCheck.Xunit

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


    [<Property>]
    let ``crm é hasheado e deshasheado corretamente`` (crm:PositiveInt) =
         int  crm  |> Domain.CRM.getHash
        |> Domain.CRM.GetCRM 
        |> (=) (int crm)
    
        
    [<Fact>]    
    let ``crm é hasheado e deshasheado corretamente1``  =
          let hash = Domain.CRM.getHash 1 
          let crm =  Domain.CRM.GetCRM hash
          
          Assert.Equal(crm, 1)

        
    //[<Fact>]
    //let ``Registro inicial é recuperado pelo crm ``()=
    //    //let result = Config.Repository.GetByCRMSerialized "11831"
        
        

    //    //for x in result do
    //    //    Xunit.Assert.Equal("ADRIANO MARQUES DA SILVA",x.nome.Value)
            

        