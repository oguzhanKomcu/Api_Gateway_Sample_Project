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
