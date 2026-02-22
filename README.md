# Graftcode Chess Solution

This repository contains a multi-project C# solution for a chess-related application. It is organized into the following main components:

## Project Structure

- **HelloChessService/**
  - `HelloChessService.csproj`: Service project for chess logic and operations.
  - `HelloChessService.cs`: Main service implementation.
  - `bin/`, `obj/`: Build output and intermediate files (ignored by .gitignore).

- **Consumer/**
  - `HelloChessConsumer.sln`: Solution file linking all projects.
  - `HelloChessConsumer/`: Consumer project for interacting with the chess service.
    - `HelloChessConsumer.csproj`: Project file.
    - `HelloChessGraftConsumer.cs`: Main consumer implementation.
  - `HelloChessConsumer.Tests/`: Unit tests for the consumer project.
    - `HelloChessConsumer.Tests.csproj`: Test project file.
    - `HelloChessGraftConsumerTest.cs`: Test implementation.

## How to Use

1. **Clone the repository:**
   ```sh
   git clone <repo-url>
   cd Graftcode
   ```
2. **Build the HelloChessService:**
   - In terminal:
     ```sh
     dotnet build HelloChessService/HelloChessService.sln
     ```

3. **Connect to Graftcode locally:**
   - Create an account on [Graftcode.com](graftcode.com).
   - Add a new service on [Graftcode dashboard](https://portal.graftcode.com/dashboard).
   - Install Graftcode from [Graftcode.com](graftcode.com).
   - Go to install directory path `{your_install_directory}\GraftcodeGateway\bin`
   - Run command from command line, that should look like this: `./gg --projectKey <your_project_key> --modules <path-to-your-modules>`
   - Check consol result, if Graftcode Gateway is up and running.

4. **Build the HelloChessConsumer solution:**
   - In terminal:
     ```sh
     dotnet build Consumer/HelloChessConsumer.sln
     ```

5. **Run tests:**
   - Execute unit tests for the consumer:
     ```sh
     dotnet test Consumer/HelloChessConsumer.Tests/HelloChessConsumer.Tests.csproj
     ```
