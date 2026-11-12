# \# 📦 CBTSWE2\_TP04 - Web API com CRUD e Arquitetura em Camadas (DLLs)

# 

# > Trabalho Prático 04 desenvolvido para a disciplina de \*\*CBTSWE2-ADS 671\*\*.

# > Uma Web API com ASP.NET Core para gerenciamento de produtos (CRUD), utilizando Entity Framework Core, banco de dados local SQLite e integração com múltiplas DLLs.

# 

# \## 👨‍💻 Autores

# 

# | Nome | Prontuário |

# | :--- | :--- |

# | \*\*ADRIANO JÚNIOR DE SOUZA ALMEIDA\*\* | CB3030644 |

# | \*\*ARTHUR LANZILOTTI FARJANES\*\* | CB3031306 |

# 

# \## ✨ Funcionalidades

# 

# \- \[x] \*\*Web API RESTful:\*\* Endpoints completos para criação, leitura, atualização e exclusão (CRUD) de produtos.

# \- \[x] \*\*Arquitetura em Camadas (DLLs):\*\* Separação de responsabilidades estruturada através de bibliotecas de classes.

# \- \[x] \*\*Interface Web:\*\* Página HTML interativa (`index.html`) que permite a execução das operações CRUD consumindo a API via JavaScript (Fetch API).

# \- \[x] \*\*Banco de Dados Local:\*\* Configuração e persistência de dados utilizando SQLite.

# \- \[x] \*\*ORM:\*\* Utilização do Entity Framework Core.

# \- \[x] \*\*Documentação interativa:\*\* Swagger integrado para testes rápidos dos endpoints.

# 

# \## 🛠️ Tecnologias Utilizadas

# 

# \- \*\*Framework:\*\* ASP.NET Core Web API (.NET 8.0)

# \- \*\*Linguagem:\*\* C#

# \- \*\*Banco de Dados:\*\* SQLite

# \- \*\*ORM:\*\* Entity Framework Core

# \- \*\*Frontend Web:\*\* HTML Vanilla e JavaScript

# 

# \## 🚀 Como Executar

# 

# 1\. Clone este repositório em sua máquina local.

# 2\. Abra a solução `CBTSWE2\_TP04.sln` no \*\*Visual Studio 2022\*\*.

# 3\. Vá em \*\*Ferramentas > Gerenciador de Pacotes NuGet > Console do Gerenciador de Pacotes\*\*.

# 4\. No console, certifique-se de que o \*\*"Projeto Padrão"\*\* seja `CBTSWE2\_TP04.Data`.

# 5\. Execute o comando `Update-Database -StartupProject CBTSWE2\_TP04.Api` para gerar o arquivo do banco de dados SQLite localmente.

# 6\. Defina o projeto `CBTSWE2\_TP04.Api` como o Projeto de Inicialização.

# 7\. Clique em \*\*Executar (F5)\*\* ou no botão "Iniciar".

# 8\. No navegador, apague o final da URL (geralmente `/swagger/index.html`) e substitua por `/index.html` para acessar a interface da aplicação Web.

