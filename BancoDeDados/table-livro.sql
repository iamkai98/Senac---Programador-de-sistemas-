CREATE TABLE IF NOT EXISTS livro (
    id INT PRIMARY KEY AUTO_INCREMENT,
    titulo VARCHAR(100) NOT NULL,
    data_publicacao DATETIME NOT NULL,
    numero_paginas INT NULL,
    preco DECIMAL(10, 2) NULL,
    isbn VARCHAR(17) NOT NULL UNIQUE,
    id_genero INT NOT NULL,
    id_editora INT NOT NULL,
    id_autor INT NOT NULL,
    FOREIGN KEY (id_genero) REFERENCES genero(id),
    FOREIGN KEY  (id_editora) REFERENCES editora (id),
    FOREIGN KEY (id_autor) REFERENCES autor (id)
);

