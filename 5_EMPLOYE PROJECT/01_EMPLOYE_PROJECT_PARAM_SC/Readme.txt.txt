# Project Overview

This project contains several components organized into separate folders. Each folder contains specific elements required for different parts of the project. 
Below are the details and instructions for running each component.

## Folder Structure

1. **DB_Query**
   - Contains PostgresSQL scripts required for creating the database and tables necessary for this project.
   - Ensure to execute these queries to set up your database before running the project.

2. **WEB_API**
   - Contains the solution for the Web API, Business Access Layer (BAL), and Data Access Layer (DAL).
   - This folder includes all the backend logic and services required for the project.
   - To run this project separately and test the endpoints, use Postman tool.

3. **API TESTING**
   - Contains a solution for testing the API to ensure it's working correctly.
   - Run this project before running the WEB API project to validate the API endpoints.
   - This is a console application that checks the functionality of the Web API.

4. **WEB_APP_CORE**
   - Contains a solution for the web application, including the User Interface (UI) and controllers.
   - This project calls the Web API to fetch and display data.
   - Make sure to run the WEB API project before running this project to ensure proper functionality.

## Instructions

### Setting Up the Database

1. Navigate to the `DB_Query` folder.
2. Execute the SQL scripts to create the database and required tables.

### Running the WEB API Project

1. Open the solution located in the `WEB_API` folder using your preferred IDE (e.g., Visual Studio).
2. Build and run the project.
3. Use Postman tool to test the API endpoints. The base URL and endpoints are defined within the solution.

### Testing the API

1. Navigate to the `API TESTING` folder.
2. Open the solution and run the console application.
3. This will test the functionality of the Web API endpoints.

### Running the Web Application

1. Navigate to the `WEB_APP_CORE` folder.
2. Open the solution using your preferred IDE.
3. Build and run the project.
4. Ensure the WEB API project is running before starting this project to enable API calls.

## Notes

- Ensure you have the necessary dependencies and environment setup for running .NET projects.
- Make sure the connection strings and configurations are correctly set up in each project to match your environment.
- For detailed information about each component, refer to the respective project documentation or comments within the code.

By following these instructions, you should be able to set up, run, and test the entire project successfully.
