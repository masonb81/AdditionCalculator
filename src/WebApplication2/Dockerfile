FROM microsoft/dotnet:1.1-sdk-projectjson
WORKDIR /app
COPY . .
EXPOSE 5000

COPY project.json .
RUN ["dotnet", "restore"]
RUN ["dotnet", "build"]

ENTRYPOINT ["dotnet", "run"]

#FROM microsoft/dotnet

#WORKDIR /WebApplication2

# copy project.json and restore as distinct layers
#COPY project.json .
#RUN dotnet restore

# copy and build everything else
#COPY . .
#RUN dotnet publish -c Release -o out
#ENTRYPOINT ["dotnet", "out/WebApplication2.dll"]

#FROM microsoft/dotnet:latest

#COPY project.json /app/
#WORKDIR /app
##RUN ["dotnet", "restore"]
#COPY . /app
#
## Default to port 5000
#ARG CONTAINER_PORT=5000
#ARG SERVER_URLS=http://*:$CONTAINER_PORT
#
#ENV SERVER.URLS $SERVER_URLS
#EXPOSE $CONTAINER_PORT

#RUN ["dotnet", "restore"]
#RUN ["dotnet", "build"]
 
#EXPOSE 5000/tcp
#ENV ASPNETCORE_URLS http://*:5000
 
# ENTRYPOINT ["dotnet", "WebApplication2.dll"]
# ENTRYPOINT ["dotnet", "run"]
