namespace Enums
type Estado = 
  |AC = 1
  |AL = 2
  |AP = 3
  |AM = 4
  |BA = 5
  |CE = 6
  |DF = 7
  |ES = 8
  |GO = 9
  |MA = 10
  |MT = 11
  |MS = 12
  |MG = 13
  |PA = 14
  |PB = 15
  |PR = 16
  |PE = 17
  |PI = 18
  |RJ = 19
  |RN = 20
  |RS = 21
  |RO = 22
  |RR = 23
  |SC = 24
  |SP = 25
  |SE = 26
  |TO = 27
    
  type Especialidade = 
  |``Acupuntura`` = 1
  |``Alergia e imunologia`` = 2
  |``Anestesiologia`` = 3
  |``Angiologia`` = 4
  |``Cardiologia`` = 5
  |``Cirurgia cardiovascular`` = 6
  |``Cirurgia da mão`` = 7
  |``Cirurgia de cabeça e pescoço`` = 8
  |``Cirurgia do aparelho digestivo`` = 9
  |``Cirurgia geral`` = 10
  |``Cirurgia oncológica`` = 11
  |``Cirurgia pediátrica`` = 12
  |``Cirurgia plástica`` = 13
  |``Cirurgia torácica`` = 14
  |``Cirurgia vascular`` = 15
  |``Clínica médica`` = 16
  |``Coloproctologia`` = 17
  |``Dermatologia`` = 18
  |``Endocrinologia e metabologia`` = 19
  |``Endoscopia`` = 20
  |``Gastroenterologia`` = 21
  |``Genética médica`` = 22
  |``Geriatria`` = 23
  |``Ginecologia e obstetrícia`` = 24
  |``Hematologia e hemoterapia`` = 25
  |``Homeopatia`` = 26
  |``Infectologia`` = 27
  |``Mastologia`` = 28
  |``Medicina de emergência`` = 29
  |``Medicina de família e comunidade`` = 30
  |``Medicina do trabalho`` = 31
  |``Medicina de tráfego`` = 32
  |``Medicina esportiva`` = 33
  |``Medicina física e reabilitação`` = 34
  |``Medicina intensiva`` = 35
  |``Medicina legal e perícia médica`` = 36
  |``Medicina nuclear`` = 37
  |``Medicina preventiva e social`` = 38
  |``Nefrologia`` = 39
  |``Neurocirurgia`` = 40
  |``Neurologia`` = 41
  |``Nutrologia`` = 42
  |``Oftalmologia`` = 43
  |``Oncologia clínica`` = 44
  |``Ortopedia e traumatologia`` = 45
  |``Otorrinolaringologia`` = 46
  |``Patologia`` = 47
  |``Patologia Clínica / Medicina Laboratorial`` = 48
  |``Pediatria`` = 49
  |``Pneumologia`` = 50
  |``Psiquiatria`` = 51
  |``Radiologia e diagnóstico por imagem`` = 52
  |``Radioterapia`` = 53
  |``Reumatologia`` = 54
  |``Urologia`` = 55
  
namespace Domain
open System
open System.ComponentModel.DataAnnotations


type RegistroAssociadoLegado = FSharp.Data.CsvProvider<"D:/repos/amg/associados.csv",";",0>
type private String50 = string
type Nome = String50
type private CPF = String50
type private CEP = String50
type Logradouro = String50
type private Email = string
type CRM = int
type private AnoFormatura = int
type private DataNascimento = DateTime
type private Telefone = string
type Sexo = |Masculino = 1 |Feminino = 2


type Endereco =  {
                                CEP:CEP;
                                Logradouro:Logradouro;
                                Numero:int option;
                                Complemento:String50 option;
                                Bairro:String50;
                                Cidade:String50;
                                Estado:Enums.Estado
                            }

  //verificar se o e-mail é requerido
type Contato =  {
                              Telefone1:Telefone;
                              Telefone2:Telefone option;
                              Email:Email
                          }

type PersonalInfo =  
                              {
                                  Nome:Nome;
                                  CRM:CRM;
                                  AnoFormatura:AnoFormatura;
                                  Especialidade:Enums.Especialidade;
                                  CPF:CPF;
                                  DataNascimento:DataNascimento;
                                  Sexo: Sexo option
                              }
type RegistroAssociado =  
                              {
                                  //Id:int;
                                  PersonalInfo:PersonalInfo
                                  Contato:Contato
                                  Endereo:Endereco
                              } 








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


[<CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module String50 =

    let (|MenorQue50|_|) (str:string) =
        if str.Length <= 50 then
            Some str
        else None 

    let Create (unvalidatedText:string) = 
        match unvalidatedText with
        |MenorQue50 str -> Ok (str:String50) 
        |_ -> Error "Texto Precisa ser Menor do que 50 Caracteres"
        //if unvalidatedText.Length <= 50 then
        //    Ok (unvalidatedText:String50)
        //else Error 

[<CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module Nome =
    let Create (unvalidatedName:string) =
       
        let (|``Nome Simples``|``Nome curto``|``Nome válido``|) (candidatoNome:string) =
            match candidatoNome with
            |nome when nome.Split().Length <= 1 -> ``Nome Simples``
            |nome when nome.Length <= 5 -> ``Nome curto``
            | _ -> ``Nome válido``


        match unvalidatedName with
        | ``Nome válido`` -> Ok (unvalidatedName:Nome)
        |``Nome curto`` -> Error "Nome muito curto"
        | ``Nome Simples`` -> Error "Nome e sobrenome são necessários"


  //TODO: Validar e-mail enviando e-mail para o e-mail especificado.
[<CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]  
module Email =
    let Create (unvalidatedEmail:string) = 
        match unvalidatedEmail with
        | x when not <| x.Contains("@") -> Error "Email Precisa Conter @"
        | x when not <| x.Contains(".") -> Error "Email Invalido pois precisa conter ."
        | _ -> Ok unvalidatedEmail
[<CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module AnoFormatura =
    let Create (anoInvalidado:int) = 
        let anoEhValido ano = 
            DateTime.Now.Year - ano < 100 && ano <= DateTime.Now.Year    
        match anoInvalidado with
        | ano when ano  |> anoEhValido -> Ok (anoInvalidado:AnoFormatura)
        | _ -> Error "Ano deve estar dentrod a última década"
[<CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]  
[<AutoOpen>]
module CPF =
      let Create unvalidatedCPF =
          match CpfLibrary.Cpf.Check unvalidatedCPF with
          |true -> Ok (unvalidatedCPF:CPF)
          |false -> Error $"O cpf {unvalidatedCPF} é inválido" 


[<CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]  
module DataNascimento =
    let Create unvalidatedData =
        let (|``Entre 02 e 120 anos``|_|) (data:DateTime) = 
            let yearspan = (DateTime.Now.Year - data.Year)
            if 20 < yearspan  && yearspan < 100 then Some data else None
          
        match unvalidatedData with
        | ``Entre 02 e 120 anos`` unvalidatedData -> Ok unvalidatedData
        | _ -> Error "data deve ser anterior à 2001 e posterior à 1901"
 
[<CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]  
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

        match unvalidatedTelefone with
        | Fixo -> Ok <|``Remover Caracteres especiais`` unvalidatedTelefone
        | ``Celular com 9 digitos`` -> Ok <| ``Remover Caracteres especiais`` unvalidatedTelefone
        | ``Celular com 8 digitos`` -> Ok <| ``Adicionar Nono Digitos`` (``Remover Caracteres especiais`` unvalidatedTelefone)
        | ``Formato desconhecido`` -> Error "Formato desconhecido"


open CEPAberto    
[<CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
[<AutoOpen>]
module CEP =
    type Unvalidatedcep = string
    //type CepValidator = Unvalidatedcep -> bool

    type CepValidatorNet = CepValidator of ( Unvalidatedcep -> bool)

    let DefaultCepValidator key :CepValidatorNet = 
        CepValidator
            (fun str -> 
                let cepClient = CEPAbertoClient(key, true)
                let result = cepClient.GetData str
                result.Success)
    
    //TODO: PENSAR EM COMO DOCUMENTAR E AUTO REGISTRAR NO DI AS FUNÇÕES QUE PRECISARÃO DE DEPENDENCIAS
    let Create (validator:CepValidatorNet) unvalidatedCep =
        let cep = ``Remover Caracteres especiais`` unvalidatedCep          
        let (CepValidator wer) = validator
        if  wer unvalidatedCep then Ok cep else Error "Cep Invalido"



  //TODO: DEFINIR QUAIS OS CAMPOS SÃO OPCIONAIS AQUI DO ENDEREÇO E CONFIRMAR QUE SOMENTE UM ENDEREÇO É POSSÍVEL OU NECESSÁRIO
  //TODO: confirmar qual das opções abaixo é a mais adequada:
  //1 : nenhum telefone é requerido, um telefone de cada tipo é possível
  //2: ao menos um telefone é requerido, é possível cadastrar um telefone de cada tipo
  //3 : um telefone de cada itpo é requerido, um telefone de cada tipo é possível
  //4 : um telefone de cada tipo é requerido, vários telefones de cada tipo são possíveis


  

