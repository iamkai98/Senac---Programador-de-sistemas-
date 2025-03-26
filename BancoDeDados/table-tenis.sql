USE tenis;

CREATE TABLE IF NOT EXISTS tenis(
id INT PRIMARY KEY AUTO_INCREMENT,
nome VARCHAR (100) NOT NULL,
marca VARCHAR (100) NOT NULL,
preco INT (15) NOT NULL
);

SELECT *
FROM tenis;

INSERT INTO tenis (nome, marca, preco)
VALUES 	('','nike',''),
		('','nike',''),
        ('','nike',''),
		('','nike',''),
        ('','nike',''),
		('ozmillen','adidas','800'),
        ('ozweego','adidas','900'),
		('campus 00','adidas','699'),
        ('','adidas',''),
		('','adidas',''),
        ('','new balance',''),
		('','new balance',''),
        ('','asics',''),
		('','asics',''),
        ('','puma','');
		
        