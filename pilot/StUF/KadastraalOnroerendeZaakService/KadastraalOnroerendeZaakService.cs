using StUF4.Entiteiten.KadastraleOnroerendeZaak;
using StUF4.Koppelvlak.Services.KadastraleOnroerendeZaak;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace KadastraalOnroerendeZaakService
{
    public class KadastraalOnroerendeZaakService : BevraagKadastraleOnroerendeZaak
    {
        [return: MessageParameter(Name = "KadastraleOnroerendeZaak")]
        public KadastraleOnroerendeZaak RaadpleegKadastraleOnroerendeZaak(string kadastraleIdentificatie)
        {
            return new KadastraleOnroerendeZaak {
                kadastraleIdentificatie = kadastraleIdentificatie,
                kadastraleGemeentecode = "",
                sectie="",
                perceelnummer="",
                adressen = new KadastraleOnroerendeZaakBeperkt.adressenType()
            };
        }

        [return: MessageParameter(Name = "kadastraleOnroerendeZaken")]
        public KadastraleOnroerendeZaak RaadpleegKadastraleOnroerendeZaakOpAanduiding(RaadpleegKadastraleOnroerendeZaakOpAanduidingFilter filter)
        {
            throw new NotImplementedException();
        }

        [return: MessageParameter(Name = "kadastraleOnroerendeZaken")]
        public KadastraleOnroerendeZakenBeperkt ZoekKadastraleOnroerendeZaakOpNummeraanduiding(string identificatieNummeraanduiding)
        {
            throw new NotImplementedException();
        }

        [return: MessageParameter(Name = "kadastraleOnroerendeZaken")]
        public KadastraleOnroerendeZakenBeperkt ZoekKadastraleOnroerendeZaakOpZakelijkRechtAnderNatuurlijkPersoon(ZoekKadastraleOnroerendeZaakOpZakelijkRechtAnderNatuurlijkPersoonFilter filter)
        {
            throw new NotImplementedException();
        }

        [return: MessageParameter(Name = "kadastraleOnroerendeZaken")]
        public KadastraleOnroerendeZakenBeperkt ZoekKadastraleOnroerendeZaakOpZakelijkRechtAnderNietNatuurlijkPersoon(string naam)
        {
            throw new NotImplementedException();
        }

        [return: MessageParameter(Name = "kadastraleOnroerendeZaken")]
        public KadastraleOnroerendeZakenBeperkt ZoekKadastraleOnroerendeZaakOpZakelijkRechtIngeschrevenNatuurlijkPersoon(string burgerservicenummer)
        {
            throw new NotImplementedException();
        }

        [return: MessageParameter(Name = "kadastraleOnroerendeZaken")]
        public KadastraleOnroerendeZakenBeperkt ZoekKadastraleOnroerendeZaakOpZakelijkRechtIngeschrevenNietNatuurlijkPersoonMetKvKnummer(string kvkNummer)
        {
            throw new NotImplementedException();
        }

        [return: MessageParameter(Name = "kadastraleOnroerendeZaken")]
        public KadastraleOnroerendeZakenBeperkt ZoekKadastraleOnroerendeZaakOpZakelijkRechtIngeschrevenNietNatuurlijkPersoonMetRsin(string rsin)
        {
            throw new NotImplementedException();
        }
    }
}