# RunnersAppBackEndApi.XUnit.Tests

ASP.NET Core Web API for managing runner profiles.
This project provides REST endpoints to create, retrieve, and manage runner profile data.

## Technologies Used

* ASP.NET Core Web API
* Entity Framework Core
* SQL Server
* xUnit (Unit Testing)
* FluentAssertions
* EF Core InMemory Database (for testing)

## Project Structure

```
RunnersAppBackEndApi
│
├── Controllers
│   └── ProfileController.cs
│
├── Models
│   ├── Entities
│   │   └── Profile.cs
│   └── Dto
│       └── AddProfileDto.cs
│
├── Data
│   └── ApplicationDbContext.cs
│
└── Tests
    └── ProfileControllerTests.cs
```

## Features

* Create runner profiles
* Retrieve all profiles
* Retrieve profile by ID
* Unit testing for API endpoints
* In-memory database testing


## API Endpoints

### Get All Profiles

```
GET /api/profile
```

Returns all runner profiles.

### Get Profile By ID

```
GET /api/profile/{id}
```

Returns a specific profile.

### Add Profile

```
POST /api/profile
```

Example Request Body:

```json
{
  "name": "John Doe",
  "nic": "123456789V",
  "phone": 771234567,
  "email": "john@test.com",
  "performannceid": 1,
  "profilepic": "profile.jpg"
}
```

##  Running Tests

This project includes unit tests using **xUnit** and **FluentAssertions**.

Run tests with:

```
dotnet test
```

The tests use **EF Core InMemory Database** to isolate test data.


##  Testing Strategy

Tests cover:

* Retrieving all profiles
* Retrieving a profile by ID
* Handling invalid profile IDs
* Creating new profiles

Each test uses a unique in-memory database instance to prevent shared state between tests.


##  Running the Project

1. Clone the repository

```
git clone https://github.com/yourusername/RunnersAppBackEndApi.git
```

2. Navigate to the project

```
cd RunnersAppBackEndApi
```

3. Run the API

```
dotnet run
```

##  Future Improvements

* Add AI Performance Indicator
* Add AI Workout Planner

