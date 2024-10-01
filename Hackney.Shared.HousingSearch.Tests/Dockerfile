FROM mcr.microsoft.com/dotnet/sdk:6.0

# disable microsoft telematry
ENV DOTNET_CLI_TELEMETRY_OPTOUT='true'
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY ./Hackney.Shared.HousingSearch.sln ./
COPY ./Hackney.Shared.HousingSearch/Hackney.Shared.HousingSearch.csproj ./Hackney.Shared.HousingSearch/
COPY ./Hackney.Shared.HousingSearch.Tests/Hackney.Shared.HousingSearch.Tests.csproj ./Hackney.Shared.HousingSearch.Tests/
COPY /nuget.config /root/.nuget/NuGet/NuGet.Config

# We mount secrets so they can't end up in logs or build layers.
# We chain both restore commands so we only make the token available
# once and don't store it elsewhere.
# see:
#   - https://docs.docker.com/reference/dockerfile/#arg
#   - https://docs.docker.com/compose/how-tos/use-secrets/ 
RUN --mount=type=secret,id=LBHPACKAGESTOKEN \
  export LBHPACKAGESTOKEN=$(cat /run/secrets/LBHPACKAGESTOKEN) && \
  dotnet restore ./Hackney.Shared.HousingSearch/Hackney.Shared.HousingSearch.csproj && \
  dotnet restore ./Hackney.Shared.HousingSearch.Tests/Hackney.Shared.HousingSearch.Tests.csproj

# Copy everything else and build
COPY . .

RUN dotnet build -c debug -o out Hackney.Shared.HousingSearch.Tests/Hackney.Shared.HousingSearch.Tests.csproj

CMD dotnet test
