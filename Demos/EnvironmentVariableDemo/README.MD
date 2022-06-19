# containerized dotnet console app with environment variable
docker run --rm -it  environmentvariabledemo:latest --env test=value1

https://docs.docker.com/engine/reference/commandline/run/#:~:text=Set%20environment%20variables%20(%2De,env%2C%20%2D%2Denv%2Dfile)&text=When%20running%20the%20command%2C%20the,be%20set%20in%20the%20container.
https://enlabsoftware.com/development/dotnet-core-environment-how-config-examples.html#:~:text=NET%20core%20uses%20environment%20variables,to%20access%20the%20environment%20variables.
https://docs.microsoft.com/en-us/dotnet/core/docker/build-container?tabs=windows