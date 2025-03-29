SELECT 
    livro.id,
    livro.data_publicacao,
    livro.numero_paginas,
    livro.preco,
    livro.isbn,
    genero.nome AS genero,
    editora.nome AS editora,
    autor.nome AS nome
FROM
    livro,
    autor,
    editora,
    genero
WHERE
    livro.id_autor = autor.id
        AND livro.id_editora = editora.id
        AND livro.id_genero = genero.id;

   

