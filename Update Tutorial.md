# Tutorial pre základné updaty projektu aj správy tabletu
*použitá verzia Unity: 2022.3.7f1; pozor na kompatibilitu*
---
## Odomknutie tabletu
*berieme že tablet je v základnom stave - beží len SNG Mapa a nič iné nejde spustiť*<br>
**1. vypnúť tablet**<br>
**2. spustiť tablet v safe móde** - naraz držať tlačítka na zapnutie a volume down - _**treba ich držať celý čas až pokiaľ sa neukáže lockscreen s nápisom Safe Mode v rohu**_<br>
**3. odinštalovať SNG Mapu** - *hej je to strašne Lidl spôsob ale lepší sme nenašli takže donútime Kiosk aplikáciu aby nemohla spustiť SNG Mapu*<br>
**4. reštartovať tablet** - *tentokrát ho necháme spustiť sa normálne* - ak sa po spustení sťažuje že ho treba nastaviť ako Home app tak nastaviť Fully Kiosk ako Home app<br>
**5. odomknúť kiosk** - *(mala by byť spustená modrá úvodná obrazovka kisoku)* čo najrýchlejšie: swipe doprava -> Settings -> Zadať PIN **1212** ->*(tu už netreba rýchlo)* Kiosk Mode (PLUS) -> Enable Kiosk Mode - vypnúť

## Opätovné spustenie kiosku
*berieme že tablet je z minulého kroku odomknutý a SNG Mapa je odinštalovaná*<br>
**1. nainštalovať aplikáciu** - cez kábel alebo z internetu *(gl so školskou sieťou)* dostať apk súbor a nainštalovať ho<br>
**2. spustiť kiosk** - zapnúť aplikáciu _**Fully kiosk browser**_ -> swipe doprava -> Settings -> Kiosk Mode (PLUS) -> Enable Kiosk Mode -> Single App Mode -> Select Single App - vybrať SNG Mapa -> ísť naspäť dokiaľ sa aplikácia nespýta či chceme spustiť Kiosk -> nastaviť Fully Kiosk Browser ako Home app<br>
**3. reštartovať tablet** - *pre istotu aby všetko správne fungovalo*

## Update fotiek
**1. nájsť súbor s fotkami** - SNG_mapa_projekt/Assets/Sprites/Fotky<br>
**2. nahradiť fotky** - fotka sa vždy volá podľa čísla miestnosti, treba ju nahradiť s rovnakým názvom<br>
**3. nastaviť kompresiu (optional)** - *toto nie je až tak dôležité ak aplikácia beží len na tablete ale celkovo je to fajn lebo inak by fotky zaberali strašne moc priestoru* - v Unity kliknúť na asset fotky -> napravo v tabuľke pod advanced nastaviť správne hodnoty pre dané platformy *(primárne Android, iOS a WebGL)*, tu sú hodnoty ktoré používam ja: Max Size: 1024; Resize Algorithm: Mitchell; Format: RGB(A) Compressed ASTC 12x12 block; Compressor Quality: Normal; Override ETC2 fallback: Use build settings

## Update popisu tried
**1. nájsť objekt triedy v Unity** - Unity Hierarchy: Mapa/UI_ScreenSpace/Triedy_popisy_*psochodie*/*číslo triedy*<br>
**2. upraviť text** - najviac podstatný bude zrejme objekt [Učitelia], tu sa nachádzajú mená učiteľov pre danú triedu, *tiež pri úprave nezabudnúť zviditeľniť objekt na ktorom pracujem aby som videl zmeny ktoré robím*

## Update učiteľov vo vyhľadávaní
**1. nájsť parent objekt mien v Unity** - Unity Hierarchy: Mapa/UI_ScreenSpace/Triedy_popisy_*psochodie*/*číslo triedy*/Zoznam učiteľov<br>
**2. nahradiť/premenovať objekty** - funkcia vyhľadávania hľadá objekty podľa mena, preto aby bol priradený učiteľ k triede treba pod danou triedou vytvoriť prázdny objekt s daným menom
