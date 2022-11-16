# Purspot.Personalkollen.Core
Personalkollen thirdpary integration middleware API developemt

As per my understanding our goal is "Pursoft different systems" to integrate with Personalkollen services. So I am suggesting below high level architecture design for this implementation
![image](https://user-images.githubusercontent.com/86515501/202280093-a36a313b-61a6-4127-8c65-f1302613f918.png)
Furthermore, suggesting middleware implementation related layers architecture as below.
![image](https://user-images.githubusercontent.com/86515501/202280458-07446e68-4a94-4be4-83af-63fdd8d5c937.png)

I have followed the SOLID principle, design patterns(Adapter Pattern) and loosely coupled multi layered architecture for this implementation. As technologies that I used .Net 6, Web API and .Net 6 class libraries for development, source code maintenance with Azure Git and hosted API using Azure PAAS WebApps. 

Please refer below screenshots for .Net middleware API implementation.

![image](https://user-images.githubusercontent.com/86515501/202280517-3cabd1f3-567e-4220-b71e-56552e14cd37.png)
![image](https://user-images.githubusercontent.com/86515501/202280550-3b4e61e4-2bf7-412b-941a-761d38ad853d.png)

Temporary hosted as a API in Azure 
![image](https://user-images.githubusercontent.com/86515501/202280608-ee0367ff-45c3-4506-b8d4-b7388f574e02.png)

I have enabled swagger documentation for your reference in Azure hosted API.
https://purspot-personalkollen-integration-dev.azurewebsites.net/swagger/index.html

Swagger demonstration for API and model details as below.
![image](https://user-images.githubusercontent.com/86515501/202280673-62d67302-50dd-4a11-8f05-1d6f747662e7.png)


==============================Implementation details=========================================================================

"Purspot.Personalkollen.Core.Api" is developed for communicating with Pursoft in different systems and taking necessary data. Then validate that data before sending it to "Personalkollen" service. Finally, planning to integrate that data with the Personalkollen REST API. 
![image](https://user-images.githubusercontent.com/86515501/202280728-0986fc50-b610-4544-95b0-bbc953a4820a.png)

Furthermore, my suggestion is to share an error or success message using a custom model like below and it is customizable as per our requirement.
![image](https://user-images.githubusercontent.com/86515501/202280762-da907c06-05b8-45af-953e-ae3f58097bce.png)

All the validations and external communication planning to do in  "Purspot.Personalkollen.Core.Business" class library
![image](https://user-images.githubusercontent.com/86515501/202280952-7a284494-ab6d-4936-a946-2a079fdf6417.png)

Data transfer objects planning to maintain using "Purspot.Personalkollen.Core.Entities" class library
![image](https://user-images.githubusercontent.com/86515501/202280988-f0a71079-31f8-4eb5-829f-0388ee48c41e.png)
![image](https://user-images.githubusercontent.com/86515501/202281016-6f4e0b89-dee0-4ff9-b359-6f76542e6c49.png)
 
System related all interfaces planning to maintain using "Purspot.Personalkollen.Core.Contracts" class library
![image](https://user-images.githubusercontent.com/86515501/202281051-d479fd40-b544-4c63-86db-820b8cb5d493.png)


System related all error messages planning to maintain using "Purspot.Personalkollen.Core.Resources" class library

![image](https://user-images.githubusercontent.com/86515501/202281089-c8855ce9-e522-48a8-a9c2-3491f00d753a.png)
image.png

System related all common services planning to maintain using "Purspot.Personalkollen.Core.Common" class library
![image](https://user-images.githubusercontent.com/86515501/202281160-87ce2b3d-c1ba-4c93-a1ba-6fad778042a4.png)

System related external API communication planning to maintain using "Purspot.Personalkollen.Core.Services" class library
![image](https://user-images.githubusercontent.com/86515501/202281214-7b68a617-6768-4f29-99ec-932808b5ca7a.png)


Middleware implementation related request auditing and database related implementation planning to maintain using "Purspot.Personalkollen.Core.Data, Purspot.Personalkollen.Core.DataBase, Purspot.Personalkollen.Core.DataContext" class libraries and database project
