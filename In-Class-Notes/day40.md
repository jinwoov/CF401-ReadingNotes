auhtorize.net
- payment processor
- developer.authorize.net
- Hello world -> get started -> install-package
- create a account
- keep the api info
- signin to sandbox
- keep it to live 
- 
```cs
// new class in service folder
// call it payment service

// install-package authorizenet

//run method

public class PaymentService
{
    public void Run()
    {
        private IConfiguration
        public PayentService(IConfiguration configuration)
        {
            _config = configuration;
        }
        // controller base
        // bring he contract v1 for request
        ApioperationBase<ANetAPIRequest, ANetApiResponse>.RunEnvironment = AuthorizeNet.Environment.SANDBOX;

        // Go to our user secret
        ApiOperatoinBase<ANetApiRequest, ANetApiResponse>.MerchantAuthentication = new MerchantAuthenticationType()
        {
            name = _config["ApiLoginID"],
            ItemElementName = ItemChoiceType.transactionKey,
            Item = _config["TransactionKey"]
        }

        // set a credit card
        // do not ask user for credit card name

        var creditCard = new creditCardType
        {
            cardNumber = "number",
            expirationDate = "number"
        };

        customerAddressType billingAddress= GetAddress("someUserID");

        var paymentType = new paymentType{ Item = creditCard };

        //everything that has been 
        var transactionRequest = new transactionRequestType
        {
            transactionType = transactionTypeEnum.authCaptureTransaction.ToString();
            amount = 122.5m
            payment = paymentType,
            billTo = billingAddress
        };

        var request = new createTransactionRequest {transactionRequest = transactionRequest};

        // bringing in the library
        var controller = new createTransactionController(request);


        controller.Execute();

        var response = controller.GetApiResponse();

        if(response != null)
        {
            if(response.message.resultCode == messageTypeEnum.Ok)
            {
                return "success";
            }

        }
        return "fail";
    }
    public CustomerAddressType GetAddress(string userName)
    {
        customerAddressType address = new customerAddressType
        {
            firsname
            lastname
            address
            city
            zip

        };
        return address;
    }
}


```

user secret
```json

"AN-ApiLoginID": "id",
"AN-TransactionKey": "key"
```

in interface

IPayment
```cs

    string Run();

```

in startup

add transient

services.AddTransient<Ipayment, paymentService>();


install-package System.Configuration.ConfigurationManager