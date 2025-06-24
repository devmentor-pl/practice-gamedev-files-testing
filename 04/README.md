> :white_check_mark: *Jeśli będziesz mieć problem z rozwiązaniem tego zadania, poproś o pomoc na odpowiednim kanale na Slacku, tj. `s10e04-gamedev-files-testing` (dotyczy [mentee](https://devmentor.pl/mentoring/)) lub na ogólnodostępnej i bezpłatnej [społeczności na Discordzie](https://devmentor.pl/discord). Pamiętaj, aby treść Twojego wpisu spełniała [odpowiednie kryteria](https://devmentor.pl/jak-prosic-o-pomoc/).*

&nbsp;

# `#04` GameDev: Pliki i Testowanie

## System informacji o pracownikach - część II
To ćwiczenie jest kontynuacją ćwiczenia `System informacji o pracownikach - część I`. Przekopiuj jego cały kod do tego projektu, by móc go rozbudowywać na potrzeby tego ćwiczenia:
1. Zaimplementuj klasę `Company`, która zawiera listę managerów oraz działów;
2. Zaimplementuj interfejs generyczny `IRepository<T>`, który zgodnie ze wzorcem projektowym Repository zawiera operacje CRUD oraz kilka dodatkowych
    - `Create` - metoda dodaje dany element do zbioru danych i zwraca jego ID;
    - `Read` - metoda zwraca element o danym ID, jeżeli istnieje;
    - `ReadWhere` - metoda zwraca wszystkie elementy, które spełniają podane kryterium (`Func<bool, T>`);
    - `Update` - metoda podmienia element o danym ID na podany element;
    - `Delete` - metoda usuwa element o danym ID;
    - `DeleteAll` - metoda usuwa wszystkie przechowywane elementy w zbiorze danych;
    - `Exists` - metoda zwraca `true`, jeżeli element o danym ID istnieje;
    - `Count` - metoda zwraca ilość elementów, które spełniają podane kryterium (`Func<bool, T>`);
3. Zaimplementuj klasę generyczną `InMemoryRepository<T>`, która implementuje interfejs `IRepository<T>` i przechowuje dane jedynie w pamięci RAM;
4. Zaimplementuj klasę generyczną `JsonRepository<T>`, która implementuje interfejs `IRepository<T>` i przechowuje dane w plikach .json;
5. W `JsonRepository<T>` zaimplementuj mechanizm cachingu, tj. zapamiętywania w pamięci RAM raz odczytanych/zapisanych elementów, aby ograniczyć do minimum ilość operacji ładowania danych z plików (np. przy wielokrotnym odczycie tego samego elementu);
6. Przetestuj działanie `JsonRepository<T>` przechowując w nim obiekty typu `Company`;

&nbsp;

> :no_entry: *Jeśli nie posiadasz materiałów do tego zadania tj. **PDF, projekt + Code Review**, znajdziesz je na stronie [devmentor.pl](https://devmentor.pl/workshop-gamedev-files-testing)*

> :arrow_left: [*poprzednie zadanie*](./../03) | [*następne zadanie*](./../05) :arrow_right:
