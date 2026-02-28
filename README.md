# Cáculo de Aumento Salarial

Programa simples em C# para leitura e exibição de dados de um funcionário, cálculo de salário líquido e aplicação de aumento percentual sobre o salário bruto.

Este projeto foi desenvolvido de forma incremental, registrando a evolução do código em uma abordagem **orientada a objetos**.

## Conceitos Trabalhados

- Implementação procedural (quando solicitado)
- Classes, métodos e sobrescrita (Override)
- Métodos e classes estáticas (quando aplicável)
- Construtores e sobrecarcaga (Overload)
- Encapsulamento, Properties e Auto-Properties (quando aplicável)

## Enunciado do Projeto

Fazer um programa para ler um número inteiro N, representando a quantidade de funcionários a serem cadastrados. Em seguida, ler os dados de N funcionários, contendo:

- Id (inteiro)
- Nome
- Salário bruto
- Imposto

Não deve haver repetição de Id. Caso um Id informado já exista na lista, o cadastro deve ser rejeitado ou solicitado novamente. Após o cadastro:

- Mostrar a lista de funcionários contendo nome e salário líquido.
- Ler um Id correspondente a um funcionário cadastrado.
- Ler um percentual de aumento.
- Aplicar o aumento percentual apenas ao salário bruto do funcionário identificado.

Caso o Id informado não exista, exibir uma mensagem informando que o funcionário não foi encontrado e abortar a operação de aumento. Ao final, exibir a lista atualizada dos funcionários.

Regras importantes:

- O salário não pode ser alterado livremente.
- O salário bruto só pode ser modificado por meio do método responsável pelo aumento percentual.
- Deve ser aplicada a técnica de encapsulamento para proteger os atributos da classe Funcionario.
- As regras de validação já existentes para nome, salário e imposto devem ser mantidas.

## Estrutura do Projeto

```bash
|- Projeto/
   |- Img/
   |- Src/
      |- IO/
         |- FuncionarioInputs.cs
         |- FuncionarioListaInputs.cs
      |- Funcionario.cs
      |- FuncionarioLista.cs
   |- Program.cs
   |- ProgramExamples.cs
   |- Projeto.csproj
   |- Projeto.sln
   |- README.md
```

*(A estrutura pode evoluir conforme o aprendizado avança.)*

## Evolução do Projeto (Tags)

- [**v0.1**][1] — Modelo orientado a objetos para aumento salarial
- [**v0.2**][2] — Aplicacao de construtores e sobrecarga na classe Funcionario
- [**v0.3**][3] — Aplicacao de encapsulamento na classe Funcionario
- [**v0.4**][4] — Validacao e regras de negocio na classe Funcionario
- [**v0.5**][5] — Lista de funcionarios com id unico e reajuste por id

## Objetivo Educacional

Este projeto **não tem como foco a solução final perfeita**, mas sim o processo de aprendizado e a comparação entre abordagens diferentes para o mesmo problema.

[1]: https://github.com/jspneto/csharp-estudos-aumento-salarial/tree/v0.1/Projeto "v0.1"
[2]: https://github.com/jspneto/csharp-estudos-aumento-salarial/tree/v0.2/Projeto "v0.2"
[3]: https://github.com/jspneto/csharp-estudos-aumento-salarial/tree/v0.3/Projeto "v0.3"
[4]: https://github.com/jspneto/csharp-estudos-aumento-salarial/tree/v0.4/Projeto "v0.4"
[5]: https://github.com/jspneto/csharp-estudos-aumento-salarial/tree/v0.5/Projeto "v0.5"
