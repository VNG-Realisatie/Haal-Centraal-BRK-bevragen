---
layout: page-with-side-nav
title: Getting Started
---
# Getting Started
De 'BRK Bevragen' API is gespecificeerd met behulp van de OpenAPI Specifications (OAS3).

Om aan te sluiten kun je de volgende stappen doorlopen:
1. [Meld je aan bij het kadaster om toegang te krijgen](#aanmelden-om-aan-te-sluiten)
2. [Bekijk de functionaliteit en specificaties](#functionaliteit-en-specificaties)
3. [Implementeer de API](#bouw-de-api)
4. [Probeer en test de API](#probeer-en-test-de-api)
5. [Sluit aan op productie](#aansluiten-op-productie)

## Aanmelden om aan te sluiten
Meld je aan bij het kadaster om [aan te sluiten en voor toegang tot de testomgeving](https://formulieren.kadaster.nl/aanmelden_brk_bevragen). Je ontvangt dan o.a. een API-key die nodig is voor toegang tot de testomgeving.

## Functionaliteit en specificaties
Je kunt een visuele representatie van de specificatie bekijken met [Swagger UI]({{ site.baseurl }}/swagger-ui) of [Redoc]({{ site.baseurl }}/redoc).

Je kunt de [functionele documentatie](./features) vinden in de [features](./features).

### Beschikbare resources
De volgende Basis Registratie Kadaster gegevens kunnen opgevraagd worden:
- [Kadastraal onroerende zaak](#kadastraalonroerendezaak)
- [Zakelijk gerechtigde](#zakelijkgerechtigde)
- [Kadaster natuurlijk persoon](#kadasternatuurlijkpersoon)
- [Kadaster niet-natuurlijk persoon](#kadasternietnatuurlijkpersoon)
- [Hypotheek](#hypotheek)
- [Beslag](#beslag)
- [Privaatrechtelijke beperking](#privaatrechtelijkebeperking)
- [Publiekrechtelijke beperking](#publiekrechtelijkebeperking)

#### KadastraalOnroerendeZaak
- Opvragen van 1 specifiek kadastraalonroerendezaak resource o.b.v. een kadastraalonroerendezaakidentificatie.
- Opvragen van 1 specifiek kadastraalonroerendezaak resource o.b.v. een kadastraleaanduiding.
- Opvragen van een collectie kadastraalonroerendezaak resources o.b.v. een adres (postcode, huisnummer, huisletter, huisnummertoevoeging).
- Opvragen van een collectie kadastraalonroerendezaak resources, waarbij een kadaster natuurlijk persoon rechthebbende is, o.b.v. een kadasterpersoonidentificatie.
- Opvragen van een collectie kadastraalonroerendezaak resources, waarbij een kadaster nietnatuurlijk persoon rechthebbende is, o.b.v. een kadasterpersoonidentificatie.
- Opvragen van een collectie kadastraalonroerendezaak resources, waarbij een ingeschreven natuurlijk persoon rechthebbende is, o.b.v. een burgerservicenummer.

#### ZakelijkGerechtigde
- Opvragen van een collectie zakelijkgerechtigde resources van 1 specifiek kadastraalonroerendezaak o.b.v. een kadastraalonroerendezaakidentificatie.
- Opvragen van 1 specifiek zakelijkgerechtigde resource o.b.v. een zakelijkgerechtigdeidentificatie.

#### KadasterNatuurlijkPersoon
- Opvragen van 1 specifiek kadaster natuurlijk persoon resource o.b.v. een kadasterpersoonidentificatie.
- Opvragen van een collectie kadaster natuurlijkpersoon resources o.b.v. een zoekterm. (Zie feature [zoeken kadasternatuurlijkpersoon](../features/zoeken-kadasternatuurlijkpersoon.feature))

#### KadasterNietNatuurlijkPersoon
- Opvragen van 1 specifiek kadaster nietnatuurlijk persoon resource o.b.v. kadasterpersoonidentificatie.
- Opvragen van een collectie kadaster nietnatuurlijk persoon resources o.b.v. een zoekterm. (Zie feature [zoeken kadasternietnatuurlijkpersoon](../features/zoeken-kadasternietnatuurlijkpersoon.feature))

#### Hypotheek
- Opvragen van 1 specifiek hypotheek resource o.b.v. hypotheekidentificatie en kadastraalonroerendezaakidentificatie.
- Opvragen van een collectie hypotheek resources behorende bij een kadastraal onroerende zaak o.b.v. een kadastraalonroerendezaakidentificatie.

#### Beslag
- Opvragen van 1 specifiek beslag resource o.b.v. beslagidentificatie en kadastraalonroerendezaakidentificatie.
- Opvragen van een collectie beslag resources behorende bij een kadastraal onroerende zaak o.b.v. een kadastraalonroerendezaakidentificatie.

#### PrivaatrechtelijkeBeperking
- Opvragen van 1 specifiek privaatrechtelijkebeperking resource o.b.v. privaatrechtelijkebeperkingidentificatie en kadastraalonroerendezaakidentificatie.
- Opvragen van een collectie privaatrechtelijkebeperking resources behorende bij een kadastraal onroerende zaak o.b.v. een kadastraalonroerendezaakidentificatie.

#### PrubliekrechtelijkeBeperking
- Opvragen van een collectie publiekrechtelijkebeperking resources o.b.v. een kadastraalonroerendezaakidentificatie.


### Algemeen
Verder zijn er nog een paar algemene functies die gelden voor alle bovenstaande aanvragen:
- Gebruik van de fields parameter om de response te filteren. (Voor werking, zie feature [fields](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.2.0/features/fields.feature))
- Gebruik van de expand parameter om subresources te ontsluiten. (Voor werking, zie feature [expand](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.2.0/features/expand.feature))
- Velden die altijd worden geleverd. (Voor werking, zie feature [levering velden](../features/levering-velden.feature))

|Resource                           |Velden                         |
|-----                              |------                         |
|KadastraalOnroerendeZaak           |identificatie, type, _links.self |
|ZakelijkGerechtigde                |identificatie, _links.self |
|KadasterNatuurlijkPersoon          |identificatie, _links.self |
|KadasterNietNatuurlijkPersoon      |identificatie, _links.self |
|Beslag                             |identificatie, _links.self |
|hypotheek                          |identificatie, _links.self |
|KadasterNietNatuurlijkPersoon      |identificatie, _links.self |
|PrivaatrechtelijkeBeperking        |identificatie, _links.self |
|PubliekrechtelijkeBeperking        |identificatie |

- Combinatie van velden die altijd verplicht worden geleverd.

|Resource                           |Velden                         | Uitleg |
|-----                              |------                         |----- |
|KadastraalOnroerendeZaak           |koopsom & koopjaar & (aardCultuurBebouwd of aardCultuurOnBebouwd) | [levering koopsom](../features/levering-koopsom.feature)|

- [HAL links](https://tools.ietf.org/html/draft-kelly-json-hal-08), die soms [templated](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.2.0/features/uri-templating.feature) worden geleverd.

## Bouw de API
We hebben [client code](https://github.com/VNG-Realisatie/Haal-Centraal-BRK-bevragen/tree/master/code){:target="_blank" rel="noopener"} voor API-clients in enkele varianten. Hiermee kan je direct aan de slag met het gebruiken van de API.

Zit jouw gewenste ontwikkelomgeving er niet bij, dan kan je zelf ook code genereren vanuit de "[genereervariant](https://github.com/VNG-Realisatie/Haal-Centraal-BRK-bevragen/blob/master/specificatie/genereervariant/openapi.yaml){:target="_blank" rel="noopener"}" van de API-specificaties.

## Probeer en test de API
De werking van de API is het makkelijkst te testen met behulp van [Postman](https://www.getpostman.com/).
We hebben al een project voor je gemaakt die je kan gebruiken: [BRK-Bevragen-postman-collection.json](../test/BRK-Bevragen-postman-collection.json). Hierin moet je alleen de endpoints en authenticatie (API-key) nog invullen.
We hebben al een [Postman collection](https://github.com/VNG-Realisatie/Haal-Centraal-BRK-bevragen/blob/master/test/BRK-Bevragen-postman-collection.json){:target="_blank" rel="noopener"} voor je klaargezet. Deze kun je importeren in Postman.

### Configureer de url en api key

1. Klik bij "Kadaster - BRK-Bevragen API" op de drie bolletjes.
2. Klik vervolgens op Edit
3. Selecteer tabblad "Authorization"
4. Kies TYPE "API Key"
5. Vul in Key: "x-api-key", Value: de API key die je van het Kadaster hebt ontvangen, Add to: "Header"
6. Selecteer tabblad "Variables"
7. Vul bij baseUrl INITIAL VALUE en bij CURRENT VALUE de url
8. Klik op de knop Update

De testomgeving van de API is te benaderen via de volgende urls:
- _Beveiligde verbinding met alleen API-key: https://api.brk.kadaster.nl/esd-eto-apikey/bevragen/v1/_
    - Voor deze connectie met de testomgeving van deze API is vereist:
        - Een geldige API-key. Deze wordt bij de request opgenomen in request header "X-Api-Key". Wanneer je je aanmeldt voor het gebruiken van de API ontvang je de API-key.

- _Beveiligde verbinding met API-key & mTLS: https://api.brk.kadaster.nl/esd-eto/bevragen/v1/_
    - Voor deze connectie met de testomgeving van deze API is vereist:
        - Een geldige API-key. Deze wordt bij de request opgenomen in request header "X-Api-Key". Wanneer je je aanmeldt voor het gebruiken van de API ontvang je de API-key.
        - Internet toegang tot het Kadaster endpoint via IPv4 of IPv6 en met het TLS 1.2 protocol.
        - Een Staat der Nederlanden root CA - G3 certificaat in de truststore, zie hiervoor: https://www.pkioverheid.nl/
        - Een geldig PKIoverheid client certificaat met SERIALNUMMER=<eigen-OIN-nummer> in de keystore dat deel uitmaakt van de Staat der Nederlanden - G3 hiërarchie,
zie hiervoor: https://www.logius.nl/diensten/pkioverheid
        - Een mutual TLS endpoint configuratie, waarbij de TLS verbinding met het Kadaster alleen tot stand mag en kan komen als er bij het opzetten van de verbinding een wederzijds vertrouwen op basis van de PKIoverheid certificaten hiërarchie bestaat.

### Testgevallen
Onderstaande tabellen bevatten testgevallen voor specifieke situaties waarmee de werking van de API kan worden getest op de test omgeving.

#### Onroerende Zaken

<table>
	<tr>
		<th>Testgeval                                      </th>
		<th>Kadastraalobjectidentificatie / Kadastraleaanduiding  </th>
		<th>Postcode              </th>
		<th>Bijzonderheden</th>
	</tr>                                                                    
	<tr>
		<td>2 eigenaren (Kadaster Natuurlijk Persoon)      </td>
		<td>76870487970000<br/>Beekbergen:87 K 4879     </td>
		<td>7361EW 29             </td>
		<td><ul><li>alle velden gevuld</li><li>1x hypotheek</li><li>2x publiekrechtelijke beperking</li><li>1x privaatrechtelijke beperking</li></ul></td>
	</tr>
	<tr>
		<td>1 eigenaar (Kadaster Niet Natuurlijk Persoon)  </td>
		<td>76870488070000<br/>Beekbergen:87 K 4880     </td>
		<td>7361EW 27             </td>
		<td><ul><li>1x privaatrechtelijke beperking</li></ul></td>
	</tr>
	<tr>
		<td>1 eigenaar (Kadaster Natuurlijk Persoon)       </td>
		<td>76870482670000<br/>Beekbergen:87 K 4826     </td>
		<td>7361EW 25             </td>
		<td><ul><li>2x hypotheek</li></ul></td>
	</tr>
	<tr>
		<td>1 eigenaar (Kadaster Niet Natuurlijk Persoon)  </td>
		<td>76870482570000<br/>Beekbergen:87 K 4825     </td>
		<td>7361EW 21             </td>
		<td><ul><li>2 erfpachters met erfpachtcanon</li><li>1x hypotheek</li></ul></td>
	</tr>
	<tr>
		<td>1 eigenaar (Ingeschreven Natuurlijk Persoon)   </td>
		<td>22310827210003<br/>'s Gravenhage:881 N 8272 3</td>
		<td>2517GL 84             </td>
		<td><ul><li>appartementsrecht</li><li>1x hypotheek</li><li>1x publiekrechtelijke beperking</li></ul></td>
	</tr>
	<tr>
		<td>1 eigenaar (Ingeschreven Natuurlijk Persoon)   </td>
		<td>22310827210004<br/>'s Gravenhage:881 N 8272 4</td>
		<td>2517GL 85             </td>
		<td><ul><li>appartementsrecht</li></ul></td>
	</tr>
	<tr>
		<td>1 eigenaar (Ingeschreven Natuurlijk Persoon)   </td>
		<td>56020234070000<br/>Odoorn:717 N 2340        </td>
		<td>9573PA 3              </td>
		<td><ul><li>1 artikel5_3b</li><li>1x hypotheek</li></ul></td>
	</tr>
	<tr>
		<td>1 eigenaar (Ingeschreven Natuurlijk Persoon)   </td>
		<td>23280647970000<br/>Loosduinen:561 H 6479    </td>
		<td>2551XS 31<br/>2551XN 45<br/>2551XN 47<br/>2551XN 49<br/>2551XN 51             </td>
		<td><ul><li>meerdere adressen</li><li>1x privaatrechtelijke beperking</li></ul></td>
	</tr>
	<tr>
		<td>1 eigenaar (Ingeschreven Natuurlijk Persoon)   </td>
		<td>65490485370000<br/>Hellendoorn:395 G 4853   </td>
		<td>7441JC 1 a            </td>
		<td><ul><li>bevat huisletter</li></ul></td>
	</tr>
	<tr>
		<td>2 eigenaren (Ingeschreven &amp; Kadaster Natuurlijk Persoon)   </td>
		<td>65490485270000<br/>Hellendoorn:395 G 4853   </td>
		<td>7441JC 1              </td>
		<td></td>
	</tr>
	<tr>
		<td>1 eigenaar (Ingeschreven Natuurlijk Persoon)   </td>
		<td>24780711870000<br/>Voorschoten:1040 B 7118  </td>
		<td>2252EB 14<br/>2252EB 14 B<br/>2252EB 14 C<br/>2252EB 14 D<br/>2252EB 16<br/>2252EB 18             </td>
		<td><ul><li>meerdere adressen</li><li>betrokkenGorzenEnAanwassen</li></ul></td>
	</tr>
	<tr>
		<td>1 eigenaar (Ingeschreven Natuurlijk Persoon)   </td>
		<td>17150075470000<br/>Hellevoetsluis:396 E 754 </td>
		<td>3224EA 39             </td>
		<td><ul><li>1x hypotheek</li><li>1x beslag</li></ul></td>
	</tr>
	<tr>
		<td>1 eigenaar (Kadaster Niet Natuurlijk Persoon)  </td>
		<td>22590043870000<br/>'s Gravenhage:881 AW 438 </td>
		<td>2545NN 178<br/>2545NN 180<br/>2545NN 182            </td>
		<td><ul><li>1 erfpachter</li><li>meerdere adressen</li><li>betrokkenSamenwerkingsverband</li><li>2x privaatrechtelijke beperking</li></ul></td>
	</tr>
	<tr>
		<td>1 eigenaar (Ingeschreven Natuurlijk Persoon)   </td>
		<td>17500393970000<br/>IJsselmonde:459 D 3939   </td>
		<td>3078JG 4              </td>
		<td></td>
	</tr>
	<tr>
		<td>1 eigenaar (Ingeschreven Natuurlijk Persoon)   </td>
		<td>22360467970000<br/>'s Gravenhage:881 V 4679 </td>
		<td>2597LD 58             </td>
		<td><ul><li>1 erfpachter</li><li>1x publiekrechtelijke beperking</li></ul></td>
	</tr>
	<tr>
		<td>1 eigenaar (Ingeschreven Natuurlijk Persoon)   </td>
		<td>19560032970000<br/>Rotterdam:841 AF 329     </td>
		<td>3011KD 70<br/>3011KD 72             </td>
		<td><ul><li>meerdere adressen</li><li>2x hypotheek</li><li>2x publiekrechtelijke beperking</li></ul></td>
	</tr>
	<tr>
		<td>2 eigenaren (Ingeschreven Natuurlijk Persoon)  </td>
		<td>17550448670000<br/>Kralingen:501 C 4486     </td>
		<td>3066VS 9              </td>
		<td><ul><li>betrokkenPartner</li><li>1x hypotheek</li></ul></td>
	</tr>
</table>

#### Kadaster Natuurlijke Personen

<table>
	<tr><th>Naam</th><th>Geboortedatum</th><th>KadasterPersoonIdentificatie</th><th>Bijzonderheden</th></tr>
	<tr><td>Willem Jansens</td><td>1971-11-01</td><td>70882239</td><td><ul><li>alle velden gevuld</li><li>woonadres is niet bekend in BAG</li></ul></td></tr>
	<tr><td>Sidonia Jansens</td><td>1950-01-01</td><td>50550743</td><td><ul><li>buitenlands woonadres</li></ul></td></tr>
	<tr><td>Christaan Goede</td><td>1971-11-01</td><td>71303564</td><td><ul><li>woonadres is wel bekend in BAG</li></ul></td></tr>
	<tr><td>Anne Janssens</td><td></td><td>80000001</td><td><ul><li>geslacht onbekend</li><li>kan niet op gezocht worden via /kadasternatuurlijkpersonen?q=</li></ul></td></tr>
	<tr><td>Jan Groenen</td><td></td><td>80000002</td><td><ul><li>aanduiding: eigen geslachtsnaam</li><li>kan niet op gezocht worden via /kadasternatuurlijkpersonen?q=</li></ul></td></tr>
	<tr><td>Susan in het Veld</td><td></td><td>80000003</td><td><ul><li>aanduiding: geslachtsnaam echtgenoot/geregistreerd partner na eigen geslachtsnaam</li><li>kan niet op gezocht worden via /kadasternatuurlijkpersonen?q=</li></ul></td></tr>
	<tr><td>Petra Anne Veldwijk</td><td></td><td>80000004</td><td><ul><li>aanduiding: geslachtsnaam echtgenoot/geregistreerd partner</li><li>kan niet op gezocht worden via /kadasternatuurlijkpersonen?q=</li></ul></td></tr>
	<tr><td>H Pieters</td><td></td><td>80000005</td><td><ul><li>aanduiding: geslachtsnaam echtgenoot/geregistreerd partner voor eigen geslachtsnaam</li><li>kan niet op gezocht worden via /kadasternatuurlijkpersonen?q=</li></ul></td></tr>
	<tr><td>Öle Klaassen</td><td></td><td>80000006</td><td><ul><li>diakriet in voornaam</li><li>kan niet op gezocht worden via /kadasternatuurlijkpersonen?q=</li></ul></td></tr>
	<tr><td>Baron Jan-Jaap de Vierde</td><td></td><td>80000007</td><td><ul><li>adellijke titel</li><li>kan niet op gezocht worden via /kadasternatuurlijkpersonen?q=</li></ul></td></tr>
</table>

#### Ingeschreven Natuurlijke Personen

<table>
	<tr><th>Naam</th><th>Burgerservice-nummer</th></tr>
	<tr><td>Linda Haglund</td><td>999991905</td></tr>
	<tr><td>Lisanty do Livramento...</td><td>999990482</td></tr>
	<tr><td>Merel Kooyman</td><td>999993847</td></tr>
	<tr><td>Suzanne van der Stappen</td><td>999993653</td></tr>
	<tr><td>Mirjam Heijn</td><td>999991292</td></tr>
	<tr><td>Jael de Jager</td><td>999992740</td></tr>
	<tr><td>Wladyslaw Kwasniewski</td><td>999995017</td></tr>
	<tr><td>Żáïŀëñøŕ Åłéèç Ðëļŧå Streeveld</td><td>999994669</td></tr>
	<tr><td>Adrianus Hendrikus Holthuizen</td><td>999990421</td></tr>
	<tr><td>Peter-Jan Meijden</td><td>999993872</td></tr>
	<tr><td>Paul Man</td><td>999990883</td></tr>
</table>

#### Niet Natuurlijke Personen

<table>
	<tr><th>Statutaire Naam             </th><th>Zetel        </th><th>Type                                </th><th>KadasterPersoonIdentificatie  </th>	<th>Bijzonderheden       </th></tr>
	<tr><td>Bankbedrijf                 </td><td>ROTTERDAM    </td><td>Kadaster Niet Natuurlijk Persoon    </td><td>71291440                      </td><td><ul><li>postadres is postbus</li></ul></td></tr>
	<tr><td>Bankbedrijf van vrucht      </td><td>GRAVE        </td><td>Ingeschreven Niet Natuurlijk Persoon</td><td>71291493                      </td><td><ul><li>heeft niks op naam</li></ul></td></tr>
	<tr><td>Gasunie Test BV             </td><td>GRONINGEN    </td><td>Ingeschreven Niet Natuurlijk Persoon</td><td>440650207                     </td><td>                                      </td></tr>
	<tr><td>Gemeente Den Testland       </td><td>'S-GRAVENHAGE</td><td>Kadaster Niet Natuurlijk Persoon    </td><td>71291441                      </td><td><ul><li>kan niet op gezocht worden via /kadasternietnatuurlijkpersonen?q=</li></ul></td></tr>
	<tr><td>Woningstichting Den Testland</td><td>'S-GRAVENHAGE</td><td>Kadaster Niet Natuurlijk Persoon    </td><td>71291442                      </td><td><ul><li>kan niet op gezocht worden /kadasternietnatuurlijkpersonen?q=</li></ul></td></tr>
</table>

#### Foutscenarios

|Aanvraag                                |Foutscenario   |
|-----                                   |-------        |
|/kadastraalonroerendezaken/122003147000 | 404 Not found |
|/kadastraalonroerendezaken/122003157000 | 410 Gone      |

## Aansluiten op productie
Voor de connectie met de productieomgeving van deze API is vereist:
- Een geldige API-key. Deze wordt bij de request opgenomen in request header "X-Api-Key". Wanneer je je aanmeldt voor het gebruiken van de API ontvang je de API-key.
- Internet toegang tot het Kadaster endpoint via IPv4 of IPv6 en met het TLS 1.2 protocol.
- Een Staat der Nederlanden root CA - G3 certificaat in de truststore, zie hiervoor: https://www.pkioverheid.nl/
- Een geldig PKIoverheid client certificaat met SERIALNUMMER=<eigen-OIN-nummer> in de keystore dat deel uitmaakt van de Staat der Nederlanden - G3 hiërarchie,
zie hiervoor: https://www.logius.nl/diensten/pkioverheid
- Een mutual TLS endpoint configuratie, waarbij de TLS verbinding met het Kadaster alleen tot stand mag en kan komen als er bij het opzetten van de verbinding een wederzijds vertrouwen op basis van de PKIoverheid certificaten hiërarchie bestaat.

### URL
De productieomgeving van de API is te benaderen via de volgende url: https://api.brk.kadaster.nl/esd/bevragen/v1/
