# durable-functions-anti-pattarns
## Problem
Azure Storage Emulator

```
C:\Program Files (x86)\Microsoft SDKs\Azure\Storage Emulator>AzureStorageEmulator.exe start
Windows Azure Storage Emulator 5.8.0.0 command line tool
The storage emulator was successfully started.
```

csproj

```json
<ItemGroup>
    <PackageReference Include="Microsoft.Azure.WebJobs.Extensions.DurableTask" Version="1.6.2" />
    <PackageReference Include="Microsoft.NET.Sdk.Functions" Version="1.0.24" />
</ItemGroup>
```

local.settings.json

```json
{
    "IsEncrypted": false,
    "Values": {
        "AzureWebJobsStorage": "UseDevelopmentStorage=true",
        "FUNCTIONS_WORKER_RUNTIME": "dotnet"
    }
}
```

In runnig, not work Durable Functions.

```
Azure Functions Core Tools (2.2.32 Commit hash: c5476ae629a0a438d6850e58eae1f5203c896cd6)
Function Runtime Version: 2.0.12165.0
[2018/11/17 6:32:07] Building host: startup suppressed:False, configuration suppressed: False
[2018/11/17 6:32:07] Reading host configuration file 'D:\src\yuta\func\durable-functions-anti-pattarns\durable-functions-anti-pattarns\bin\Debug\netcoreapp2.1\host.json'
[2018/11/17 6:32:07] Host configuration file read:
[2018/11/17 6:32:07] {
[2018/11/17 6:32:07]   "version": "2.0"
[2018/11/17 6:32:07] }
[2018/11/17 6:32:34] A host error has occurred
[2018/11/17 6:32:34] Microsoft.WindowsAzure.Storage: Server encountered an internal error. Please try again after some time.
```

## Reason
[Unable to run Durable Functions with Azure Storage Emulator v5.8 · Issue #474 · Azure/azure-functions-durable-extension](https://github.com/Azure/azure-functions-durable-extension/issues/474)
