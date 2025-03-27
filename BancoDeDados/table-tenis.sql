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
VALUES 	('initiator','nike','512'),
		('air max sc','nike','417'),
        ('full force low','nike','475'),
		('uplift sc','nike','405'),
        ('sb vertebrae','nike','380'),
		('ozmillen','adidas','800'),
        ('ozweego','adidas','900'),
		('campus 00','adidas','699'),
        ('cout 24','adidas','299'),
		('crazy chaos 2000','adidas','290'),
        ('530','new balance','674'),
		('550','new balance','849'),
        ('quantum 180 fly','asics','319'),
		('japan s','asics','400'),
        ('x-ray 2','puma','380');
		
        