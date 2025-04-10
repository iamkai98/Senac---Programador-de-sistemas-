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
INSERT INTO empregado(nome, idade, departamento, salario) VALUES ('tomas', '20', 'vendas', '58000');
INSERT INTO empregado(nome, idade, departamento, salario) VALUES ('claudia', '45', 'rh', '70000');
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

-- Insert --
INSERT INTO departamento (nome) VALUES ('rh'), ('ti'),('vendas');

-- Atualização da tabela empregado--
CREATE TABLE empregado(
id INT PRIMARY KEY AUTO_INCREMENT,
nome VARCHAR(30) NOT NULL,
idade VARCHAR (3) NOT NULL,
salario INT NOT NULL,
id_departamento INT NOT NULL,
FOREIGN KEY (id_departamento) REFERENCES departamento(id)
);
-- INSERT -- 
INSERT INTO empregado (nome, idade, salario, id_departamento)
VALUES
('joao', '30', '50000', 1),
('sarah', '28',  '60000', 2 ),
('miguel', '35', '55000', 3),
('ana', '27', '62000', 2),
('tomas', '20', '58000' , 3),
('claudia', '45', '70000', 1);

SELECT * FROM departamento; 

SELECT empregado.id, empregado.nome, departamento.id as departament_id
FROM empregado 
JOIN departamento ON empregado.id_departamento = departamento.id;


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
UPDATE empregado SET salario = 1.05 * salario WHERE id_departamento = 2; 
SELECT * FROM empregado;
-- -- -- -- -- -- -- -- -- -- 
DELETE FROM empregado 
WHERE
    idade <= '40';
-- -- -- -- -- -- -- -- -- -- 

SELECT * FROM empregado;
 
 DROP table empregado;

 

