# Purspot.Personalkollen.Core
Personalkollen thirdpary integration middleware API developemt

As per my understanding our goal is "Pursoft different systems" to integrate with Personalkollen services. So I am suggesting below high level architecture design for this implementation
![image](https://user-images.githubusercontent.com/86515501/202280093-a36a313b-61a6-4127-8c65-f1302613f918.png)
Furthermore, suggesting middleware implementation related layers architecture as below.
Layored Architecture.PNG

I have followed the SOLID principle, design patterns(Adapter Pattern) and loosely coupled multi layered architecture for this implementation. As technologies that I used .Net 6, Web API and .Net 6 class libraries for development, source code maintenance with Azure Git and hosted API using Azure PAAS WebApps. 

Please refer below screenshots for .Net middleware API implementation.

image.png
image.png

Temporary hosted as a API in Azure 
image.png

I have enabled swagger documentation for your reference in Azure hosted API.
https://purspot-personalkollen-integration-dev.azurewebsites.net/swagger/index.html

Swagger demonstration for API and model details as below.
screencapture-localhost-7085-swagger-index-html-2022-10-22-20_43_52.png

----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
Implementation details

"Purspot.Personalkollen.Core.Api" is developed for communicating with Pursoft in different systems and taking necessary data. Then validate that data before sending it to "Personalkollen" service. Finally, planning to integrate that data with the Personalkollen REST API. 
image.png

Furthermore, my suggestion is to share an error or success message using a custom model like below and it is customizable as per our requirement.
image.png

All the validations and external communication planning to do in  "Purspot.Personalkollen.Core.Business" class library
image.png

Data transfer objects planning to maintain using "Purspot.Personalkollen.Core.Entities" class library
image.png
image.png
 
System related all interfaces planning to maintain using "Purspot.Personalkollen.Core.Contracts" class library
image.png


System related all error messages planning to maintain using "Purspot.Personalkollen.Core.Resources" class library

image.png
image.png

System related all common services planning to maintain using "Purspot.Personalkollen.Core.Common" class library
image.png

System related external API communication planning to maintain using "Purspot.Personalkollen.Core.Services" class library
image.png


Middleware implementation related request auditing and database related implementation planning to maintain using "Purspot.Personalkollen.Core.Data, Purspot.Personalkollen.Core.DataBase, Purspot.Personalkollen.Core.DataContext" class libraries and database project
