$version=6
docker login
docker build -t argotest:$version .
docker tag argotest:$version renamedrj/argotest:$version
docker push renamedrj/argotest:$version