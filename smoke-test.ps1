Set-StrictMode -Version Latest
$ErrorActionPreference = "Stop"
$PSDefaultParameterValues['*:ErrorAction']='Stop'
function ThrowOnNativeFailure {
    if (-not $?)
    {
        throw 'Native Failure'
    }
}

Write-Host "Download Swagger Petstore v3 OpenAPI spec" -ForegroundColor Green
Invoke-WebRequest -Uri https://petstore3.swagger.io/api/v3/openapi.yaml -OutFile ./openapi.yaml

Write-Host "Generate code`n" -ForegroundColor Green
Set-Location src/Atc.Rest.ApiGenerator.CLI
dotnet run -- `
    generate `
    server `
    all `
    -p "Swagger Petstore" `
    -s ../../openapi.yaml `
    --outputSlnPath ../../petstore3/ `
    --outputSrcPath ../../petstore3/src `
    --outputTestPath ../../petstore3/test `
    -v true `
    ; ThrowOnNativeFailure

Write-Host "`nBuild Generated Code`n"
Set-Location ../../
dotnet build ./petstore3; ThrowOnNativeFailure

Write-Host "`nRun Generated Code`n"
$process = Start-Process "dotnet" `    -Args "run --project .\petstore3\src\Swagger.Petstore.Api\Swagger.Petstore.Api.csproj" `    -NoNewWindow `
    -PassThru

try {
    do {
        $swagger = Invoke-WebRequest -Uri https://localhost:5001/swagger
    } until ($swagger.StatusCode -eq 200)

    try {
        Invoke-WebRequest -Uri https://localhost:5001/api/v3/pet/1
    }
    catch {
        if ($_.Exception.Response.StatusCode -eq 404) {
            throw 'GET https://localhost:5001/api/v3/pet/1 returned HTTP 404'
        }
    }
}
finally {
    Write-Host "`nStopping the app`n"
    $process.Kill();
    Start-Sleep -Seconds 1.5
}

Write-Host "`nRemoving generated files`n"
Remove-Item ./petstore3 -Recurse -Force
Remove-Item openapi.yaml