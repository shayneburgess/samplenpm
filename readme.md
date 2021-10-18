

# Create a dev docker container

docker run --rm -it -v $PWD:/home/app -w /home/app --name npmsample node:latest /bin/bash


# CI

Actions will run to test changes on checkin/PR and deploy to Packages on release

Test change