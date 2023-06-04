CREATE TABLE #EmpDetails (id INT, name VARCHAR(25))  
INSERT INTO #EmpDetails VALUES (01, 'Lalit'), (02, 'Atharva') 
select * from #EmpDetails

------------local temp----------
CREATE PROCEDURE ProcTemp 
AS
BEGIN
CREATE TABLE #EmpDetails
INSERT INTO #EmpDetails VALUES ( 01, 'Lalit'), ( 02, 'Atharva')
SELECT * FROM #EmpDetails
END
EXECUTE ProcTemp 
----------------global temp----------
CREATE TABLE ##EmpDetails (id INT, name VARCHAR(25)) 