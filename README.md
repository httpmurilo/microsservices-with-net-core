Projeto de estudo com MicroServices.

1 . Catalog.API 
Api realiza o CRUD de Produtos.

Stacks usadas : 
- WebApi.
- MongoDB.

Documentação : 
´´´
http://localhost:8000/swagger/v1/swagger.json
´´´

Para execução da orquestração :
´´´
 docker-compose -f docker-compose.yml -f docker-compose.override.yml  up -d 
´´´

Para exclusão de uma imagem :
´´´
docker container rm container_id
´´´

2. Basket.API
Api utilizada para cadastro do Carrinho com Redis.