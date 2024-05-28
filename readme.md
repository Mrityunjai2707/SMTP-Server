# Email Sender Console Application

This is a simple console application written in C# that sends emails using SMTP. It demonstrates how to use the `System.Net.Mail` namespace to send emails programmatically.

## Prerequisites

- .NET Core SDK installed on your machine.
- An SMTP server to send emails (e.g., Gmail, Yahoo, or any other email service provider that supports SMTP).

## Setup

1. **Clone the Repository**

    ```sh
    git clone https://github.com/Mrityunjai2707/SMTP-Server
    cd SMTP-Server
    ```

2. **Open the Project**

    Open the project in your preferred C# IDE (e.g., Visual Studio).

3. **Configure Email Details**

    Update the `MyEmailDetails` object in the `Main` method of `Program.cs` with your email details.

    ```csharp
    MyEmailDetails emailDetails = new MyEmailDetails
    {
        SmtpServer = "smtp.example.com", // Your SMTP server
        SmtpPort = 587,                  // SMTP port (e.g., 587 for TLS, 465 for SSL)
        FromEmail = "your-email@example.com", // Your email address
        ToEmail = "recipient@example.com",   // Recipient's email address
        Subject = "Test Mail",               // Email subject
        Body = "This is a test email.",      // Email body
        Password = "your-email-password",    // Your email account password
        EnableSsl = true                     // Enable SSL/TLS
    };
    ```

## Running the Application

1. **Build and Run the Application**

    - Open the terminal in the project directory or use the IDE.
    - Run the application using the following command if you're using the command line:

    ```sh
    dotnet run
    ```

    - Or, press `F5` in Visual Studio to build and run the application.

2. **Check the Output**

    - If the email is sent successfully, the console will display "Mail Sent".
    - If there is an error, the console will display the exception message.
