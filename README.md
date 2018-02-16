# Pang Game (World) - Arcade Clone / WIP

```
Note:

This is an independent game development clone from scratch without profits.
It is a small challenge for me to develop this game of my childhood.
Out of respect, I will not publish the game code. 
This page will act as a visual wiki of development.
I do not look for money or want to gain followers. 
I want to share a single goal that is the development of games for all audiences 
and continue learning day to day.
```

### Roadmap 
* [Technical data](https://github.com/vicboma1/PangGame/blob/master/README.md#technical-data)
* [Bios](https://github.com/vicboma1/PangGame/blob/master/README.md#bios)
* [License](https://github.com/vicboma1/PangGame/blob/master/README.md#license)
* [Ranking](https://github.com/vicboma1/PangGame/blob/master/README.md#ranking)
* [Intro](https://github.com/vicboma1/PangGame/blob/master/README.md#intro-1)
* [Players](https://github.com/vicboma1/PangGame/blob/master/README.md#players)
* [Wires](https://github.com/vicboma1/PangGame/blob/master/README.md#wires)
* [Blocks](https://github.com/vicboma1/PangGame/blob/master/README.md#blocks)
* [Map Select](https://github.com/vicboma1/PangGame/blob/master/README.md#map-select)
* [HUD](https://github.com/vicboma1/PangGame/blob/master/README.md#hud)
* [Overloads](https://github.com/vicboma1/PangGame/blob/master/README.md#overloads)
* [Stages](https://github.com/vicboma1/PangGame/blob/master/README.md#stages)
* [Bonus Stage](https://github.com/vicboma1/PangGame/blob/master/README.md#bonus-stage)
* [Physics Engine 2D](https://github.com/vicboma1/PangGame/blob/master/README.md#physics-engine-2d)
* [Miscellaneous](https://github.com/vicboma1/PangGame/blob/master/README.md#miscellaneous)
  * [Arcade](https://github.com/vicboma1/PangGame/blob/master/README.md#arcade)
  * [PCB](https://github.com/vicboma1/PangGame/blob/master/README.md#pcb)
  * [Controllers](https://github.com/vicboma1/PangGame/blob/master/README.md#controllers)
* [References]()

## Technical data

```
Name      : Pang | Pomping World | ポンピング・ワールド | Ponpingu Wārudo | Buster Bros
Developer : Mitchell
Publisher : JP/EU: Mitchell | NA: Capcom
Director  : Yoshiki Okamoto
Designer  : Toshihiko Uda (NDA)
Composer  : Tamayo Kawamoto
Platform  : Arcade, TurboGrafx-CD, SNES, Game Boy, ZX Spectrum, Commodore 64, Amstrad CPC, 
            Commodore Amiga, Atari ST, DOS...
Release	  : 1989
Genre     : Arcade
Mode      : Two-player
```

## Bios

## License
![](https://raw.githubusercontent.com/vicboma1/PangGame/master/assets/Licen.png)

## Ranking

* Enumeration of the first 10 records
* Score, Name and Stage description

![](https://github.com/vicboma1/PangGame/blob/master/assets/RANKING.gif)

## Intro

* Animation (WIP)
* Supports up to 9 credits
* Menu "Push Start Button"
* Flicker enterprise name

![](https://github.com/vicboma1/PangGame/blob/master/assets/intro2.gif)

## Players

* P1
* P2 (WIP)
* Left - Right
* Up - Down (Ladders) (WIP)
* Score
* Lives
* Stage
* Wire

![](https://github.com/vicboma1/PangGame/raw/master/assets/spriteP1.png)

## Wires

* [Single Arrow](https://youtu.be/Pna5vo2CjYg)
* [Double Arrow](https://youtu.be/c0dbKrCp4Xw)
* [Power Ancle](https://youtu.be/vdmoUfphufM) 
* [Vulcan](https://youtu.be/kNvfsLPoD0g) 

![](https://github.com/vicboma1/PangGame/raw/master/assets/PowerUpsHud.gif)

## Blocks

Horizontal

* [Blue Fade Out](https://youtu.be/RKO0Qd1V1FE)
* [Pink Fade Out | Fixed ](https://youtu.be/29oOrQJIR3o)

Vertical

* [Blue Fade Out](https://youtu.be/BKVPup4ARZs)

Others

* Yelow Ladders
* Yellow Block Fixed

![](https://github.com/vicboma1/PangGame/raw/master/assets/ladder_05.gif)

## Map Select

* Countdown to 0 seconds
* Sight arrow with white node
* Travel plane between cities
* Spelling description data 
* Cities & Stages information
* Navigation between forward and backward nodes without limit in Barcelona city
* Cities visited with red node
* Blinking vision arrow when selected the city

![](https://github.com/vicboma1/PangGame/raw/master/assets/spellDescription2.gif)

## HUD 

* P1
* P2 (WIP)
* Score
* Lives
* Stage
* Wire
* City
* World - Level
* Hi Score
* Timer
  * Fonts Numerics (WIP)
* Insert Coin blink
* Press Start blink
* Continue countDown
* Rec Score name
* Game Over!

![](https://github.com/vicboma1/PangGame/raw/master/assets/hudContinue.gif)

## Overloads

* Ready
* Time Over
* Game Over

![](https://github.com/vicboma1/PangGame/raw/master/assets/GameOver.png)

## Stages

MT.FUJI (1) 
```  
  1
    * BG Display
    * OBJ (Sprites) 
    
  2
    * BG Display
    * OBJ (Sprites) 
    * BG Tile
      * Blocks Fade Out
    
  3
    * BG Display
    * OBJ (Sprites)
    * BG Tile
      * Blocks { Fade Out | Statics }
```

MT.KEIRIN (2)
```  
  4
    * BG Display
    * OBJ (Sprites)
    * BG Tile
      * Ladders
      * Block static
    
  5
    * BG Display
    * OBJ (Sprites) 
    * BG Tile
      * Blocks Fade Out | Vertical
    
  6
    * BG Display
    * OBJ (Sprites)
    * BG Tile
      * Blocks { Fade Out | Statics }
```

* [EMERALD TEMPLE]()
* [ANKOR WATT]()
* [AUSTRALIA]()
* [TAG MAHAL]()
* [LENINGRAD]()
* [PARIS]()
* [LONDON]()
* [BARCELONA]()
* [ATHENS]()
* [EGYPT]()
* [KENYA]()
* [NEY YORK]()
* [MAYA]()
* [EASTER ISLAND]()

## Bonus Stage

* Time Bonus
* Next Extends
* Random Images
  * Animations backgrounds (WIP)

## Physics Engine 2D

### Collision

* Ground
* Player [P1 - P2 (WIP)]
* Enemies
* Blocks
* Left
* Right
* Top

### Parabolic Motion

Based on parabolic movement with environmental factors

![](https://explorandolafisica.wikispaces.com/file/view/PARABOLICO.png)

* Dir_H [ Left - Right]
* Dir_V [ Top - Bottom]
* Detla Time
* Gravity 9.81 
* vt
* vti
* x0
* y0
* Angle 
* Vi
* Viy
* Vix
* Vx
* Vy
* TyMax
* yMax
* TxMax
* xMax
* X
* Y
* Acc (WIP)
* Curve renderer (WIP)
* Position
* Lerp (Based on Bresenham algorithm)
  * Linear
  * Bicubic
  * Spline (WIP)
  * Stairstep (WIP - Digital Image definition)
  
![](https://github.com/vicboma1/PangGame/raw/master/assets/ParabolicMotion.gif)


## Miscellaneous

### Arcade Cabinet
![](https://github.com/vicboma1/PangGame/raw/master/assets/2799327_1_l.jpg)

### PCB
![](https://github.com/vicboma1/PangGame/blob/master/assets/FWnEv-2.jpg)

### Controllers
![](https://github.com/vicboma1/PangGame/blob/master/assets/pang.png)


## References
* [Technical Data](https://en.wikipedia.org/wiki/Pang_(video_game))
* [The Brief History Of Pang (AKA Buster Bros)](https://www.youtube.com/watch?v=10F4criBTcU)
* [Bresenham algorithm](https://en.wikipedia.org/wiki/Bresenham%27s_line_algorithm)

@Author: [Victor Bolinches](https://www.linkedin.com/in/victorbolinches)

Twitter: [@vicboma1](https://twitter.com/vicboma1)
