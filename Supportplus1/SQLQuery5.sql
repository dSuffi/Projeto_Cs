
DROP TABLE IF EXISTS [dbo].[Feedback];
DROP TABLE IF EXISTS [dbo].[Ticket];
DROP TABLE IF EXISTS [dbo].[Usuario];

 
CREATE TABLE [dbo].[Usuario] (
    [Id]      INT           NOT NULL IDENTITY(1,1),
    [Usuario] NVARCHAR (50) NOT NULL,
    [Senha]   NVARCHAR (50) NOT NULL, 
    CONSTRAINT [PK_Usuario] PRIMARY KEY ([Id])
);



CREATE TABLE [dbo].[Ticket]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [UsuarioId] INT NULL,
	INDEX [UsuarioIdIdx] ([UsuarioId]),
	[Titulo] NVARCHAR(50) NULL, 
    [Mensagem] NVARCHAR(50) NOT NULL, 
    [Estado] NVARCHAR(50) NULL, 
    [Urgência] NVARCHAR(50) NOT NULL, 
    [DataAbertura] DATETIMEOFFSET NULL, 
    [DataFechamento] DATETIMEOFFSET NULL, 
    CONSTRAINT [ChamadoUsuarioId]
		FOREIGN KEY ([UsuarioId])
		REFERENCES [dbo].[Usuario] ([Id])
	);


CREATE TABLE [dbo].[Feedback]
(
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [Resolvido] BIT NULL, 
    [Nota] NVARCHAR(50) NULL, 
    [Mensagem] NCHAR(10) NOT NULL, 
    [DataEnvio] DATETIMEOFFSET NULL, 
    [TicketId] INT NOT NULL,
	INDEX [TicketIdIdx] ([TicketId]),
	 CONSTRAINT [FeedbackTicketId]
		FOREIGN KEY ([TicketId])
		REFERENCES [dbo].[Ticket] ([Id])
	
);












