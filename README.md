# Company Archive

Enterprise Document & Records Management System for internal company use.

## Status

Phase 1 — Project Foundation & Database Foundation (in progress).

## Requirements

- .NET 10 SDK

## Verify

```bash
dotnet restore Company.Archive.slnx
dotnet build Company.Archive.slnx --configuration Release --no-restore
dotnet test Company.Archive.slnx --configuration Release --no-build
```

Production credentials, connection strings, certificates, and file-server paths must never be committed.
