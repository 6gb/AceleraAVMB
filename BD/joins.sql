-- Exercício 1 - Liste todos os carros das marcas Fiat e VW, e os carros sem marcas.

select modelo, ano from carros
	left join marcas
	on carros.marca = marcas.id_marcas
	where marcas.marca = 'Fiat'	or marcas.marca = 'VW' or carros.marca is null

-- Exercício 2 - Mostre as marcas que não possuem veiculos.

select marcas.marca from marcas
	left join carros
	on carros.marca = marcas.id_marcas
	where carros.marca is null

-- Exercício 3 - Mostre os veiculos da GM e Ford ordenados por ordem alfabetica.

select modelo, ano from carros
	inner join marcas
	on carros.marca = marcas.id_marcas
	where marcas.marca = 'GM' or marcas.marca = 'Ford'
	order by modelo

-- Exercicio 4 - Mostre as marcas que possuem mais de 3 carros cadastrados.

select marcas.marca from carros
	inner join marcas
	on carros.marca = marcas.id_marcas
	where marcas.marca = 'GM' or marcas.marca = 'Ford'
	order by modelo

-- Exercicio 5 - https://www.youtube.com/watch?v=f-gTevkp7sg
