#!/jenkins/bin/bash
echo "$upass" | sudo -S sleep 100 && sudo su
docker build -t $imageName .

aasdasdsadsadsadas