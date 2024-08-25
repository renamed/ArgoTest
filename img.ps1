$version=27
Write-Host "version: $version"
docker login
docker build -t argotest:$version .
docker tag argotest:$version renamedrj/argotest:$version
docker push renamedrj/argotest:$version
Write-Host "version: $version feita"