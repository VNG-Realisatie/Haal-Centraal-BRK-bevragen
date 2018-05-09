using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StUF4.Entiteiten.Gemeenschappelijk;
using StUF4.Entiteiten.IngeschrevenPersoon;

namespace Provider
{
    public class Repository
    {
        public ICollection<IngeschrevenPersoon> SelecteerIngeschrevenPersonenVoorZoekenOpBinnenlandsVerblijfsadres()
        {
            var ingeschrevenPersonen = new List<IngeschrevenPersoon>
            {
                SelecteerIngeschrevenPersoonMetAlleenVerplichteKenmerken("123456780", "Pieterse"),
                SelecteerIngeschrevenPersoonMetAlleenVerplichteKenmerken("123456781", "Koning"),
                SelecteerIngeschrevenPersoonMetAlleenVerplichteKenmerken("123456782", "Nelis"),
            };

            ingeschrevenPersonen[1].verblijfsadres = new VerblijfsAdresRelatie
            {
                periodeGeldigheid = new Periode { van = DateTime.Today.AddYears(-1) },
                adres = new NummeraanduidingBeperkt
                {
                    identificatieNummeraanduiding = "2",
                    naamOpenbareRuimte = "Leyweg",
                    huisnummer = 345,
                    woonplaatsNaam = "Den Haag",
                    woonplaatsIdentificatie = "518"
                }
            };

            return ingeschrevenPersonen;
        }

        public ICollection<IngeschrevenPersoon> SelecteerIngeschrevenPersonenVoorRaadpleegBewoning(Periode periode)
        {
            var ingeschrevenPersonen = new List<IngeschrevenPersoon>
            {
                SelecteerIngeschrevenPersoonMetAlleenVerplichteKenmerken("123456780", "Pieterse"),
                SelecteerIngeschrevenPersoonMetAlleenVerplichteKenmerken("123456781", "Koning"),
                SelecteerIngeschrevenPersoonMetAlleenVerplichteKenmerken("123456782", "Nelis"),
            };

            foreach (var ingeschrevenPersoon in ingeschrevenPersonen)
            {
                ingeschrevenPersoon.verblijfsadres = SelecteerVerblijfsAdresVoor(periode);
            }
            var datumOverlijden = DateTime.Today.AddMonths(-2);
            ingeschrevenPersonen[2].overlijden = new IngeschrevenPersoon.overlijdenType
            {
                overlijdensdatum = new Overlijdensdatum { jaar = datumOverlijden.Year, maand = datumOverlijden.Month, dag = datumOverlijden.Day },
                overlijdenPlaats = "",
                overlijdenLand = ""
            };

            return ingeschrevenPersonen;
        }

        public VerblijfsAdresRelatie SelecteerVerblijfsAdresVoor(Periode periode)
        {
            return new VerblijfsAdresRelatie
            {
                periodeGeldigheid = periode == null
                    ? new Periode { van = DateTime.Today.AddMonths(-1) }
                    : new Periode { van = periode.van.AddMonths(-1), totEnMet = periode.totEnMet.GetValueOrDefault(DateTime.Today).AddMonths(1) },
                adres = new NummeraanduidingBeperkt
                {
                    identificatieNummeraanduiding = "1",
                    huisnummer = 70,
                    naamOpenbareRuimte = "Spui",
                    woonplaatsNaam = "Den Haag",
                    woonplaatsIdentificatie = "518"
                }
            };
        }

        public IngeschrevenPersoon SelecteerIngeschrevenPersoonMetAlleenVerplichteKenmerken(string bsn, string geslachtsnaam)
        {
            return new IngeschrevenPersoon
            {
                geslachtsnaam = geslachtsnaam,
                burgerservicenummer = bsn,
                geslachtsnaamAanschrijving = geslachtsnaam,
                geboorteplaats = "'s-Gravenhage",
                geboorteland = "Nederland",
                kinderen = new IngeschrevenPersoon.kinderenType(),
                ouders = new IngeschrevenPersoon.oudersType(),
                partners = new IngeschrevenPersoon.partnersType(),
                nationaliteiten = new IngeschrevenPersoon.nationaliteitenType(),
                verblijfstitels = new IngeschrevenPersoon.verblijfstitelsType(),
            };
        }
    }
}