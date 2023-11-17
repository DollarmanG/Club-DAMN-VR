# CLUBDAMN VR Projekt README 

  

## Projektöversikt 

  

Det här är ett VR-projekt som simulerar en nattklubbupplevelse där användaren kan delta som gäst, dansa, beställa drycker och interagera med olika element. Projektet inkluderar NPC:er som agerar som besökare och har olika animationer. Dessutom finns det en DJ-funktion där spelaren kan agera som diskjockey. 

  

## Projektstruktur 

  

### Mappstruktur 

  

- **Huvudmapp** 

  - `Animationcontrollers`: Innehåller animation controllers för olika karaktärsrörelser och interaktioner. Namngivningen för animation controllers i mappen är bundna och reglerade till namnen till dom olika NPC’s i spelet som dom ska vara kopplade till, om det inte är ett namn så är det en generell animation controll. 

  - `Animations`: Här finns animationer för olika rörelser och handlingar. 

  - `Assets`: Övriga projektresurser som ljudfiler, modeller, och liknande som vi har hämtat från olika hemsidor. 

  - `Materials`: Materialfiler för rendering av objekt och karaktärer, tex olika färger. 

  - `Prefabs`: Färdiga objektinstanser som kan återanvändas. 

  - `Scenes`: Unity-scener som representerar olika delar av nattklubben. 

  - `Scripts`: Källkodsfiler för projektets funktionalitet och logik, kodfilerna har bra namngivning, är kommenterade vad dem gör och är logiskt skrivna. Du kan kolla i skripten för att se vilken kod dom utför. 

  - `Textures`: Texturfiler för att texturera objekt och miljöer. 

  - `UI`: Användargränssnittselement och deras tillhörande skript. 

  

## Arbetsflöde för utvecklare 

  

För att bidra till projektet, följ dessa steg: 

  

1. **Klona projektet:** Använd Git för att klona projektet till din lokala maskin. 
https://github.com/DollarmanG/Club-DAMN-VR 

2. **Arbete med Unity-versionen 2021.3.20:** Se till att använda Unity-versionen 2021.3.20 för att undvika kompatibilitetsproblem. 

  

3. **Arbete med specifika komponenter:** 

    - För att ändra eller lägga till animationer, använd mapparna `Animationcontrollers` och `Animations`. 

    - Skapa eller modifiera material i `Materials`. 

    - Utveckla logik och funktionalitet genom att redigera eller skapa skript i mappen `Scripts`.

    - För att skapa eller redigera olika scener i projektet, arbeta inom mappen `Scenes`.

    - Uppdatera användargränssnittet genom att redigera UI-relaterade filer i `UI`. 

    - Lägg till eller redigera texturer som används för att texturera objekt och miljöer inom projektet genom att arbeta i `Textures`.	

    - Spara assets du hittar på internett i mappen assets.

    - När du är helt klar med ett objekt i appen spara det som en prefab under mappen "Prefabs".
  

4. **Testa ändringar:** Kör projektet i Unity för att testa och säkerställa att ändringar fungerar som förväntat. Testa även med VR så att du fungerar bra där.

	(1). **Versionshantering med Unity:** Innan du commitar och pushar dina ändringar, se till att uppdatera versionen utav projektet i Unity. 

  

5. **Commit och push:** När du är klar med ändringar, gör commit och pusha till det centrala Git-repot. 

  

6. **Sammanfoga ändringar:** Se till att sammanfoga ändringar från andra utvecklare för att undvika konflikter. 

  

7. **Dokumentera ändringar:** Vid ändringar eller nya funktioner, se till att dokumentera dem för att underlätta för andra utvecklare att förstå ändringarna. Det gör du på denna Trello sida: https://trello.com/b/B3cuxwHY/publicering-musik-vr-app 
 
Dokumentera även dina tasks i Trellon så vi kan följa vad du gör. 

  

## Övrigt 

  

För eventuella frågor eller support, kontakta projektets administratörer eller utvecklarteamet. 