> :white_check_mark: *Jeśli będziesz mieć problem z rozwiązaniem tego zadania, poproś o pomoc na odpowiednim kanale na Slacku, tj. `s10e01-gamedev-files-testing` (dotyczy [mentee](https://devmentor.pl/mentoring/)) lub na ogólnodostępnej i bezpłatnej [społeczności na Discordzie](https://devmentor.pl/discord). Pamiętaj, aby treść Twojego wpisu spełniała [odpowiednie kryteria](https://devmentor.pl/jak-prosic-o-pomoc/).*

&nbsp;

# `#01` GameDev: Pliki i Testowanie

## Ćwiczenia z testami jednostkowymi
Do tej pory, każde ćwiczenie zawierało oddzielny projekt, aby odseparować kod poszczególnych ćwiczeń i umożliwić łatwe uruchamianie.
Ćwiczenia korzystające z testów jednostkowych będą zawierały dodatkowe projekty testowe. Np. ćwiczenie 2 ma projekt `02` oraz `02_Test`.

## Notatnik
Zaimplementuj prosty notatnik. Powinien zawierać następujące funkcjonalności:
1. Menu główne
   - Pojawia się tuż po odpaleniu programu, można także do niego wrócić podczas pracy z notatnikiem;
   - Wyświetla opcje: `Nowy plik`, `Otwórz plik`, `Ostatnie pliki`, `Wyjdź`;
   - Opcja `Nowy plik` we wskazanym przez użytkownika folderze tworzy nowy plik .txt o podanej przez użytkownika nazwie;
   - Opcja `Otwórz plik` otwiera już istniejący plik .txt w oparciu o podaną przez użytkownika ścieżkę;
   - Opcja `Ostatnie pliki` wyświetla listę plików, które użytkownik wcześniej otwierał i umożliwia ich szybkie otwarcie;
   - Opcja `Wyjdź` zamyka program;
2. Widok notatki
   - Na samej górze jest wyświetlona ścieżka pliku;
   - Następnie, wyświetlona jest treść pliku;
   - Użytkownik może napisać dowolny tekst i kliknąć `Enter`, wówczas zostanie on dopisany jako linijka tekstu na samym końcu pliku;
   - Wszystkie zmiany w pliku są na bieżąco zapisywane;
3. System komend
   - W widoku notatki, użytkownik może wpisać komendę, wówczas wykona ona konkretną czynność, zamiast być zapisaną jako tekst w pliku;
   - `--exit` opuszcza widok notatki i powraca do menu głównego;
   - `--clear` usuwa całą zawartość pliku;
   - `--removeline` usuwa ostatnią linijkę tekstu;



&nbsp;
> :no_entry: *Jeśli nie posiadasz materiałów do tego zadania tj. **PDF, projekt + Code Review**, znajdziesz je na stronie [devmentor.pl](https://devmentor.pl/workshop-gamedev-files-testing)*

> :arrow_left: ~~*poprzednie zadanie*~~ | [*następne zadanie*](./../02) :arrow_right:
