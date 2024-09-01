# Fanush MAUI(Android Application)

**Fanush MAUI** is a cross-platform mobile application developed using .NET MAUI (Multi-platform App UI) for Android. This mobile app interfaces with the Fanush API to provide Human Resource Management and Payroll functionalities on mobile devices.

## Features

- **Employee Management**: View and manage employee profiles and job details.
- **Recruitment Management**: Post job listings and track applicants directly from your mobile device.
- **Time and Attendance**: Clock in/out, manage leave requests, and track overtime.
- **Performance Management**: Access performance reviews and track development plans.
- **Payroll Management**: Manage salary and benefits, view pay stubs, and handle payment options.
- **Benefits Administration**: Manage employee benefits and integration with providers.
- **Learning and Development**: Access learning materials and track training progress.
- **Employee Self-Service**: Allow employees to request leave, view personal information, and access training resources.

## Technologies Used

- **.NET MAUI**: Framework for building cross-platform applications using .NET.
- **C#**: Programming language used for application development.
- **XAML**: Markup language for defining the UI in .NET MAUI applications.
- **Android SDK**: Tools and libraries for building Android applications.

## Getting Started

### Prerequisites

- **.NET 8 SDK**: Required for building and running the application.
- **Visual Studio 2022**: With .NET MAUI and Android development workloads installed.
- **Android Emulator**: For testing the application.

### Installation

1. **Clone the Repository**

   ```bash
   git clone https://github.com/ChowdhuryMunir/Fanush_MAUI.git
   cd Fanush_MAUI
   ```

2. **Open the Project**

   - Open the solution file (`Fanush_MAUI.sln`) in Visual Studio 2022.

3. **Restore Dependencies**

   - Run the following command in the terminal to restore the project dependencies:

   ```bash
   dotnet restore
   ```

4. **Update API Endpoint**

   - Configure the API endpoint in the `App.xaml.cs` file or relevant configuration files to point to your Fanush API server:

   ```csharp
   public static class Constants
   {
       public const string ApiUrl = "https://your-api-endpoint";
   }
   ```

5. **Build and Run the Application**

   - Build and deploy the application to an Android emulator or physical device directly from Visual Studio.

## Project Structure

- **Views**: Contains XAML files for defining the UI and associated code-behind files.
- **ViewModels**: Contains view models that handle data and business logic.
- **Models**: Contains classes representing data structures used in the application.
- **Services**: Contains services for API calls and other functionalities.
- **Resources**: Includes images, styles, and other resources used in the application.

## API Endpoints

The application interacts with the following `JobPosting` controller endpoints:

- **Get All Job Postings**
  - **Endpoint**: `GET /api/jobposting`
  - **Description**: Retrieves a list of all job postings.

- **Get Job Posting by ID**
  - **Endpoint**: `GET /api/jobposting/{id}`
  - **Description**: Retrieves a specific job posting by its ID.

- **Create Job Posting**
  - **Endpoint**: `POST /api/jobposting`
  - **Description**: Creates a new job posting with the provided details.

- **Update Job Posting**
  - **Endpoint**: `PUT /api/jobposting/{id}`
  - **Description**: Updates an existing job posting by its ID with new data.

- **Delete Job Posting**
  - **Endpoint**: `DELETE /api/jobposting/{id}`
  - **Description**: Deletes a job posting by its ID.

## Contributor

- [Munir Chowdhury](https://github.com/ChowdhuryMunir)

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## Contact

For questions or feedback, please reach out to [Munir Chowdhury](https://github.com/ChowdhuryMunir).
