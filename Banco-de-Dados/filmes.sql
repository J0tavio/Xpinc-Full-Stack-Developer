-- Queries feitas no MySQL

-- 1 
SELECT nome, ano FROM filmes;

-- 2
SELECT nome, ano FROM filmes
ORDER BY ano;

-- 3
SELECT nome, ano, duracao FROM filmes
WHERE nome = 'de volta para o futuro';

-- 4
SELECT * FROM filmes
WHERE ano = 1997;

-- 5
SELECT * FROM filmes
WHERE ano > 2000;

-- 6
SELECT * FROM filmes
WHERE Duracao > 100 AND Duracao < 150
ORDER BY Duracao;

-- 7
SELECT ano, count(ano) quantidade FROM filmes
GROUP BY ano
ORDER BY quantidade desc;

-- 8
SELECT primeiroNome, UltimoNome, Genero FROM atores
WHERE Genero = 'M';

-- 9
SELECT primeiroNome, UltimoNome, Genero FROM atores
WHERE Genero = 'F'
ORDER BY PrimeiroNome;

-- 10
SELECT f.nome AS filme, g.Genero AS gênero
FROM filmes f
INNER JOIN filmesgenero fg ON f.id = fg.IdFilme
INNER JOIN generos g ON fg.IdGenero = g.Id;

-- 11
SELECT f.nome AS filme, g.Genero
FROM filmes f
INNER JOIN filmesgenero fg ON f.Id = fg.IdFilme
INNER JOIN generos g on fg.IdGenero = g.Id
WHERE g.Genero = 'Mistério';

-- 12
SELECT f.id, f.nome AS filmes, a.primeironome AS Nome, a.ultimoNome AS Sobrenome, e.Papel
FROM filmes f
INNER JOIN elencofilme e ON f.Id = e.IdFilme
INNER JOIN atores a ON e.IdAtor = a.Id;

-- 13

