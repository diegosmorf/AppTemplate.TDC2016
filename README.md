Exemplo TDC2016 
==================

- Xamarin Forms Login Template

Author
------

#DiegoCardoso #Docs #Smorf


Configuração TeamCity

-VCS:
https://github.com/diegosmorf/AppTemplate.TDC2016

Build Steps:

1-) Install Pre Requisites - Chocolatey 
install-pre-requisites.bat

2-)Restore NuGet packages
nuget restore %teamcity.build.checkoutDir%/AppTemplate.TDC2016.sln

3-)Compilar Solução
build.bat compile