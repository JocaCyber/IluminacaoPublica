# Use uma imagem base para o .NET SDK
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

# Configure o diretório de trabalho
WORKDIR /app

# Copie o arquivo de projeto (.csproj) e restaure as dependências
COPY ProjetoSIP/SistemaIluminacaoPublica/*.csproj ./
RUN dotnet restore

# Copie o restante dos arquivos do projeto para o container
COPY ProjetoSIP/SistemaIluminacaoPublica/. ./

# Compile o projeto
RUN dotnet publish -c Release -o /app/publish

# Use a imagem base para o runtime do .NET
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .

# Comando para rodar a aplicação
ENTRYPOINT ["dotnet", "SistemaIluminacaoPublica.dll"]
