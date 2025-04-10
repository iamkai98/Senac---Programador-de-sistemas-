-- Criacao da tabela --
CREATE TABLE empregado(
id INT PRIMARY KEY AUTO_INCREMENT,
nome VARCHAR(30) NOT NULL,
idade VARCHAR (3) NOT NULL,
departamento VARCHAR (10) NOT NULL,
salario INT NOT NULL
);

-- INSERT --
INSERT INTO empregado (nome, idade, departamento, salario)
VALUES
( 'joao', '30', 'rh', '50000'),
('sarah', '28', 'ti', '60000'),
('miguel', '35', 'vendas', '55000'),
('ana', '27', 'ti', '62000');

-- Exercicio 1 -- 
SELECT 
    *
FROM
    empregado
WHERE
    departamento = 'ti';
-- -- -- -- -- -- -- -- -- -- 
SELECT 
    *
FROM
    empregado
WHERE
    salario >= '55000';
-- -- -- -- -- -- -- -- -- -- 
SELECT 
    *
FROM
    empregado
ORDER BY idade DESC;


-- Exercicio 2 --
SELECT 
    *
FROM
    empregado
WHERE
    idade >= 28 AND idade <= 35;
-- -- -- -- -- -- -- -- -- -- 
SELECT 
    *
FROM
    empregado
WHERE
    nome LIKE 'm%';
-- -- -- -- -- -- -- -- -- -- 
SELECT 
    *
FROM
    empregado
WHERE
    departamento <> 'rh';


-- Exercicio 3 -- 
SELECT 
    COUNT(departamento)
FROM
    empregado
WHERE
    departamento = 'rh';
SELECT 
    COUNT(departamento)
FROM
    empregado
WHERE
    departamento = 'ti';
SELECT 
    COUNT(departamento)
FROM
    empregado
WHERE
    departamento = 'vendas';
-- -- -- -- -- -- -- -- -- -- 
SELECT 
    AVG(salario)
FROM
    empregado;
-- -- -- -- -- -- -- -- -- -- 
INSERT INTO empregado VALUES ('tomas', '20', 'vendas', '58000');
INSERT INTO empregado VALUES ('claudia', '45', 'rh', '70000');
SELECT 
    SUM(salario)
FROM
    empregado
WHERE
    departamento = 'vendas';



-- Exercicio 4 -- 
CREATE TABLE departamento (
id INT PRIMARY KEY auto_increment,
nome VARCHAR (10) NOT NULL);

INSERT INTO departamento (nome)
VALUES ('rh'), ('ti'), ('vendas');

CREATE TABLE empregado(
id INT PRIMARY KEY AUTO_INCREMENT,
nome VARCHAR(30) NOT NULL,
id_departamento INT,
FOREIGN KEY (id_departamento) REFERENCES departamento(id)
);

INSERT INTO empregado (nome, id_departamento)
VALUES
( 'joao', '1'),
('sarah', '2'),
('miguel','3'),
('ana', '2'),
('tomas', '3'),
('claudia', null);


SELECT empregado.nome, empregado.id_departamento
FROM empregado 
INNER JOIN departamento ON empregado.id_departamento = departamento.id;

SELECT empregado.nome, empregado.id_departamento
FROM empregado 
LEFT JOIN departamento ON empregado.id_departamento = departamento.id;


SELECT * FROM departamento;
SELECT * FROM empregado;

DROP TABLE departamento;
DROP TABLE EMPREGADO;

-- Exercicio 5 -- 
SELECT 
    AVG(salario)
FROM
    empregado;
SELECT 
    *
FROM
    empregado
WHERE
    salario >= (SELECT AVG(salario) FROM (empregado));
-- -- -- -- -- -- -- -- -- -- 
SELECT 
    *
FROM
    empregado
WHERE
    departamento = 'ti';

-- Exercicio 6 --
UPDATE empregado SET salario = salario * 1.05 WHERE departamento = 'ti'; 

-- -- -- -- -- -- -- -- -- -- 
DELETE FROM empregado 
WHERE
    idade <= '40';
-- -- -- -- -- -- -- -- -- -- 

SELECT * FROM empregado;
 
 

 

