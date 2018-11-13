FROM microsoft/dotnet:2.1-aspnetcore-runtime

WORKDIR /app
COPY ./MedatrApp/publish/ ./
ENTRYPOINT ["dotnet", "MedatrApp.dll"]
