# questo file per essere eseguito bisogna creare il file `post-checkout`
# al interno del path .git/hooks ed al interno inserire questo:
# file: `post-checkout`
# > #!/bin/sh
# > echo "executing post-checkout"
# > # Chiama PowerShell passandogli il file dello script
# > pwsh -File '.\post-checkout.ps1'
# > exit 0

echo "post-checkout.ps1 executing..."

# Recupera il nome del branch corrente
$currentBranch = git symbolic-ref --short HEAD

if ($currentBranch -eq "main") {
    Write-Host "Sei su main: pulizia cartelle bin/obj in corso..." -ForegroundColor Cyan
    
    # Definisci i percorsi da rimuovere
    $pathsToRemove = @("src", "src/obj")

    foreach ($path in $pathsToRemove) {
        if (Test-Path $path) {
            Remove-Item -Path $path -Recurse -Force
            Write-Host "Rimosso: $path" -ForegroundColor Yellow
        }
    }
    
    # Opzionale: se vuoi comunque usare git clean per tutto il resto
    # git clean -fdx
}
else {
    Write-Host "Branch attuale: $currentBranch. Nessuna pulizia necessaria." -ForegroundColor Gray
}