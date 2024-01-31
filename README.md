# API de Supermercado

Bem-vindo à API de Supermercado! Esta API fornece endpoints para gerenciar informações sobre produtos em um supermercado. Você pode listar, buscar, adicionar, atualizar e excluir produtos usando as operações disponíveis.

## Estrutura do Projeto

O projeto está organizado da seguinte forma:

- `Supermercado.Models`: Contém as definições dos modelos de dados, como a classe `Produto`.
- `Supermercado.Rotas`: Contém a implementação das rotas da API, utilizando o framework WebApplication.

## Produtos Pré-cadastrados

A API inicializa com alguns produtos pré-cadastrados para fins de demonstração. Eles incluem:

1. **Arroz**
   - ID: [ID_GENERATED]
   - Preço: 20

2. **Feijão**
   - ID: [ID_GENERATED]
   - Preço: 15

3. **Batata**
   - ID: [ID_GENERATED]
   - Preço: 12

4. **Macarrão**
   - ID: [ID_GENERATED]
   - Preço: 10

5. **Cenoura**
   - ID: [ID_GENERATED]
   - Preço: 8

6. **Tomate**
   - ID: [ID_GENERATED]
   - Preço: 25

7. **Ovos**
   - ID: [ID_GENERATED]
   - Preço: 18

8. **Leite**
   - ID: [ID_GENERATED]
   - Preço: 30

9. **Pão**
   - ID: [ID_GENERATED]
   - Preço: 15

10. **Carne**
    - ID: [ID_GENERATED]
    - Preço: 40

## Endpoints Disponíveis

### 1. Obter todos os produtos

**Endpoint:** `GET /produtos`

Retorna uma lista de todos os produtos disponíveis.

### 2. Obter um produto pelo nome

**Endpoint:** `GET /produtos/{nomeproduto}`

Retorna informações detalhadas sobre um produto com base no nome fornecido.

### 3. Adicionar um novo produto

**Endpoint:** `POST /produtos`

Permite adicionar um novo produto à lista.

**Corpo da solicitação (JSON):**
```json
{
  "nomeProduto": "Nome do Produto",
  "preco": 25.99
}
```

### 4. Atualizar um produto existente
Endpoint: PUT /produtos/{id}/{nomeproduto}/{valor}

Permite atualizar as informações de um produto existente com base no ID fornecido.

### 5. Excluir um produto
Endpoint: DELETE /produtos/{id}

Remove um produto específico com base no ID fornecido.

