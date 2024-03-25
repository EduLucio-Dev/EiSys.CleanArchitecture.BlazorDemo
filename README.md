# Arquitetura do Projeto Blazor com API

Este documento descreve a estrutura arquitetônica de um projeto Blazor com API, detalhando suas camadas e responsabilidades principais. O objetivo é fornecer uma visão clara da separação de responsabilidades, facilitando a manutenção e a escalabilidade do projeto.

## Camadas da Arquitetura

### 1. Camada de Apresentação (Presentation)

#### Responsabilidades:
- Interagir com o usuário, apresentando dados e interpretando as ações do usuário.
- Utilizar componentes Blazor para reusabilidade e interação eficiente.

#### Tecnologias e Ferramentas:
- **Blazor WebAssembly**: Para execução no lado do cliente.
- **Blazor Server**: Para lógica do lado do servidor.
- **ASP.NET Core Web API**: Para servir dados ao cliente.

### 2. Camada de Aplicação (Application)

#### Responsabilidades:
- Coordenar o fluxo de operações da aplicação, servindo como ponte entre a camada de apresentação e as camadas de domínio/infraestrutura.
- Abstrair a complexidade das operações de domínio e infraestrutura.
#### Estrutura
- Interfaces
- Models

#### Tecnologias e Ferramentas:
- **CQRS (Command Query Responsibility Segregation)**: Para separar as operações de leitura e escrita.
- **Padrão Mediator**: Para reduzir dependências entre componentes.
- **DTOs (Data Transfer Objects)**: Para transferência de dados entre camadas.

### 3. Camada de Domínio (Domain)

#### Responsabilidades:
- Representar o núcleo da lógica de negócios.
- Definir entidades, lógica de negócios e regras fundamentais para a funcionalidade da aplicação.

#### Tecnologias e Ferramentas:
- **Objetos de Valor e Entidades**: Para modelar conceitos do domínio.
- **DDD (Domain-Driven Design)**: Para modelagem de lógica de negócios complexa.

### 4. Camada de Infraestrutura (Infrastructure)

#### Responsabilidades:
- Prover implementações concretas para as abstrações das camadas de domínio e aplicação.
- Gerenciar acesso a banco de dados, comunicação com APIs de terceiros e outras necessidades técnicas.

#### Tecnologias e Ferramentas:
- **Entity Framework Core**: Para acesso a banco de dados e ORM.
- **HttpClient**: Para chamadas a APIs de terceiros.
- **Serviços de Infraestrutura Específicos**: Como sistemas de arquivo, serviços de e-mail, etc.

---

Essa estrutura arquitetônica promove a clareza, reusabilidade e facilidade na manutenção e escalabilidade do projeto Blazor com API, adequando-se tanto a pequenas como a grandes aplicações.

## Contatos

- [LinkedIn](https://www.linkedin.com/in/eduardo-lucio-13723a151/)
- E-mail: eduardo.lucio@eisys.com.br
