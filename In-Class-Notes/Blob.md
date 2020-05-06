# container

- each user can have container
- pull down whole container
- product 
- azure 
    - make storage account
    - seattledotnet 401d10
    - hot and cool 
        - hot is often
        - cool don't care about
        - review and pass
        -  in access key use key 1
        -  storage-account-name: "" to secret jo



```json
// need to put
"storage-account-name":
"Blobkey":

"prodcutContainer"



```


go to container
create a container
- container
- after creating a link 
- new class

```cs

// create blob in the model

public class Blob
{
    public CloudStorageAccount CloudStorageAccount{get;set;}
    public CloudBlobClient CloudBlobClient {get;set;}

    public Blob(IConfiguration configuration)
    {
        //added library
        var storageCreds= new StorageCredential(configuration["storeage-account"], conifuration["BlobKey"]);
        ///cchoose https
        CloudStorageAccount = new CloudStorageAccount(storageCreds, true );

        CloudBlobClient = CloudStorageAccount.CreateCloudBlobClient();


    }

    public async Task<CloudBlobContainer> GetContainer(string containerName)
    {
        CloudBlobContainer cbc = CloudBobClient.GetContainerReference(containerName);
        await cbc.CreateIfNotExistsAsync();

        await cbc.SetPermissionsAsync(new BlobContainerPermission
        {
            PublicAccess = BlobContainerPublicAccessType.Blob
        });

        return cdc;
    }


    public async Task<CloudBlob> GetBlob(string imageName, string containerName)
    {
        var container = await GetContainer(containerName);
        CloudBlob blob = container.GetBlobReference(ImageName);

        return blob;
    }

    public async Task UploadFile(string containerName, string fileName,Stream filePath )
    {
        // get the container
        var container = await GetContainer(containerName);
        var blobFile = container.GetBlockBlobReference(fileName);
        await blobFile.UploadFromStreamAsync(filePath);
    }

    public async Task DeleteBlob(string containerName, string fileName)
    {
        var container = await GetContainer(containerName);
        CloudBlockBlob blockBlob = container.GetBlockBlobReference(fileName);

        await blockBlob.DeleteAsync();

    }
}

```
install-package windowsazure.storage

**in the page model**

```cs
public IndexModel(IConfiguration configuration)
{
    Blob = new Blob(configuration);
}


public Blob blob {get;set;}

[BindProperty]
public IFormFile Image {get;set;}


public async Task OnPost()
{
    // systemio
    // middle man to temporarily store the file
    var filePath= Path.GetTempPath();

    var cloudContainer = Blob.GetContainer{"cats"};


    using (var memoryStream = new MemoryStream())
    {
       await Image.CopyToAsync(memoryStream);
       await Blob.UploadFile("cats", "kittycat", memoryStream);
    }

    var blob = await Blob.GetBlob("kittyKat", "cats");

    var kitCat = blob.Uri;


    return Page();

}

```


in the cshtmlcs

```html

    <form enctype="multipart/form-data" method="post">

        <label asp-for="Image"></label>
        <input asp-for="Image" type="file" />

        <button typ="submit">upload</button>

    </form>

```

change access levelto container 