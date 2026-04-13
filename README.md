# 🧩 Sistema de Cadastro de Pessoas (Console - C#)

Este projeto é uma aplicação de console desenvolvida em C# que simula um sistema de cadastro de pessoas, aplicando conceitos fundamentais de desenvolvimento backend, como separação de responsabilidades, validação de dados e organização de código.

---

## 🚀 Funcionalidades

* ✅ Cadastrar pessoa (nome, idade e CPF)
* 📋 Listar todas as pessoas cadastradas
* 🔍 Buscar pessoa por nome
* ⚠️ Validação de dados (idade mínima, campos obrigatórios)
* 💥 Tratamento de erros

---

## 🏗️ Estrutura do Projeto

O projeto segue uma organização em camadas:

```
/Models
    Pessoa.cs

/Services
    PessoaService.cs

Program.cs
```

### 🔹 Program (UI)

Responsável pela interação com o usuário:

* Entrada de dados
* Exibição de informações
* Controle de fluxo do sistema

### 🔹 Service

Contém a lógica de negócio:

* Cadastro
* Listagem
* Busca

### 🔹 Model

Representa a entidade e valida os dados:

* Nome obrigatório
* Idade mínima (18 anos)
* CPF obrigatório

---

## 🧠 Conceitos Aplicados

* Separação de responsabilidades (UI, Service, Model)
* Encapsulamento
* Tratamento de exceções (`try/catch`)
* Validação de entrada (`TryParse`, validações no Model)
* Boas práticas de organização de código
* Proteção de dados internos (cópia de lista)

---

## ▶️ Como Executar

1. Clone o repositório:

```bash
git clone https://github.com/Murilo004/Cadastro-Pessoas-Console.git
```

2. Acesse a pasta do projeto:

```bash
cd Cadastro
```

3. Execute o projeto:

```bash
dotnet run
```

---

## 💻 Tecnologias Utilizadas

* C#
* .NET (Console Application)

---

## 📌 Observações

Este projeto foi desenvolvido com foco em aprendizado e prática de fundamentos de backend, sem uso de frameworks avançados ou bibliotecas externas, priorizando o entendimento da lógica e da estrutura do código.

---

## 👨‍💻 Autor

Desenvolvido por Murilo Rálio como parte da evolução nos estudos de desenvolvimento backend.
