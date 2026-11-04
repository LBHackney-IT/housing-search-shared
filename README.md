# Hackney.Shared.HousingSearch

Shared NuGet library for Hackney housing search consumers. It provides domain
models, Elasticsearch query models and conversion helpers; it is not a hosted API.

## Framework compatibility

The package targets `netstandard2.1`, preserving its existing consumer framework
support. The test project targets `net10.0` and the test container uses the .NET 10
SDK. Using .NET 10 for tests does not require consumers to move to .NET 10.
Retargeting the library itself to `net10.0` would remove support for older
consumers and should be treated as a breaking change with a major package release.

## Functionality and data sources

- Domain models cover accounts, assets, contracts, people, processes, tenures and
  transactions, including temporary accommodation details.
- `Gateways/Models` contains queryable models with NEST Elasticsearch field
  mappings; `Gateways/Entities/Accounts` contains account database entity models.
- `DomainFactory` and `EntityFactory` convert process and contract-related models
  between domain and query representations, including shared process models.
  Other model conversion methods include tenure and tenured asset creation.
- `NonEmptyGuidAttribute` validates that a supplied GUID is not empty.
- Models include JSON serialization annotations and use shared tenure helpers.

The library represents housing search data supplied by consuming applications,
including Elasticsearch search documents and account database records. It does
not open database connections, query Elasticsearch, configure indexes or ingest
external data. No database, Elasticsearch instance or external API is needed for
the existing unit tests, which use AutoFixture-generated objects.

## API endpoints

None. This repository contains a library and its unit tests, with no HTTP server,
controllers, routes or application entry point. Consumers define their own API
endpoints and data connections.

## Setup and installation

For local development, install the .NET 10 SDK, or use Docker with Docker Compose
v2 and Make to run the container tests. Package restore uses nuget.org and the
Hackney GitHub Packages feed configured in `nuget.config`.

Set `LBHPACKAGESTOKEN` in your shell to a token with read access to the required
Hackney packages (and any organization authorization required by your account).
Do not commit tokens. The Docker build reads this value as a BuildKit secret.

From the repository root, with the token exported:

```sh
dotnet restore Hackney.Shared.HousingSearch.sln
dotnet build Hackney.Shared.HousingSearch.sln --no-restore
dotnet test Hackney.Shared.HousingSearch.sln --no-build --no-restore
```

To build and run tests in Docker using the same service as CI:

```sh
make test
```

Equivalent commands:

```sh
docker compose build hackney-shared-housing-search-test
docker compose run --rm hackney-shared-housing-search-test
```

To consume the package, configure the Hackney GitHub Packages feed and credentials
in your consuming project, then install a published version:

```sh
dotnet add package Hackney.Shared.HousingSearch --version <published-version>
```

Published versions are listed in [GitHub Packages](https://github.com/orgs/LBHackney-IT/packages?repo_name=housing-search-shared).

## Dependencies

Library package versions are intentionally preserved:

| Package | Version |
| --- | --- |
| Hackney.Shared.Processes | 0.7.0 |
| Hackney.Shared.Tenure | 0.9.0 |
| NEST | 7.11.1 |
| System.ComponentModel.Annotations | 5.0.0 |

Tests use AutoFixture, Microsoft.NET.Test.Sdk, xUnit, coverlet.collector and
FluentAssertions; exact versions are in the test project file.

## Contributing and packaging

The workflow in `.github/workflows/publish.yml` calculates versions with
GitVersion, checks formatting, builds and tests through Docker Compose, and packs
and publishes the library to GitHub Packages after successful tests. It runs on
pushes to `main` and `feature/**`. Use `feature/<description>` for feature branches;
`GitVersion.yml` configures feature prerelease suffixes and minor increments.

To create a local package without publishing:

```sh
dotnet pack Hackney.Shared.HousingSearch --configuration Release
```

Version changes should follow semantic versioning: major for breaking consumer
changes, minor for compatible features, patch for compatible fixes. This migration
preserves the library target and does not add .NET 10-specific functionality.
