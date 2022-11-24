env.DOCKER_HOST = 'tcp://192.168.122.93:2375'
pipeline {
    agent {
        docker { image 'mcr.microsoft.com/dotnet/aspnet:6.0' }
    }
    stages {
        stage('Test') {
            steps {
                sh 'dotnet --version'
            }
        }
    }
}