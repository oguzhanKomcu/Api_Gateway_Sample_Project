# Api_Gateway_Sample_Project

In this project, in an application that uses the microservice approach, I made a sample project on the use of the Ocelot library from the "Api Gateway" configurations, which undertakes to direct the incoming requests to the relevant services.

In the continuation of my project, I first pushed it to github. Then I turned it into a docker container with the help of Jenkins running in my docker. In this way, I made arrangements for running the codes I developed on .Net along with a pipeline that started with push to github.


# What is microservice?

Microservices are basically independent software services that provide a specific feature or function in a software application and serve a single purpose. These services should be independently maintainable, traceable and deployable.

Microservices are modular projects that have a single responsibility and do a single job and only carry out the works of that job.

Microservice architecture is an approach that has mechanisms that should be considered as a small service in a modular structure while developing a single application and that can carry out its own business and communication in each service, which is not very complex and has little dependence on other services.

<img src="http://mustafabas.me/Images/Uploads/microservices-and-monolithic-architecturesjpg_size.jpg" width="500" height="300">

# What are the advantages of Microservice architecture?

- Independently deployable : The most important benefit of MicroServices is that services are smaller and independently deployable.
- Easy to understand : Follow the code more easily as the function is isolated and less dependent.
- Highly scalable : Microservices allow each service to scale independently to increase demand for certain services, and you can deploy across various servers and infrastructures to meet your needs.
- Get to market faster : Microservices shorten development cycles and support more agile deployment and updates.
- Reusable code : In microservices, the software is divided into smaller modules that enable teams to use functions for multiple purposes. This allows apps to boot themselves, as developers can build new capabilities without writing code from scratch.
- Resilient : Independent services, when they fail, do not affect the performance of one another, unlike monolithic models.
- Faster fault isolation : When any service crashes or test fails, you can isolate quickly with Microservices.
- Reusable: Share small services like login systems or payment across the business.
- Technological freedom : Microservices will not follow a "one size fits all" approach. You have the freedom to choose the best tool based on your needs.

[Source website](https://mindmajix.com/what-is-microservices#benefits)

# What is API Gateway?

It is an API that is a facade that enables complex services used in Microservice structures to be opened against clients from a single source. Clients go through security and authorization checks through this API and get results by triggering the target microservice through API Gateway.API Gateway is criticized for creating a tight bond with the client, but this can be ignored since its advantages seriously overshadow this disadvantage. The main function of API Gateway is to receive the request from the client and forward it to the appropriate service.

With the API gateway, operations such as authentication and authorization, logging, response caching, response caching can be done.

<img src="http://mustafabas.me/Images/Uploads/1_5uiljeete7o-u0klbk1kpgjpeg_size.jpeg" width="500" height="300">

# What is Jenkins ?

Jenkins is a CI (Continous Integration) tool that automates the structural processes that are required dynamically in a software project, allowing the project to be quickly and easily reported, and easily tested and fixed.

### Why is Jenkins used?

We maintain our project on a version control system (Git). Tools, plug-ins and certain config settings are required for the software to work in the server environment. The project's UI, Unit, Api etc. tests that need to be run are run and it continues to serve the end user by making sure that it is stable. Jenkins automates each process for us for this and more detailed processes by taking over and establishing a pipeline between them.

