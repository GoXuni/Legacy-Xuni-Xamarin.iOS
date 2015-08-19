using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace FlexPieSample
{
    public static class License
    {
        public const string Key =
            "ACIBIgIiB4pGAGwAZQB4AFAAaQBlAFMAYQBtAHAAbABlAEFrIFN4c4uqC+XsYux2" +
            "jpZmOOrf+3yaL4EyTzJb0LLWKNQh1jj4X9nlk4nt8Y9ZCI24rqOlo17l7gbYYSGA" +
            "FCvdfEG3BKuGX3bpeI+yhV+hL35VZEKDI7li246kP1IJknFz48QrV5FJ795wtr63" +
            "JRddGFLbK5/fPNXGz5FMrbcJbAXdkoy9pDsLuMi9p7Z+ETK93pOaE/xTh7LuGEXf" +
            "gm+YrsfX35Uhf5kP6dTFmitCBhmpj2djb3DQWPm+VqoKyKwDW2m9KYNkFku2US8E" +
            "z+aHIBOnRs4O603obIdLNdFoxtVYs/lElapKp/9q6M1dYs63ZNoj+iiRyjhFWSWc" +
            "t9KbZqMhQGkLWt2y4bAl7gJBeh6CXA/SjzIqDdgcG3l1SFOn0noxr5iy3wF51E2s" +
            "WvcXmApHX4xjyo7B4OBPjIJoUE1Ra5w1IhLXGmziZUREZEmSvfGMuTG2f6pbTGMF" +
            "7f/bdWoA7yNkMeGQq3tpeHsfRdlVxs8YRwLoUmhKRSAP6ubZzauVdaErRort9eR3" +
            "EJS3pOFB5arfdh3iWsJa5+nvjp0G+g8NBSL4aIx/jKdNiBjG8I/1L0dCg8PvR91d" +
            "V6Nk1+FwPnXqkcBr8Nj6B/3wtsYNJGpg4Izn4lwF+AS4m2wAfj0xT+mRPc5fEHi9" +
            "szD/yiZPCmIKMSptRhz8gg9IMIIFZDCCBEygAwIBAgIQIhCyF0sLEn+7KAUuEbMl" +
            "CjANBgkqhkiG9w0BAQUFADCBtDELMAkGA1UEBhMCVVMxFzAVBgNVBAoTDlZlcmlT" +
            "aWduLCBJbmMuMR8wHQYDVQQLExZWZXJpU2lnbiBUcnVzdCBOZXR3b3JrMTswOQYD" +
            "VQQLEzJUZXJtcyBvZiB1c2UgYXQgaHR0cHM6Ly93d3cudmVyaXNpZ24uY29tL3Jw" +
            "YSAoYykxMDEuMCwGA1UEAxMlVmVyaVNpZ24gQ2xhc3MgMyBDb2RlIFNpZ25pbmcg" +
            "MjAxMCBDQTAeFw0xMzA5MjQwMDAwMDBaFw0xNjEwMjMyMzU5NTlaMIGnMQswCQYD" +
            "VQQGEwJVUzEVMBMGA1UECBMMUGVubnN5bHZhbmlhMRMwEQYDVQQHEwpQaXR0c2J1" +
            "cmdoMRUwEwYDVQQKFAxDb21wb25lbnRPbmUxPjA8BgNVBAsTNURpZ2l0YWwgSUQg" +
            "Q2xhc3MgMyAtIE1pY3Jvc29mdCBTb2Z0d2FyZSBWYWxpZGF0aW9uIHYyMRUwEwYD" +
            "VQQDFAxDb21wb25lbnRPbmUwggEiMA0GCSqGSIb3DQEBAQUAA4IBDwAwggEKAoIB" +
            "AQC5y6CaqUlVapyS82tOZUyHGpHL8pe3cQcWfnMJOAqpOvlGgun+WeS70Q9fgIYg" +
            "EbpSICO7z4JAn/nPN4jlYkFsiblxSTJxmr2twGel/6NA2lKs2MxTls/zKwMzib2D" +
            "La4/zU/ZvAVnovlJGNTVlMrYkmtCSDWLeeYvxc7cV7T+ytuy492WMMFJDSziieH/" +
            "qpEdEEp8oGFEEMjAzi4Ob32JAy3VEJDa3rQU9iWesenZDXAqYn+XW2dNTDhRBI2S" +
            "ZRnZ763p7jmH8OQjZaA0gkc7bUifPSbSTo0McqwUH9cpTl6Ilwj6cwFwlNkhf3WF" +
            "0oplTPKU9DWe6VDRtR/gM9pzAgMBAAGjggF7MIIBdzAJBgNVHRMEAjAAMA4GA1Ud" +
            "DwEB/wQEAwIHgDBABgNVHR8EOTA3MDWgM6Axhi9odHRwOi8vY3NjMy0yMDEwLWNy" +
            "bC52ZXJpc2lnbi5jb20vQ1NDMy0yMDEwLmNybDBEBgNVHSAEPTA7MDkGC2CGSAGG" +
            "+EUBBxcDMCowKAYIKwYBBQUHAgEWHGh0dHBzOi8vd3d3LnZlcmlzaWduLmNvbS9y" +
            "cGEwEwYDVR0lBAwwCgYIKwYBBQUHAwMwcQYIKwYBBQUHAQEEZTBjMCQGCCsGAQUF" +
            "BzABhhhodHRwOi8vb2NzcC52ZXJpc2lnbi5jb20wOwYIKwYBBQUHMAKGL2h0dHA6" +
            "Ly9jc2MzLTIwMTAtYWlhLnZlcmlzaWduLmNvbS9DU0MzLTIwMTAuY2VyMB8GA1Ud" +
            "IwQYMBaAFM+Zqep7JvRLyY6P1/AFJu/j0qedMBEGCWCGSAGG+EIBAQQEAwIEEDAW" +
            "BgorBgEEAYI3AgEbBAgwBgEBAAEB/zANBgkqhkiG9w0BAQUFAAOCAQEAYc1WOc48" +
            "GABY5iGtiUlm6nl0NY639qOQ6EWFoCP/uCxKSflNqPlQCOZCGEjRqeWI6u170KLI" +
            "7PwuqncKX03d24dpRBEeFwkc6aPuByvVscI9A/D9VKFJ+Ny45WzAfxs0UYTatATf" +
            "hE5Q9PgXo7KaFLLHeRkYRizTl5rQ1fvf2u4+4fbeSRDJPviW5crFXulKXILaGPV4" +
            "LmS7JuQzoUE9ECJYDiCtUEpf8IYihnTwXw+YzeP0h7BlVGz6Qvj8Y4eck/y0pvfj" +
            "apPrczEEHKW033iyrPZC4LBuFKPX7IOcDpeBTeAgR6Ngi1xKra4st//66VDDrrVS" +
            "pptWsB4YBqrLhTCCArQwggGcoAMCAQICBA7u7u4wDQYJKoZIhvcNAQEFBQAwHDEa" +
            "MBgGA1UEAwwRR0MtU1UxMTUwMC02NjY2NjYwHhcNMTUwMTAxMDAwMDAwWhcNMjAw" +
            "MTAxMDAwMDAwWjAcMRowGAYDVQQDDBFHQy1TVTExNTAwLTY2NjY2NjCCASIwDQYJ" +
            "KoZIhvcNAQEBBQADggEPADCCAQoCggEBANReO8hZAsSiSupzJIsedeQX5LflTfLF" +
            "k02qECSekY2draUVHH+aSqxmoK6kDwRIizB8XJew/1/Rk5wAZtTOQXp5pkxqBWLM" +
            "wJvKLQQDlohhZCdmqSBXuqj3KgVhfOVr99NdR2FeXiVi3uN3qM1CW4F1VSueSrQn" +
            "f5X9tienJ7LtVbQOsDuxK4WI3hoXDWdfjdGdA0/1xMZdDbvhXvqvgKG91GVSNx4b" +
            "ttdClNpqA11WmFq3P5k7p/j2qsliAl73GZZFFbWbUZx/XlBjEfaV9DSzJra2wl18" +
            "qkqIj69OjwEZxvQ1Bd4ZvxBl5+68C47QxJeqSIfwU5SUrtDbEsy5QV0CAwEAATAN" +
            "BgkqhkiG9w0BAQUFAAOCAQEAZN9XRiwDUsC0XDyDHlg7rLcRHQHiIw9Xoc86Hnid" +
            "0E3QznXXBi9gVTqPeo8q7geAOzc48aarbst6Hb43s74YVPMqlyuJGcrPwJAWXjhd" +
            "6rNYT3PKUWcMq37qcVGBWjb/zAFao/vtVrjI7guEl2F0zrMW5712ny/IRaXN4FEt" +
            "e7WqhLSAiJYK6L+m8Uk10g0cneCsbtFv2+tD08UO03TWkUzyEwswaPg47G0xv6LG" +
            "gbXc0r0THGjIExJIDTH5wjyse2qa4/9B7rlsJ+wz6BNElnJ6wdurzES0IYLrIftj" +
            "R0HJ+w2AHrOJHb70YkdRLLjbRtNZ2rBkfMsxcIgK5fqr8A==";
    }

}