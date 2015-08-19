using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace FlexGridSample
{
    public static class License
    {
        public const string Key =
            "ACQBJAIkB4xGAGwAZQB4AEcAcgBpAGQAUwBhAG0AcABsAGUAn/IOafdLKuXcw2Jw" +
            "7IQnVO43uREF56rI14fHWDy3pVJRfE51HqTwlrkCvCYwM0SCiM+HG/qqfrosb/7N" +
            "O8uaZVsGJzo2ab/BvtgJI7XHS1HuWkuMxaKJjI8AfdJJk8mCG3229/wpk6uNH29T" +
            "eSc5TEYdsfnfdM4rTbG1+2qc8sOjBvRcwIbhkmhaQ6cSWryneElv68HKdF8FnPIB" +
            "16t+mpPXjCDixDyZdNFcby+JKpzrnQTPYouekALHSs5L8WfxfU0X/vcb3fOto5EA" +
            "cksy6hG23ojkLRwZpiZntcXxEHAb4SHYBVUgwGEdbH+kEO6ccMUG7k/fOowj1dc5" +
            "sURlbVBFLHg7XJZQXiIh28u2rS/PVauTv72HfjCA/NuGILY7MZFdo2AxpB9vf29u" +
            "BAWAFgan6i/RlYu4rCrtv7tiqJQ+FxrrHcQvRfMsk00PR7OWcLUx3CvLDUQHBERH" +
            "FrahCARt3hv6lnfTAAyB0kZUOpe57dBG0jh/Ob+ciZtvGcoHL/YmLdrMdAKdYIv0" +
            "44scDctxTCF5MQKabS7iQEB/WfjbpHUOodYkE0icaaWUxrxxDT1dofgNmwhSuqfz" +
            "7hhV5rNWeaqTNjVxlw88DYSUPO6o27y8neT7vBtXn1TXlm7Q48i3yMNSPG8farRG" +
            "9UQi+bU1ZkfjQ2sJegF1xfkYbxMwggVkMIIETKADAgECAhAiELIXSwsSf7soBS4R" +
            "syUKMA0GCSqGSIb3DQEBBQUAMIG0MQswCQYDVQQGEwJVUzEXMBUGA1UEChMOVmVy" +
            "aVNpZ24sIEluYy4xHzAdBgNVBAsTFlZlcmlTaWduIFRydXN0IE5ldHdvcmsxOzA5" +
            "BgNVBAsTMlRlcm1zIG9mIHVzZSBhdCBodHRwczovL3d3dy52ZXJpc2lnbi5jb20v" +
            "cnBhIChjKTEwMS4wLAYDVQQDEyVWZXJpU2lnbiBDbGFzcyAzIENvZGUgU2lnbmlu" +
            "ZyAyMDEwIENBMB4XDTEzMDkyNDAwMDAwMFoXDTE2MTAyMzIzNTk1OVowgacxCzAJ" +
            "BgNVBAYTAlVTMRUwEwYDVQQIEwxQZW5uc3lsdmFuaWExEzARBgNVBAcTClBpdHRz" +
            "YnVyZ2gxFTATBgNVBAoUDENvbXBvbmVudE9uZTE+MDwGA1UECxM1RGlnaXRhbCBJ" +
            "RCBDbGFzcyAzIC0gTWljcm9zb2Z0IFNvZnR3YXJlIFZhbGlkYXRpb24gdjIxFTAT" +
            "BgNVBAMUDENvbXBvbmVudE9uZTCCASIwDQYJKoZIhvcNAQEBBQADggEPADCCAQoC" +
            "ggEBALnLoJqpSVVqnJLza05lTIcakcvyl7dxBxZ+cwk4Cqk6+UaC6f5Z5LvRD1+A" +
            "hiARulIgI7vPgkCf+c83iOViQWyJuXFJMnGava3AZ6X/o0DaUqzYzFOWz/MrAzOJ" +
            "vYMtrj/NT9m8BWei+UkY1NWUytiSa0JINYt55i/FztxXtP7K27Lj3ZYwwUkNLOKJ" +
            "4f+qkR0QSnygYUQQyMDOLg5vfYkDLdUQkNretBT2JZ6x6dkNcCpif5dbZ01MOFEE" +
            "jZJlGdnvrenuOYfw5CNloDSCRzttSJ89JtJOjQxyrBQf1ylOXoiXCPpzAXCU2SF/" +
            "dYXSimVM8pT0NZ7pUNG1H+Az2nMCAwEAAaOCAXswggF3MAkGA1UdEwQCMAAwDgYD" +
            "VR0PAQH/BAQDAgeAMEAGA1UdHwQ5MDcwNaAzoDGGL2h0dHA6Ly9jc2MzLTIwMTAt" +
            "Y3JsLnZlcmlzaWduLmNvbS9DU0MzLTIwMTAuY3JsMEQGA1UdIAQ9MDswOQYLYIZI" +
            "AYb4RQEHFwMwKjAoBggrBgEFBQcCARYcaHR0cHM6Ly93d3cudmVyaXNpZ24uY29t" +
            "L3JwYTATBgNVHSUEDDAKBggrBgEFBQcDAzBxBggrBgEFBQcBAQRlMGMwJAYIKwYB" +
            "BQUHMAGGGGh0dHA6Ly9vY3NwLnZlcmlzaWduLmNvbTA7BggrBgEFBQcwAoYvaHR0" +
            "cDovL2NzYzMtMjAxMC1haWEudmVyaXNpZ24uY29tL0NTQzMtMjAxMC5jZXIwHwYD" +
            "VR0jBBgwFoAUz5mp6nsm9EvJjo/X8AUm7+PSp50wEQYJYIZIAYb4QgEBBAQDAgQQ" +
            "MBYGCisGAQQBgjcCARsECDAGAQEAAQH/MA0GCSqGSIb3DQEBBQUAA4IBAQBhzVY5" +
            "zjwYAFjmIa2JSWbqeXQ1jrf2o5DoRYWgI/+4LEpJ+U2o+VAI5kIYSNGp5Yjq7XvQ" +
            "osjs/C6qdwpfTd3bh2lEER4XCRzpo+4HK9Wxwj0D8P1UoUn43LjlbMB/GzRRhNq0" +
            "BN+ETlD0+BejspoUssd5GRhGLNOXmtDV+9/a7j7h9t5JEMk++JblysVe6UpcgtoY" +
            "9XguZLsm5DOhQT0QIlgOIK1QSl/whiKGdPBfD5jN4/SHsGVUbPpC+Pxjh5yT/LSm" +
            "9+Nqk+tzMQQcpbTfeLKs9kLgsG4Uo9fsg5wOl4FN4CBHo2CLXEqtriy3//rpUMOu" +
            "tVKmm1awHhgGqsuFMIICtDCCAZygAwIBAgIEDu7u7jANBgkqhkiG9w0BAQUFADAc" +
            "MRowGAYDVQQDDBFHQy1YVTExNTAwLTE0MDAyNjAeFw0xNTAxMDEwMDAwMDBaFw0y" +
            "MDAxMDEwMDAwMDBaMBwxGjAYBgNVBAMMEUdDLVhVMTE1MDAtMTQwMDI2MIIBIjAN" +
            "BgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAyncfAvR2kiBUS2ibMuii+lJct8qV" +
            "55joZT+LGBTxBbUg992hSqBgs3Hg4ywR3YXwsiRQdLPr3FKnrS90812pQgdWT+6g" +
            "dpH1lzbW4jpu7fAadv0GGejl/iKi/ONe8qLUuK0Yi8T25zaOBNIN3Ygo0eJVbcA/" +
            "04Rh93sn7k+0YYqxVUi0aV6dRsIW/T/f6nUhwPUSkOgqQo3BdMNg1fDPUHp84tFP" +
            "kiNKV9c9n1QAno7x3OGWS6r+k8UBcIa1lKKCRLukZwtuC17fp5Gx5lwT5kyQjo4q" +
            "+WCJhxkfVAF5BMoupcpeRCHCidYRYJbUxRvB9LbvrHMxoRW6PY4dCTiUdwIDAQAB" +
            "MA0GCSqGSIb3DQEBBQUAA4IBAQCshE9DdNujG3VQyKRDp7ztT7L+t0uAtKDAepcJ" +
            "wO+5eZLdZAGmmH3YDKSmo8jPwWfIwp7eMhsG5QKvT1ZY0qdZgMcteQEQopEqkmLY" +
            "h1OAZvwPXUbz0ADHD61jWTBwL5L27iSM31x9Rp8GqZ1tAGpMozZq5U1mQQTr1w9d" +
            "cjjipDXMjazsJnQvvV6jk3e/bpbVyzDkoTSFM8FyW+5Yf3PKwT5A5E6soR6Iet/r" +
            "+l9hw11ZACtE2T5R2VbmaMRgpE+Q5og3sZ1mPPcfjtTiXnw00RH2/cO/hi6iWWnT" +
            "rSqp/6g5jsQKyxda/ZzXHxaqn7fRBh3l/IErkxLlBuos6wo8";
    }

}