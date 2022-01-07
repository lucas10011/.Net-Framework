CREATE PROCEDURE [dbo].[SelectClientesProdutos]
AS
begin
  select * from CLIENTES;
  select * from PRODUTOS;
end