

## FallPlayer

- lees de uitleg hieronder:
```
We hebben nu een game waar de speler valt, maar door de vloer gaat!
dat kunnen we met een IF tegenhouden
```
> ![](img/fallplayer.GIF)

- open de solution `FallPlayer.sln`

- run de application:
    > ![](img/game.PNG)
    - druk nu op spatie:
    > ![](img/woops.PNG)


## 1)

- open `Form1.cs`
- zoek:
    - //1) 
        - maak daaronder een variable:
            - type: int
            - naam: ground
            - met de waarde van 7 keer size

## 2)

- open `Form1.cs`
- zoek:
    - //2) 
        - maak daaronder een variable:
            - type: float
            - naam: playerBottom
            - met de waarde van player.y plus size
  
## 3)

- open `Form1.cs`
- zoek:
    - //3)           
        - gebruik een If om te kijken of de playerBottom < ground
            - dan mag je de player bewegen, anders niet!
                - gebruik daarvoor de code die er al stond 
                > die code komt dus tussen de {} van de if

## testen

- start de applicatie op
- druk op spatie
    - de speler beweegt
    > ![](img/stopped.PNG)

## klaar

- commit & push naar je github        