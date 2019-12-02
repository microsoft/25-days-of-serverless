using namespace System.Net

# Your task for today: create a REST API endpoint that spins a dreidel
# and randomly returns נ (Nun), ג (Gimmel), ה (Hay), or ש (Shin). 
# This sounds like a great opportunity to use a serverless function 
# to create an endpoint that any application can call!

# Input bindings are passed in via param block.
param($Request, $TriggerMetadata)

# Write to the Azure Functions log stream.
Write-Host "PowerShell HTTP trigger function processed a request."

$dreidelSides = @('נ (Nun)','ג (Gimmel)','ה (Hay)','ש (Shin)')
$spin = get-random -InputObject $dreidelSides 

$status = [HttpStatusCode]::OK
$body = "You spun: " + $spin 


# Associate values to output bindings by calling 'Push-OutputBinding'.
Push-OutputBinding -Name Response -Value ([HttpResponseContext]@{
    StatusCode = $status
    Body = $body
})
