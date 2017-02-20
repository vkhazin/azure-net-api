Deploy WebApi App to Azure App Service
=

# Overview
The purpose of this repo is to demonstrate deployment of .Net WebApi App to Azure App Service.
Additionally it demonstrates how to protect otherwise private end-point with httpheader token authentication

# Authenticated Request
* Using Windows 10 PowerShell:
```
curl -H @{"x-app-key"="377dab30-da05-491b-9cee-e95ec6ec7cc1"} "http://<deployment url>/echo"
```
* Using Bash Shell:
```
curl -H 'x-app-key:377dab30-da05-491b-9cee-e95ec6ec7cc1' 'http://<deployment url>/echo''
```


# Hosting Options:
1. Virtual machine(s) with manual load balancer
2. Virtual machines set with automate load balancer
3. App Services - PaaS with no Operating System maintenance on the application owner end.

# Code Deployment Options:
1. Using Visual Studio IDE
2. Using continuous deployment from git or from VS Online
3. VS web deploy
4. Ftp deploy
5. Command line deploy
6. and [more](https://docs.microsoft.com/en-us/azure/app-service-web/web-sites-deploy)

# The two code deployment options I have confirmed on 2017-02-20:
1. from VS IDE
2. continuous deployment from Github