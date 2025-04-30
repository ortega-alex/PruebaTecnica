
USE DBService;
GO

CREATE PROCEDURE sp_customer
(
	@Buscar varchar(100) = ''
)
AS 
BEGIN
	SELECT * 
	FROM Customers
	WHERE CONCAT(Name, Code, IIF(IsActive = 1, 'Si', 'No')) LIKE '%' + @Buscar + '%';
END
GO

CREATE PROCEDURE sp_services
(
	@Buscar varchar(100) = ''
)
AS
BEGIN
	
	SELECT s.*,
		sl.City, sl.Zone,
		ss.Name[ServiceType],
		st.Name[ServiceSetting]
	FROM Services s
	INNER JOIN ServiceLocations sl ON s.ServiceLocationId = sl.id
	INNER JOIN ServiceSettings ss ON s.ServiceSettingId = ss.id
	INNER JOIN ServiceTypes st ON s.ServiceTypeId = st.id
	WHERE CONCAT(s.Description, sl.City, sl.Zone, ss.Name, st.Name, IIF(s.IsActive = 1, 'Si', 'No')) LIKE '%' + @Buscar + '%';

END