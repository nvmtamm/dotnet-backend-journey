# BookVerse

BookVerse is a long-term learning project for practicing C# fundamentals, Entity Framework Core, ASP.NET Core Web API, authentication, testing, and backend architecture.

## Learning Goal

- Learn C# from the basics with practical examples.
- Build a bookstore management system step by step.
- Keep GitHub contributions meaningful with real daily progress.
- Turn small C# labs into a complete ASP.NET Core backend portfolio project.

## Daily Rules

- **Pace**: 1 lab per day, 1 commit per day — keeps the contribution graph steady.
- **Commit message**: `Day XX: <Topic>` (simple style).
- **Git flow**:
  1. `git checkout -b day-XX-<topic>`
  2. Create folder + code + README following the Day 01 pattern.
  3. `dotnet run` to verify it builds and runs.
  4. `git add . && git commit -m "Day XX: <Topic>"`
  5. `git push origin day-XX-<topic>`
  6. Open PR into `main`, merge, close PR.
- Update [docs/roadmap.md](docs/roadmap.md) and the `Progress` table below after each phase.

## Progress

| Day   | Topic                       | Status |
|-------|-----------------------------|--------|
| Day 01 | Variables and Data Types   | Done   |
| Day 02 | Input and Output           | Done   |
| Day 03 | Operators and Expressions  | Done   |
| Day 04 | Conditions                 | Done   |

## Roadmap

### Phase 1 — C# Fundamentals (Day 01–07)

Build small BookVerse examples for each concept. Day 01 already exists.

| Day | Folder                  | Topic                | Practice                                    |
|-----|-------------------------|----------------------|---------------------------------------------|
| 02  | day-02-input-output/    | Console I/O          | Display book info, read user input          |
| 03  | day-03-operators-expressions/ | Operators      | Calculate totals, apply discounts           |
| 04  | day-04-conditions/      | if/else              | Check stock availability and price tiers    |
| 05  | day-05-switch/          | switch               | Build CRUD menu choices                     |
| 06  | day-06-loops/           | for/while/foreach    | Print book lists and repeat menu actions    |
| 07  | day-07-methods/         | methods              | Split logic into reusable methods           |

### Phase 2 — Collections & LINQ (Day 08–11)

Inside `labs/02-collections-linq/`.

| Day | Folder              | Topic                                    |
|-----|---------------------|------------------------------------------|
| 08  | day-08-array-list/  | Array, `List<Book>`                      |
| 09  | day-09-dictionary/  | `Dictionary<int, Book>`                  |
| 10  | day-10-lambda/      | Lambda expressions                       |
| 11  | day-11-linq/        | `Where`, `Select`, `OrderBy`, `GroupBy`  |

### Phase 3 — Object-Oriented Programming (Day 12–18)

Inside `labs/03-oop/`.

| Day | Folder                          | Topic                                  |
|-----|---------------------------------|----------------------------------------|
| 12  | day-12-class-object/            | `class Book`, `Category`, `Customer`   |
| 13  | day-13-constructor-property/    | Ctor, get/set, init                    |
| 14  | day-14-encapsulation/           | private fields, properties             |
| 15  | day-15-inheritance/             | Base class `PrintableItem`             |
| 16  | day-16-interface/               | `IBookRepository`, `IOrderService`     |
| 17  | day-17-abstract-class/          | `abstract PaymentMethod`               |
| 18  | day-18-polymorphism/            | `override`, `virtual` methods          |

### Phase 4 — BookVerse Console App (Day 19–25)

Inside `src/BookVerse.Console/`.

- Day 19: scaffold solution + project
- Day 20: add / update / delete books
- Day 21: search and display books
- Day 22: manage shopping cart
- Day 23: create orders
- Day 24: read/write JSON file
- Day 25: polish + refactor + README

### Phase 5 — ASP.NET Core Backend (Day 26–35)

Inside `src/BookVerse.Api/` (solution `BookVerse.sln`).

| Day | Topic                                                       |
|-----|-------------------------------------------------------------|
| 26  | Scaffold ASP.NET Core Web API                               |
| 27  | Entity Framework Core + DbContext                           |
| 28  | Migration + SQL Server (LocalDB)                            |
| 29  | Repository pattern + DI                                     |
| 30  | CRUD endpoints for Book                                     |
| 31  | JWT Authentication                                          |
| 32  | Role-based Authorization (Admin/User)                        |
| 33  | Clean Architecture (Domain/Application/Infrastructure/Api)    |
| 34  | Unit Testing (xUnit + Moq)                                 |
| 35  | Integration Testing + Swagger polish                        |

### Phase 6 — Deployment (Day 36–41)

Inside `src/BookVerse.Api/` and `.github/workflows/`.

| Day | Topic                                                        |
|-----|--------------------------------------------------------------|
| 36  | Dockerfile + .dockerignore                                   |
| 37  | docker-compose (API + SQL Server)                            |
| 38  | GitHub Actions CI (build + test)                             |
| 39  | GitHub Actions CD (publish Docker image)                      |
| 40  | Azure App Service deploy (or Railway / Render free tier)     |
| 41  | Health checks + logging + deploy README                       |

## Timeline Summary

- 41 days (around 6 weeks if done daily).
- 41 commits, 41 PRs — dense contribution graph.
- End result: a complete BookVerse portfolio that can be demoed and deployed.

## Run Labs

Install the .NET SDK first, then run:

```bash
cd labs/01-csharp-fundamentals/day-01-variables-data-types
dotnet run
```

```bash
cd labs/01-csharp-fundamentals/day-02-input-output
dotnet run
```

```bash
cd labs/01-csharp-fundamentals/day-03-operators-expressions
dotnet run
```

```bash
cd labs/01-csharp-fundamentals/day-04-conditions
dotnet run
```