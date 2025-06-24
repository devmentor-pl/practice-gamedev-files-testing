> :white_check_mark: *Jeśli będziesz mieć problem z rozwiązaniem tego zadania, poproś o pomoc na odpowiednim kanale na Slacku, tj. `s10e03-gamedev-files-testing` (dotyczy [mentee](https://devmentor.pl/mentoring/)) lub na ogólnodostępnej i bezpłatnej [społeczności na Discordzie](https://devmentor.pl/discord). Pamiętaj, aby treść Twojego wpisu spełniała [odpowiednie kryteria](https://devmentor.pl/jak-prosic-o-pomoc/).*

&nbsp;

# `#03` GameDev: Pliki i Testowanie

## System informacji o pracownikach - część I
Zaimplementuj ogólną strukturę aplikacji przechowującej dane o pracownikach firmy:
1. Klasa `Employee`, która zawiera informacje o imieniu i nazwisku, płci, roku urodzenia oraz wynagrodzeniu
2. Klasa `Department`, która zawiera nazwę oraz referencje do pracowników z danego działu
3. Klasa `Manager`, która bazując na `Employee` zawiera dodatkowo referencję do zarządzanego działu

Następnie zaimplementuj klasę statyczną `Queries`, która zawiera zestaw metod statycznych - zapytań, przyjmujących kolekcje danych jako parametry i zwracające rezultaty wedle kryteriów zapytania:
1. Metoda przyjmuje jako parametr jeden dział (`Department`) i zwraca najmłodszego pracownika (`Employee`) w danym dziale.
2. Metoda przyjmuje jako parametry listę pracowników (`List<Employee>`) oraz wartość progową wynagrodzenia (`decimal`) i zwraca listę pracowników (`List<Employee>`), których wynagrodzenie jest większe niż podana wartość.
3. Metoda przyjmuje jako parametr listę pracowników (`List<Employee>`) i zwraca średnie wynagrodzenie (`decimal`) w tej grupie.
4. Metoda przyjmuje jako parametry listę działów (`List<Department>`) oraz listę menedżerów (`List<Manager>`) i zwraca listę działów (`List<Department>`), które nie mają przypisanego menedżera.
5. Metoda przyjmuje jako parametr listę działów (`List<Department>`) i zwraca słownik (`Dictionary<string, int>`), w którym kluczem jest nazwa działu, a wartością liczba pracowników w tym dziale.
6. Metoda przyjmuje jako parametr listę działów (`List<Department>`) i zwraca najstarszego pracownika (`Employee`) w firmie.
7. Metoda przyjmuje jako parametr listę pracowników (`List<Employee>`) i zwraca listę kobiet (`List<Employee>`), których wynagrodzenie jest wyższe niż średnie wynagrodzenie w tej grupie.
8. Metoda przyjmuje jako parametr listę pracowników (`List<Employee>`) i zwraca tę listę posortowaną malejąco według wynagrodzenia (`List<Employee>`).
9. Metoda przyjmuje jako parametry listę działów (`List<Department>`) oraz listę menedżerów (`List<Manager>`) i zwraca listę pracowników (`List<Employee>`), których wynagrodzenie jest równe wynagrodzeniu menedżera ich działu.
10. Metoda przyjmuje jako parametr listę menedżerów (`List<Manager>`) i zwraca słownik (`Dictionary<Manager, List<Employee>>`), w którym kluczem jest menedżer, a wartością lista pracowników w zarządzanym przez niego dziale. Menedżerowie bez przypisanego działu nie są uwzględniani.

&nbsp;

> :no_entry: *Jeśli nie posiadasz materiałów do tego zadania tj. **PDF, projekt + Code Review**, znajdziesz je na stronie [devmentor.pl](https://devmentor.pl/workshop-gamedev-files-testing)*

> :arrow_left: [*poprzednie zadanie*](./../02) | [*następne zadanie*](./../04) :arrow_right:
