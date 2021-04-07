#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/core/runtime:3.1-nanoserver-1903 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-nanoserver-1903 AS build
WORKDIR /src
COPY ["Carrefour_Projeto_Testes/Carrefour_Projeto_Testes.csproj", "Carrefour_Projeto_Testes/"]
RUN dotnet restore "Carrefour_Projeto_Testes/Carrefour_Projeto_Testes.csproj"
COPY . .
WORKDIR "/src/Carrefour_Projeto_Testes"
RUN dotnet build "Carrefour_Projeto_Testes.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Carrefour_Projeto_Testes.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Carrefour_Projeto_Testes.dll"]