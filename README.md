# MediatRDemo

## What is it

Super Simple MediatR demo in ASP.NET MVC Core.

MediatR is a super simple to use message dispatcher which can be used to make CQRS super simple in ASP.NET MVC.

See <https://github.com/jbogard/MediatR/wiki> for details of how to use MediatR.

## How to run it

### Pre-requisits

* Install docker <https://www.docker.com/products/docker-desktop>
* Install the .NET Core 2.1 SDK <https://www.microsoft.com/net/download>

### Running the code

Run ./run.sh. This will: -

* Build the project
* Build a docker image called samuelpratt/mediatrapp
* Run the docker image locally with ports 80:80 mapped

navigate to <http://localhost/api/ping/foo>
