FROM microsoft/dotnet:latest

#COPY project.json /app/
WORKDIR /app
#RUN ["dotnet", "restore"]
COPY . /app

# Default to port 5000
ARG CONTAINER_PORT=5000
ARG SERVER_URLS=http://*:$CONTAINER_PORT

ENV SERVER.URLS $SERVER_URLS
EXPOSE $CONTAINER_PORT

RUN ["dotnet", "restore"]
RUN ["dotnet", "build"]
 
#EXPOSE 5000/tcp
#ENV ASPNETCORE_URLS http://*:5000
 
ENTRYPOINT ["dotnet", "run"]