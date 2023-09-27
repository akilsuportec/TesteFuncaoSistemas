CREATE PROCEDURE FI_SP_IncBeneficiario
    @Cpf NVARCHAR(14),
    @Nome NVARCHAR(255),
    @IdCliente BIGINT
AS
BEGIN
    INSERT INTO BENEFICIARIOS(Cpf, Nome, IdCliente)
    VALUES (@Cpf, @Nome, @IdCliente)
END