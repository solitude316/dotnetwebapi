node {
    checkout scm

    docker.withServer('tcp://192.168.122.93:2375') {
        docker.image('mcr.microsoft.com/dotnet/aspnet:6.0') {
            sh 'dotnet --info'
        }
    }

    // docker.withRegistry('http://192.168.122.93:5000') {
    //     def customImage = docker.build("dotnetwebapi:${env.BUILD_ID}")

    //     customImage.push()
    // }
}