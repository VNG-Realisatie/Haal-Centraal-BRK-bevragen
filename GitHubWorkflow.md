# GitHub workflow
Samenwerking in GitHub kan erg complex zijn en leiden tot ongewenste effecten zoals ingewikkelde bestandsconflicten en  verlies van aangebrachte wijzigingen.
Om dat tegen te gaan is het essentieel goede afspraken te maken over deze samenwerking. 
Binnen de HaalCentraal BRK Bevragen repositories gebruiken we daarvoor Gitflow.

## Gitflow
Binnen Gitflow wordt de 'master' branch alleen gebruikt om de officiële releases van een product op te slaan waarbij we de diverse releases met behulp van een 'tag' van elkaar onderscheiden.
De 'master' branch wordt dus niet gebruikt om tussentijdse wijzigingen vast te leggen teneinde stukjes functionaliteit toe te voegen.

Voor het voorbereiden van een nieuwe release en in het kader van het stap voor stap uitbreiden van de functionaliteit worden de zogenaamde  'develop' branch en 'feature' branches gebruikt.
De 'feature' branches worden gebruikt voor het dedicated werken aan een specifieke hoeveelheid functionaliteit en de 'develop' branch voor het samenvoegen van de in de 'feature' branches gebouwde code met de laatste officiële versie.
Bij het bepalen van wat het doel van een PR is het dus van belang te weten wat de bedoeling van een PR is. 
Gaat het om een tussentijdse aanpassing van een feature die daarmee echter nog niet gereed is dan betreft het een PR op de gerelateerde 'feature' branch.
Gaat het om een feature dat gereed is om samengevoegd te worden met de toekomstige versie van het product dan is het doel de 'develop' branch.

Of en zo ja wanneer een 'feature' branch met de 'develop' branch wordt samengevoegd is aan het HaalCentraal team.
Zo kan besloten worden een feature niet met de komende release aan te bieden maar met een release die verder in de toekomst ligt.
Een 'feature' branch die eenmaal is samengevoegd zal daarna komen te vervallen zodat uit de lijst met branches duidelijk wordt welke functionaliteit nog niet ondergebracht is in een release.

Zodra de inhoud van de 'develop' branch naar de mening van het HaalCentraal team gereed is voor een officiële versie wordt deze doorgezet naar een zogenaamde 'release' branch.
Op deze branch vinden de laatste testen plaats en worden zonodig nog correcties aangebracht. 
Pas als de code in de release branch helemaal correct wordt bevonden wordt deze samengevoegd met de 'master' branch waarna op de master een nieuwe 'tag' wordt geplaatst.
Uiteindelijk wordt de 'release' branch, tenminste als er in deze branch nog wijzigingen zijn aangebracht, ook weer samengevoegd met de develop branch zodat ook deze weer up-to-date. 
De 'release' branch kan daarna weer komen te vervallen.

Tenslotte is er nog één type branch die voor kan komen. Het betreft de 'hotfix' branch. M.b.v. deze branch worden patches geproduceerd waarmee correcties op een officiële versie kunnen worden aangebracht.
Na het vervaardigen van de correctie wordt deze branch dan ook direct samengevoegd met de 'master' branch maar natuurlijk ook met de 'develop' branch. 
We willen immers niet dat de fout zich in een volgende versie van het product weer voordoet.

Op deze wijze zijn er uiteindelijk slechts 2 branches die nooit verwijderd worden, de 'master' en de 'develop' branch en ontstaat een workflow waarmee we een strakke regie kunnen voeren op het doorvoeren van wijzigingen.
Ook is hiermee altijd duidelijk waar de oficiële versies van het product opgehaald kunnen worden.

Voor meer informatie over Gitflow verwijzen we naar deze [Gitflow tutorial](https://www.atlassian.com/git/tutorials/comparing-workflows/gitflow-workflow) en deze [cheatsheet](https://danielkummer.github.io/git-flow-cheatsheet/).
