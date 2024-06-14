pipeline {
        environment {
        dotnetF = "clinivia_backend-master/clinivia_backend" //nom du projet backend
        angularF = "clinivia_frontend-master" //nom du projet frontend
        DOCKERHUB_CREDENTIALS = credentials('dockerhub_cred_sipacademy2024')//DOcker hub  ID Credential
                    }

          agent any
          stages {

          stage('Build Docker Image Backend') {
            steps {
                sh 'docker build -t sipacademy2024/clinivia_backend:latest ${dotnetF}'//variable nom du projet
            }
          }

          stage('Push Docker Image Backend') {//build back
          steps {
              script {
            sh "echo $DOCKERHUB_CREDENTIALS_PSW | docker login -u $DOCKERHUB_CREDENTIALS_USR --password-stdin"
            sh 'docker push sipacademy2024/clinivia_backend:latest'
        }
            }
           post {
             always {
            sh 'docker logout'
                    }
                }

          }

           stage('Build Docker Image Frontend') {//build front
            steps {
                sh 'docker build -t sipacademy2024/clinivia_frontend:latest ${angularF}'
            }
          }

          stage('Push Docker Image Frontend') {//push front
          steps {
              script {
            sh "echo $DOCKERHUB_CREDENTIALS_PSW | docker login -u $DOCKERHUB_CREDENTIALS_USR --password-stdin"
            sh 'docker push sipacademy2024/clinivia_frontend:latest'
        }
            }
           post {
             always {
            sh 'docker logout'
                    }
                }

          }

          stage('Run Docker Compose') {//docker compose
            steps {
                script {
                    sh "docker compose -f docker-compose.yaml up -d"
                }
            }
        }
       }
}
