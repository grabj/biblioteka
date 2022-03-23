# biblioteka

DOKUMENTACJA PROJEKTU „BIBLIOTEKA”

Celem projektu jest stworzenie systemu zarządzania biblioteką. System ma za główne zadanie umożliwiać wypożyczanie oraz ewidencję zbiorów bibliotecznych. 
Każdy użytkownik aplikacji będzie miał możliwość przeglądania i przeszukiwania zbiorów, a w przypadku założenia konta również do wypożyczenia książki. Bibliotekarz będzie miał możliwość zarządzania listami książek, czytelników i aktualnych wypożyczeń. Natomiast administrator będzie miał dostęp do tych wszystkich możliwości, oraz do zarządzania listami wszystkich użytkowników.
Książka będzie mogła być wypożyczona czytelnikowi na okres 30 dni z uwzględnieniem limitu do 3 wypożyczeń. Zwrot będzie mógł nastąpić przed upływem czasu.

Funkcjonalności danych użytkowników dostępne w interfejsie:

Gość:
•	przeglądanie listy książek
•	utworzenie nowego czytelnika

Czytelnik:
•	wszystkie z powyższych, oraz:
•	logowanie do aplikacji
•	wypożyczenie oraz zwrot książki
•	przeglądanie listy wypożyczonych przez siebie pozycji książek

Bibliotekarz:
•	wszystkie z powyższych, oraz:
•	przeglądanie listy czytelników
•	edycja i usunięcie istniejącego czytelnika
•	dodanie nowej pozycji książki
•	edycja i usunięcie istniejącej pozycji książki
•	przeglądanie listy wypożyczeń
•	edycja statusu dostępności książek

Administrator:
•	wszystkie z powyższych, oraz:
•	przeglądanie wszystkich listy użytkowników
•	dodanie nowego użytkownika do bazy danych
•	edycja i usunięcie istniejącego użytkownika

Opis interfejsu:
Po uruchomieniu programu pojawi się panel logowania, gdzie użytkownik będzie mógł się zalogować (poprzez weryfikację loginu i hasła) lub kontynuować jako gość. W zależności od uprawnień użytkownika na oknie głównym widoczny będzie dostęp do okien z listami: użytkowników, książek, wypożyczeń, wraz z właściwymi im funkcjami, np. wyszukaj, dodaj, edytuj, usuń, itp. Z pozycji okna głównego będzie możliwość wylogowania się i powrót do panelu logowania.
