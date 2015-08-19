using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace FlexChartSample
{
    public static class License
    {
        public const string Key =
            "ACYBJgImB45GAGwAZQB4AEMAaABhAHIAdABTAGEAbQBwAGwAZQCIsLYmYXO1quKc" +
            "6QvgZAxbi1Zbt7/p0X837XHBdNpdGOoIM1toANuh794Rx/9x8bml7S739JS72+kR" +
            "vqjprYAUzVP2twQbCPim/57KVsjUVgL6DzM8/6LymJrfJmOLLZKYmVqCy6TO7uwD" +
            "pGHTszcnTN+TntiLHa8w+eb1Tx63zPai4ikxEOrs0Graeiq4Zcxfi00adi8PTnqT" +
            "6V/J/IvoCTm13x+IdIHXVGAaK7tKqDiaaNaet+YdaTuJydZQhjufhhMdBfXjHEYn" +
            "C2KKuNu7dHAcGpFn/p8jHOqfxliPsDm+qx11hB5XUvaO2HBvtLK6aK2IgV7aLaqk" +
            "ut8kQWIXU0kaIPIFJqklxS/05YhWDLZATwGv32geZb518pNhXvEOTe+ifO84nCMK" +
            "5/2qf3LFmREBE/Tksp1UIm/mRtcRHqJnrbajg+VvuUjUqUX5lZOBlOsBd9/MoyqQ" +
            "anvzqzqpZWCbQEzpmWIiLe2f/hva+BNx3v574SwNYNP5HbtzqqI6UZrGiOh3uD2W" +
            "pFhTu4qC/vMDToqMD/2zUz8nt63rDcARpicgEQFQgqF9aeyhnoKg8AaHoXkwE+Di" +
            "EDjQE7fx737TOTYYkJtJhzDnPi8gwg2i42LnfG0KyoyWPM+fiHTRNeoN74Z9dHhH" +
            "5XwBmJTD7GsihTgI2PVRytur2P1+ZDCCBWQwggRMoAMCAQICECIQshdLCxJ/uygF" +
            "LhGzJQowDQYJKoZIhvcNAQEFBQAwgbQxCzAJBgNVBAYTAlVTMRcwFQYDVQQKEw5W" +
            "ZXJpU2lnbiwgSW5jLjEfMB0GA1UECxMWVmVyaVNpZ24gVHJ1c3QgTmV0d29yazE7" +
            "MDkGA1UECxMyVGVybXMgb2YgdXNlIGF0IGh0dHBzOi8vd3d3LnZlcmlzaWduLmNv" +
            "bS9ycGEgKGMpMTAxLjAsBgNVBAMTJVZlcmlTaWduIENsYXNzIDMgQ29kZSBTaWdu" +
            "aW5nIDIwMTAgQ0EwHhcNMTMwOTI0MDAwMDAwWhcNMTYxMDIzMjM1OTU5WjCBpzEL" +
            "MAkGA1UEBhMCVVMxFTATBgNVBAgTDFBlbm5zeWx2YW5pYTETMBEGA1UEBxMKUGl0" +
            "dHNidXJnaDEVMBMGA1UEChQMQ29tcG9uZW50T25lMT4wPAYDVQQLEzVEaWdpdGFs" +
            "IElEIENsYXNzIDMgLSBNaWNyb3NvZnQgU29mdHdhcmUgVmFsaWRhdGlvbiB2MjEV" +
            "MBMGA1UEAxQMQ29tcG9uZW50T25lMIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIB" +
            "CgKCAQEAucugmqlJVWqckvNrTmVMhxqRy/KXt3EHFn5zCTgKqTr5RoLp/lnku9EP" +
            "X4CGIBG6UiAju8+CQJ/5zzeI5WJBbIm5cUkycZq9rcBnpf+jQNpSrNjMU5bP8ysD" +
            "M4m9gy2uP81P2bwFZ6L5SRjU1ZTK2JJrQkg1i3nmL8XO3Fe0/srbsuPdljDBSQ0s" +
            "4onh/6qRHRBKfKBhRBDIwM4uDm99iQMt1RCQ2t60FPYlnrHp2Q1wKmJ/l1tnTUw4" +
            "UQSNkmUZ2e+t6e45h/DkI2WgNIJHO21Inz0m0k6NDHKsFB/XKU5eiJcI+nMBcJTZ" +
            "IX91hdKKZUzylPQ1nulQ0bUf4DPacwIDAQABo4IBezCCAXcwCQYDVR0TBAIwADAO" +
            "BgNVHQ8BAf8EBAMCB4AwQAYDVR0fBDkwNzA1oDOgMYYvaHR0cDovL2NzYzMtMjAx" +
            "MC1jcmwudmVyaXNpZ24uY29tL0NTQzMtMjAxMC5jcmwwRAYDVR0gBD0wOzA5Bgtg" +
            "hkgBhvhFAQcXAzAqMCgGCCsGAQUFBwIBFhxodHRwczovL3d3dy52ZXJpc2lnbi5j" +
            "b20vcnBhMBMGA1UdJQQMMAoGCCsGAQUFBwMDMHEGCCsGAQUFBwEBBGUwYzAkBggr" +
            "BgEFBQcwAYYYaHR0cDovL29jc3AudmVyaXNpZ24uY29tMDsGCCsGAQUFBzAChi9o" +
            "dHRwOi8vY3NjMy0yMDEwLWFpYS52ZXJpc2lnbi5jb20vQ1NDMy0yMDEwLmNlcjAf" +
            "BgNVHSMEGDAWgBTPmanqeyb0S8mOj9fwBSbv49KnnTARBglghkgBhvhCAQEEBAMC" +
            "BBAwFgYKKwYBBAGCNwIBGwQIMAYBAQABAf8wDQYJKoZIhvcNAQEFBQADggEBAGHN" +
            "VjnOPBgAWOYhrYlJZup5dDWOt/ajkOhFhaAj/7gsSkn5Taj5UAjmQhhI0anliOrt" +
            "e9CiyOz8Lqp3Cl9N3duHaUQRHhcJHOmj7gcr1bHCPQPw/VShSfjcuOVswH8bNFGE" +
            "2rQE34ROUPT4F6OymhSyx3kZGEYs05ea0NX739ruPuH23kkQyT74luXKxV7pSlyC" +
            "2hj1eC5kuybkM6FBPRAiWA4grVBKX/CGIoZ08F8PmM3j9IewZVRs+kL4/GOHnJP8" +
            "tKb342qT63MxBByltN94sqz2QuCwbhSj1+yDnA6XgU3gIEejYItcSq2uLLf/+ulQ" +
            "w661UqabVrAeGAaqy4UwggK0MIIBnKADAgECAgQO7u7uMA0GCSqGSIb3DQEBBQUA" +
            "MBwxGjAYBgNVBAMMEUdDLVhVMTE1MDAtMTQwMDI2MB4XDTE1MDEwMTAwMDAwMFoX" +
            "DTIwMDEwMTAwMDAwMFowHDEaMBgGA1UEAwwRR0MtWFUxMTUwMC0xNDAwMjYwggEi" +
            "MA0GCSqGSIb3DQEBAQUAA4IBDwAwggEKAoIBAQC1yFJZipoO9nZh/+4DvQ94sPNl" +
            "8LjG6awZFu9iZCuEUs97wEtTrsCg9jyQaA6lz17dQ23JSMioldEhRXt6Jqv6lfhD" +
            "WUwYp1GqMIALB9HZkRPei2zijDGHLJ/ej45yC5fVcg6L+6qvD17lSKFEYUPyhrmh" +
            "H5vchCSHhhoopykdvgWVIuY/jH1pqaHLvSrc5f/7+sz/aiIdse2qA9HeNTUYYpGq" +
            "4ieV5T06xfHyRBn/vNk/DLY76P8m06KgfRU0u4wROdeRIsWpQKHoQt/Ngdiyg+Qb" +
            "QQUeHqUisaxtoCqvo82lJnsZyACUivcLPL/8Fq31DQibImMsOubkwP5Fm3/ZAgMB" +
            "AAEwDQYJKoZIhvcNAQEFBQADggEBABiysnF+rBm/pjqXBnLAaON6YW+HVdjOLe/R" +
            "rrfYsI/uCKEcVuwLFEp5vD566OYphMNakgNgZ9DjzQreRqpnGkOaNjOl+VRlKkh9" +
            "TKnclWgA4BNK2C73maLyYWkObFTsump7qip8ZYhvqFVlKxr4X/DJFTenVqCJcWgN" +
            "GeNCvloZHsLw3U+2J95uWsuHvFn/Z08SRNsTX3MjT3Nb5Diutbsocs8ouA+0Jj06" +
            "gB/GWrMDODAxpYdpTU+VA8aMJPkkyOKdF/j2y7BdujPfgZGdGJz3HRiA75R2fon/" +
            "hk0IKqADgAGvPY44dXr4rl9hTH2rzq5QUC5rM1LlhNrsh+W78VU=";
    }
}