DROP DATABASE senac; 

create database senac;

CREATE TABLE produto (
id INT PRIMARY KEY auto_increment,
nome VARCHAR (50) NOT NULL,
categoria VARCHAR (50),
preco DECIMAL (6,2) NOT NULL, 
estoque INT NOT NULL, 
fornecedor_id INT, 
FOREIGN KEY (fornecedor_id) references fornecedor (id));

INSERT INTO produto (nome, categoria, preco, estoque, fornecedor_id)
VALUES
('Celular X','Eletrônicos',2500.00, 30, 1),
('Notebook Y','Eletrônicos', 4800.00, 15 , 2),
('Mesa de Madeira','Móveis', 750.00, 10 , 3),
('Cadeira Z', 'Móveis', 300.00, 25, 3),
('TV 50','Eletrônicos',3500.00 , 8, 1);

SELECT * FROM produto;
-- -- -- -- -- -- -- -- -- -- -- --

CREATE TABLE fornecedor (
id INT PRIMARY KEY AUTO_INCREMENT, 
nome VARCHAR (50) NOT NULL,
cidade VARCHAR (50) NOT NULL);

INSERT INTO fornecedor (nome, cidade)
VALUES ('TechBrasil','São Paulo'),
('Computech','Rio de Janeiro'), 
('Moveis&Co','Curitiba');

SELECT * FROM fornecedor;
-- -- -- -- -- -- -- -- -- -- -- --

CREATE TABLE pedido (
id INT PRIMARY KEY AUTO_INCREMENT,
produto_id INT, 
quantidade INT NOT NULL,
data_pedido DATE,
cliente_id INT,
FOREIGN KEY (produto_id) REFERENCES produto(id),
FOREIGN KEY (cliente_id) REFERENCES cliente(id));

INSERT INTO pedido (produto_id,quantidade, data_pedido, cliente_id)
VALUES
(1, 2 ,'2024-03-10', 1),
(3, 1 ,'2024-03-11', 2),
(2, 1 ,'2024-03-15', 3),
(5, 3 ,'2024-03-18', 1),
(4, 4 ,'2024-03-20', 4);

SELECT * FROM pedido;
DROP TABLE pedido;
-- -- -- -- -- -- -- -- -- -- -- --

CREATE TABLE cliente (
id INT PRIMARY KEY AUTO_INCREMENT, 
nome VARCHAR (50) NOT NULL, 
cidade VARCHAR (50) NOT NULL, 
idade INT NOT NULL);

INSERT INTO cliente ( nome, cidade, idade)
VALUES 
('João Silva', 'São Paulo', 35),
('Maria Santos', 'Belo Horizonte', 28),
('Carlos Lima','Rio de Janeiro', 42),
('Fernanda Rocha','Curitiba', 30);

SELECT * FROM cliente;

-- 2. Exercicios avançados
-- 2.1
SELECT categoria, preco FROM produto WHERE categoria = 'Eletrônicos' AND preco > 3000 ORDER BY preco DESC;
-- 2.2
SELECT * FROM cliente WHERE cidade <> 'São Paulo' AND idade > 30;
-- 2.3
Select * FROM pedido WHERE data_pedido BETWEEN '2024-03-10' AND '2024-03-15';
-- 2.4 
Insert INTO produto (nome, categoria, preco, estoque, fornecedor_id) 
VALUES('Microfone Z','Eletrônicos', 200.00 ,9, 1);

SELECT nome, estoque FROM produto WHERE estoque < 10 ORDER BY estoque ASC;
-- 2.5 
SELECT * FROM fornecedor WHERE nome LIKE 'T%' AND cidade <> 'Rio de Janeiro'; 

-- 3. Exercicio 
-- 3.1
SELECT AVG (preco), categoria FROM produto GROUP BY categoria;

-- 3.2
Select cliente_id, COUNT(quantidade)  FROM pedido GROUP BY cliente_id;

-- 3.3
SELECT categoria, sum(estoque) FROM produto GROUP BY categoria;

-- 3.4 -- 
SELECT id, produto_id, quantidade from pedido order by quantidade desc
limit 1;   


-- 3.5
INSERT INTO cliente ( nome, cidade, idade)
VALUES ('Ronan Souza', 'São Paulo', 35);
-- -- -- -- 
SELECT count(nome) as cliente, cidade FROM cliente group by cidade DESC; 



-- 4. Exercicio -- 
-- 4.1 
SELECT produto.nome as produto_nome, fornecedor.nome as fornecedor_nome, produto.fornecedor_id as fornecedor_id
FROM produto
JOIN fornecedor ON produto.fornecedor_id = fornecedor.id ORDER BY fornecedor.nome;

-- 4.2 
SELECT pedido.produto_id, cliente_id,
 cliente.nome as cliente_nome, 
 produto.nome as produto_nome, 
 data_pedido 
FROM pedido
JOIN cliente ON pedido.cliente_id = cliente.id
JOIN produto ON pedido.produto_id = produto.id
ORDER BY data_pedido;

-- 4.3  
SELECT pedido.produto_id, 
cliente_id, 
cliente.nome as cliente_nome, 
produto.nome as produto_nome, 
fornecedor.nome as fornecedor_nome 
FROM pedido
JOIN cliente ON pedido.cliente_id = cliente.id
JOIN produto ON pedido.produto_id = produto.id
JOIN fornecedor ON produto.fornecedor_id = fornecedor.id;

-- 4.4 
SELECT cliente.nome as cliente_nome, 
SUM(pedido.quantidade) AS total_quantidade  
FROM pedido
JOIN cliente ON pedido.cliente_id = cliente.id
GROUP BY cliente.nome order by cliente.nome;

-- 5. Exercicio
-- 5.1 !!!!!!!!!!!!! 
SELECT id, nome, preco FROM produto WHERE preco > (SELECT AVG (preco) FROM produto WHERE categoria = 'Eletrônicos') 
union SELECT id, nome, preco FROM produto WHERE preco > (SELECT AVG (preco) FROM produto WHERE categoria = 'Móveis');

-- 5.2 -- 
UPDATE produto SET preco = 1.10 * preco  WHERE categoria = 'Eletrônicos'; 
SELECT * FROM produto;

-- 5.3 -- 
SELECT * FROM cliente;

DELETE FROM pedido WHERE cliente_id in 
(SELECT cidade FROM cliente WHERE cidade = 'curitiba');


-- 5.4 -- 
INSERT INTO cliente ( nome, cidade, idade)
VALUES ('Ricardo Lopes', 'Porto Alegre', 38);

SELECT * FROM cliente;
-- 5.5 --
INSERT INTO pedido (produto_id,quantidade, data_pedido, cliente_id)
VALUES (2, 2 ,'2024-03-25', 1);


-- 5.6 -- 
SELECT pedido.produto_id, cliente_id, cliente.nome as cliente_nome, produto.categoria as produto_categoria FROM pedido
JOIN cliente ON pedido.cliente_id = cliente.id
JOIN produto ON pedido.produto_id = produto.id;





