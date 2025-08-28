// See https://aka.ms/new-console-template for more information
/*
--This project created in Linux/Ubuntu PC
Note: The easiest way to generate a comprehensive '.gitignore file for .NET is to use the .NET CLI. In the root of your project, run the command:
--dotnet new gitignore

-Build the Docker Image
podman build -t ubuntu-vscode-demo .
[OR]
docker build -t ubuntu-vscode-demo .
-Run the Container
podman run --rm ubuntu-vscode-demo   //NOTE : this command run the container and after executin it stop and remove, so, podman ps will not listing.
[OR]
docker run --rm ubuntu-vscode-demo
--some more important commands 
1) podman images
2) podman images -a
3) podman ps -a
4) podman container prune
5) podman images --help ; podman container --help; podman pod --help


*/
Console.WriteLine("Hello, World!");
