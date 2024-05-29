## Project Overview
This repository contains a C# .NET project that uses Selenium for automated web testing. The project aims to ensure robust testing of web applications by automating interactions with web browsers, leveraging Selenium for browser automation.

## Framework and Technologies
- **.NET**: The project is built using the .NET framework, providing a comprehensive and consistent programming model for application development.
- **Selenium**: Employs Selenium for automating web browsers, simulating real user interactions with web pages.
- **NUnit**: Manages test cases and assertions to ensure the web application behaves as expected. 

## GitHub Actions Integration
The project integrates with GitHub Actions, enabling continuous integration and deployment (CI/CD) through detailed workflows defined in YAML (.yml) files. This automation not only streamlines the build process and testing but also manages deployment activities upon commits to the repository.

### GitHub Actions Workflow Details
- **Checkout Code**: Utilizes `actions/checkout@v3` to check out the repository code under `$GITHUB_WORKSPACE`, ensuring that the latest version of the code is used for each build.
- **Setup .NET Environment**: Uses `actions/setup-dotnet@v4` to prepare the .NET environment. This action configures the runner with .NET SDK version 7.0.400, ensuring compatibility with the project’s requirements.
- **Build and Analyze Code**: The `dotnet build` command compiles the application on a Windows VM (`windows-latest`). It redirects build output and errors to log files within the TestResults directory for potential troubleshooting and review.
- **Test Execution**: `dotnet test` command runs NUnit tests to validate web application functionality. Tests are executed without prior build (using `--no-build`) to utilize the latest successful build artifact, and test results are logged in HTML format for enhanced readability.
- **Artifact Management**: Successful tests capture results as artifacts, which are then uploaded to GitHub Actions for review. This includes build output, build errors, and HTML test reports, ensuring that all relevant data from the testing process is accessible for analysis.
- **Virtual Machine and Execution Environment**: The workflow runs on the latest version of the Windows runner (`windows-latest`) provided by GitHub Actions, which includes the most recent updates and patches. This VM environment is optimized for stability and performance in CI/CD workflows.

## Continuous Feedback and Quality Assurance
By leveraging GitHub Actions, the project upholds high-quality standards with each integration, providing immediate feedback on the impact of recent changes. This CI/CD pipeline facilitates the quick detection and resolution of integration errors, ensuring the application’s stability and reliability.

## Getting Started
To run this project locally, you will need:
- **.NET SDK** (version specified in `global.json`)
- A compatible web browser with the corresponding WebDriver installed (e.g., ChromeDriver for Google Chrome)

### Steps to Run Locally
1. Clone the repository.
2. Navigate to the project directory.
3. Execute `dotnet restore` to restore necessary packages.
4. Run `dotnet build` to build the application.
5. Execute `dotnet test` to perform tests.

## Contributing
Contributions are welcomed! Please review the contributing guidelines to propose bug fixes or improvements to the codebase and documentation.
