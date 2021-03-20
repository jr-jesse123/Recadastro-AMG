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
type Sexo = |Masculino |Feminino 


type Endereco =  {
                                CEP:CEP;
                                Logradouro:Logradouro;
                                Numero:int option;
                                Complemento:String50;
                                Bairro:String50;
                                Cidade:String50;
                                Estado:Enums.Estado
                            }

  //verificar se o e-mail é requerido
type Contato =  {
                              TelefoneFixo:Telefone;
                              TelefoneMovel:Telefone;
                              Email:Email
                          }

type PerrsonalInfo =  
                              {
                                  CRM:CRM;
                                  AnoFormatura:AnoFormatura;
                                  Especialidade:Enums.Especialidade;
                                  CPF:CPF;
                                  DataNascimento:DataNascimento;
                                  Sexo:Sexo
                              }
type RegistroAssociado =  
                              {
                                  //Id:int;
                                  Nome:Nome
                                  PersonalInfo:PerrsonalInfo
                                  Contato:Contato
                                  Endereo:Endereco
                              } 
