node {
    checkout scm

    docker.withServer('tcp://192.168.122.93:2375') {
        docker.image('node:16.13.1-alpine') {
            sh 'node --version'
        }
    }

     docker.withRegistry('http://192.168.122.93:5000') {
         def customImage = docker.build("dotnetwebapi:${env.BUILD_ID}")

         customImage.push()
     }
}
