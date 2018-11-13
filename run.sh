#!/bin/sh

echo "Pulling docker Image..."
docker pull microsoft/aspnetcore

echo "Building Code"
dotnet build MedatrApp.sln
dotnet publish -c Release -o publish

echo "Building docker image"
docker build -t samuelpratt/mediatrapp .

echo "Running docker. Push ctrl+c to terminate"
docker run -it -p 80:80  samuelpratt/mediatrapp
