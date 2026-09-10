# ADR-0001: Modular Monolith

- Status: Accepted
- Date: 2026-09-10

## Decision

Build the first production version as an ASP.NET Core modular monolith with Domain, Application, Infrastructure, and Web boundaries.

## Consequences

Business rules remain independent of MVC, Oracle, and file storage. Deployment stays operationally simple while module boundaries leave a path for later extraction if measurements justify it.
