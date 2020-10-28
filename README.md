Projeto de estudo com MicroServices.

Catalog.API 
Api realiza o CRUD de Produtos.

Stacks usadas : 
- WebApi.
- MongoDB.

Documentação : 
´´´
http://localhost:8000/index.html
´´´

Para execução da orquestração :
´´´
 docker-compose -f docker-compose.yml -f docker-compose.override.yml  up -d 
´´´

Para exclusão de uma imagem :
´´´
docker container rm container_id
´´´