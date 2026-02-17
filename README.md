# Bewerber-Aufgaben – Backend (C#)

## Überblick
Dieses Repository enthält Lösungen zu den Bewerber-Aufgaben für eine Backend-Position.  
Der Fokus liegt auf **sauberem Code**, **Testbarkeit** und **testgetriebener Entwicklung (TDD)**.

---

## Projektstruktur

```
.
├─ .github/
│  └─ workflows/
│     └─ dotnet.yml
│
├─ Solutions/
│  ├─ Solutions.csproj
│  ├─ MultiplesOfThreeOrFive.cs
│  ├─ SumOfEvenFibonacciNumbers.cs
│  ├─ LargestPrimeFactor.cs
│  ├─ LargestPalindromeProduct.cs
│  └─ SmallestMultiple.cs
│
├─ Solutions.Tests/
│  ├─ Solutions.Tests.csproj
│  ├─ MultiplesOfThreeOrFiveTests.cs
│  ├─ SumOfEvenFibonacciNumbersTests.cs
│  ├─ LargestPrimeFactorTests.cs
│  ├─ LargestPalindromeProductTests.cs
│  └─ SmallestMultipleTests.cs
│
├─ docs/
│  └─ task-notes/
│     ├─ 01_multiples_of_3_or_5.txt
│     ├─ 02_sum_of_even_fibonacci_numbers.txt
│     ├─ 03_largest_prime_factor.txt
│     ├─ 04_largest_palindrome_product.txt
│     └─ 05_smallest_multiple.txt
│
└─ README.md
```

- **Solutions**  
  Enthält die eigentlichen Lösungsimplementierungen (Business-Logik).

- **Solutions.Tests**  
  Enthält Unit Tests (xUnit), die das Verhalten der Lösungen absichern.

- **docs/task-notes**  
  Enthält pro Aufgabe eine kurze Schritt-für-Schritt-Erklärung, inklusive Begründung der gewählten Lösung.

---

## Vorgehensweise (TDD)

Die Aufgaben wurden **testgetrieben** umgesetzt:

1. Zunächst wurden Unit Tests basierend auf der Aufgabenbeschreibung geschrieben  
   (u. a. das Beispiel „below 10 returns 23“ aus der Aufgabenstellung).
2. Anschließend wurde eine minimale Implementierung erstellt, um die Tests grün zu bekommen.
3. Danach erfolgte ein Refactoring hin zu einer klaren, deklarativen Lösung  
   (u. a. Nutzung von LINQ).

Die Tests dienen dabei sowohl als **Sicherheitsnetz** als auch als **lebende Dokumentation** des gewünschten Verhaltens.

---

## Technische Entscheidungen

- **Sprache:** C# (.NET)
- **Testframework:** xUnit
- **Stil:**
  - Trennung von Logik und I/O
  - Reine, zustandslose Funktionen
  - Funktionaler Stil, wo sinnvoll (LINQ)

---

## Tests ausführen

Alle Tests können mit folgendem Befehl ausgeführt werden:

```
dotnet test
```

---

## CI / Pipeline

Zusätzlich zu lokalen Tests werden die Tests auch automatisch in der Pipeline ausgeführt  
(GitHub Actions, siehe `.github/workflows/dotnet.yml`).

Die Pipeline führt bei Pushes und Pull Requests auf `main` folgende Schritte aus:

1. `dotnet restore`
2. `dotnet build --no-restore`
3. `dotnet test --no-build --verbosity normal`

---

## Lösungsnotizen je Aufgabe

Für jede Aufgabe gibt es eine separate Notizdatei mit Vorgehen und Begründung:

- `docs/task-notes/01_multiples_of_3_or_5.txt`
- `docs/task-notes/02_sum_of_even_fibonacci_numbers.txt`
- `docs/task-notes/03_largest_prime_factor.txt`
- `docs/task-notes/04_largest_palindrome_product.txt`
- `docs/task-notes/05_smallest_multiple.txt`

---

## Hinweise

Die Projektstruktur ist bewusst einfach gehalten und auf die Aufgabenstellung fokussiert.  
Ziel war es, eine saubere, gut testbare Lösung zu zeigen – nicht maximale Komplexität.
