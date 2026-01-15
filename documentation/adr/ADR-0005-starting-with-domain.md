# ADR-0005: Starting with a Domain-First Approach

## Status: `Accepted`

## Context
Pizza X follows a **backend-first development strategy** to ensure that all
business rules, validations, and invariants are enforced consistently across
multiple frontend clients.

After setting up the backend project structure and required packages, the next
critical step is to establish a strong and expressive **Domain layer**. The
Domain represents the core business logic of the system and must remain
independent of infrastructure, frameworks, and presentation concerns.

To avoid an anemic model and prevent invalid data from entering the system,
a **Domain-Driven Design (DDD)** approach with a **Rich Domain Model** is adopted.

## Decision
Development begins with the **Domain layer**, focusing on modeling business
rules explicitly and enforcing invariants at the entity and value object level.

The Domain is composed of the following core building blocks:

---

### 1. Entities
Entities represent core business concepts and are uniquely identifiable.

- All entities inherit from a shared `BaseEntity`, which provides a unique
  identifier.
- Entities that require lifecycle tracking inherit from `AuditableEntity`,
  enabling automatic tracking of creation and modification timestamps.

This approach ensures consistency across entities while avoiding duplication
of common concerns.

Example responsibilities:
- Encapsulate business behavior
- Protect internal state
- Control state transitions through methods

---

### 2. Value Objects
Value Objects are used to represent concepts that:
- Do not have identity
- Are immutable by design
- Must always remain valid

In Pizza X, value objects are used for sensitive and rule-heavy data such as:
- Email
- Password

By encapsulating validation and formatting logic inside value objects, the
Domain guarantees that entities can never exist in an invalid state.

---

### 3. Shield (Guards and Domain Exceptions)
A defensive layer referred to as **Shield** is introduced to protect the Domain
from invalid or unauthorized data.

The Shield consists of:
- Custom domain exceptions
- Guard methods used inside entities and value objects

The Shield enforces rules such as:
- Prevention of negative values
- Protection against null or whitespace strings
- String length constraints (minimum and maximum)
- Password mismatch validation
- Authorization checks for admin-only operations

All validation failures are handled at the Domain level, ensuring that invalid
state is rejected **before** reaching persistence or external layers.

---

## Consequences

### Positive
- Strong and expressive domain model
- Business rules enforced at the core of the system
- Prevention of invalid data at the earliest possible stage
- Reduced reliance on external validation layers
- Domain remains framework-agnostic and reusable

### Negative
- Increased upfront modeling effort
- Domain logic can be more complex to design and evolve
- Requires discipline to maintain clear boundaries

## Notes
The Domain layer must not reference:
- Infrastructure concerns (database, ORM)
- Frameworks (ASP.NET, EF Core)
- UI or transport-related logic

All future backend development must respect Domain invariants and extend
business behavior through domain methods rather than external manipulation.
