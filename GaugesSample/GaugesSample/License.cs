using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace GaugesSample
{
    public static class License
    {
        public const string Key =
            "ACABIAIgB4hHAGEAdQBnAGUAcwBTAGEAbQBwAGwAZQAj/HvWWidI5Q64rP08aUE4" +
            "2r1LL7G3Qt6bIW9Hzi13JFWkKlgDEHS8UVZPiHw+tIxjRHTShwz83C5DbLv9RIlH" +
            "P+v32OPl1EF1BWPnm48rlYn3K23/wBzdbsKPBBLJluo9qa3s5/APdq8fLvzdzD6Z" +
            "IsAwPxAE8hcM1siKmKaeT+zOTVhP5f5k8Hu2MBZPpXvCKnIAR+9fpyRkkaZDgmbp" +
            "bFFvzcvFBf1PKvxE1ui4iM/Rop48PLBqZhALPnYGYHnWIQbwcg7mTvdhXiT2xSLY" +
            "N9ANG5MXMS3zo0deULHhNpu0mr+XZ4oKrQ0pojG1HnOzw/XpEv5W17RJbRx0ec4I" +
            "iz8iIIcvAN7Zx1Bpr0Jcglp4ivOCaSePO07JbYFjyo7kccVbo9Sq4L1ly/s2Tv6L" +
            "as0vN819PVQDRdSRjM7Ddn3w3DHW7ckkznchN8nKnqSxTIlO7BZQmtyblds3eWEz" +
            "WYTBEwZLGL/gXlfdMGVmiSfK6yrPk5x0KLmFD7a0nt2riBsYPRFvgsq6iP7AZt+N" +
            "RUCS0M182Oeyge48bsVREzEq/rWLi6tQZAV0Zx1IPETkuMX73PfomsDLFjS5c1B6" +
            "PuG9ebUTwjKv0T4qBp5PsnRCqeFW5vU+XJdEEPo1Apm5nyNjl5+z7dnGlXjTeIHW" +
            "Vw2WTg/n557b00IQ8JJ/3TCCBWQwggRMoAMCAQICECIQshdLCxJ/uygFLhGzJQow" +
            "DQYJKoZIhvcNAQEFBQAwgbQxCzAJBgNVBAYTAlVTMRcwFQYDVQQKEw5WZXJpU2ln" +
            "biwgSW5jLjEfMB0GA1UECxMWVmVyaVNpZ24gVHJ1c3QgTmV0d29yazE7MDkGA1UE" +
            "CxMyVGVybXMgb2YgdXNlIGF0IGh0dHBzOi8vd3d3LnZlcmlzaWduLmNvbS9ycGEg" +
            "KGMpMTAxLjAsBgNVBAMTJVZlcmlTaWduIENsYXNzIDMgQ29kZSBTaWduaW5nIDIw" +
            "MTAgQ0EwHhcNMTMwOTI0MDAwMDAwWhcNMTYxMDIzMjM1OTU5WjCBpzELMAkGA1UE" +
            "BhMCVVMxFTATBgNVBAgTDFBlbm5zeWx2YW5pYTETMBEGA1UEBxMKUGl0dHNidXJn" +
            "aDEVMBMGA1UEChQMQ29tcG9uZW50T25lMT4wPAYDVQQLEzVEaWdpdGFsIElEIENs" +
            "YXNzIDMgLSBNaWNyb3NvZnQgU29mdHdhcmUgVmFsaWRhdGlvbiB2MjEVMBMGA1UE" +
            "AxQMQ29tcG9uZW50T25lMIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEA" +
            "ucugmqlJVWqckvNrTmVMhxqRy/KXt3EHFn5zCTgKqTr5RoLp/lnku9EPX4CGIBG6" +
            "UiAju8+CQJ/5zzeI5WJBbIm5cUkycZq9rcBnpf+jQNpSrNjMU5bP8ysDM4m9gy2u" +
            "P81P2bwFZ6L5SRjU1ZTK2JJrQkg1i3nmL8XO3Fe0/srbsuPdljDBSQ0s4onh/6qR" +
            "HRBKfKBhRBDIwM4uDm99iQMt1RCQ2t60FPYlnrHp2Q1wKmJ/l1tnTUw4UQSNkmUZ" +
            "2e+t6e45h/DkI2WgNIJHO21Inz0m0k6NDHKsFB/XKU5eiJcI+nMBcJTZIX91hdKK" +
            "ZUzylPQ1nulQ0bUf4DPacwIDAQABo4IBezCCAXcwCQYDVR0TBAIwADAOBgNVHQ8B" +
            "Af8EBAMCB4AwQAYDVR0fBDkwNzA1oDOgMYYvaHR0cDovL2NzYzMtMjAxMC1jcmwu" +
            "dmVyaXNpZ24uY29tL0NTQzMtMjAxMC5jcmwwRAYDVR0gBD0wOzA5BgtghkgBhvhF" +
            "AQcXAzAqMCgGCCsGAQUFBwIBFhxodHRwczovL3d3dy52ZXJpc2lnbi5jb20vcnBh" +
            "MBMGA1UdJQQMMAoGCCsGAQUFBwMDMHEGCCsGAQUFBwEBBGUwYzAkBggrBgEFBQcw" +
            "AYYYaHR0cDovL29jc3AudmVyaXNpZ24uY29tMDsGCCsGAQUFBzAChi9odHRwOi8v" +
            "Y3NjMy0yMDEwLWFpYS52ZXJpc2lnbi5jb20vQ1NDMy0yMDEwLmNlcjAfBgNVHSME" +
            "GDAWgBTPmanqeyb0S8mOj9fwBSbv49KnnTARBglghkgBhvhCAQEEBAMCBBAwFgYK" +
            "KwYBBAGCNwIBGwQIMAYBAQABAf8wDQYJKoZIhvcNAQEFBQADggEBAGHNVjnOPBgA" +
            "WOYhrYlJZup5dDWOt/ajkOhFhaAj/7gsSkn5Taj5UAjmQhhI0anliOrte9CiyOz8" +
            "Lqp3Cl9N3duHaUQRHhcJHOmj7gcr1bHCPQPw/VShSfjcuOVswH8bNFGE2rQE34RO" +
            "UPT4F6OymhSyx3kZGEYs05ea0NX739ruPuH23kkQyT74luXKxV7pSlyC2hj1eC5k" +
            "uybkM6FBPRAiWA4grVBKX/CGIoZ08F8PmM3j9IewZVRs+kL4/GOHnJP8tKb342qT" +
            "63MxBByltN94sqz2QuCwbhSj1+yDnA6XgU3gIEejYItcSq2uLLf/+ulQw661Uqab" +
            "VrAeGAaqy4UwggK0MIIBnKADAgECAgQO7u7uMA0GCSqGSIb3DQEBBQUAMBwxGjAY" +
            "BgNVBAMMEUdDLVNVMTE1MDAtNjY2NjY2MB4XDTE1MDEwMTAwMDAwMFoXDTIwMDEw" +
            "MTAwMDAwMFowHDEaMBgGA1UEAwwRR0MtU1UxMTUwMC02NjY2NjYwggEiMA0GCSqG" +
            "SIb3DQEBAQUAA4IBDwAwggEKAoIBAQCknfxFL61UnN2KwGS0QOpvlWaM/f06hU5H" +
            "A9Ti2C7KVxrh9IA8SgzgG40V3EQC58ermZAwBsnD0rRYzKmQ/Ifg2M8bAOX7mQMu" +
            "lRfw4pttOnf81LR5+K5FehPB4uiMzKhLvyA8FPX1l8Y9e2jSomAEwglCJ84oUJe4" +
            "oMNtoJoSwl+7manDXP9bu76n7/eGjqQDGMBD9p5VA2jVrDnM/tmYbWSVQ5ZPqSjV" +
            "gKoxSQVmjCIEsh63r80deAyY5eyKILfwje3Sv/Yr8O9JwL8p6qqVQAJnDI41yG/P" +
            "rpUopnRIxeBdZz5JqNuwqgvvNvjS5u9a5idv+DOMUoM15V7lA4jTAgMBAAEwDQYJ" +
            "KoZIhvcNAQEFBQADggEBAHOVDdilfw7pueoxIWfSj5keeOkpn4v+1KjIB4UPpgtX" +
            "lpjGFcdjdiP8asp0lzD198h3DaZIPCOyA3KQ3DQumFaqwiKIu16eDZ1/itSZ3jNN" +
            "krit228bCleJUcrslVHiZ0X90hm7eRG963P9/HL8LI14DQQ8QA/01f9IEYTwgzp8" +
            "TIK+vpc6+7uG7IL6ug8+6nWtUuWiINKiWNq0GsJo5n/TJX65jqdV1dwj32BbZmGc" +
            "iWR1N/4oE2OTtzpLSwcA9So1IIkvDM6Dwh1qrlWl9usZMKaHV9NPK/zdWCA8Az9T" +
            "c4JZmI23PG5J3fBmobqot8AhyetglrRCByOYjcUFZ1w=";
    }

}