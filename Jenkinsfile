node {
    checkout scm

    docker.withServer('tcp://192.168.122.93:2375') {
        docker.image('mcr.microsoft.com/dotnet/aspnet') {
            sh 'dotnet --version'
        }
    }
}