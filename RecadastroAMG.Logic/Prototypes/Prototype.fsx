
#r "nuget:FSharp.Data"
#r "nuget:Cpf"
#r "nuget:CEPAberto"
open FSharp.Data

open System

module Helpers =
    let ``Remover Caracteres especiais`` (texto:string) = 
        let charArray = texto.ToCharArray() 
                        |> Array.filter (fun letter -> Char.IsDigit letter) 
                        |> List.ofArray
                        |> List.fold (fun acumulador letra  ->  letra :: acumulador ) []
                        |> List.rev
                        |> List.toArray
        new string(charArray)

open Helpers
module Domain =
    
    module Types = 
        type RegistroAssociadoLegado = FSharp.Data.CsvProvider<"D:/repos/amg/associados.csv",";",0>
        type private String50 = string
        module String50 =
            let Create (unvalidatedText:string) = 
                if unvalidatedText.Length <= 50 then
                    Ok unvalidatedText 
                else Error "Texto Precisa ser Menor do que 50 Caracteres"

        

        //TODO: qual nível de validação que queremos no e-mail? queremos testar para ver se o envio é válido? ou basta saber se tem arroba, tem ponto e etc...
        type private Email = string
        module Email =
            let Create (unvalidatedEmail:string) = 
                match unvalidatedEmail with
                | x when not <| x.Contains("@") -> Error "Email Precisa Conter @"
                | x when not <| x.Contains(".") -> Error "Email Invalido pois precisa conter ."
                | _ -> Ok unvalidatedEmail


        //TODO: DESCOBRIR SE CRMS PRECISAM SER VALIDADOS?
        type CRM = int

        
        type private AnoFormatura = int
        module AnoFormatura =
            let Create (anoInvalidado:int) = 
                let anoEhValido ano = 
                    DateTime.Now.Year - ano < 100 && ano <= DateTime.Now.Year    
                match anoInvalidado with
                | ano when ano  |> anoEhValido -> Ok anoInvalidado
                | _ -> Error "Ano deve estar dentrod a última década"
        
        type Sexo = |Masculino |Feminino 

        type private CPF = string
        module CPF =
            let Create unvalidatedCPF =
                match CpfLibrary.Cpf.Check unvalidatedCPF with
                |true -> Ok unvalidatedCPF
                |false -> Error $"O cpf {unvalidatedCPF} é inválido" 
        
        type private DataNascimento = DateTime
        module DataNascimento =
            
            let Create unvalidatedData =
                let (|``Entre 02 e 120 anos``|_|) (data:DateTime) = 
                    let yearspan = (DateTime.Now.Year - data.Year)
                    if 20 < yearspan  && yearspan < 100 then Some data else None
                
                match unvalidatedData with
                | ``Entre 02 e 120 anos`` unvalidatedData -> Ok unvalidatedData
                | _ -> Error "data deve ser anterior à 2001 e posterior à 1901"



         
        type private Telefone = string
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

        type private CEP = string
        module CEP =
            open CEPAberto
            let Create unvalidatedCep =
                let cep = ``Remover Caracteres especiais`` unvalidatedCep
                let cepClient = new CEPAbertoClient("6853a9938993caad408c4eb25703c849", true)
                let result = cepClient.GetData cep
                if result.Success then Ok result.PostalCode else Error "Cep Invalido"


        type Logradouro = String50

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


        //TODO: DEFINIR QUAIS OS CAMPOS SÃO OPCIONAIS AQUI DO ENDEREÇO E CONFIRMAR QUE SOMENTE UM ENDEREÇO É POSSÍVEL OU NECESSÁRIO
        type Endereco = private {CEP:CEP;Logradouro:Logradouro;Numero:int option;Complemento:String50;Bairro:String50;Cidade:String50;Estado:Estado}
        //TODO: confirmar qual das opções abaixo é a mais adequada:
        //1 : nenhum telefone é requerido, um telefone de cada tipo é possível
        //2: ao menos um telefone é requerido, é possível cadastrar um telefone de cada tipo
        //3 : um telefone de cada itpo é requerido, um telefone de cada tipo é possível
        //4 : um telefone de cada tipo é requerido, vários telefones de cada tipo são possíveis


        //verificar se o e-mail é requerido
        type Contato = private {
                                    TelefoneFixo:Telefone;
                                    TelefoneMovel:Telefone;
                                    Email:Email
                                }

        type PerrsonalInfo = private 
                                    {
                                        CRM:CRM;
                                        AnoFormatura:AnoFormatura;
                                        Especialidade:Especialidade;
                                        CPF:CPF;
                                        DataNascimento:DataNascimento;
                                        Sexo:Sexo
                                    }
        type RegistroAssociado = private 
                                    {
                                        //TODO: verificar este camarada
                                        //status:Status; 
                                        Id:int;
                                        PersonalInfo:PerrsonalInfo
                                        Contato:Contato
                                        Endereo:Endereco
                                    }
