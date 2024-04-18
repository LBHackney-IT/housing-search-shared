FROM mcr.microsoft.com/dotnet/sdk:6.0

# disable microsoft telematry
ENV DOTNET_CLI_TELEMETRY_OPTOUT='true'

ARG LBHPACKAGESTOKEN
ENV LBHPACKAGESTOKEN=$LBHPACKAGESTOKEN
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY ./Hackney.Shared.HousingSearch.sln ./
COPY ./Hackney.Shared.HousingSearch/Hackney.Shared.HousingSearch.csproj ./Hackney.Shared.HousingSearch/
COPY ./Hackney.Shared.HousingSearch.Tests/Hackney.Shared.HousingSearch.Tests.csproj ./Hackney.Shared.HousingSearch.Tests/
COPY /nuget.config /root/.nuget/NuGet/NuGet.Config

RUN dotnet restore ./Hackney.Shared.HousingSearch/Hackney.Shared.HousingSearch.csproj
RUN dotnet restore ./Hackney.Shared.HousingSearch.Tests/Hackney.Shared.HousingSearch.Tests.csproj

# Copy everything else and build
COPY . .

RUN dotnet build -c debug -o out Hackney.Shared.HousingSearch.Tests/Hackney.Shared.HousingSearch.Tests.csproj

CMD dotnet test
