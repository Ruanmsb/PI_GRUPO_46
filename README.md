Membros: Daniel Christian Nardes, Daniel de Oliveira Lopes, Jonathan Taborda de Carvalho, Ruan Marcelo Silva Barreto


Instruções para execução: 
- O projeto utiliza ASP.NET Core MVC, linguagem C# com Entity Framework e Banco de Dados SQL Server
- É necessário ter o SQL com uma instância rodando no ambiente de execução, e fazer a chamada dessa instância no arquivo "appsettings.json", com usuário e senha da instância, configurando a string de conexão.
-> Instalar no Visual Studio os pacotes:
Microsoft.EntityFrameworkcore. 8.0.22
Microsoft.EntityFrameworkCore.Design
Microsoft.EntityFrameworkCore.Tools
Microsoft.EntityFrameworkCore.SqlServer
- Precisa criar o BD que será utilizado, abrir o Package Manager Console no Visual Studio e rodas os comandos:
Add-Migration
Update-Database
