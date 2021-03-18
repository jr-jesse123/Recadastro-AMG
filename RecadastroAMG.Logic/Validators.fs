namespace Domainn
open System


[<AutoOpen>]
module Helpers =
    let ``Remover Caracteres especiais`` (texto:string) = 
        let charArray = texto.ToCharArray() 
                        |> Array.filter (Char.IsDigit) 
                        |> List.ofArray
                        |> List.fold (fun acumulador letra  ->  letra :: acumulador ) []
                        |> List.rev
                        |> List.toArray
        new string(charArray)
    

module String50 =
    let Create (unvalidatedText:string) = 
        if unvalidatedText.Length <= 50 then
            Ok unvalidatedText 
        else Error "Texto Precisa ser Menor do que 50 Caracteres"

  //TODO: Validar e-mail enviando e-mail para o e-mail especificado.
  
module Email =
    let Create (unvalidatedEmail:string) = 
        match unvalidatedEmail with
        | x when not <| x.Contains("@") -> Error "Email Precisa Conter @"
        | x when not <| x.Contains(".") -> Error "Email Invalido pois precisa conter ."
        | _ -> Ok unvalidatedEmail

  
  

  
module AnoFormatura =
    let Create (anoInvalidado:int) = 
        let anoEhValido ano = 
            DateTime.Now.Year - ano < 100 && ano <= DateTime.Now.Year    
        match anoInvalidado with
        | ano when ano  |> anoEhValido -> Ok anoInvalidado
        | _ -> Error "Ano deve estar dentrod a última década"
  
  
module CPF =
      let Create unvalidatedCPF =
          match CpfLibrary.Cpf.Check unvalidatedCPF with
          |true -> Ok unvalidatedCPF
          |false -> Error $"O cpf {unvalidatedCPF} é inválido" 
  
  
module DataNascimento =
      
    let Create unvalidatedData =
        let (|``Entre 02 e 120 anos``|_|) (data:DateTime) = 
            let yearspan = (DateTime.Now.Year - data.Year)
            if 20 < yearspan  && yearspan < 100 then Some data else None
          
        match unvalidatedData with
        | ``Entre 02 e 120 anos`` unvalidatedData -> Ok unvalidatedData
        | _ -> Error "data deve ser anterior à 2001 e posterior à 1901"
 
  
module Telefone =
    let Create (unvalidatedTelefone:string) =
        let ``Adicionar Nono Digitos`` (telefoneSemCaracteresEspeciais:string) = 
            telefoneSemCaracteresEspeciais.Substring(0,2) + "9" + telefoneSemCaracteresEspeciais.Substring 2
                        
        let (|Fixo|``Celular com 8 digitos``| ``Celular com 9 digitos``|``Formato desconhecido``|) (input:string) =
            ``Remover Caracteres especiais`` unvalidatedTelefone
            |> function
            | input when input.Length = 10 && input.[3] |> int >= 7 -> ``Celular com 8 digitos``
            |  input when input.Length = 11 && input.[3] |> int = 9 -> ``Celular com 9 digitos``
            |  input when input.Length = 11 && input.[3] |> int < 7 -> ``Fixo``
            | _ -> ``Formato desconhecido``

        function
        | Fixo -> Ok <|``Remover Caracteres especiais`` unvalidatedTelefone
        | ``Celular com 9 digitos`` -> Ok <| ``Remover Caracteres especiais`` unvalidatedTelefone
        | ``Celular com 8 digitos`` -> Ok <| ``Adicionar Nono Digitos`` (``Remover Caracteres especiais`` unvalidatedTelefone)
        | ``Formato desconhecido`` -> Error "Formato desconhecido"


open CEPAberto    
module CEP =
    let DefaultCepValidator key cep = 
        let cepClient = new CEPAbertoClient(key, true)
        let result = cepClient.GetData cep
        result.Success


    let _Create validator unvalidatedCep =
        let cep = ``Remover Caracteres especiais`` unvalidatedCep          
        if validator unvalidatedCep then Ok cep else Error "Cep Invalido"



  //TODO: DEFINIR QUAIS OS CAMPOS SÃO OPCIONAIS AQUI DO ENDEREÇO E CONFIRMAR QUE SOMENTE UM ENDEREÇO É POSSÍVEL OU NECESSÁRIO
  //TODO: confirmar qual das opções abaixo é a mais adequada:
  //1 : nenhum telefone é requerido, um telefone de cada tipo é possível
  //2: ao menos um telefone é requerido, é possível cadastrar um telefone de cada tipo
  //3 : um telefone de cada itpo é requerido, um telefone de cada tipo é possível
  //4 : um telefone de cada tipo é requerido, vários telefones de cada tipo são possíveis


  

