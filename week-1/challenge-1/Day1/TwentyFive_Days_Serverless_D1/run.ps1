using namespace System.Net

<#
# 25 Days of Serverless - Day 1 Serverless Dreidel
https://25daysofserverless.com/calendar/1

Random Dreidel spinner based on 'spin strength' supplied through query.
Results sent back in JSON

/api/TwentyFive_Days_Serverless_D1?strength=slow

{
  "result": "נ Nun",
  "spin": "slow",
  "spinTime": "8 seconds"
}

Darren Robinson
https://blog.darrenjrobinson.com
#>


# Input bindings are passed in via param block.
param($Request, $TriggerMetadata)

# Write to the Azure Functions log stream.
Write-Host "PowerShell HTTP trigger function processed a request."

$sides = @("Nun", "Gimmel", "Hay", "Shin")

$arrSides = @{ }
$arrSides.add("Nun", "נ")
$arrSides.add("Gimmel", "ג")
$arrSides.add("Hay", "ה")
$arrSides.add("Shin", "ש")

# Interact with query parameters or the body of the request.
$strength = $Request.Query.Strength
if (-not $Strength) {
    $strength = $Request.Body.Strength
}

if ($strength) {
    $status = [HttpStatusCode]::OK
    $spinResults = @{"Nun" = 0; "Gimmel" = 0; "Hay" = 0; "Shin" = 0}            
    $spins = 0

    switch ($strength) {
        slow {            
            $spinTime = get-random -Minimum 2 -Maximum 10 
            
            do {
                $randomSpinResult = Get-Random $sides
                $spinResults.$randomSpinResult = $spinResults.$randomSpinResult + 1            
                $spins++
            } until ($spins -ge $spinTime)
            write-host $spinResults
            $resultSide = $spinResults.GetEnumerator() | Sort-Object -Property value -Descending -top 1
            $body = @{spin = $strength; spinTime = "$($spinTime) seconds"; result = "$($arrSides.($resultSide.name)) $($resultSide.name)"}                        
            $body 
        }
        medium {
            $spinTime = get-random -Minimum 10 -Maximum 20 

            do {
                $randomSpinResult = Get-Random $sides
                $spinResults.$randomSpinResult = $spinResults.$randomSpinResult + 1            
                $spins++
            } until ($spins -ge $spinTime)
            
            $resultSide = $spinResults.GetEnumerator() | Sort-Object -Property value -Descending -top 1
            $body = @{spin = $strength; spinTime = "$($spinTime) seconds" ;result = "$($arrSides.($resultSide.name)) $($resultSide.name)"}                        
            $body 
        }
        fast {
            $spinTime = get-random -Minimum 20 -Maximum 35 

            do {
                $randomSpinResult = Get-Random $sides
                $spinResults.$randomSpinResult = $spinResults.$randomSpinResult + 1            
                $spins++
            } until ($spins -ge $spinTime)
            
            $resultSide = $spinResults.GetEnumerator() | Sort-Object -Property value -Descending -top 1
            $body = @{spin = $strength; spinTime = "$($spinTime) seconds" ;result = "$($arrSides.($resultSide.name)) $($resultSide.name)"}                        
            $body 
        }
    }
}
else {
    $status = [HttpStatusCode]::BadRequest
    $body = "Please pass a 'strength' for the spin on the query string or in the request body. Valid strenghts are: slow, medium and fast"
}

# Associate values to output bindings by calling 'Push-OutputBinding'.
Push-OutputBinding -Name Response -Value ([HttpResponseContext]@{
        StatusCode = $status
        Body       = $body
    })
