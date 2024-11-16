## Pizza

Requisitos 
	*Ultima version de Visual Studio* https://visualstudio.microsoft.com/es/vs/community/
	*Tener .NET8*
	*Docker Deskpto (Solo es windows)* https://www.docker.com/products/docker-desktop/

# Pasos Run Project

Pasos
	*Estableces como projecto Inicio "Template.AppHost"*
	*Tener Docker Corriendo*
	*Listo A Disfrutar Net Aspire*
	*Te pedira una password para la base de Postgres Use el que desea o puede quitarlo*
	*https://localhost:7176/swagger/index.html*

## Migracion Base de datos

Add Migration
	*cd .\src\Template\Command*
	*dotnet ef --startup-project ..\Api\ -v migrations add "Inital"*


## Aspire Comand Line

Generacion de los Biceps para subirlo a AZURE
https://learn.microsoft.com/en-us/dotnet/aspire/deployment/azure/aca-deployment-azd-in-depth?tabs=windows#generate-bicep-from-net-aspire-app-model
Moverse al directio donde se encuentra el proyecto de AspireHost y siguiente Comando :

		azd config set alpha.infraSynth on
		azd infra synth

# Generacion del Manifest

https://learn.microsoft.com/en-us/dotnet/aspire/deployment/manifest-format#generate-a-manifest

# Deploy

azd up --environment production-login

# Se Subio un Archivo Postman

Para la prueba de enpoint. Pddt para crear pizzas tanto como prestablecidas como personalizadas tiene que obtener los GUID de las entidades y mandarla al endpoint