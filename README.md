# asp.net-api-core-conta-pagar

Criar uma API para Contas a Pagar em ASP.NET CORE 3.1 com EntityFramework e Consumir utilizando ASP.NET Core

Passo a passo

- Criar a Solution vazia
- Criar a library de domínio
- Criar a classe ContaPagar
	- Criar as propriedades (Id, Nome, Valor, DataDeVencimento, DataDePagamento, DiasDeAtraso, PercentualDaMulta, ValorDaMulta, PercentualDosJuros, ValorDosJuros)
	- Criar o construtor (Nome, Valor, DataDeVencimento, DataDePagamento)
	- Criar método para fazer o processamento (Popular as propriedades: DiasDeAtraso, PercentualDaMulta, ValorDaMulta, PercentualDosJuros e ValorDosJuros)
- Criar a interface do repositório contaPagar
- Criar a library de infra ef
	- DbContext
	- Mapeamentos
	- Repositorios
	- IServicoExternoDePersistencia e ServicoExternoDePersistenciaViaEF
- Criar o Contexto 
	- DbSet ContaPagar
- Criar o Mapeamento de Conta Pagar
- Criar o Repositório de Conta Pagar (Listagem e Inclusão)
- Criar a library de aplicacao da api
- Criar os modelos
	- Inclusão de Conta Pagar (Nome, Valor, Data de Vencimento, Data de Pagamento)
	- Listagem de Conta Pagar (Nome, Valor, Valor Corrigido, Quantidade de dias de atraso, Data de Pagamento)
- Criar a interface de Gestão de Conta Pagar (Listagem e Inclusao)
- Criar a classe que executar a interface de Conta Pagar
- Criar a library de aplicacao de consumo da api
	- Modelos (Listagem e ContasPagar)
	- interface IServicoDeConsumoDeContasPagar e ServicoDeConsumoDeContasPagar
  -  Criar a client api
- Adicionar as referencias (Dominio, Aplicacao Api e Infra)
- Startup. 
	- Contexto
	- IServicoDeGestaoDeContasPagar e ServicoDeGestaoDeContasPagar
	- Adicionar o Swagger
- Criar a controle ContasPagar
	- GET (Listagem)
	- POST (Inclusao)
6 - Criar a cliente web
- Adicionar a referencia (Aplicacao de Consumo)
- Criar a controller de ContasPagar
- Criar as views
- Criar o layout

