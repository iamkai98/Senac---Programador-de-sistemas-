SELECT* 
FROM livro
WHERE data_publicacao >='1990-01-01 00:00:00'
AND data_publicacao <= '1999-12-31 23:59:59';

SELECT 
    *
FROM
    livro
WHERE
    data_publicacao BETWEEN '1990-01-01 00:00:00' AND '1999-12-31 23:59:59';
    
SELECT DISTINCT (autor) FROM livro;

SELECT sum(preco), avg(preco), max(preco), min(preco) from livro
where autor = 'rafael sousa';

select count(id) from livro;
