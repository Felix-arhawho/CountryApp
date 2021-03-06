﻿using CountryApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CountryApp.CountrySetup
{
    public class AllCountries
    {
        public static List<Country> GetAllCountries()
        {
            List<Country> ListOfCountries = new List<Country>
            {
                            new Country{ CountryName ="Afghanistan"},
                            new Country{ CountryName ="Albania"},
                            new Country{ CountryName ="Algeria"},
                            new Country{ CountryName ="Andorra"},
                            new Country{ CountryName ="Angola"},
                            new Country{ CountryName ="Antigua and Barbuda"},
                            new Country{ CountryName ="Argentina"},
                            new Country{ CountryName ="Armenia"},
                            new Country{ CountryName ="Australia"},
                            new Country{ CountryName ="Austria"},
                            new Country{ CountryName ="Azerbaijan"},
                            new Country{ CountryName ="Bahamas"},
                            new Country{ CountryName ="Bahrain"},
                            new Country{ CountryName ="Bangladesh"},
                            new Country{ CountryName ="Barbados"},
                            new Country{ CountryName ="Belarus"},
                            new Country{ CountryName ="Belgium"},
                            new Country{ CountryName ="Belize"},
                            new Country{ CountryName ="Benin"},
                            new Country{ CountryName ="Bhutan"},
                            new Country{ CountryName ="Bolivia"},
                            new Country{ CountryName ="Bosnia"},
                            new Country{ CountryName ="Botswana"},
                            new Country{ CountryName ="Brazil"},
                            new Country{ CountryName ="Brunei"},
                            new Country{ CountryName ="Bulgaria"},
                            new Country{ CountryName ="Burkina"},
                            new Country{ CountryName ="Burundi"},
                            new Country{ CountryName ="Cabo"},
                            new Country{ CountryName ="Cambodia"},
                            new Country{ CountryName ="Cameroon"},
                            new Country{ CountryName ="Canada"},
                            new Country{ CountryName ="Central African Republic (CAR)"},
                            new Country{ CountryName ="Chad"},
                            new Country{ CountryName ="Chile"},
                            new Country{ CountryName ="China"},
                            new Country{ CountryName ="Colombia"},
                            new Country{ CountryName ="Comoros"},
                            new Country{ CountryName ="Democratic Republic of Congo"},
                            new Country{ CountryName ="Costa Rica"},
                            new Country{ CountryName ="Cote d'Ivoire"},
                            new Country{ CountryName ="Croatia"},
                            new Country{ CountryName ="Cuba"},
                            new Country{ CountryName ="Cyprus"},
                            new Country{ CountryName ="Czech Republic"},
                            new Country{ CountryName ="Denmark"},
                            new Country{ CountryName ="Djibouti"},
                            new Country{ CountryName ="Dominica"},
                            new Country{ CountryName ="Dominican Republic"},
                            new Country{ CountryName ="Ecuador"},
                            new Country{ CountryName ="Egypt"},
                            new Country{ CountryName ="El Salvador"},
                            new Country{ CountryName ="Equatorial Guinea"},
                            new Country{ CountryName ="Eritrea"},
                            new Country{ CountryName ="Estonia"},
                            new Country{ CountryName ="Ethiopia"},
                            new Country{ CountryName ="Fiji"},
                            new Country{ CountryName ="Finland"},
                            new Country{ CountryName ="France"},
                            new Country{ CountryName ="Gabon"},
                            new Country{ CountryName ="Gambia"},
                            new Country{ CountryName ="Georgia"},
                            new Country{ CountryName ="Guyana"},
                            new Country{ CountryName ="Ghana"},
                            new Country{ CountryName ="Greece"},
                            new Country{ CountryName ="Grenada"},
                            new Country{ CountryName ="Guatemala"},
                            new Country{ CountryName ="Guinea"},
                            new Country{ CountryName ="Guinea-Bissau"},
                            new Country{ CountryName ="Guyana"},
                            new Country{ CountryName ="Haiti"},
                            new Country{ CountryName ="Honduras"},
                            new Country{ CountryName ="Hungary"},
                            new Country{ CountryName ="Iceland"},
                            new Country{ CountryName ="India"},
                            new Country{ CountryName ="Indonesia"},
                            new Country{ CountryName ="Iran"},
                            new Country{ CountryName ="Iraq"},
                            new Country{ CountryName ="Ireland"},
                            new Country{ CountryName ="Israel"},
                            new Country{ CountryName ="Italy"},
                            new Country{ CountryName ="Jamaica"},
                            new Country{ CountryName ="Japan"},
                            new Country{ CountryName ="Jordan"},
                            new Country{ CountryName ="Kazakhstan"},
                            new Country{ CountryName ="Kenya"},
                            new Country{ CountryName ="Kiribati"},
                            new Country{ CountryName ="Kosovo"},
                            new Country{ CountryName ="Kuwait"},
                            new Country{ CountryName ="Kyrgyzstan"},
                            new Country{ CountryName ="Laos"},
                            new Country{ CountryName ="Latvia"},
                            new Country{ CountryName ="Lebanon"},
                            new Country{ CountryName ="Lesotho"},
                            new Country{ CountryName ="Liberia"},
                            new Country{ CountryName ="Libya"},
                            new Country{ CountryName ="Liechtenstein"},
                            new Country{ CountryName ="Lithuania"},
                            new Country{ CountryName ="Luxembourg"},
                            new Country{ CountryName ="Macedonia"},
                            new Country{ CountryName ="Madagascar"},
                            new Country{ CountryName ="Malawi"},
                            new Country{ CountryName ="Malaysia"},
                            new Country{ CountryName ="Maldives"},
                            new Country{ CountryName ="Mali"},
                            new Country{ CountryName ="Malta"},
                            new Country{ CountryName ="Marshall"},
                            new Country{ CountryName ="Mauritania"},
                            new Country{ CountryName ="Mauritius"},
                            new Country{ CountryName ="Mexico"},
                            new Country{ CountryName ="Micronesia"},
                            new Country{ CountryName ="Moldova"},
                            new Country{ CountryName ="Monaco"},
                            new Country{ CountryName ="Mongolia"},
                            new Country{ CountryName ="Montenegro"},
                            new Country{ CountryName ="Morocco"},
                            new Country{ CountryName ="Mozambique"},
                            new Country{ CountryName ="Myanmar"},
                            new Country{ CountryName ="Namibia"},
                            new Country{ CountryName ="Nauru"},
                            new Country{ CountryName ="Nepal"},
                            new Country{ CountryName ="Nepal"},
                            new Country{ CountryName ="New Zealand"},
                            new Country{ CountryName ="Nicaragua"},
                            new Country{ CountryName ="Niger"},
                            new Country{ CountryName ="Nigeria"},
                            new Country{ CountryName ="North Korea"},
                            new Country{ CountryName ="Norway"},
                            new Country{ CountryName ="Oman"},
                            new Country{ CountryName ="Pakistan"},
                            new Country{ CountryName ="Palau"},
                            new Country{ CountryName ="Palestine"},
                            new Country{ CountryName ="Panama"},
                            new Country{ CountryName ="Papua New Guinea"},
                            new Country{ CountryName ="Paraguay"},
                            new Country{ CountryName ="Peru"},
                            new Country{ CountryName ="Philippines"},
                            new Country{ CountryName ="Poland"},
                            new Country{ CountryName ="Portugal"},
                            new Country{ CountryName ="Qatar"},
                            new Country{ CountryName ="Romania"},
                            new Country{ CountryName ="Russia"},
                            new Country{ CountryName ="Rwanda"},
                            new Country{ CountryName ="Saint Kitts and Nevis"},
                            new Country{ CountryName ="Saint Lucia"},
                            new Country{ CountryName ="Saint Vincent and the Grenadines"},
                            new Country{ CountryName ="Samoa"},
                            new Country{ CountryName ="SanMarino"},
                            new Country{ CountryName ="Sao Tome and Principe"},
                            new Country{ CountryName ="SaudiArabia"},
                            new Country{ CountryName ="Senegal"},
                            new Country{ CountryName ="Serbia"},
                            new Country{ CountryName ="Sierra Leone"},
                            new Country{ CountryName ="Singapore"},
                            new Country{ CountryName ="Slovakia"},
                            new Country{ CountryName ="Slovenia"},
                            new Country{ CountryName ="Solomon Islands"},
                            new Country{ CountryName ="Somalia"},
                            new Country{ CountryName ="South Africa"},
                            new Country{ CountryName ="South Korea"},
                            new Country{ CountryName ="South Sudan"},
                            new Country{ CountryName ="Spain"},
                            new Country{ CountryName ="SriLanka"},
                            new Country{ CountryName ="Sudan"},
                            new Country{ CountryName ="Suriname"},
                            new Country{ CountryName ="Swaziland"},
                            new Country{ CountryName ="Sweden"},
                            new Country{ CountryName ="Switzerland"},
                            new Country{ CountryName ="Syria"},
                            new Country{ CountryName ="Taiwan"},
                            new Country{ CountryName ="Tajikistan"},
                            new Country{ CountryName ="Tanzania"},
                            new Country{ CountryName ="Thailand"},
                            new Country{ CountryName ="Timor-Leste"},
                            new Country{ CountryName ="Togo"},
                            new Country{ CountryName ="Tonga"},
                            new Country{ CountryName ="Trinidad and Tobago"},
                            new Country{ CountryName ="Tunisia"},
                            new Country{ CountryName ="Turkey"},
                            new Country{ CountryName ="Turkmenistan"},
                            new Country{ CountryName ="Tuvalu"},
                            new Country{ CountryName ="Uganda"},
                            new Country{ CountryName ="Ukraine"},
                            new Country{ CountryName ="United Arab Emirates (UAE)"},
                            new Country{ CountryName ="United Kingdom (UK)"},
                            new Country{ CountryName ="United States of America (USA)"},
                            new Country{ CountryName ="Uruguay"},
                            new Country{ CountryName ="Uzbekistan"},
                            new Country{ CountryName ="Vanuatu"},
                            new Country{ CountryName ="Vatican City (Holy See)"},
                            new Country{ CountryName ="Venezuela"},
                            new Country{ CountryName ="Vietnam"},
                            new Country{ CountryName ="Yemen"},
                            new Country{ CountryName ="Zambia"},
                            new Country{ CountryName ="Zimbabwe"}

            };

            return ListOfCountries;
        }
    }
}