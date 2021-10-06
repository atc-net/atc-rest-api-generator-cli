﻿using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Scenario2.Api.Generated.Contracts;
using Scenario2.Api.Generated.Contracts.Addresses;

//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Scenario2.Api.Tests.Endpoints.Addresses.Generated
{
    [GeneratedCode("ApiGenerator", "x.x.x.x")]
    public class GetAddressesByPostalCodesHandlerStub : IGetAddressesByPostalCodesHandler
    {
        public Task<GetAddressesByPostalCodesResult> ExecuteAsync(GetAddressesByPostalCodesParameters parameters, CancellationToken cancellationToken = default)
        {
            var data = new List<Address>
            {
                new Address
                {
                    StreetName = "Hallo1",
                    StreetNumber = "Hallo11",
                    PostalCode = "Hallo12",
                    CityName = "Hallo13",
                    MyCountry = new Country
                    {
                        Name = "Hallo11",
                        Alpha2Code = "Ha",
                        Alpha3Code = "Hal",
                    },
                },
                new Address
                {
                    StreetName = "Hallo2",
                    StreetNumber = "Hallo21",
                    PostalCode = "Hallo22",
                    CityName = "Hallo23",
                    MyCountry = new Country
                    {
                        Name = "Hallo21",
                        Alpha2Code = "Ha",
                        Alpha3Code = "Hal",
                    },
                },
                new Address
                {
                    StreetName = "Hallo3",
                    StreetNumber = "Hallo31",
                    PostalCode = "Hallo32",
                    CityName = "Hallo33",
                    MyCountry = new Country
                    {
                        Name = "Hallo31",
                        Alpha2Code = "Ha",
                        Alpha3Code = "Hal",
                    },
                },
            };

            return Task.FromResult(GetAddressesByPostalCodesResult.Ok(data));
        }
    }
}