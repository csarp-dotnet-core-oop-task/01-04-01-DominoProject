# 01-04-01-DominoProject
## DominoProject
Feladata objektum orientált programban modellezni a dominó játék egy dominóját. Ehhez készítse el a következő osztályhierarchiát:
Készítse el az oldal (side) osztályt melynek egy adattagja van, az azon az oldalon lévő pöttyök száma és az oldal neve. A pöttyök száma egy egész szám. Készítsen konstruktort az oldal megadására. A pöttyök számából készítsen olvasható tulajdonságot pont (point) néven. 
Mintakód az osztályhoz:
```
Side rightSide=new Side(„jobb oldal”,3);
Console.WriteLine(rightSide);
```
Kimenet:
```
A jobb oldal 3 pöttyöt tartalmaz.
```
Készítse el a dominó (domino) osztályt menynek két adattagja van, a jobb oldal és a bal oldal (side). Ezek az előbb elkészített dominó oldal osztályú adattagok. Készítsen egy olvasható őszpontszám (total point) tulajdonságot, amely a dominó bal és jobb oldalán lévő pontok összege.
Mintakód az osztályhoz:
```      
Side rightSide = new Side("jobb oldal", 3);
Side leftSide = new Side("bal oldal", 8);
Domino d = new Domino(rightSide, leftSide);
Console.WriteLine(d);
```
Kimenet:
```
A jobb oldal 3 pöttyöt tartalmaz.
A bal oldal 8 pöttyöt tartalmaz.
A dominon lévő pontok száma: 11 pont.
```
