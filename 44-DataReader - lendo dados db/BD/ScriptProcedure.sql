CREATE PROCEDURE [dbo].[InsertCliente]
	@NomeCliente varchar(max),
	@EMail varchar(max)
AS
begin
	insert into CLIENTES(NomeCliente,EMail) 
	values (@NomeCliente,@EMail);
end
