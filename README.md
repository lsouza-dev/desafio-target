# Case técnico — Desenvolvedor(a) Júnior | Target

Aplicação de console desenvolvida em C# com .NET 10 como parte do processo seletivo para a vaga de Desenvolvedor(a) Júnior da Target. O projeto reúne exercícios de cálculo de comissões, movimentação de estoque e cálculo de juros por atraso.

## Funcionalidades

- **Comissões de vendas:** calcula e exibe a comissão de cada venda. O percentual é de 1% para vendas abaixo de R$ 500,00 e 5% para vendas de R$ 500,00 ou mais.
- **Movimentação de estoque:** permite cadastrar produtos, baixar quantidades do estoque e listar os produtos cadastrados.
- **Cálculo de juros:** solicita um valor e a data de vencimento e calcula juros simples de 2,5% por dia de atraso. Se a data de vencimento for hoje ou futura, não há dias de atraso nem juros.

Os dados de vendas e os produtos iniciais são definidos em memória. As alterações feitas durante a execução não são salvas depois que o programa é encerrado.

## Arquitetura

O projeto usa uma organização simples por responsabilidade:

| Diretório/arquivo | Responsabilidade |
| --- | --- |
| `Program.cs` | Ponto de entrada; apresenta os resultados das vendas, conduz o menu de estoque e solicita os dados para o cálculo de juros. |
| `Model/` | Classes de domínio `Vendas` e `Produto`. |
| `Service/` | Regras e operações de negócio: cálculo de comissão (`VendasService`) e operações de estoque (`ProdutoService`). |
| `Data/Dados.cs` | Dados iniciais em memória para vendas e produtos. |
| `teste.csproj` | Configuração do aplicativo e do framework .NET de destino. |

## Requisitos

- .NET SDK 10.0 ou superior.

## Execução

Na raiz do projeto, execute:

```bash
dotnet run
```

Para compilar sem executar:

```bash
dotnet build
```

## Utilização

Ao iniciar, o programa exibe as vendas e suas comissões. Em seguida, apresenta o menu de estoque:

1. **Entrada:** cadastra um produto e informa sua quantidade inicial.
2. **Saída:** reduz a quantidade de um produto existente, desde que haja estoque suficiente.
3. **Listar:** mostra os produtos e suas quantidades.
4. **Sair:** encerra a etapa de movimentação de estoque.

Depois do menu de estoque, a calculadora solicita:

- **Valor:** informe o valor usando a cultura brasileira, por exemplo `100,00`.
- **Data de vencimento:** informe no formato `dd/MM/yyyy`, por exemplo `01/10/2026`.

O cálculo utilizado é:

```text
juros = valor × 0,025 × dias de atraso
total = valor + juros
```
