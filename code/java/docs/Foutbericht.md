

# Foutbericht

Terugmelding bij een fout. JSON representatie in lijn met [RFC7807](https://tools.ietf.org/html/rfc7807).
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**type** | [**URI**](URI.md) | Link naar meer informatie over deze fout |  [optional]
**title** | **String** | Beschrijving van de fout |  [optional]
**status** | **Integer** | Http status code |  [optional]
**detail** | **String** | Details over de fout |  [optional]
**instance** | [**URI**](URI.md) | Uri van de aanroep die de fout heeft veroorzaakt |  [optional]
**code** | **String** | Systeemcode die het type fout aangeeft |  [optional]



