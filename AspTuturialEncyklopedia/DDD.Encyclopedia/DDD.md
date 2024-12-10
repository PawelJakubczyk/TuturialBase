### 1. Persistence (Trwałość)
Warstwa Persistence jest odpowiedzialna za interakcję z bazą danych oraz zapewnienie trwałości danych. Dzięki niej logika aplikacyjna jest oddzielona od 
szczegółów implementacyjnych dotyczących przechowywania danych.

### 1. Domain (Domena)
Folder ten zawiera centralne elementy logiki biznesowej oraz reguły związane z problematyką domeny.

Entities (Encje): Obiekty biznesowe z unikalnym identyfikatorem, które reprezentują rzeczywiste byty w domenie.

Value Objects (Obiekty Wartości): Są to obiekty, które są w pełni określone przez swoje atrybuty, nie mają unikalnego identyfikatora.

Aggregates (Agregaty): Są to klastry powiązanych obiektów, które powinny być traktowane jako jedność.

Repositories (Repozytoria): Interfejsy do przechowywania i pobierania agregatów.

### 2. Application (Aplikacja)
Warstwa aplikacyjna zajmuje się koordynowaniem zadań i procesów biznesowych.

Services (Serwisy): Definicje logiki aplikacyjnej, zgrupowane według funkcjonalności.

DTOs (Data Transfer Objects): Obiekty używane do przenoszenia danych między warstwami.

### 3. Infrastructure (Infrastruktura)
Tutaj znajdują się implementacje repozytoriów, dostępy do baz danych, oraz inne zależności zewnętrzne.

Persistence (Trwałość danych): Implementacje repozytoriów i kontekstu bazodanowego.

Configuration (Konfiguracja): Pliki konfiguracyjne dla zależności i frameworków.

### 4. Presentation (Prezentacja)
Warstwa odpowiedzialna za interakcję z użytkownikiem, może zawierać kontrolery MVC, API, widoki, itp.

Controllers (Kontrolery): Zarządzają żądaniami HTTP i delegują zadania do serwisów aplikacyjnych.

Views (Widoki): Widoki dla aplikacji webowych, np. Razor Views w ASP.NET.

