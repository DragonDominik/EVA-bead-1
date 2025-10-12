# Feladat
Készítsünk programot, amellyel a következő játékot játszhatjuk.
Adott egy 𝑛 × 𝑛 elemből álló játékpálya, ahol a játékos két üldöző elől próbál
menekülni, illetve próbálja őket aknára csalni.
Kezdetben a játékos játékpálya felső sorának közepén helyezkedik el, a két
üldöző pedig az alsó két sarokban. Az ellenfelek adott időközönként lépnek egy
mezőt a játékos felé haladva úgy, hogy ha a függőleges távolság a nagyobb, akkor
függőlegesen, ellenkező esetben vízszintesen mozognak a játékos felé.
A pályán véletlenszerű pozíciókban aknák is elhelyezkednek, amelyekbe az
ellenfelek könnyen beleléphetnek, ekkor eltűnnek (az akna megmarad).
A játékos vízszintesen, illetve függőlegesen mozoghat (egyesével) a pályán, és
célja, hogy az ellenfeleket aknára csalja, miközben ő nem lép aknára. Ha sikerül
minden üldözőt aknára csalnia, akkor győzött, ha valamely ellenfél elkapja (egy
pozíciót foglal el vele), vagy aknára lép, akkor veszített.
A program biztosítson lehetőséget új játék kezdésére a pályaméret megadásával
(11 × 11, 15 × 15, 21 × 21), valamint játék szüneteltetésére (ekkor nem telik az
idő, és nem léphet senki). Ismerje fel, ha vége a játéknak, és jelenítse meg, hogy
győzött, vagy veszített-e a játékos. Ezen felül szüneteltetés alatt legyen lehetőség
a játék elmentésére, valamint betöltésére. A program játék közben folyamatosan
jelezze ki a játékidőt.
