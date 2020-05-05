# Blob storage
- Microsoft object storage solution for the cloud
- storing massive amount of unstructure data.
- Its useful for text or binary data
- low cost and teired storage with high availability
- if the storage is named `mystorageaccount` the end point will be
`http://mystorageaccount.blob.core.windows.net`
- there are three blobs in azure storage, block blobs which stores text and binary data up to about 4.7tb. Append blob which are made up of blocks like block blobs but uses append operation and page blob that store random access file up to 8 TB.
- to install the package `dotnet add package Azure.Storage.Blobs` is invoked
- for connection string `setx AZURE_STORAGE_CONNECTION_STRING "<yourconnectionstring>"` can be used
- maybe configuration library can be brought in to use secret json line.
- To create a container 
```
// Create a BlobServiceClient object which will be used to create a container client
BlobServiceClient blobServiceClient = new BlobServiceClient(connectionString);

//Create a unique name for the container
string "name of the container" = "quickstartblobs" + Guid.NewGuid().ToString();

// Create the container and return a container client object
BlobContainerClient containerClient = await blobServiceClient.CreateBlobContainerAsync(containerName);
```
- Crud operation can be done to blob as well as they can be downloaded, get list of blobs in a container, upload, create, and delete.