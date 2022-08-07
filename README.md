# wm75 Documentation
Distributed System 
DOCUMENTATION
PREFACE
Out Of Bounds Ltd is a company that specializes in managing software development projects. They have teams of project managers and developers who are experts in various fields of technology. Some of their teams are based at their London premises, but others are at geographically distant locations. For certain projects, they outsource work to other companies.
They are currently using Pert and Gantt charts to plan their projects and set up tasks, responsibilities, timeframes, etc. Instructions are then given to the team leaders involved. Communication and progress tracking is done through face-to-face meetings with local teams and through email/telephone/video conferencing with the international teams.
Practical Lecture 1
Introduction
We are building a distributed information system using Microsoft .NET technology. The system will have heterogeneous clients, and the clients will be implemented using both .NET and Java technology.
The main points of the article are as follows: 
1.	The system will be developed using a distributed approach, with various concepts related to distributed systems being explained during the implementation process.
2.	Microsoft Visual Studio and programming languages such as C# and Java will be used in the development of the system.
The system should allow a manager to register projects and divide them into tasks. Rules regarding the order of tasks can be set, and different tasks can be assigned to different teams. The system should provide functionality for team leaders to register task progress, and project progress can be tracked by the project manager. The customer who commissioned the project should be able to get summary information about the structure of the project, distribution of work, and progress.
The administrator/project manager will have full access to the system, including the ability to add, edit, and delete users, projects, and tasks. The team leader (internal) will have access to all projects and tasks, but will only be able to edit and delete projects and tasks that they have created themselves. The team leader (external) will have access to all projects and tasks, but will only be able to view and comment on tasks. The customer will only be able to view the projects and tasks that they have been assigned to.
The administrator is the project manager and is responsible for setting up the project, dividing it into tasks, assigning tasks to teams, creating new teams if necessary, updating any changes to the project, and tracking overall project progress.
A team leader is responsible for the overall performance of a team. They set goals and objectives, assign tasks, and provide support and guidance to team members. They also monitor progress and performance, and take corrective action when necessary.
The customer is responsible for hiring Out Of Bounds Ltd to carry out a project. The customer is expected to liaise directly with the project manager, and will use the PTS to view project structure and other project-related information, as well as to track the overall progress of the project.
A distributed system is a system that consists of multiple components that are located in different physical locations. These components interact with each other in order to achieve a common goal.
 The system will be built using a service oriented architecture (SOA) 
The system will be deployed on a number of servers in a load balanced configuration 
The system will be monitored using a number of tools to ensure availability and performance
The system will be backed up on a regular basis to ensure data integrity 
The system will be tested using a number of different techniques
The system will be supported by a dedicated team of developers
The system will be built using a number of different technologies to ensure that it is robust and scalable.
The system will be designed to be extensible so that new features can be added in the future

Practical Lecture 2
The business tier contains the core functionality of our system, including business rules and workflows. It provides controlled access to data and enables validation and processing of data input.
• The business tier will be defined using classes 
• The collection (library) of classes representing our business tier will be deployed as a component – In our case a DLL
 • The business tier will be deployed on a server – In our case the server will be the same machine as the client
Our component consists of a collection of classes developed to fulfil a certain specification. It can be reused and should encapsulate all its behaviour. It provides an interface to allow it to be accessed by a client (could even be another component).
Clear separation between business and persistence logic means that the DAOs will contain all the SQL code for reading and writing to the database, and the business logic will be separate from this. This will make it easier to maintain and change the code, as well as making it easier to test.

Practical Lecture 3
We have built a Graphical User Interface application for an administrator. This application uses the PTSLibrary component implemented in the previously. We take both of the projects and make them communicate using .NET Remoting.
Practical Lecture 4
We implemented a Remote Server Application. 
We used the remote server application to distribute the admin tool and the PTSLibrary component.
There are two ways of building distributed systems in .NET, which provide means to invoke an object on another computer via a local proxy – Web Services: works across platforms, so can be used to provide services to clients that are not under your control and could be written in any language – .NET Remoting: works only when client and server are written in .NET. Can be used when both are under you’re the control.
Marshalling determines how an object is exposed to the client application
 • Objects can be marshalled 
– By value: a copy of the server object is sent and kept in the client domain
 – By reference: the client only holds a reference to the object.
We did run the remote server application. When the remote server application was running, admin tool was then started. Check that everything still works. The fact that the admin tool is now communicating using .NET Remoting is completely transparent to the user, though a little slower.
	We built a new project to act as a remote server application.
	The business component was changed, so the required classes could be marshalled.
	The existing admin tool was changed to work with .NET Remoting. 
	We created a web service façade for the PTSLibrary and created the customer browser client that uses the web service.
Practical Lecture 5
• We created a web service that acts as a façade to an existing business component.
•We implemented an ASP.NET website that communicates with the web service.
• We added a code to the PTSLibrary component to expose some of its methods as a web service. We then created two web services, one for a customer client application and one for a team leader application. Implementation of a website using ASP.NET that uses the customer web service to allow a user to log in and view project details was enhanced.
Practical Lecture 6
•	We created the business logic for the service in a Java class.
•	Annotated the class with @WebService to make it a web service. 
•	Deployment of the web service on a web server.
•	Creation of a client for the web service.
•	Creating of proxies for a web service in NetBeans was done.
•	 We created a standalone Java application that makes calls on a web service implemented in .NET, thus demonstrating cross-platform interoperability of web services.

