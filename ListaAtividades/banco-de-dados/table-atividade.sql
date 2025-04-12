use senac;

create table atividade (
id INT PRIMARY KEY AUTO_INCREMENT,
titulo VARCHAR (100) NOT NULL,
situacao INT NOT NULL DEFAULT 0 
);

INSERT INTO atividade (titulo) VALUES (@titulo);

UPDATE atividade SET situacao = @situacao WHERE id = @id; -- alterar situacao / o '@' serve para um parametro no C# 
SELECT * FROM atividade WHERE situacao = 1; -- buscar atividade "fazendo(1)" 
SELECT * FROM atividade WHERE situacao = 0; -- buscar atividade "a fazer(0)"

 