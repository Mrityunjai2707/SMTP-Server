# SMTP Email Sender in C#

This is a simple C# application that demonstrates how to send an email using the SMTP protocol. The application uses the `System.Net.Mail` namespace to send an email.

## Prerequisites

- .NET Framework or .NET Core SDK installed on your machine.
- A valid email account to send emails (with SMTP server details).

## Setup

1. Clone this repository or download the code files.
2. Open the project in your preferred C# IDE (e.g., Visual Studio, Visual Studio Code).

## Configuration

Before running the application, you need to configure the SMTP server settings and email credentials in the `Program.cs` file.

1. Open `Program.cs`.
2. Replace the following placeholder values with your actual email and SMTP server details:

```csharp
string fromAddress = "your_email@example.com";
string toAddress = "recipient_email@example.com";
string smtpServer = "smtp.example.com";
int smtpPort = 587; // or the port your SMTP server uses
string smtpUser = "your_email@example.com"; // SMTP username
string smtpPass = "your_password"; // SMTP password


## Running the Application

 **Build and Run the Application**

    - Open the terminal in the project directory or use the IDE.
    - Run the application using the following command if you're using the command line:

    ```sh
    dotnet run
    ```

    - Or, press `F5` in Visual Studio to build and run the application.