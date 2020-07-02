# KadasterPersoon

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**identificatie** | **str** | Unieke identificatie voor de persoon. Voor een Kadasterpersoon is dit de identificatie zoals die door het Kadaster is vastgesteld. Voor een ingeschreven natuurlijk persoon is dit het burgerservicenummer. Voor een ingeschreven niet-natuurlijk persoon is dit het RSIN. Of de waarde in identificatie een burgerservicenummer, een RSIN of een kadasterpersoonidentificatie is kan worden afgeleid uit het type persoon. | [optional] 
**omschrijving** | **str** | Voor mensen leesbare, herkenbare en identificerende omschrijving van de persoon (met bijvoorbeeld de naam). | [optional] 
**domein** | **str** | Het domein waartoe de identificatie behoort. | [optional] 
**indicatie_niet_toonbare_diakriet** | **bool** |  | [optional] 
**beschikkingsbevoegdheid** | [**Waardelijst**](Waardelijst.md) |  | [optional] 
**woonadres** | [**Adres**](Adres.md) |  | [optional] 
**postadres** | [**Postadres**](Postadres.md) |  | [optional] 
**kadastraal_onroerende_zaak_identificaties** | **list[str]** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

