SELECT 
	emp.Id,
	emp.Nombre1,
	emp.Nombre2,
	emp.Nombre3,
	emp.Apellido1,
	emp.Apellido2,
	emp.Apellido3,
	CAST(reg.FechaHora as DATE) as Dia,
	(CASE 
		WHEN reg.Tipo = 'E' THEN 'Entrada'
		ELSE 'Salida'
	END) as Accion,
	CAST(reg.FechaHora as time) as Hora,
	reg.FechaHora
FROM Registro reg
INNER JOIN EMpleado emp ON emp.Id = reg.IdEmpleado
WHERE 1 = 1 
	-- AND CAST(reg.FechaHora as DATE) = '2018-03-05'
ORDER BY 
emp.Id, reg.FechaHora


-- SELECT * FROM Registro

