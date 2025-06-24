> :white_check_mark: *Jeśli będziesz mieć problem z rozwiązaniem tego zadania, poproś o pomoc na odpowiednim kanale na Slacku, tj. `s10e05-gamedev-files-testing` (dotyczy [mentee](https://devmentor.pl/mentoring/)) lub na ogólnodostępnej i bezpłatnej [społeczności na Discordzie](https://devmentor.pl/discord). Pamiętaj, aby treść Twojego wpisu spełniała [odpowiednie kryteria](https://devmentor.pl/jak-prosic-o-pomoc/).*

&nbsp;

# `#05` GameDev: Pliki i Testowanie

## System informacji o pracownikach - część III
To ćwiczenie jest kontynuacją ćwiczenia `System informacji o pracownikach - część II`. Przekopiuj jego cały kod do tego projektu, by móc go rozbudowywać na potrzeby tego ćwiczenia:
1. Zaimplementuj testy jednostkowe sprawdzające wszystkie zaimplementowane metody w `Queries`:
   - Wykorzystaj metodę z atrybutem `SetUp` do stworzenia obiektu typu `Company` i zapełnienia go danymi, które potem wykorzystasz do testowania;
   - Podczas sprawdzania rezultatów, nie wykonuj prostego porównania `==` dużych, złożonych obiektów, np. całych departamentów. Zamiast tego, sprawdź, czy ich poszczególne obiekty są takie same (wartości ich pól i właściwości są równe);
   - Pamiętaj: w przypadku typów referencyjnych (za wyjątkiem `string`) operator `==` oznacza `czy referencja po lewej stronie odnosi się do tego samego obiektu, co referencja po prawej stronie`;
   - Aby sprawdzić, czy dane obiekty są sobie równe, ale nie są tym samym obiektem, należy użyć metody `Equals()`;
2. Zaimplementuj testy jednostkowe sprawdzające funkcjonalność klasy `JsonRepository<T>`:
   - Metody testowe powinny operować na interfejsie `IRepository<T>`, nie powinny bezpośrednio się odwoływać do konkretnej implementacji;
   - Wykorzystaj metodę z atrybutem `SetUp`, aby zainicjować repozytorium i zapełnić je danymi przed każdym testem;
   - Wykorzystaj metodę z atrybutem `TearDown`, aby wyczyścić wszystkie dane przechowywane w repozytorium po wykonanym teście;
   - 
&nbsp;

> :no_entry: *Jeśli nie posiadasz materiałów do tego zadania tj. **PDF, projekt + Code Review**, znajdziesz je na stronie [devmentor.pl](https://devmentor.pl/workshop-gamedev-files-testing)*

> :arrow_left: [*poprzednie zadanie*](./../04) | ~~*następne zadanie*~~ :arrow_right:
