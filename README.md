# BeerCollection - Aplikacja do Zarządzania Kolekcją Piw

## 1. Opis Aplikacji

**BeerCollection** to aplikacja desktopowa stworzona w technologii Windows Forms (.NET), która służy do katalogowania i zarządzania kolekcją piw. Umożliwia użytkownikowi dodawanie, przeglądanie, edytowanie i usuwanie piw oraz browarów, a także przeglądanie recenzji dla poszczególnych piw.

### Główne Funkcjonalności
* **Zarządzanie Browarami:** Pełna obsługa operacji CRUD (Create, Read, Update, Delete) dla browarów. Aplikacja zapobiega usunięciu browaru, jeśli są z nim powiązane jakieś piwa.
* **Zarządzanie Piwami:** Pełna obsługa operacji CRUD dla piw. Podczas dodawania lub edycji piwa, browar wybierany jest z istniejącej listy, co zapewnia spójność danych.
* **Wyświetlanie Recenzji:** Po podwójnym kliknięciu na piwo na liście, otwiera się dedykowane okno z recenzjami dla tego piwa. Usunięcie piwa powoduje kaskadowe usunięcie wszystkich jego recenzji.
* **Wyszukiwanie:** Aplikacja oferuje funkcję wyszukiwania za pomocą przycisku, która filtruje listę piw na podstawie nazwy piwa, nazwy browaru lub typu piwa.

### Zastosowane Technologie
* **Język:** C#
* **Platforma:** .NET (wersja 9.0)
* **Interfejs użytkownika:** Windows Forms (WinForms)
* **Dostęp do danych:** Entity Framework Core
* **Baza danych:** SQLite

---

## 2. Opis Bazy Danych

Aplikacja wykorzystuje lekką, plikową bazę danych **SQLite**. Struktura bazy danych (schemat) jest definiowana w pliku `beers.sql` dołączonym do projektu.

### Tabele
Baza danych składa się z trzech głównych tabel:

1.  **`Breweries` (Browary)**
    * Przechowuje informacje o browarach.
    * **Główne kolumny:** `Id` (klucz główny), `Name`, `Country`, `City`.

2.  **`Beers` (Piwa)**
    * Przechowuje szczegółowe informacje o poszczególnych piwach.
    * **Główne kolumny:** `Id` (klucz główny), `Name`, `BreweryId` (klucz obcy), `BeerType`, `AlcoholContent`, `Volume`, `Price`, `Description`.

3.  **`Reviews` (Recenzje)**
    * Przechowuje recenzje wystawione dla piw.
    * **Główne kolumny:** `Id` (klucz główny), `BeerId` (klucz obcy), `ReviewerName`, `Rating`, `Comment`, `ReviewDate`.

### Relacje
* **`Breweries` ↔ `Beers` (Jeden-do-wielu):** Jeden browar może mieć wiele piw. Relacja jest zabezpieczona przez `ON DELETE RESTRICT`, co oznacza, że nie można usunąć browaru, jeśli są do niego przypisane jakieś piwa.
* **`Beers` ↔ `Reviews` (Jeden-do-wielu):** Jedno piwo może mieć wiele recenzji. Relacja posiada ustawienie `ON DELETE CASCADE`, co oznacza, że usunięcie piwa automatycznie usuwa wszystkie jego recenzje.

---

## 3. Konfiguracja

### Pliki konfiguracyjne
* **`appsettings.json`**: Główny plik konfiguracyjny aplikacji. Zawiera `connection string` do bazy danych SQLite. Domyślnie wskazuje na plik bazy danych, który zostanie utworzony w katalogu wyjściowym aplikacji (np. `bin/Debug/...`).
    ```json
    {
      "ConnectionStrings": {
        "DefaultConnection": "Data Source=MojaBazaPiw.db"
      }
    }
    ```
* **`beers.sql`**: Skrypt SQL, który zawiera polecenia `CREATE TABLE` do utworzenia schematu bazy danych. Aplikacja jest zaprojektowana tak, aby automatycznie wykonać ten skrypt przy pierwszym uruchomieniu, jeśli wykryje, że tabele w bazie danych nie istnieją. Skrypt zawiera również przykładowe dane (`INSERT INTO...`), które pozwalają na przetestowanie aplikacji od razu po uruchomieniu.

### Zależności (Pakiety NuGet)
Projekt korzysta z Entity Framework Core do komunikacji z bazą danych. Wszystkie wymagane pakiety (np. `Microsoft.EntityFrameworkCore.Sqlite`) są zdefiniowane w pliku `.csproj` i zostaną automatycznie pobrane przez Visual Studio podczas budowania projektu.

---
