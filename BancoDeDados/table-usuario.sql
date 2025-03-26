USE senac;

CREATE TABLE IF NOT EXISTS usuario (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    email VARCHAR(50) NOT NULL UNIQUE,
    senha VARCHAR(16) NOT NULL
);

SELECT 
    *
FROM
    usuario;
    
INSERT INTO usuario (nome, email, senha) 
VALUES('osvaldo','osvaldo2009@gmail.com', 'Senha@123'),
		('NeymarJr.', 'njr@email.com ', 'a1s2d3f4'),
        ('Pablo Vitar', 'p.vitar@email.com ', 'Bruna1234 ');