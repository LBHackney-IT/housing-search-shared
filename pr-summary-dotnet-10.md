# Run housing-search-shared tests on .NET 10

## Changed

- Retargeted `Hackney.Shared.HousingSearch.Tests` from `net6.0` to `net10.0`.
- Changed the test Docker SDK image from `mcr.microsoft.com/dotnet/sdk:6.0`
  to `mcr.microsoft.com/dotnet/sdk:10.0`. Existing CI uses this Dockerfile.
- Added a minimal `Makefile` test target using the existing CI service to build
  and run tests. There was no Makefile in the checkout, so there were no
  `docker-compose` occurrences to replace. The new target intentionally uses
  `docker compose`, because Compose v1 is unavailable; `--rm` removes the test
  container after execution.
- Rewrote the repository's only README to document actual library functionality,
  framework support, setup, package feeds, tests, data representations and the
  absence of HTTP endpoints.

## Compatibility and release impact

This checkout had a `netstandard2.1` NuGet library and a `net6.0` test project,
not a .NET 8 application. The library target remains `netstandard2.1`, which is
supported by .NET 10. This validates the existing library on .NET 10 without
unnecessarily requiring consumers to upgrade or publishing a duplicate
framework-specific library asset. No application source or test assertions changed.

Retargeting the library exclusively to `net10.0` would drop older consumers and
should require a major package release. This change does not impose that breaking
restriction. GitVersion and publication behavior are unchanged; nothing was
published as part of this work.

## Initial inventory and package changes

The solution contains exactly two projects. The test project references the
library; the library has no project references. There is no `global.json`, and
none was required for Docker-based validation. The host has only SDK 8.0.303;
validation used Docker rather than modifying the host SDK installation.

No package references or versions changed, including transitive dependencies.
Existing direct references remain:

| Project | Package | Version |
| --- | --- | --- |
| Library | Hackney.Shared.Processes | 0.7.0 |
| Library | Hackney.Shared.Tenure | 0.9.0 |
| Library | NEST | 7.11.1 |
| Library | System.ComponentModel.Annotations | 5.0.0 |
| Tests | AutoFixture | 4.18.1 |
| Tests | Microsoft.NET.Test.Sdk | 16.5.0 |
| Tests | xunit | 2.4.0 |
| Tests | xunit.runner.visualstudio | 2.4.0 |
| Tests | coverlet.collector | 6.0.2 |
| Tests | FluentAssertions | 6.12.0 |

## Validation

| Check | Result |
| --- | --- |
| Original `make test` before environment preparation | No Makefile/test target existed |
| Baseline `make test` after adding the Compose target, before migration | Passed on .NET 6: 9 passed, 0 failed, 0 skipped; build had 0 warnings/errors |
| Post-migration `make test` | Passed on .NET 10: 9 passed, 0 failed, 0 skipped |
| Explicit `dotnet restore Hackney.Shared.HousingSearch.sln` in test container | Succeeded |
| Explicit `dotnet build Hackney.Shared.HousingSearch.sln --no-restore` in test container | Succeeded: 2 warnings, 0 errors |
| SDK used for final validation | 10.0.403 |
| `git diff --check` | Passed |

The first .NET 10 `make test` attempt failed during restore with NU1301 because
Docker could not resolve `nuget.pkg.github.com`. Retrying the same command
succeeded without configuration or dependency changes. Final test counts match
the baseline exactly. No external-service integration or downstream consumer
suite was run; this repository provides nine unit tests.

Neither the Compose file nor Dockerfile contains SonarCloud configuration.
No temporary SonarCloud workaround was necessary or applied, and no SonarCloud
changes remain in the diff. No temporary source/configuration workarounds remain.
The Compose v2 Makefile target is intentionally retained to support `make test`.

## Warnings and out of scope

- Docker Compose warns that the existing `version` attribute is obsolete. It was
  left unchanged because it does not block the migration.
- The newer SDK's default NuGet restore checks emitted NU1902 for existing
  transitive `Microsoft.IdentityModel.JsonWebTokens` 6.11.1 and
  `System.IdentityModel.Tokens.Jwt` 6.11.1. The explicit solution build reports
  these two warnings; the Docker build repeats them during restore/build.
  No separate security scan was run, and no remediation or dependency
  modernization was performed.
- Existing workflow actions, formatting tooling, GitVersion policy, serialization,
  business logic and database/data models were left unchanged.
