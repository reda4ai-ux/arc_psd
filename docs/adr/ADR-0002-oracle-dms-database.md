# ADR-0002: Oracle as the DMS database

- Status: Accepted with DBA verification pending
- Date: 2026-09-10

## Decision

Use Oracle for DMS metadata in the dedicated `ARC_PSD` schema, subject to confirming the actual schema/user, default tablespace, quota, Oracle version, and character set.

## Safety constraint

No destructive command or production DDL is executed until inventory, backup/snapshot, script review, and explicit DBA approval are complete.
