# Sistema de Iluminação Pública Inteligente

## Requisitos
- .NET 8.0 SDK
- Docker e Docker Compose

## Como executar o projeto
### Usando Docker Compose
1. Execute `docker-compose up --build` no diretório do projeto.
2. A aplicação estará disponível em `http://localhost:5000`.

### Executando Localmente
1. Navegue até a pasta do projeto: `cd ProjetoSIP/SistemaIluminacaoPublica`.
2. Execute `dotnet build` para compilar o projeto.
3. Execute `dotnet run` para iniciar a aplicação.
4. Acesse `http://localhost:5000`.

## Estrutura do Projeto
- Controllers: Controladores da API
- Models: Modelos usados pela aplicação
- Dockerfile: Configuração para containerização da aplicação
- docker-compose.yml: Arquivo de orquestração Docker
