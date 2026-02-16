# Bewerber-Aufgaben – Backend (C#)

## Überblick
Dieses Repository enthält Lösungen zu den Bewerber-Aufgaben für eine Backend-Position.  
Der Fokus liegt auf **sauberem Code**, **Testbarkeit** und **testgetriebener Entwicklung (TDD)**.

---

## Projektstruktur

```
.
├─ Solutions/
│  ├─ Solutions.csproj
│  └─ MultiplesOfThreeOrFive.cs
│
├─ Solutions.Tests/
│  ├─ Solutions.Tests.csproj
│  └─ MultiplesOfThreeOrFiveTests.cs
│
└─ README.md
```

- **Solutions**  
  Enthält die eigentlichen Lösungsimplementierungen (Business-Logik).

- **Solutions.Tests**  
  Enthält Unit Tests (xUnit), die das Verhalten der Lösungen absichern.

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

## Hinweise

Die Projektstruktur ist bewusst einfach gehalten und auf die Aufgabenstellung fokussiert.  
Ziel war es, eine saubere, gut testbare Lösung zu zeigen – nicht maximale Komplexität.
