# SiiHackathon

## Description

SiiHackathon is a .NET-based project designed to support hackathon activities. It includes an end-to-end testing suite built with [Microsoft Playwright](https://playwright.dev/) and [NUnit](https://nunit.org/), enabling automated browser testing as part of the project workflow.

## Prerequisites

Before getting started, make sure you have the following installed:

- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- [Node.js](https://nodejs.org/) (required by Playwright for browser management)
- A compatible IDE such as [Visual Studio](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/) with the C# extension

## Setup Instructions

1. **Clone the repository:**

   ```bash
   git clone https://github.com/mysubscriptionsolution/SiiHackathon.git
   cd SiiHackathon
   ```

2. **Restore NuGet dependencies:**

   ```bash
   dotnet restore
   ```

3. **Install Playwright browsers:**

   After building the project, install the required browser binaries:

   ```bash
   dotnet build
   pwsh SiiHackathon/bin/Debug/net9.0/playwright.ps1 install
   ```

   If PowerShell is not available, you can use the Playwright CLI directly:

   ```bash
   dotnet tool install --global Microsoft.Playwright.CLI
   playwright install
   ```

## Building the Project

To build the solution, run the following command from the repository root:

```bash
dotnet build
```

## Running the Tests

To execute all tests in the project:

```bash
dotnet test
```

To run tests with detailed output:

```bash
dotnet test --logger "console;verbosity=detailed"
```

## Project Structure

```
SiiHackathon/
├── SiiHackathon.sln          # Visual Studio solution file
└── SiiHackathon/
    ├── SiiHackathon.csproj   # Project file with dependencies
    └── UnitTest1.cs          # Playwright end-to-end tests
```

## Contributing

Contributions are welcome! To contribute to this project:

1. Fork the repository
2. Create a new feature branch (`git checkout -b feature/your-feature-name`)
3. Make your changes and add tests where appropriate
4. Ensure all tests pass (`dotnet test`)
5. Commit your changes (`git commit -m 'Add your feature description'`)
6. Push to your branch (`git push origin feature/your-feature-name`)
7. Open a Pull Request against the `main` branch

Please keep your changes focused and well-tested.

## License

This project is provided as-is for hackathon use. Please refer to any license file in the repository for applicable terms, or contact the repository owner for licensing information.
