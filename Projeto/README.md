# Cáculo de Aumento Salarial

Programa simples em C# para leitura e exibição de dados de um funcionário, cálculo de salário líquido e aplicação de aumento percentual sobre o salário bruto.

## Detalhes Gerais

- **Versão**: 0.4
- **Conceito aplicado:** Validação de Entradas

## Descrição da Tag

Implementacao de validacoes internas na classe Funcionario para garantir integridade dos dados.

Foram criados metodos privados para validar nome, salario e imposto, definindo valores minimos e limites aceitaveis conforme regras de negocio.

O metodo AumentarSalario tambem passou a validar o percentual informado, impedindo aplicacao de reajustes negativos ou invalidos.

Esta versao fortalece o modelo de dominio ao concentrar regras de negocio diretamente na entidade.

## Exemplo de Execução

<img src="Img/Screenshot-v0.1.png" alt="Solução Problema" width="936">