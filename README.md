# NetworkingUtilities

## Description

NetwokringUtilities is a library to make networking easier in C# with basic and easy to use wrapper and classess

## Table of Content

| Classess            | Description                                                             |
| ------------------- | ----------------------------------------------------------------------- |
| IClient.cs          | An interface for BasicClient and SecureClient                           |
| BasicClient.cs      | A wrapper for the class System.Net.Sockets.TcpClient                    |
| SecureClient        | A wrapper for the class System.Net.Sockets.TcpClient with SSL support   |
| IServer.cs          | An interface for BasicServer and SecureServer                           |
| BasicServer.cs      | A wrapper for the class System.Net.Sockets.TcpListener                  |
| SecureServer.cs     | A wrapper for the class System.Net.Sockets.TcpListener with SSL support |
| IConnection.cs      | An interface for BasicConnectin and SecureConnection                    |
| BasicConnectin.cs   | A wrapper for the class System.Net.Sockets.Socket                       |
| SecureConnection.cs | A wrapper for the class System.Net.Sockets.Socket with SSL support      |

-   Note classess with SSL support accept only X509 Certificates

## Installation

-   [NuGet](https://nuget.org/)

## Usage

-   All classes, functions, variables and parameters have descriptions so it should be pretty straight forward

## Contributing

1. Clone repository
2. Make new branch locally
3. Make changes to the new branch you created
4. Make a pull request on GitHub
5. Wait for a review

## Credits

-   Zihasz
-   Anyone else who contributed to this project

## Licence

This work is licenced under the MIT Licence
