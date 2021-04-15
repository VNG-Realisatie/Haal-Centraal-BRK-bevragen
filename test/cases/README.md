# Testgevallen

Hier staan per operatie de beschikbare testgevallen waarbij per property is aangegeven of het testgeval hierop een waarde heeft.

De bovenste rij van elke tabel bevat de identificaties van de test-resources.
De linker kolom(men) bevatten de namen van properties van de resource.
Aan het einde van een propertynaam toegevoegde
- "{}" betekent dat dit property een object (gegevensgroep) is.
- "[]" betekent dat dit property een array is.
- "[{}]" betekent dat dit property een array van objecten is.
- "()" betekent dat dit property een enumeratie is.

Bij een testgeval betekent
- "X" dat dit testgeval een waarde heeft voor het betreffende gegeven.
- Een getal dat het aantal items van het gegeven het testgeval heeft.
- Tekst dat dit de enumeratiewaarde is van het gegeven bij dit testgeval.

**Operaties:**

- [GetKadastraalOnroerendeZaak](#GetKadastraalOnroerendeZaak)
- [GetZakelijkGerechtigde](#GetZakelijkGerechtigde)
- [GetKadasterPersoon](#GetKadasterPersoon)
- [GetKadasterNietNatuurlijkPersoon](#GetKadasterNietNatuurlijkPersoon)
- [GetHypotheek](#GetHypotheek)
- [GetBeslag](#GetBeslag)
- [GetPrivaatrechtelijkeBeperking](#GetPrivaatrechtelijkeBeperking)
- [GetStuk](#GetStuk)
- [GetStukdeel](#GetStukdeel)

## GetKadastraalOnroerendeZaak

||||76870487970000|76870488070000|76870482670000|76870482570000|22310827210003|22310827210004|22310691970000|56020234070000|23280647970000|65490485370000|65490485270000|24780711870000|17150075470000|22590043870000|17500393970000|22360467970000|19560032970000|17550448670000|76370602970000|59020170810219|59020170810593|59020170810594|59020170810218|59020170670000|59020130970000|
|--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |
|aardCultuurBebouwd{}|||X||X||||||||||X||X||X|||X|X|||||
|aardCultuurOnbebouwd{}|||||||||||||||||||X|||||||||
|adressen[{}]|||1|1|1|1|1|1||1|5|1|1|6|1|3|1|1|2|1|||||||2|
||huisletter|||||||||||X||X||||||||||||||
||huisnummer||X|X|X|X|X|X||X|X|X|X|X|X|X|X|X|X|X|||||||X|
||huisnummertoevoeging|||||||||||||X||||||||||||||
||postcode||X|X|X|X|X|X||X|X|X|X|X|X|X|X|X|X|X|||||||X|
||straat||X|X|X|X|X|X||X|X|X|X|X|X|X|X|X|X|X|||||||X|
||woonplaats||X|X|X|X|X|X||X|X|X|X|X|X|X|X|X|X|X|||||||X|
||adresregel1||X|X|X|X|X|X||X|X|X|X|X|X|X|X|X|X|X|||||||X|
||adresregel2||X|X|X|X|X|X||X|X|X|X|X|X|X|X|X|X|X|||||||X|
||adresregel3|||||||||||||||||||||||||||
||land{}|||||||||||||||||||||||||||
||nummeraanduidingIdentificatie||X|X|X|X|X|X||X|X|X|X|X|X|X|X|X|X|X|||||||X|
||adresseerbaarObjectIdentificatie|||||||||||||||||||||||||||
||koppelingswijze{}||X|X|X|X|X|X||X|X|X|X|X|X|X|X|X|X|X|||||||X|
|begrenzingPerceel{}|||X|X||X||||||||||||||||||||||
||coordinates[]||1|1||1||||||||||||||||||||||
||type()||Polygon|Polygon||Polygon||||||||||||||||||||||
|beslagIdentificaties[]|||||||||||||||2|||||||||||||
|bijbehorendeAppartementsrechtIdentificaties[]|||||||||1|||||||||||||2|1|1||4|4|
|bijbehorendeGrondperceelIdentificaties[]||||||||||||||||||||||||||||
|domein|||X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|
|einddatum||||||||||||||||||||||||||||
|hypotheekIdentificaties[]|||1||2|1|1|2||1|||||1||||2|1||||||||
|identificatie|||X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|
|indicatieVervallen||||||||||||||||||||||||||||
|isOntstaanUit[{}]|||||||1|1||||||||||||||2|3|3|2|2|1|
||aard{}|||||||||||||||||||||||||X|X|
||indicatieVervallenKadastraalOnroerendeZaak|||||||||||||||||||||||||||
||kadastraalOnroerendeZaakIdentificatie||||||X|X||||||||||||||X|X|X|X|X|X|
|isOvergegaanIn[{}]||||||||||||||||||||||||||||
||aard{}|||||||||||||||||||||||||||
||indicatieVervallenKadastraalOnroerendeZaak|||||||||||||||||||||||||||
||kadastraalOnroerendeZaakIdentificatie|||||||||||||||||||||||||||
|isVermeldInStukdeelIdentificaties[]|||1|1|1||1|1||1|1|1|1|1|1|1|1|1|1|1|1|||||||
|kadastraleAanduiding|||X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|
|kadastraleGrootte{}|||X|X|X|X|||X|X|X|X|X|X|X|X|X|X|X|X|X|||||X|X|
||soortGrootte{}||X|X|X|X|||X|X|X|X|X|X|X|X|X|X|X|X|X|||||X|X|
||waarde||X|X|X|X|||X|X|X|X|X|X|X|X|X|X|X|X|X|||||X|X|
|koopsom{}|||X||X|||||||||X|X|X|X||X|||X|X|||||
||indicatieMetMeerObjectenVerkregen|||||||||||||X||X||||||||||||
||koopjaar||X||X||||||||||X||X||X|||X|X|||||
||koopsom||X||X||||||||||X||X||X|||X|X|||||
|perceelnummerRotatie|||X|||||||||||||||||||||||||
|perceelnummerVerschuiving{}|||X|||||||||||||||||||||||||
||deltax||X|||||||||||||||||||||||||
||deltay||X|||||||||||||||||||||||||
|plaatscoordinaten{}|||X|X|X|X|||X|X|X|X|X|X|X|X|X|X|X|X|X|||||X|X|
||coordinates[]||2|2|2|2|||2|2|2|2|2|2|2|2|2|2|2|2|2|||||2|2|
||type()||Point|Point|Point|Point|||Point|Point|Point|Point|Point|Point|Point|Point|Point|Point|Point|Point|Point|||||Point|Point|
|privaatrechtelijkeBeperkingIdentificaties[]|||1|1|||||||1|||||2||||||||||||
|stukIdentificaties[]|||1|1|1||1|1||1|1|1|1|1|1|1|1|1|1|1||||||||
|toelichtingBewaarder|||X|||||||||||||||||||||||||
|type()|||perceel|perceel|perceel|perceel|appartementsrecht|appartementsrecht|perceel|perceel|perceel|perceel|perceel|perceel|perceel|perceel|perceel|perceel|perceel|perceel|perceel|appartementsrecht|appartementsrecht|appartementsrecht|appartementsrecht|perceel|perceel|
|zakelijkGerechtigdeIdentificaties[]|||2|1|1|3|1|1||2|2|2|2|1|1|2|1|2|1|2|1||1|1|1|||
|_links{}|||X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|
||adresseerbareObjecten[]|||||||||||||||||||||||||||
||adressen[]||1|1|1|1|1|1||1|1|1|1|1|1|1|1|1|1|1|||||||1|
||beslagen[]||||||||||||||1|||||||||||||
||bijbehorendeAppartementsrechten[]||||||||1|||||||||||||1|1|1||1|1|
||bijbehorendeGrondpercelen[]|||||||||||||||||||||||||||
||hypotheken[]||1||1|1|1|1||1|||||1||||1|1||||||||
||isOntstaanUit[]||||||1|1||||||||||||||1|1|1|1|1|1|
||isOvergegaanIn[]|||||||||||||||||||||||||||
||privaatrechtelijkeBeperkingen[]||1|1|||||||1|||||1||||||||||||
||self{}||X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|
||stukdelen[]||1|1|1||1|1||1|1|1|1|1|1|1|1|1|1|1|1|||||||
||stukken[]||1|1|1||1|1||1|1|1|1|1|1|1|1|1|1|1||||||||
||zakelijkGerechtigden[]||1|1|1|1|1|1||1|1|1|1|1|1|1|1|1|1|1|1||1|1|1|||

## GetZakelijkGerechtigde

||||76870487970000/30493367|76870487970000/30493368|76870488070000/30493369|76870482670000/1000003519|76870482570000/20170719|76870482570000/20170717|76870482570000/20170718|22310827210003/90283613|22310827210004/90283614|56020234070000/50415050|56020234070000/50037358|23280647970000/90763536|23280647970000/90763535|65490485370000/150561360|65490485370000/150561361|65490485270000/150561358|65490485270000/150561359|24780711870000/91205343|17150075470000/1002195641|22590043870000/90495202|22590043870000/90495201|17500393970000/10848244|22360467970000/90317713|22360467970000/90317712|19560032970000/11225310|17550448670000/10872286|17550448670000/10872287|76370602970000/30426366|59020170810593/1000901820|59020170810594/1000899117|59020170810218/80214110|
|--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |
|aanvangsdatum|||X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|
|erfpachtCanon{}||||||||X|X||||||||||||||X|||||||||||
||betrefMeerOnroerendeZaken|||||||X|X|||||||||||||||||||||||||
||einddatumAfkoop|||||||X|X|||||||||||||||||||||||||
||indicatieOudeOnroerendeZaakBetrokken|||||||X|X|||||||||||||||||||||||||
||isGebaseerdOpStukdeelIdentificatie|||||||X|X||||||||||||||X|||||||||||
||isVermeldInStukdeelIdentificaties[]|||||||2|2|||||||||||||||||||||||||
||jaarlijksBedrag{}|||||||X|X|||||||||||||||||||||||||
|||som||||||X|X|||||||||||||||||||||||||
|||valuta{}||||||X|X|||||||||||||||||||||||||
||soortErfpachtCanon{}|||||||X|X||||||||||||||X|||||||||||
||stukIdentificaties[]|||||||2|2||||||||||||||1|||||||||||
|identificatie|||X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|
|persoon{}|||X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|
||identificatie||X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|
||omschrijving||X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|
||type()||kadaster_natuurlijk_persoon|kadaster_natuurlijk_persoon|kadaster_niet_natuurlijk_persoon|kadaster_natuurlijk_persoon|kadaster_niet_natuurlijk_persoon|kadaster_natuurlijk_persoon|ingeschreven_natuurlijk_persoon|ingeschreven_natuurlijk_persoon|ingeschreven_natuurlijk_persoon|ingeschreven_natuurlijk_persoon|ingeschreven_niet_natuurlijk_persoon|kadaster_niet_natuurlijk_persoon|ingeschreven_niet_natuurlijk_persoon|ingeschreven_natuurlijk_persoon|ingeschreven_natuurlijk_persoon|kadaster_natuurlijk_persoon|ingeschreven_natuurlijk_persoon|ingeschreven_natuurlijk_persoon|ingeschreven_natuurlijk_persoon|kadaster_niet_natuurlijk_persoon|ingeschreven_niet_natuurlijk_persoon|ingeschreven_natuurlijk_persoon|kadaster_niet_natuurlijk_persoon|ingeschreven_natuurlijk_persoon|ingeschreven_natuurlijk_persoon|ingeschreven_natuurlijk_persoon|ingeschreven_natuurlijk_persoon|kadaster_natuurlijk_persoon|kadaster_niet_natuurlijk_persoon|kadaster_niet_natuurlijk_persoon|kadaster_natuurlijk_persoon|
|tenaamstelling{}|||X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|
||aandeel{}||X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|
|||noemer|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|
|||teller|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|
||aantekeningen[{}]||||||||||||||1||||||||2|||||||||||
|||aard{}|||||||||||||X||||||||X|||||||||||
|||betreftGedeelteVanPerceel|||||||||||||||||||||X|||||||||||
|||omschrijving|||||||||||||||||||||X|||||||||||
|||domein|||||||||||||X||||||||X|||||||||||
|||einddatum|||||||||||||||||||||X|||||||||||
|||einddatumRecht|||||||||||||||||||||X|||||||||||
|||identificatie|||||||||||||X||||||||X|||||||||||
|||isGebaseerdOpStukdeelIdentificatie|||||||||||||X||||||||X|||||||||||
|||isVermeldInStukdeelIdentificaties[]|||||||||||||2|||||||||||||||||||
|||stukIdentificaties[]|||||||||||||2||||||||1|||||||||||
|||begrenzing||||||||||||||||||||||||||||||||
|||indicatieOorspronkelijkObject||||||||||||||||||||||||||||||||
||betrokkenGorzenEnAanwassen{}||X|||||||||||||||||||||||||||||||
|||identificatie|X|||||||||||||||||||||||||||||||
|||omschrijving|X|||||||||||||||||||||||||||||||
|||type()|ingeschreven_niet_natuurlijk_persoon|||||||||||||||||||||||||||||||
||betrokkenPartner{}||X|X||||||||||||||||||||||||X|X|||||
|||identificatie|X|X||||||||||||||||||||||||X|X|||||
|||omschrijving|X|X||||||||||||||||||||||||X|X|||||
|||type()|kadaster_natuurlijk_persoon|kadaster_natuurlijk_persoon||||||||||||||||||||||||ingeschreven_natuurlijk_persoon|ingeschreven_natuurlijk_persoon|||||
||betrokkenSamenwerkingsverband{}||X|||||||||||||||||||||||||||||||
|||identificatie|X|||||||||||||||||||||||||||||||
|||omschrijving|X|||||||||||||||||||||||||||||||
|||type()|kadaster_niet_natuurlijk_persoon|||||||||||||||||||||||||||||||
||burgerlijkeStaatTenTijdeVanVerkrijging{}||X|X||X||X|X||X|||||X|X|X|X||X|||X||||X|X|X|||X|
||gezamenlijkAandeel{}||X|||||||||||||||||||||||||||||||
|||noemer|X|||||||||||||||||||||||||||||||
|||teller|X|||||||||||||||||||||||||||||||
||isGebaseerdOpStukdeelIdentificaties[]||1|1|3|1|1|1|1|1|1|1|1|1|1|2|2|2|2|2|2|2|1|1|1|2|1|2|2|1|1|2|1|
||isVermeldInStukdeelIdentificaties[]||||3||1|||||2||||||||||||||||||||||
||stukIdentificaties[]||1|1|6|1|2|1|1|1|1|3|1|1|1|2|2|2|2|2|2|2|1|1|1|2|1|2|2|1|1|2|1|
||verkregenNamensSamenwerkingsverband{}||||||||||||||||||||||||||X|||||||
|type()|||eigenaar|eigenaar|eigenaar|eigenaar|eigenaar|erfpachter|erfpachter|eigenaar|eigenaar|eigenaar|artikel5_3b|eigenaar|erfpachter|eigenaar|eigenaar|eigenaar|eigenaar|eigenaar|eigenaar|eigenaar|erfpachter|eigenaar|eigenaar|erfpachter|eigenaar|eigenaar|eigenaar|eigenaar|eigenaar|eigenaar|eigenaar|
|zakelijkRecht{}|||||||||||||X|||||||||||||||||||||
||isGebaseerdOpStukdeelIdentificaties[]||||||||||||1|||||||||||||||||||||
||isVermeldInStukdeelIdentificaties[]||||||||||||2|||||||||||||||||||||
||stukIdentificaties[]||||||||||||2|||||||||||||||||||||
|_links{}|||X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|
||betrokkenGorzenEnAanwassen{}||X|||||||||||||||||||||||||||||||
||betrokkenPartner{}||X|X||||||||||||||||||||||||||||||
||betrokkenSamenwerkingsverband{}||X|||||||||||||||||||||||||||||||
||persoon{}||X|X|X|X|X|X|||||X|X|X|||X||||X|X||X|||||X|X|X|X|
||self{}||X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|
||stukdelen[]||1|1|2|1|2|3|3|1|1|2|3|1|3|1|1|1|1|1|1|1|3|1|1|1|1|1|1|1|1|1|1|
||stukken[]||1|1|1|1|1|2|2|1|1|1|2|1|2|1|1|1|1|1|1|1|3|1|1|1|1|1|1|1|1|1|1|

## GetKadasterPersoon

||||46299338|50550743|70882239|70882250|71303564|71303565|71303566|80000001|80000002|80000003|80000004|80000005|80000006|80000007|80000008|
|--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |
|identificatie|||X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|
|omschrijving|||X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|
|beschikkingsbevoegdheid{}|||||X|||||||||||||
|domein|||X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|
|indicatieNietToonbareDiakriet||||X||||||X||||||||
|kadastraalOnroerendeZaakIdentificaties[]|||1|1|2|1|2|3|1|||||||||
|postadres{}||||X|X|X|X|||||||||||
||huisletter||||X|||||||||||||
||huisnummer||||X||X|||||||||||
||huisnummertoevoeging||||X|||||||||||||
||postcode||||X|X|X|||||||||||
||straat||||X||X|||||||||||
||woonplaats||||X|X|X|||||||||||
||adresregel1|||X|X|X|X|||||||||||
||adresregel2|||X|X|X|X|||||||||||
||adresregel3|||X||||||||||||||
||land{}|||X||||||||||||||
||nummeraanduidingIdentificatie||||||X|||||||||||
||postbusnummer|||||X||||||||||||
|woonadres{}|||X|X|X||X|X|X|||||||||
||huisletter||X||X|||||||||||||
||huisnummer||X||X||X|X|X|||||||||
||huisnummertoevoeging||||X|||||||||||||
||postcode||X||X||X|X|X|||||||||
||straat||X||X||X|X|X|||||||||
||woonplaats||X||X||X|X|X|||||||||
||adresregel1||X|X|X||X|X|X|||||||||
||adresregel2||X|X|X||X|X|X|||||||||
||adresregel3|||X||||||||||||||
||land{}|||X||||||||||||||
||nummeraanduidingIdentificatie||||||X|||||||||||
|geboorte{}|||X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|
||datum{}||X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|
|||dag|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|
|||datum|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|
|||jaar|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|
|||maand|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|
||land{}||X||X||X|||||||||||
||plaats||X||X||X|||||||||||
|geheimhoudingPersoonsgegevens||||||||||||||||||
|geslachtsaanduiding()|||vrouw|vrouw|man|man|man|vrouw|vrouw|onbekend|man|vrouw|vrouw|vrouw|man|man|man|
|heeftPartnerschap[{}]||||1|1||||||1|1|1|1||||
||datumOntbinding|||||||||||||||||
||datumSluiting|||||||||||||||||
||naam{}|||X|X||||||X|X|X|X||||
|||geslachtsnaam||X|X||||||X|X|X|X||||
|||voornamen||X|X||||||X|X|X|X||||
|||voorvoegsel||||||||||X|X|||||
|landWaarnaarVertrokken{}||||X||||||||||||||
|naam{}|||X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|
||geslachtsnaam||X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|
||voornamen||X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|
||voorvoegsel||||||X||||X|X||||X||
||aanhef||X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|
||aanschrijfwijze||X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|
||gebruikInLopendeTekst||X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|
|overlijden{}||||||X|||||||||||X|
||datum{}|||||X|||||||||||X|
|||dag||||X|||||||||||X|
|||datum||||X|||||||||||X|
|||jaar||||X|||||||||||X|
|||maand||||X|||||||||||X|
|_links{}|||X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|
||kadastraalOnroerendeZaken[]||1|1|1|1|1|1|1|||||||||
||postadres{}|||||||||||||||||
||self{}||X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|
||woonadres{}|||||||||||||||||
||zakelijkGerechtigden[]||1|1|2|1|2|3|1|||||||||

## GetKadasterNietNatuurlijkPersoon

||||24268006|47045173|71291440|71291441|71291442|71291493|122778081|419941781|440650207|
|--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |
|identificatie|||X|X|X|X|X|X|X|X|X|
|omschrijving|||X|X|X|X|X|X|X|X|X|
|beschikkingsbevoegdheid{}||||||||||||
|domein|||X|X|X|X|X|X|X|X|X|
|indicatieNietToonbareDiakriet|||||||||||X|
|kadastraalOnroerendeZaakIdentificaties[]||||1|2|3|2||||1|
|postadres{}|||X|X||X||X|X||X|
||huisletter|||||||X|||X|
||huisnummer|||||||X|X||X|
||huisnummertoevoeging|||||||X|||X|
||postcode||X|X||X||X|X|||
||straat|||||||X|X||X|
||woonplaats||X|X||X||X|X||X|
||adresregel1||X|X||X||X|X||X|
||adresregel2||X|X||X||X|X||X|
||adresregel3|||||||||||
||land{}|||||||||||
||nummeraanduidingIdentificatie||||||||||X|
||postbusnummer||X|X||X||||||
|woonadres{}||||X|X|X|X|X|X|X|X|
||huisletter||||X|||||||
||huisnummer|||X|X|X|X|X||X|X|
||huisnummertoevoeging||||X|||||||
||postcode|||X|X|X|X|X||X|X|
||straat|||X|X|X|X|X||X|X|
||woonplaats|||X|X|X|X|X|X|X|X|
||adresregel1|||X|X|X|X|X||X|X|
||adresregel2|||X|X|X|X|X|X|X|X|
||adresregel3|||||||||||
||land{}|||||||||||
||nummeraanduidingIdentificatie||||||||||X|
|kvkNummer|||X||||X|X|||X|
|rechtsvorm{}|||X|X|X|X|X|X|X|X|X|
|rsin|||X||||X|X|||X|
|statutaireNaam|||X|X|X|X|X|X|X|X|X|
|statutaireZetel|||X|X|X|X|X|X|X|X|X|
|_links{}|||X|X|X|X|X|X|X|X|X|
||kadastraalOnroerendeZaken[]||1|1|1|1|1|1|1|1|1|
||postadres{}|||||||||||
||self{}||X|X|X|X|X|X|X|X|X|
||woonadres{}|||||||||||
||zakelijkGerechtigden[]|||1|2|3|2||||1|

## GetHypotheek

||||76870487970000/35052041|76870482670000/1000002150|76870482670000/35139325|76870482570000/25381030|22310827210003/95045785|22310827210004/95243355|22310827210004/95243356|56020234070000/55224371|17150075470000/15479389|19560032970000/15303394|19560032970000/15303397|17550448670000/15598882|
|--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |
|aandeelInBetrokkenRecht{}|||X|X|X|X|X|X|X|X|X|X|X|X|
||noemer||X|X|X|X|X|X|X|X|X|X|X|X|
||teller||X|X|X|X|X|X|X|X|X|X|X|X|
|aantekeningen[{}]|||||1||||||3||||
||aard{}||||X||||||X||||
||betreftGedeelteVanPerceel||||||||||X||||
||omschrijving||||X||||||X||||
|bedragZekerheidsstelling{}|||X|X|X|X|||X|X|X|X|X|X|
||som||X|X|X|X|||X|X|X|X|X|X|
||valuta{}||X|X|X|X|||X|X|X|X|X|X|
|betreftGedeelteVanPerceel||||X|||||||X||||
|domein|||X|X|X|X|X|X|X|X|X|X|X|X|
|gedeeltelijkeBezwaringOudObject|||||X||||||||||
|hypotheekhouders[{}]|||1|1|1|1|1|||1|2|1|1|1|
||identificatie||X|X|X|X|X|||X|X|X|X|X|
||omschrijving||X|X|X|X|X|||X|X|X|X|X|
||type()||kadaster_niet_natuurlijk_persoon|kadaster_niet_natuurlijk_persoon|ingeschreven_niet_natuurlijk_persoon|kadaster_natuurlijk_persoon|kadaster_natuurlijk_persoon|||ingeschreven_niet_natuurlijk_persoon|ingeschreven_niet_natuurlijk_persoon|ingeschreven_niet_natuurlijk_persoon|kadaster_niet_natuurlijk_persoon|ingeschreven_niet_natuurlijk_persoon|
|identificatie|||X|X|X|X|X|X|X|X|X|X|X|X|
|isGebaseerdOpStukdeelIdentificatie|||X|X|X|X|X|X|X|X|X|X|X|X|
|isVermeldInStukdeelIdentificaties[]|||||||||||1|||1|
|omschrijvingBetrokkenRecht{}|||X|X|X|X|X|X|X|X|X|X|X|X|
|omschrijvingGekozenWoonplaats|||X|X|X|X|||X|X||X|X|X|
|stukIdentificaties[]|||1|1|1|1|1|1|1|1|2|1|1|2|
|toelichtingBewaarder|||||||||||X||||
|_links{}|||X|X|X|X|X|X|X|X|X|X|X|X|
||hypotheekhouders[]||1|1|1|1|1|||1|2|1|1|1|
||self{}||X|X|X|X|X|X|X|X|X|X|X|X|
||stukdelen[]||1|1|1|1|1|1|1|1|2|1|1|2|
||stukken[]||1|1|1|1|1|1|1|1|1|1|1|1|

## GetBeslag

||||17150075470000/95377750|17150075470000/95377751|
|--- |--- |--- |--- |--- |
|aandeelInBetrokkenRecht{}|||X|X|
||noemer||X|X|
||teller||X|X|
|aantekeningen[{}]|||2||
||aard{}||X||
||betreftGedeelteVanPerceel||||
||omschrijving||X||
|aard{}|||X|X|
|bedragVordering{}|||X|X|
||som||X|X|
||valuta{}||X|X|
|beslagleggers[{}]|||2|1|
||identificatie||X|X|
||omschrijving||X|X|
||type()||ingeschreven_niet_natuurlijk_persoon|ingeschreven_niet_natuurlijk_persoon|
|domein|||X|X|
|gedeeltelijkeBezwaringOudObject|||X||
|identificatie|||X|X|
|isGebaseerdOpStukdeelIdentificatie|||X|X|
|isVermeldInStukdeelIdentificaties[]|||2||
|omschrijvingBetrokkenRecht{}|||X|X|
|stukIdentificaties[]|||2|1|
|toelichtingBewaarder||||X|
|_links{}|||X|X|
||beslagleggers[]||2|1|
||self{}||X|X|
||stukdelen[]||2|1|
||stukken[]||1|1|

## GetPrivaatrechtelijkeBeperking

||||76870487970000/30336965|76870488070000/30336966|23280647970000/91104907|22590043870000/91074411|22590043870000/91074412|
|--- |--- |--- |--- |--- |--- |--- |--- |
|aard{}|||X|X|X|X|X|
|betreftGedeelteVanPerceel||||||X||
|omschrijving||||||X||
|domein|||X|X|X|X|X|
|einddatum||||||X||
|einddatumRecht||||||X||
|identificatie|||X|X|X|X|X|
|isGebaseerdOpStukdeelIdentificatie|||X|X|X|X|X|
|isVermeldInStukdeelIdentificaties[]|||2||2|||
|stukIdentificaties[]|||2|1|2|1|1|
|_links{}|||X|X|X|X|X|
||self{}||X|X|X|X|X|
||stukdelen[]||2|1|2|1|1|
||stukken[]||1|1|1|1|1|

## GetStuk

||||20170102999999|20200227000564|20190409001159|20181230000001|20150209000285|20150209000284|20200617001840|18020223007191|20101228003687|20110105001818|20140509000357|20140515002559|20170103000973|20181011002195|20180801006361|20181011002193|20160523002203|20160425002157|20161130002071|20160523001278|20200617001837|18060904017284|18050504014555|18061204003791|20101224002005|18050519015236|20131224000644|20060410001235|20060413001606|20060524002230|20140206000047|18011017010446|20200617001838|20170112112820|20200617001836|18050329018096|18011129011165|20021202002459|18011209006307|20021220001664|17990613006175|20120423000694|17990607002967|20200617001839|17990709013766|20111230005781|17990712016255|17990623003542|20131210000494|20170112069499|18010421002984|20040616004631|20110103000422|20150331003222|20180524001411|20150331003221|20161230002508|20181203005136|18010417012180|20040120003497|18020130003032|20190124000722|20161213002442|20190124000385|20111004001244|
|--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |
|aard{}||||||||||X||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
|bewaardersVerklaring||||||||||X||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
|domein|||X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|
|equivalentieVerklaarder{}||||||||||X||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
||geslachtsnaam|||||||||X||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
||voornamen|||||||||X||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
||voorvoegsel|||||||||X||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
||standplaats|||||||||X||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
|identificatie|||X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|
|indicatieTekeningBijgevoegd||||||||||X||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
|kadasterverzoeken[{}]||||||||||1||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
||aard{}|||||||||X||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
||redenenVerzoek[{}]|||||||||2||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
|||reden{}||||||||X||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
|||redenOmschrijving||||||||X||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
|status{}||||X|X||X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X||X|X|X|X|X|X|X|X|X|X|X|X|X|X|X||X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|
|stukType()|||Kadasterstuk|Aangebodenstuk|Aangebodenstuk|Kadasterstuk|Aangebodenstuk|Aangebodenstuk|Aangebodenstuk|Aangebodenstuk|Aangebodenstuk|Aangebodenstuk|Aangebodenstuk|Aangebodenstuk|Aangebodenstuk|Aangebodenstuk|Aangebodenstuk|Aangebodenstuk|Aangebodenstuk|Aangebodenstuk|Aangebodenstuk|Aangebodenstuk|Aangebodenstuk|Aangebodenstuk|Aangebodenstuk|Aangebodenstuk|Aangebodenstuk|Aangebodenstuk|Aangebodenstuk|Aangebodenstuk|Aangebodenstuk|Aangebodenstuk|Aangebodenstuk|Aangebodenstuk|Aangebodenstuk|Kadasterstuk|Aangebodenstuk|Aangebodenstuk|Aangebodenstuk|Aangebodenstuk|Aangebodenstuk|Aangebodenstuk|Aangebodenstuk|Aangebodenstuk|Aangebodenstuk|Aangebodenstuk|Aangebodenstuk|Aangebodenstuk|Aangebodenstuk|Aangebodenstuk|Aangebodenstuk|Kadasterstuk|Aangebodenstuk|Aangebodenstuk|Aangebodenstuk|Aangebodenstuk|Aangebodenstuk|Aangebodenstuk|Aangebodenstuk|Aangebodenstuk|Aangebodenstuk|Aangebodenstuk|Aangebodenstuk|Aangebodenstuk|Aangebodenstuk|Aangebodenstuk|Aangebodenstuk|
|stukdeelIdentificaties[]|||1|1|1|1|1|1|2|1|1|1|1|1|1|1|1|1|1|1|1|1|2|1|1|1|1|1|1|1|1|1|1|1|2|1|2|1|1|1|1|1|1|1|2|2|2|1|1|2|1|1|1|1|1|1|1|1|1|1|1|1|1|1|1|1|1|
|tijdstipAanbieding||||X|X||X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|||X||X|X|X|X|X|X|X||X|||X|X|X|X|X|X|X|X|X|X|X|X||X|||X|X|X|X|X|X|X||X|X|X|X|
|tijdstipOndertekening|||||X||X|||||||||X|X|X|X||||||||X||X||||||||||||||||X||X|X||||||||X|X||X|X||||X||X||
|toelichtingBewaarder||||||||||X||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
|_links{}|||X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|
||self{}||X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|
||stukdelen[]||1|1|1|1|1|1|1|1|1|1|1|1|1|1|1|1|1|1|1|1|1|1|1|1|1|1|1|1|1|1|1|1|1|1|1|1|1|1|1|1|1|1|1|1|1|1|1|1|1|1|1|1|1|1|1|1|1|1|1|1|1|1|1|1|1|

## GetStukdeel

||||1029999990|500001938598|500000657144|500000271633|1002241290|1001591789|32790058|32790059|1000854514|1001690789|1001441135|1001442932|1001559491|1001560108|500000003045|1002264425|500000003038|1007563710|1006938879|1006971479|1006942716|32790052|32790053|1010255056|1008269067|1009817003|1010172671|1008091224|1022484915|1022853788|1022853885|1022855688|1022941586|1022500606|32790054|32790055|1009609671|32790050|32790051|1008049451|1014599110|1014241153|1014600872|1014436359|1008784555|1009258734|1010122465|32790056|32790057|1010122466|1005512339|1005012023|1003839114|1008767621|1009300569|1009566350|1008767622|1003538521|1008956910|1009221604|1005406949|1005195516|1004455335|1005291811|500000171906|1003467720|1003956448|1000370114|500000374766|1022124727|500000375568|1022066043|1013701450|
|--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |--- |
|aard{}|||X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|
|bedragTransactiesomLevering{}|||||||||||X|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
||som||||||||||X|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
||valuta{}||||||||||X|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
|domein|||X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|
|identificatie|||X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|
|omschrijvingKadastraleObjecten|||||||||||X|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
|omschrijvingTopografischeMutatie|||||||||||X|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
|_links{}|||X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|
||self{}||X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|
||stuk{}||X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|X|
