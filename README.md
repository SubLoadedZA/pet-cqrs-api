# .NET CQRS Pet API Performance Challenge

This repository contains the code for a performance challenge that compares the performance of the .NET CQRS framework for implementing a RESTful API that supports CRUD operations for a simple Pet model. Other challengers will be creating this in Node/NestJS. 

## Challenge

The challenge, and code in this repo, implements a RESTful API for a simple Pet model using the .NET CQRS framework. The API should support the following operations:

- Get a list of all pets.
- Get a single pet by ID.
- Create a new pet.
- Update an existing pet by ID.
- Delete an existing pet by ID.

The API should be implemented using the CQRS pattern with command and query separation. I used the MediatR library here. 

## Getting Started

To get started, clone this repository and open the solution in your preferred IDE or text editor. You'll need to have .NET 6 installed on your system to run the application.

To run the application, navigate to the `PetApi.Api` directory and run the following commands:

```
dotnet restore
dotnet run
```

This will restore the necessary dependencies and start the .NET server.

## Endpoints

The .NET CQRS Pet API supports the following endpoints:

| Endpoint     | Method | Description                                      |
| ------------ | ------ | ------------------------------------------------ |
| `/pets`      | GET    | Returns a list of all pets.                      |
| `/pets/:id`  | GET    | Returns a single pet by ID.                      |
| `/pets`      | POST   | Creates a new pet.                               |
| `/pets/:id`  | PUT    | Updates an existing pet by ID.                   |
| `/pets/:id`  | DELETE | Deletes an existing pet by ID.                   |

## Testing

To test the performance of the API, you can use a tool like Apache Benchmark (`ab`) or Siege. For example, to test the `/pets` endpoint with 100 requests and 10 concurrent requests using `ab`, you could run the following command:

```
ab -n 100 -c 10 https://localhost:{port}/pets
```

This will send 100 GET requests to the `/pets` endpoint with 10 requests being sent concurrently.

## Conclusion

This challenge is meant to be a starting point for testing and optimizing the performance of the .NET CQRS framework. Depending on your specific use case and workload, you may see different results. 
