 
a.  Top 10 de clientes que tienen mayor peso bruto generado por producto y por mes 
durante el año 2014. listar: - Nombre cliente (cliente) - Dirección del cliente (dirección) - NIT del cliente (nit) - Nombre del producto (producto) - Suma peso bruto de la transacción (pbruto) - Mes (fecha) - Año (fecha) 


            SELECT TOP 10
                c.cliente,
                c.direccion,
                c.nit,
                p.producto,
                SUM(e.fbruto) AS pbruto,
                MONTH(e.fecha) AS mes,
                YEAR(e.fecha) AS anio
            FROM envio e
            JOIN cliente c ON e.codcliente = c.codcliente
            JOIN producto p ON e.codproducto = p.codproducto
            WHERE YEAR(e.fecha) = 2014
            GROUP BY
                c.cliente,
                c.direccion,
                c.nit,
                p.producto,
                MONTH(e.fecha),
                YEAR(e.fecha)
            ORDER BY pbruto DESC;


b. Generar un detalle por finca del número[conteo] de transacciones[envios] mensuales 
durante el primer semestre del 2015, excluir aquellos conteos inferiores a 100, ordenar 
por finca. Listar: 
    - Nombre de la finca (finca) 
    - Nombre de la empresa (empresa) 
    - Total transacciones - Mes (fecha) 
    - Año (fecha) 


            SELECT
                f.finca,
                emp.empresa,
                COUNT(e.codenvio) AS total_transacciones,
                MONTH(e.fecha) AS mes,
                YEAR(e.fecha) AS anio
            FROM envio e
            JOIN finca f ON e.codfinca = f.codfinca
            JOIN empresa emp ON f.codempresa = emp.codempresa
            WHERE YEAR(e.fecha) = 2015
            AND MONTH(e.fecha) BETWEEN 1 AND 6
            GROUP BY
                f.finca,
                emp.empresa,
                MONTH(e.fecha),
                YEAR(e.fecha)
            HAVING COUNT(e.codenvio) >= 100
            ORDER BY f.finca;
