pipeline {
    agent any
    stages {
        stage('Build') {
            steps {
                bat 'dotnet build SOAPService.sln'
                bat 'dotnet build RESTApi.sln'
                bat 'dotnet build GrpcService.sln'
            }
        }
        stage('Test') {
            steps {
                bat 'dotnet test'
            }
        }
        stage('Docker Build') {
            steps {
                bat 'docker-compose build'
            }
        }
        stage('Deploy') {
            steps {
                bat 'docker-compose up -d'
            }
        }
    }
}
