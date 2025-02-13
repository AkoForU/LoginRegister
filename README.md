LoginRegister

This project presents a sleek Login and Register interface featuring a blurred background effect, compatible with Windows 7 and 10. It integrates with a local SQL database, enabling user registration and authentication functionalities. To ensure security, the application utilizes SHA-256 hashing for password storage.
Table of Contents

    Features
    Prerequisites
    Installation
    Usage
    Security
    Project Structure
    License
    Acknowledgements

Features

    Modern Login and Register interface with a blurred background effect.
    Integration with a local SQL database for user management.
    User registration with data validation.
    User authentication with error handling.
    Passwords are securely hashed using the SHA-256 algorithm.

Prerequisites

    Operating System: Windows 7 or Windows 10.
    .NET Framework: Ensure the appropriate version is installed.
    SQL Server: A local instance of SQL Server for the database.
    Development Environment: Visual Studio.

Installation

    Clone the Repository:

    git clone https://github.com/AkoForU/LoginRegister.git
    cd LoginRegister

    Open the Solution:

    Open the Login.sln file in Visual Studio.

    Configure the Database:
        Set up a local SQL Server database named LoginDB.
        Execute the provided SQL script LoginDB.sql to create the necessary tables.
        Update the connection string in the application configuration file to match your SQL Server instance.

    Build and Run:

    Press F5 in Visual Studio to build and run the application.

Usage

    Registration:
        Navigate to the Register form.
        Enter the required user information.
        Submit the form to create a new user account.

    Login:
        Navigate to the Login form.
        Enter your credentials.
        Submit the form to authenticate.

Security

To ensure the security of user passwords, this application employs the SHA-256 hashing algorithm. SHA-256 is a member of the SHA-2 family of cryptographic hash functions and is widely recognized for its security and resistance to collision attacks. By hashing passwords before storing them in the database, the application ensures that the original passwords cannot be easily retrieved, even in the event of a data breach.
securiti.ai
Project Structure

The project is organized as follows:

    /Login: Contains the main application files.
    /LoginDB.sql: SQL script for setting up the database.
    .gitattributes: Git configuration attributes.
    .gitignore: Specifies files and directories to be ignored by Git.
    Login.sln: Visual Studio solution file for the project.

License

This project is licensed under the MIT License. See the LICENSE file for details.
Acknowledgements

    Inspired by modern UI design principles.
