USE test;
CREATE TABLE cliente (
id INT PRIMARY KEY auto_increment,
nome VARCHAR (15), 
idade INT NOT NULL,
cidade VARCHAR(15) NOT NULL,
saldo DECIMAL (6,2) NOT NULL);

INSERT INTO cliente (nome, idade, cidade, saldo)
VALUES 
('carlos','45','sao paulo','2500.00'),
('mariana','32','rio de janeiro','3200.50'),
('pedro','27','belo horizonte','1500.75'),
('fernanda','38','curitiba','4200.00');

SELECT * FROM cliente;

-- Exercicio 1 --
SELECT  * FROM cliente WHERE cidade = 'rio de janeiro';
-- -- -- -- -- -- 
SELECT  * FROM cliente WHERE saldo >= 2000;
-- -- -- -- -- -- 
SELECT  nome,idade FROM cliente WHERE idade >= 30;


-- Exercicio 2 --
SELECT * FROM cliente WHERE idade >= 25 AND idade <= 40; 
-- -- -- -- -- --
SELECT * FROM cliente WHERE nome LIKE 'f%';
-- -- -- -- -- --
SELECT * FROM cliente WHERE cidade <> 'sao paulo' AND cidade <> 'curitiba';

-- Exercicio 3 -- 
-- Criação nova tabela--
CREATE TABLE pedido (
id INT PRIMARY KEY AUTO_INCREMENT,
cliente_id INT NOT NULL,
valor DECIMAL(6,2) NOT NULL,
data_pedido DATE NOT NULL);
-- Insert --
INSERT INTO pedido (cliente_id, valor, data_pedido)
VALUES('1','500.00','2024-03-10'),
('2','1200.00','2024-03-12'),
('3','300.50','2024-03-15'),
('1','800.00','2024-03-18');
-- -- -- -- -- -- -- --
SELECT sum(cliente_id) FROM pedido;
-- -- -- -- -- -- -- -- 
SELECT AVG(valor) FROM pedido;
-- -- -- -- -- -- -- -- 
SELECT sum(valor),cliente_id FROM pedido GROUP BY cliente_id;

-- Exercicio 4 --
CREATE TABLE cliente (
id INT PRIMARY KEY auto_increment,
nome VARCHAR (15),
cidade VARCHAR(15) NOT NULL, 
id_pedido INT,
FOREIGN KEY (id_pedido) REFERENCES pedido(id));

INSERT INTO cliente (nome, cidade , id_pedido) VALUES
('carlos','sao paulo','1'),
('mariana','rio de janeiro','2'),
('pedro','belo horizonte','3'),
('fernanda','curitiba', NULL),
('rafael', 'porto alegre', NULL);

CREATE TABLE pedido (
id INT PRIMARY KEY AUTO_INCREMENT,
cliente_id INT NOT NULL,
valor DECIMAL(6,2) NOT NULL);
-- Insert --
INSERT INTO pedido (cliente_id, valor)
VALUES('1','500.00'),
('2','1200.00'),
('3','300.50'),
('1','800.00');

SELECT cliente.nome, id_pedido
FROM cliente 
INNER JOIN pedido ON cliente.id_pedido = pedido.cliente_id;

SELECT cliente.nome, id_pedido
FROM cliente 
LEFT JOIN pedido ON cliente.id_pedido = pedido.cliente_id;

-- Exercicio 5 -- 

SELECT * FROM cliente WHERE id_pedido >= (SELECT AVG(id_pedido) FROM (cliente));
-- -- -- -- -- -- -- -- -- -- 
SELECT nome
FROM cliente
WHERE id IN (SELECT DISTINCT cliente_id FROM pedido WHERE pedido.valor >= 1000);

SELECT c.nome,p.valor FROM cliente c JOIN pedido p ON c.id = p.cliente_id
WHERE p.valor >= 1000;

-- Exercicio 6 --

SELECT * FROM cliente; 







SELECT * FROM cliente WHERE pedido.valor >= 1000;
SELECT * FROM cliente;
SELECT * FROM pedido;

DROP TABLE pedido;
DROP TABLE cliente;

-- Exercicio 6 --


