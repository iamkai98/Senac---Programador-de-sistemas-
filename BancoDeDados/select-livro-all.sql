SELECT 
    *
FROM
    livro,
    autor,
    editora,
    genero
WHERE
    livro.id_autor = autor.id
        AND livro.id_editora = editora.id
        AND livro.id_genero = genero.id;

   

