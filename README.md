# Tourist Information System

This project is a C# application, OOP-based, designed to manage and display information about various tourist spots, including cities, districts, and wonders. It can serve as a guide for tourists, offering insights into different attractions and their locations.

## Features

- **Manage Cities**: Add and view information about different cities.
- **Manage Districts**: Associate districts with their respective cities.
- **Tourist Guides**: Include information on guides for specific tourist spots.
- **Tourist Wonders**: List and describe wonders available for tourists to visit.

## Project Structure

- **`Program.cs`**: Entry point of the application.
- **`City.cs`**: Handles city-related information and functionality.
- **`District.cs`**: Manages district-related data.
- **`Guide.cs`**: Contains the logic related to tourist guides.
- **`Wonder.cs`**: Manages tourist wonders.
- **`input.txt`**: Input file used for feeding data into the application.
- **`tourist.sln`**: Visual Studio solution file for the project.
- **`tourist.csproj`**: Project file containing dependencies and build configuration.

## Prerequisites

- [.NET Core SDK](https://dotnet.microsoft.com/download) or any compatible version of .NET.
- Visual Studio or any C# IDE for development.
  
## Clone the repository:
   ```bash
   git clone https://github.com/yourusername/tourist-information-system.git
  ```

## Usage
- Upon running, the application will prompt you to interact with the system by providing details about cities, districts, guides, and wonders.
- You can modify the input.txt file to add initial data for testing.

## Dependencies
- **TextFile.dll:** Custom library for handling text file inputs. Ensure it is present in the project folder.
